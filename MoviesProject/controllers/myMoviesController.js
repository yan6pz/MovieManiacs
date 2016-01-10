
moviesApp.controller('MyMoviesController', function ($scope, $rootScope, $http) {
    $rootScope.showMenu = true;
    $rootScope.showSideMenu = true;
    $http.get('http://localhost:54148/api/movies/all')
       .then(function(res){
           $scope.allMovies = res.data;
           console.log(res);
       });

    $http.get('http://localhost:54148/api/usermovies/2')
   .then(function (res) {
       $scope.myMovies = res.data;
       console.log(res);
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
