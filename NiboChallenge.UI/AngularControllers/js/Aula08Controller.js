app.controller("Aula08Controller",function($scope){
    
    $scope.pessoa = novaPessoa();
    
    $scope.pessoas = [];
    
    $scope.estados = ['SP','RJ','MG','CE']
    
    $scope.salvaPessoa = function(pessoa){
        $scope.pessoas.push(pessoa);
        $scope.pessoa = novaPessoa();
             
        $scope.frm.$setPristine();
    }
    
});

function novaPessoa(){
    return {
        nome: "",
        email: "",
        sexo: "m",
        estado: "RJ"
    }
}