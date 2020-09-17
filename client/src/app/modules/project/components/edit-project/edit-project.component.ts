import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Project } from 'src/app/models/Project';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-edit-project',
  templateUrl: './edit-project.component.html',
  styleUrls: ['./edit-project.component.scss']
})
export class EditProjectComponent {

  @Input() project: Project;
  @Output() onProjectUpdate: EventEmitter<Project> = new EventEmitter<Project>();

  @ViewChild("projectForm") editForm: NgForm;
  
  constructor() { }

  updateProject(): void {
    this.onProjectUpdate.emit(this.project);
  }
}
