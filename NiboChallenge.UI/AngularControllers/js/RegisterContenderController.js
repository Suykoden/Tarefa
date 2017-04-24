var app = angular.module("app", []);
app.controller("RegisterContenderController", function ($scope, $http) {

    $scope.Save = function () {

        $http.post('/api/Contender', $scope.Contender)
        .success(function (data) {
            $scope.PostDataResponse = data;
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
    };

    $scope.LoadCategories = function () {
        $http
        .get("/api/ContenderCategory")
        .success(function (data) {
            console.log(data);
            $scope.dados = data;
            $scope.ContenderCategoriesList = data;


        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    }

    $scope.LoadSkills = function () {
        $http
        .get("/api/Skill")
        .success(function (data) {
            console.log(data);
            $scope.dados = data;
            $scope.SkillList = data;


        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });
    }
});