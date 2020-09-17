import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectsComponent } from './modules/project/components/projects/projects.component';
import { TeamsComponent } from './modules/team/components/teams/teams.component';
import { UsersComponent } from './modules/users/components/users/users.component';
import { TasksComponent } from './modules/task/components/tasks/tasks.component';
import { TeamGuard } from './modules/team/guards/team.guard';
import { UserGuard } from './modules/users/guards/user.guard';
import { TaskGuard } from './modules/task/guards/task.guard';
import { ProjectGuard } from './modules/project/guards/project.guard';

const routes: Routes = [
  { path: 'projects', component: ProjectsComponent, canDeactivate: [ProjectGuard] },
  { path: 'tasks', component: TasksComponent, canDeactivate: [TaskGuard] },
  { path: 'teams', component: TeamsComponent, canDeactivate: [TeamGuard] },
  { path: 'users', component: UsersComponent, canDeactivate: [UserGuard] },
  { path: '**', component: ProjectsComponent, canDeactivate: [ProjectGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
