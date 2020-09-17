import { Component, OnInit, Output, EventEmitter, ViewChild } from '@angular/core';
import { User } from 'src/app/models/Users';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent {

  @Output() onAddNewUser: EventEmitter<User> = new EventEmitter<User>();
  @ViewChild("userForm") form: NgForm;

  user = {} as User;
  
  constructor() { }

  saveUser(): void {
    this.user.registeredAt = new Date();
    this.onAddNewUser.emit(this.user);
  }
}
