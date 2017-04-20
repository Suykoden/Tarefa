app.controller('Aula09Controller', function($scope,operacoes,pessoa){
    
    $scope.pessoa = new pessoa();
    console.log(operacoes.somar(10,10));
    
});

app.controller('Aula09Crl2Controller',function($scope,operacoes){
    
    console.log(operacoes.subtrair(10,5));
});