import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProjectsComponent } from './components/projects/projects.component';
import { RouterModule } from '@angular/router';
import { ProjectComponent } from './components/project/project.component';
import { ProjectService } from './services/project.service';
import { AddProjectComponent } from './components/add-project/add-project.component';
import { FormsModule } from '@angular/forms';
import { EditProjectComponent } from './components/edit-project/edit-project.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [ProjectsComponent, ProjectComponent, AddProjectComponent, EditProjectComponent],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    SharedModule
  ],
  providers: [
    ProjectService
  ],
})
export class ProjectModule { }
