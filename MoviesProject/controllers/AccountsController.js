moviesApp.controller('AccountsController', function ($scope, $http, $rootScope) {
    $http.get('json/users.json')
         .then(function (res) {
             $scope.accounts = res.data;
         });
    
    $rootScope.selectUser = function(user) {
      $rootScope.selectedUser = user;
      location.href = '/#/profileinfo';
    };
});