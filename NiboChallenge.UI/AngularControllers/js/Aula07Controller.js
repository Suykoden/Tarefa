app.controller("Aula07Controller",function($scope){
        
    $scope.nomes = ['rafael','carlos','souza','gustavo','pamela','leticas'];
    $scope.Pessoas = [];
    
    $scope.Pessoas.push(
        {nome: 'Rafael', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Luiz', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Luzi', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Fernada', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Paula', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Gabriel', idade: 29, status: true} 
    );
    $scope.Pessoas.push(
        {nome: 'Leo', idade: 29, status: true} 
    );
    
       
    console.log($scope.Pessoas);
    
    $scope.adicionaPessoa = function(){
        var _nome = document.getElementById("nomepessoa");
        var _idade = document.getElementById("idadepessoa");
        
        $scope.Pessoas.push(
            {nome: _nome.value,idade: _idade.value}
      );
        
      _nome.value = "";
      _idade.value = "";
    }
   
});