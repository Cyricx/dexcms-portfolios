/// <binding BeforeBuild='clean' AfterBuild='copy' />
module.exports = function (grunt) {
    //Configuration setup
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        copy: {
            domain: {
                expand: true,
                cwd: 'DexCMS.Portfolios/bin/Release/',
                src: ['DexCMS.Portfolios.dll'],
                dest: 'dist/'
            },
            //mvc: {
            //    expand: true,
            //    cwd: 'DexCMS.Portfolios.Mvc/bin/Release/',
            //    src: ['DexCMS.Portfolios.Mvc.dll'],
            //    dest: 'dist/'
            //},
            webapi: {
                expand: true,
                cwd: 'DexCMS.Portfolios.WebApi/bin/Release/',
                src: ['DexCMS.Portfolios.WebApi.dll'],
                dest: 'dist/'
            }
        },
        clean: {
            build: ["dist"]
        }
    });

    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.registerTask('default', ['clean', 'copy']);
};
