var app = angular.module("app", []);
app.controller("ContenderManagementController", function ($scope, $http) {
    $scope.FormAddContender = {};
    $scope.Save = function () {

        $http.post('/api/Contender', $scope.Contender)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.Contender = {};
            $scope.FormAddContender.$setUntouched();
            $scope.FormAddContender.$setPristine();
            $scope.LoadContenders();
            
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
    $scope.LoadContenders = function () {
        $http
        .get("/api/Contender")
        .success(function (data) {
            console.log(data);
            $scope.dados = data;
            $scope.ContendersList = data;


        })
         .error(function () {
             alert("Não foi possível carregar os dados");
         });


    }

    $scope.OrderData = function (Order) {
    
        $scope.Ordernation = Order;
    }
});