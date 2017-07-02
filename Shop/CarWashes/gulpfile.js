var gulp = require("gulp");
var sass = require("gulp-sass");
var concat = require("gulp-concat");
var sourcemaps = require("gulp-sourcemaps");
var uglifycss = require("gulp-uglifycss");
var clean = require("gulp-clean-dest");
var minifyCss = require("gulp-clean-css");
var uglify = require("gulp-uglify");
var uglifyJS = require("uglify-es");
var babel = require("gulp-babel");


//config files
var admin = require("./admin.config.json")

function getAdminStylesSources() {
    return admin.styles.lib.src.concat(admin.styles.app.src);
}

function getAdminScriptsSources() {
    return admin.scripts.lib.src.concat(admin.scripts.app.src);
}

gulp.task("minifiedAdminStyles", function () {
    return gulp.src(getAdminStylesSources())
        .pipe(clean(admin.styles.CssDestinationPath))
        .pipe(sourcemaps.init())
        .pipe(sass().on("error", sass.logError))
        .pipe(concat("admin-style.min.css"))
        .pipe(uglifycss())
        .pipe(sourcemaps.write())       
        .pipe(gulp.dest(admin.styles.CssDestinationPath));
});

gulp.task("minifiedAdminScripts", function () {
    return gulp.src(getAdminScriptsSources())
        .pipe(clean(admin.scripts.ScriptsDestinationPath))
        .pipe(sourcemaps.init())
        .pipe(concat("admin-scripts.min.js"))
        .pipe(babel({ presets: ["babili"] }))
        .pipe(sourcemaps.write())
        .pipe(gulp.dest(admin.scripts.ScriptsDestinationPath));
});

gulp.task("watch", function () {
    gulp.watch(admin.styles.app.src, ["minifiedAdminStyles"])
})