var AppSaudacao = angular.module('AppSaudacao',[]);

AppSaudacao.filter('ola', function (){
   
    return function(nome){
        return "Olá " + nome + " !";
    }
});