app.controller('Aula10Controller', function($scope,saudacaoFilter){
   
    
   console.log(saudacaoFilter('Rafael'))
   $scope.pessoa = {
       nome: 'Rafael',
       idade: '29'
   } 
   
});