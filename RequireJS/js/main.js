require.config({
    paths: {
        "jquery": ["http://apps.bdimg.com/libs/jquery/2.1.4/jquery.min"],
        "underscore": "http://apps.bdimg.com/libs/underscore.js/1.7.0/underscore-min"

    },
    baseUrl: "js",
    shim: {

        "underscore": {  //1. 非AMD模块输出，将非标准的AMD模块"垫"成可用的模块，
            export: "_"  
        },
        "jquery.form": {
            dept: ["jquery"]  //2.插件形式的非AMD模块，我们经常会用到jquery插件，而且这些插件基本都不符合AMD规范，比如jquery.form插件，这时候就需要将form插件"垫"到jquery中
        }

    }

})