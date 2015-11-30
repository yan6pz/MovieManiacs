
moviesApp.controller('MyMoviesController', function ($scope, $rootScope, $http) {
    $rootScope.showMenu = true;
    $rootScope.showSideMenu = true;
    $http.get('json/mymovies.json')
       .then(function(res){
          $scope.myMovies = res.data;                 
       });
       
    $rootScope.selectMovie = function(movie) {
      $rootScope.selectedMovie = movie;
      location.href = '/#/moviedetails';
    };
    
    $rootScope.selectUser = function(user) {
      $rootScope.selectedUser = user;
      location.href = '/#/profileinfo';
    };
});
