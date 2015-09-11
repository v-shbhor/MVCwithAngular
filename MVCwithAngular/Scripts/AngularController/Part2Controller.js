//here i am separating each ang controller to a separate file to make it manageable
angular.module('MyApp')
    .controller('Part2Controller', function ($scope, ContactService) {
    $scope.Contact = null;
    ContactService.GetLastContact().then(function (d) {
        $scope.Contact = d.data; //success
    }, function () {
        alert('FAILED');
    });
    })
    .factory('ContactService', function ($http) { //here i have created a factory which is a popular way to create and configure services
    //$http is an AngularJS service for reading data from remote servers.
    var fac = {};
    fac.GetLastContact = function () {
        return $http.get('/Data/GetLastContact');
    }
    return fac;
});
//