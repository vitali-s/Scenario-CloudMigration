(function () {
angular
    .module("cloud-application")
    .constant("contentUrl", "/contentitems")
    .controller("contentController", function ($scope, $http, contentUrl) {

        $http.get(contentUrl)
            .success(function(data) {
                $scope.content = data;
            })
            .error(function(error) {
                $scope.error = error;
            });
    });
})();