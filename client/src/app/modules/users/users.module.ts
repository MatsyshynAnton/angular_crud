import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { UserService } from './services/user.service';
import { UsersComponent } from './components/users/users.component';
import { UserComponent } from './components/user/user.component';
import { EditUserComponent } from './components/edit-user/edit-user.component';
import { AddUserComponent } from './components/add-user/add-user.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [UsersComponent, UserComponent, EditUserComponent, AddUserComponent],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    SharedModule
  ],
  providers: [
    UserService
  ]
})
export class UsersModule { }
