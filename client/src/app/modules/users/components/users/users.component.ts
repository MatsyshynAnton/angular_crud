import { Component, OnInit, ViewChild, ViewChildren } from '@angular/core';
import { User } from 'src/app/models/Users';
import { UserService } from '../../services/user.service';
import { AddUserComponent } from '../add-user/add-user.component';
import { UserComponent } from '../user/user.component';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {

  users: User[];

  onAddNewUser: boolean = false;

  @ViewChild(AddUserComponent) addUserComponent: AddUserComponent;
  @ViewChildren(UserComponent) userComponents: UserComponent[];

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getAllUsers()
      .subscribe(result => this.users = result.sort((u1, u2) => u2.id - u1.id));
  }

  addUserHandler(user: User): void {
    this.onAddNewUser = false;

    user.id = this.users[0].id + 1;
    this.users.unshift(user);

    this.userService.createUser(user)
      .subscribe(result => user = result);
  }

  deleteUserHandler(user: User): void {
    this.users = this.users.filter(u => u.id != user.id);
    this.userService.deleteUser(user)
      .subscribe(() => this.users);
  }

  changeAddNewState(): void {
    this.onAddNewUser = !this.onAddNewUser;
  }
}
