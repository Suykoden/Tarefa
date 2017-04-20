app.controller('aula06Controller',function($scope){
    $scope.nome = "Curso AngularJS"
    $scope.olaMundo = function(nome){
        alert("hi there! " + nome +  "!" );
    }
});