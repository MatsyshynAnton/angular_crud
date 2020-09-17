import { Injectable } from "@angular/core";
import { HttpInternalService } from 'src/app/services/http-internal.service';
import { Team } from 'src/app/models/Team';
import { HttpRequest, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class TeamService {

    private readonly endpoint: string = 'api/team/';
    constructor(private httpService: HttpInternalService) { }

    getAllTeams(): Observable<Team[]> {
        return this.httpService.getRequest<Team[]>(this.endpoint);
    }

    createTeam(team: Team) : Observable<Team> {
        return this.httpService.postRequest<Team>(this.endpoint, team);
    }

    updateTeam(team: Team) : Observable<any> {
        return this.httpService.putRequest(this.endpoint, team);
    }
    
    deleteTeam(id: number) : Observable<any> {
        return this.httpService.deleteRequest(this.endpoint + id);
    }
}