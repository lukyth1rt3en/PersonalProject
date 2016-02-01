namespace GameArchive.Controller {
    export class addGamesController {     
        public game;

        public addGame(game): void {
            this.$http.post(`/api/addGames/game`, game)
                .then((reponse) => {
                    console.log("game has been created");
                })
                .catch((response) => {
                    console.log(response);
                })
        }
        constructor(private $http: ng.IHttpService, private $location: ng.ILocationService) {

        }
    }
}