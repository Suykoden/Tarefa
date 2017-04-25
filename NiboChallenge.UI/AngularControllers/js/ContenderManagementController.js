var app = angular.module("app", []);
app.controller("ContenderManagementController", function ($scope, $http, $location, $window) {
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

    $scope.OrderData = function(Order) {

        $scope.Ordernation = Order;
    };

    $scope.DeleteContender = function (Contender) {

        $http.put('/api/Contender', Contender)
        .success(function (data) {
            $scope.PostDataResponse = data;
            $scope.LoadContenders();

        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });

    };

    //Damasio: The idea here was edit data from contenders view, but it wasn't loading de contender selected properly, must find a way to do this  

    /*  $scope.EditContender = function (ContenderId) {
          $http.post('/Home/ContenderEdit/' + ContenderId)
        .success(function (data) {
            console.log(data);
            $scope.Id = ContenderId;
            $window.location = "ContenderEdit";
        })
        .error(function (data, status, header, config) {
            $scope.ResponseDetails = "Data: " + data +
                "<hr />status: " + status;
        });
      }
  
      $scope.GetContender = function (ContenderId) {
          $http
          .get("/api/Contender/" + ContenderId)
          .success(function (data) {
              console.log(data);
              $scope.ContenderEdit = data;
              
  
              })
           .error(function () {
               alert("Não foi possível carregar os dados,erro aqui");
           });
      }
      */

});