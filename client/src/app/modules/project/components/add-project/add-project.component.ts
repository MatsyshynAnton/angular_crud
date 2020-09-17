import { Component, OnInit, Output, EventEmitter, ViewChild } from '@angular/core';
import { Project } from 'src/app/models/Project';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.scss']
})
export class AddProjectComponent {

  newProject = {} as Project;

  @Output() onAddNewProject: EventEmitter<Project> = new EventEmitter<Project>();

  @ViewChild("projectForm") form: NgForm;

  constructor() { }

  saveProject(): void {
    this.newProject.createdAt = new Date();
    this.onAddNewProject.emit(this.newProject);
  }
}
