moviesApp.controller('GlobalController', function ($scope, $http, $rootScope) {
    userObject = '';

    surveyInvite = function surveyInvite(userObject) {
        var objJSON = angular.toJson(userObject, 2);
        console.log(objJSON);
        return $http.post('http://localhost:54148/api/users/new', objJSON).then(function (res) {
            return res;
        }).catch(function (err) {
            return err;
        })
    }
});