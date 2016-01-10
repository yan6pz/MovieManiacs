moviesApp.controller('GlobalController', function ($scope, $http, $rootScope) {
    $scope.userObject = {};
    $scope.loginUser = {};
    $scope.currentUser = {};
    $scope.notifyObject = {};

    $scope.registerUser = function registerUser(userObject) {
        var objJSON = angular.toJson(userObject, 2);
        console.log(objJSON);
        return $http.post('http://localhost:54148/api/users/new', objJSON).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }

    $scope.notifyUser = function notifyUser(notifyObject) {
        notifyObject.userId = 2;
        var objJSON = angular.toJson(notifyObject, 2);
        return $http.post('http://localhost:52894/notify/send', objJSON).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }
    //$scope.login = function login(loginUser) {
    //    var objJSON = angular.toJson(loginUser, 2);
    //    console.log(objJSON);
    //    return $http.post('http://localhost:54148/api/users/new', objJSON).then(function (res) {
    //        return res;
    //    }).catch(function (err) {
    //        return err;
    //    })
    //}
});