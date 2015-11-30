'use strict';

var moviesApp = angular
    .module('moviesapp', ['ngResource', 'ngRoute'])
    .config(function($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'templates/home.html'
            })
            .when('/mymovies', {
                templateUrl: 'templates/mymovies.html'
            })
            .when('/shared', {
                templateUrl: 'templates/shared.html'
            })
            .when('/registration', {
                templateUrl: 'templates/registration.html'
            })
            .when('/accounts', {
                templateUrl: 'templates/accounts.html'
            })
            .when('/popular', {
                templateUrl: 'templates/popular.html'
            })
            .when('/friends', {
                templateUrl: 'templates/friends.html'
            })
            .when('/addmovie', {
                templateUrl: 'templates/addmovie.html'
            })
            .when('/profile', {
                templateUrl: 'templates/profile.html'
            })
            .when('/moviedetails', {
                templateUrl: 'templates/moviedetails.html'
            })
            .when('/profileinfo', {
                templateUrl: 'templates/profileinfo.html'
            })
            .when('/recommend', {
                templateUrl: 'templates/recommend.html'
            })
            .when('/add', {
                templateUrl: 'templates/add.html'
            })
            .otherwise({redirectTo: '/home'});
    })