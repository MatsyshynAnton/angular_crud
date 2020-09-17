import { Component, OnInit, ViewChild, ViewChildren } from '@angular/core';
import { Project } from 'src/app/models/Project';
import { ProjectService } from '../../services/project.service';
import { AddProjectComponent } from '../add-project/add-project.component';
import { ProjectComponent } from '../project/project.component';

@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.scss']
})
export class ProjectsComponent implements OnInit {

  projects: Project[];
  onAddNewProject: boolean = false;

  @ViewChild(AddProjectComponent) addProjectComponent: AddProjectComponent;
  @ViewChildren(ProjectComponent) projectComponents: ProjectComponent[];

  constructor(private projectService: ProjectService) { }

  ngOnInit(): void {
    this.projectService.getAllProjects()
      .subscribe(result => this.projects = result.sort((p1, p2) => p2.id - p1.id));
  }

  changeAddNewState(): void {
    this.onAddNewProject = !this.onAddNewProject;
  }

  deleteProjectHandler(project: Project): void {
    this.projectService.deleteProject(project.id)
      .subscribe(() => this.projects);
    
      this.projects = this.projects.filter(p => p.id != project.id);
  }

  addProjectHandler(newProject: Project): void {
    this.onAddNewProject = false;
    newProject.id = this.projects[0].id + 1;

    this.projects.unshift(newProject);

    this.projectService.createProject(newProject)
      .subscribe(result => newProject = result);
  }
}
