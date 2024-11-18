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

const copyMoJAssets = () =>
	gulp.src(["node_modules/@ministryofjustice/frontend/moj/assets/**/*"], { encoding: false })
		.pipe(gulp.dest("wwwroot/assets"));

const copyMoJJs = () =>
	gulp.src(["node_modules/@ministryofjustice/frontend/moj/all.js"])
		.pipe(uglify())
		.pipe(rename("moj.js"))
		.pipe(gulp.dest("wwwroot/js/"));

gulp.task("build-fe", () => {
	return async.series([
		(next) => buildSass().on("end", next),
		(next) => copyMoJJs().on("end", next),
		(next) => copyMoJAssets().on("end", next),
		(next) => copyGovukFavicon().on("end", next),
		(next) => copyGovukJs().on("end", next),
		(next) => copyGovukAssets().on("end", next)
	])
}); 