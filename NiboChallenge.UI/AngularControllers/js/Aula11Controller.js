angular.module('app',['ngRoute'])

.controller('Aula11Controller', function($scope,$route,$routeParams,$location){
    
    $scope.$route = $route;
    $scope.$location = $location;
    $scope.$routeParams =  $routeParams;
})

.controller ('InicialController', function($scope){
    console.log('Controlle incial');
})

.controller('pagina1Controller', function($scope){
    console.log('Controle pagina1');
})

.controller('pagina2Controller', function($scope, $routeParams){
    
    $scope.parametros = $routeParams;
    console.log('Controle pagina2');
    console.log("id do produto"+$scope.parametros.idproduto);
})

.config(function($routeProvider, $locationProvider){
    
    $routeProvider
    .when('/',{
         templateUrl : 'Aula11_inicial.html',
        controller : 'InicialController'
    })
    .when('/pagina1',{
         templateUrl : 'Aula11_pagina1.html',
        controller : 'pagina1Controller'
    })
    .when('/pagina2/:idproduto',{
         templateUrl : 'Aula11_pagina2.html',
        controller : 'pagina2Controller'
    })
    .otherwise({
        redirectTo : '/'
    });
    
    $locationProvider.html5Mode(true);
}); 