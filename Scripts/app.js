//potluck angular app object
var potluck = angular.module('potluck',[
  'ngRoute', 
  'potluck.services',
  'potluck.controllers'
]);


//Routing configurations
potluck.config(function($routeProvider, $locationProvider){

    $routeProvider.when('/', {
      templateUrl: 'login.html',
      controller: 'loginCtrl'
    });
    
    $routeProvider.when('/landingpage', {
      templateUrl:  'landing-page.html', //'test.html',  
      controller: 'landingCtrl'
    });
    
    
    $routeProvider.when('/registration', {
      templateUrl: 'registration.html',
      controller: 'registrationCtrl'
    });
    
    
    $routeProvider.when('/forgotpassword', {
      templateUrl: 'choose-password.html' 
    });

    $routeProvider.when('/createevent', {
        templateUrl: 'create-event.html',
        controller: 'eventCtrl'
    });
    
    // use the HTML5 History API
    $locationProvider.html5Mode(true);  //Used to remove # and make pretty Urls

});