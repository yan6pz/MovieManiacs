moviesApp.controller('AddMovieController', function ($scope, $http, $rootScope) {
  $rootScope.showMenu = true;
  $rootScope.showSideMenu = true;

  $scope.moviebject = {};

  $scope.addMovie = function addMovie(moviebject) {
      var objJSON = angular.toJson(moviebject, 2);
      console.log(objJSON);
      return $http.post('http://localhost:54148/api/movie/new', objJSON).then(function (res) {
          return res;
      }).catch(function (err) {
          return err;
      })
  }

});