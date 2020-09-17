import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProjectModule } from './modules/project/project.module';
import { TeamModule } from './modules/team/team.module';
import { HttpInternalService } from './services/http-internal.service';
import { HttpClientModule } from '@angular/common/http';
import { UsersModule } from './modules/users/users.module';
import { TaskModule } from './modules/task/task.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ProjectModule,
    TaskModule,
    TeamModule,
    UsersModule,
    HttpClientModule
  ],
  providers: [HttpInternalService ],
  bootstrap: [AppComponent],
})
export class AppModule { }
