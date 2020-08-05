var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
var debug = require("gulp-debug");
var runSequence = require("run-sequence");
var merge = require('merge-stream');
var glob = require("glob");
var rimraf = require('gulp-rimraf');
var path = require('path');
var zip = require('gulp-zip');
var entityconvert = require('gulp-entity-convert');
var color = require('gulp-color');

var config;
var dest;
var configuration;
var projects;
var filesToRemoveBefore;
var filesToRemoveAfter;
var otherFiles;
var deployConent;
var deploySerializedItems;
var zipPrefix;

gulp.task("_clean-before", function () {
	var _merge = new merge();
	filesToRemoveBefore.forEach(function (fileSrc) {
		var toClean = path.join(dest, fileSrc);
		console.log("Clean Before: " + toClean);
		_merge.add(gulp.src(toClean, { read: false }).pipe(rimraf({ force: true })));
	});
	return _merge.isEmpty() ? null : _merge;
});

gulp.task("_publish-website", function () {
	var targets = ["Build"];
	if (config.runCleanBuilds) {
		targets = ["Clean", "Build"];
	}
	console.log("Publish to: " + dest);
	return gulp.src(projects)
		.pipe(debug({ title: "Building project:" }))
		.pipe(msbuild({
			stdout: true,
			targets: targets,
			configuration: configuration,
			logCommand: false,
			verbosity: "minimal",
			maxcpucount: 0,
			toolsVersion: 'auto',
			properties: {
				DeployOnBuild: "true",
				DeployDefaultTarget: "WebPublish",
				WebPublishMethod: "FileSystem",
				DeleteExistingFiles: "false",
				PostBuildEvent: '',
				publishUrl: dest,
				_FindDependencies: "false"
			}
		}));
});

gulp.task("_copy-other-files", function (cb) {
	var _merge = new merge();
	if (otherFiles) {
		otherFiles.forEach(function (item) {
			var src = item.src;
			var dest = path.resolve(item.dest);
			console.log('Copy other files from: ' + src);
			console.log('Copy other files to: ' + dest);
			_merge.add(gulp.src(src).pipe(gulp.dest(dest)));
		});
	} else {
		console.log('No other files to copy');
	}
	return _merge.isEmpty() ? null : _merge;
});

function loadConfiguration(configurationName) {
	var configFileName = './gulpfile.config.' + configurationName + '.json';

	try {
		config = require('./gulpfile.config.' + configurationName + '.json');
		console.log('Using ' + color(path.resolve(configFileName), "YELLOW"));
		dest = path.resolve(config.websiteRoot);
		zipPrefix = config.zipPrefix;
		configuration = config.buildConfiguration;
		projects = config.projects;
		filesToRemoveBefore = config.filesToRemoveBefore;
		filesToRemoveAfter = config.filesToRemoveAfter;
		deployConent = config.deployContent;
		deploySerializedItems = config.deploySerializedItems;
		otherFiles = config.otherFiles;
	} catch (e) {
		if (e.code === 'MODULE_NOT_FOUND') {
			console.log(path.resolve(configFileName));
			process.exit(1);
		}
	}
}

gulp.task("build:Debug", function (cb) {
	loadConfiguration('Debug');
	return runSequence('_clean-before', '_publish-website', '_copy-other-files', cb);
});