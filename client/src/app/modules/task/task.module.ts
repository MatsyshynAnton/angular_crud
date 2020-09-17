import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { TasksComponent } from './components/tasks/tasks.component';
import { TaskComponent } from './components/task/task.component';
import { TaskService } from './services/task.service';
import { EditTaskComponent } from './components/edit-task/edit-task.component';
import { AddTaskComponent } from './components/add-task/add-task.component';
import { SharedModule } from '../shared/shared.module';
import { TaskStateDirective } from './directives/task-state.directive';



@NgModule({
  declarations: [TasksComponent, TaskComponent, EditTaskComponent, AddTaskComponent, TaskStateDirective],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    SharedModule
  ],
  providers: [
    TaskService
  ]
})
export class TaskModule { }
