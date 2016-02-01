namespace GameArchive.Controllers {
    export class GameListController {
        public games;

        public constructor(private $http: ng.IHttpService, $routeParams) {
            $http.get(`api/games/list`)
                .then((response) => {
                    this.games = response.data;
                    console.log("the list was populated");  
                    for (var ele in response.data) {
                        console.log(ele + "There was something here");
                    }
                });
        } 
    }
}