namespace GameArchive {
    
    angular.module('GameArchive', ['ngRoute']);

    angular.module('GameArchive').factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/login');
                    }
                    return $q.reject(response);
                }
            };
        });

    angular.module('GameArchive')
        .config(function ($routeProvider: ng.route.IRouteProvider, $httpProvider: ng.IHttpProvider) {
            $httpProvider.interceptors.push('authInterceptor');
            $routeProvider
                .when('/', {
                    templateUrl: "Presentation/ngApp/views/home.html",
                    controller: GameArchive.Controllers.GameListController,
                    controllerAs: "c"
                })
                .when("/register", {
                    templateUrl: "Presentation/ngApp/views/register.html",
                    controller: GameArchive.Controllers.AuthController,
                    controllerAs: "c"
                })
                .when("/login", {
                    templateUrl: "Presentation/ngApp/views/login.html",
                    controller: GameArchive.Controllers.AuthController,
                    controllerAs: "c"
                })
                .when("/add", {
                    templateUrl: "Presentation/ngApp/views/addGame.html",

                })
        });
}