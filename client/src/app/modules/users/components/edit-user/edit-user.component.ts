import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { User } from 'src/app/models/Users';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.scss']
})
export class EditUserComponent {

  @Input() user: User;
  @Output() onUpdateUser: EventEmitter<User> = new EventEmitter<User>();

  @ViewChild("userForm") editForm: NgForm;
   
  constructor() { }

  updateUser(): void {
    this.onUpdateUser.emit(this.user);
  }
}
