import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Team } from 'src/app/models/Team';
import { TeamService } from '../../services/teams.service';
import { EditTeamComponent } from '../edit-team/edit-team.component';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.scss']
})
export class TeamComponent {

  @Input() team: Team;
  @Output() onDeleteTeam: EventEmitter<Team> = new EventEmitter<Team>();
  
  @ViewChild(EditTeamComponent) editTeamComponent: EditTeamComponent;

  additionalInfo: boolean = false;
  onEdit: boolean = false;

  constructor(private teamService: TeamService) { }

  changeAdditionalInfoState(): void {
    this.onEdit = false;
    this.additionalInfo = !this.additionalInfo;
  }

  editClick(): void {
    this.additionalInfo = false;
    this.onEdit = !this.onEdit;
  }

  deleteClick(): void {
    this.onDeleteTeam.emit(this.team);
  }

  onUpdateTeamHandler(team: Team): void {
    this.teamService.updateTeam(team)
      .subscribe(() => team);

    this.onEdit = false;
  }
}
