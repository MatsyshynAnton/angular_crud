import { Component, OnInit, Output, EventEmitter, ViewChild, ElementRef } from '@angular/core';
import { Team } from 'src/app/models/Team';
import { TeamModule } from '../../team.module';
import { Form, NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-team',
  templateUrl: './add-team.component.html',
  styleUrls: ['./add-team.component.scss']
})
export class AddTeamComponent {

  @Output("onAddNewTeam") addNewTeam: EventEmitter<Team> = new EventEmitter<Team>();
  @ViewChild("teamForm") form: NgForm;
  
  newTeam = {} as Team;

  constructor() { }

  saveTeam(): void {
    this.newTeam.createdAt = new Date();
    this.addNewTeam.emit(this.newTeam);
  }
}
