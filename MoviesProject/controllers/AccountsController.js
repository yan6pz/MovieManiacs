moviesApp.controller('AccountsController', function ($scope, $http, $rootScope) {
    $http.get('http://localhost:54148/api/friends/6')
         .then(function (res) {
             $scope.accounts = res.data;
         });
    
    $rootScope.selectUser = function(user) {
      $rootScope.selectedUser = user;
      location.href = '/#/profileinfo';
    };
});