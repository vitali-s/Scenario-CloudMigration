(function () {
    angular
        .module("cloud-application", ["ngRoute"])
        .config(function ($routeProvider) {

            $routeProvider.when("/content", {
                templateUrl: "/views/content.html"
            });

            $routeProvider.when("/database", {
                templateUrl: "/views/database.html"
            });

            $routeProvider.when("/message-queue", {
                templateUrl: "/views/message-queue.html"
            });

            $routeProvider.when("/mail", {
                templateUrl: "/views/mail.html"
            });

            $routeProvider.otherwise({
                templateUrl: "/views/application.html"
            });
        });
})();