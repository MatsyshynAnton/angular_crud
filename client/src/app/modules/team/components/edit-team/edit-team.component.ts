import { Component, OnInit, Input, Output, EventEmitter, ViewChild, ElementRef, ViewChildren } from '@angular/core';
import { Team } from 'src/app/models/Team';
import { Form, NgForm } from '@angular/forms';

@Component({
  selector: 'app-edit-team',
  templateUrl: './edit-team.component.html',
  styleUrls: ['./edit-team.component.scss']
})
export class EditTeamComponent {

  @Input() team: Team;
  @Output() onUpdateTeam: EventEmitter<Team> = new EventEmitter<Team>();
  
  @ViewChild("teamForm") editForm: NgForm;
  
  constructor() { }

  updateTeam(): void {
    this.onUpdateTeam.emit(this.team);
  }
}
