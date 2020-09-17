import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Project } from 'src/app/models/Project';
import { ProjectService } from '../../services/project.service';
import { EditProjectComponent } from '../edit-project/edit-project.component';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss']
})
export class ProjectComponent {

  @Input() project: Project;
  @Output()  onDeleteProject: EventEmitter<Project> = new EventEmitter<Project>();

  additionalInfo: boolean = false;
  onEdit: boolean = false;

  @ViewChild(EditProjectComponent) editProjectComponent: EditProjectComponent;

  constructor(private projectService: ProjectService) { }

  editClick():void {
    this.additionalInfo = false;
    this.onEdit = !this.onEdit;
  }

  deleteClick():void {
    this.onDeleteProject.emit(this.project);
  }

  changeAdditionalInfoState():void {
    this.onEdit = false;
    this.additionalInfo = !this.additionalInfo;
  }

  updateProjectHandler(project: Project):void {
    this.projectService.updateProject(project)
      .subscribe(() => project);

      this.onEdit = !this.onEdit;
  }
}
