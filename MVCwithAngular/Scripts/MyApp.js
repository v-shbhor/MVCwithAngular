(function () {
    //Create a module
    var app = angular.module('MyApp', ['ngRoute']); //will use [ngroute] when we will implement routing
    //Create a controller
    app.controller('HomeController', function ($scope) { //here $scope is used to share data between view and controller
        $scope.Message = "Yahoo! we have successfully done our first part."
    });
})();