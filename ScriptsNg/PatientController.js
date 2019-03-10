angular.module('myFormApp', [])
    .controller('PatientController', function ($scope, $http, $location, $window) {

        $scope.message = '';
        $scope.result = "color-default";
        $scope.isViewLoading = false;
        $scope.ListPatient = null;
        $scope.PatientByNameList = null;
        getallData();

        function getallData() {
            $http.get('/PatientDetails/GetAllData')
                .success(function (data, status, headers, config) {
                    $scope.ListPatient = data;
                })
                .error(function (data, status, headers, config) {
                    $scope.message = 'Unexpected Error while loading data!!';
                    $scope.result = "color-red";
                    console.log($scope.message);
                });
        };

        $scope.getPatient = function (patModel) {
            var id = patModel.PatientID;
            $http.get('/PatientDetails/GetbyID/' + id)
                .success(function (data, status, headers, config) {
                    $scope.PatientByNameList = data;
                    getallData();
                    console.log(data);
                })
                .error(function (data, status, headers, config) {
                    $scope.message = 'Unexpected Error while loading data!!';
                    $scope.result = "color-red";
                    console.log($scope.message);
                });
        };


    })
    .config(function ($locationProvider) {
        $locationProvider.html5Mode(true);

    });
$locationProvider.html5Mode({
    enabled: true,
    requireBase: false
});