app.controller('Aula13Controller', function($scope){
    
    
});
               
app.directive('ngOla', function(){
    
    return {
        restrict: 'AEC',
        scope: {
            ngNome: '@'
        },
        template: '<h1>Olá!{{ngNome}}</h1>'
    }
})              