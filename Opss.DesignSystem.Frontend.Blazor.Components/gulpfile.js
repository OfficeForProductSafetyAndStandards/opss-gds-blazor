var sass = require("gulp-dart-sass");
var async = require("async");
var rename = require("gulp-rename");
var cleanCSS = require('gulp-clean-css');
var uglify = require('gulp-uglify');
var gulp = require('gulp');

const buildSass = () =>
	gulp.src("src/*.scss")
		.pipe(sass().on("error", sass.logError))
		.pipe(cleanCSS())
		.pipe(gulp.dest("wwwroot/css"));

const copyGovukAssets = () =>
	gulp.src(["node_modules/govuk-frontend/dist/govuk/assets/**/*"], { encoding: false })
		.pipe(gulp.dest("wwwroot/assets"));

const copyGovukJs = () =>
	gulp.src(["node_modules/govuk-frontend/dist/govuk/all.bundle.js"])
		.pipe(uglify())
		.pipe(rename("govuk.js"))
		.pipe(gulp.dest("wwwroot/js/"));

const copyGovukFavicon = () =>
	gulp.src(["node_modules/govuk-frontend/dist/govuk/assets/images/favicon.ico"])
		.pipe(gulp.dest("wwwroot/"));

gulp.task("build-fe", () => {
	return async.series([
		(next) => buildSass().on("end", next),
		(next) => copyGovukFavicon().on("end", next),
		(next) => copyGovukJs().on("end", next),
		(next) => copyGovukAssets().on("end", next)
	])
}); 