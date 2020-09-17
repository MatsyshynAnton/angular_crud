import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { TeamsComponent } from './components/teams/teams.component';
import { TeamComponent } from './components/team/team.component';
import { TeamService } from './services/teams.service';
import { RouterModule } from '@angular/router';
import { AddTeamComponent } from './components/add-team/add-team.component';
import { from } from 'rxjs';
import { EditTeamComponent } from './components/edit-team/edit-team.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [TeamsComponent, TeamComponent, AddTeamComponent, EditTeamComponent],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    SharedModule
  ],
  providers: [
    TeamService,
  ]
})
export class TeamModule { }
