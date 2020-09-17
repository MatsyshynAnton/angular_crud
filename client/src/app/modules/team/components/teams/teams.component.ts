import { Component, OnInit, Input, ViewChild, ViewChildren } from '@angular/core';
import { TeamService } from '../../services/teams.service';
import { Team } from 'src/app/models/Team';
import { AddTeamComponent } from '../add-team/add-team.component';
import { TeamComponent } from '../team/team.component';


@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.scss']
})
export class TeamsComponent implements OnInit {

  teams: Team[];
  onAddNewTeam: boolean = false;

  @ViewChild(AddTeamComponent) addTeamComponent: AddTeamComponent;
  @ViewChildren(TeamComponent) teamComponents: TeamComponent[];
  
  constructor(private teamService: TeamService) { }

  ngOnInit(): void {
    this.teamService.getAllTeams()
    .subscribe(result => this.teams = result.sort((t1, t2) => t2.id - t1.id));
  }

  changeAddNewState(): void {
    this.onAddNewTeam = !this.onAddNewTeam;
  }

  deleteTeamHandler(team: Team): void {
    this.teamService.deleteTeam(team.id)
      .subscribe(() => this.teams);

    this.teams = this.teams.filter(t => t.id != team.id);
  }

  addTeamHandler(team: Team): void {
    this.onAddNewTeam = false

    team.id = this.teams[0].id + 1;
    this.teams.unshift(team);

    this.teamService.createTeam(team)
      .subscribe(result => team = result);
  }
}
