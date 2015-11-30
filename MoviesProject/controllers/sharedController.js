moviesApp.controller('sharedController', function($scope, $http) {
  $http.get('json/mymovies.json')
       .then(function(res){
          $scope.myMovies = res.data;                
       });
  $rootScope.showMenu = true;
  $rootScope.showSideMenu = true;
});