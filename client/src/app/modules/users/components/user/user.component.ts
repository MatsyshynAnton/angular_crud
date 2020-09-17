import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { User } from 'src/app/models/Users';
import { UserService } from '../../services/user.service';
import { EditUserComponent } from '../edit-user/edit-user.component';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {

  @Input() user: User;
  @Output() onUserDelete: EventEmitter<User> = new EventEmitter<User>();

  @ViewChild(EditUserComponent) editUserComponent: EditUserComponent;

  additionalInfo: boolean = false;
  onEdit: boolean = false;

  constructor(private userService: UserService) { }

  changeAdditionalInfoState(): void {
    this.onEdit = false;
    this.additionalInfo = !this.additionalInfo;
  }

  editClick(): void {
    this.additionalInfo = false;
    this.onEdit = !this.onEdit;
  }

  deleteClick(): void {
    this.onUserDelete.emit(this.user);
  }

  onUpdateUserHandler(user: User): void {
    this.userService.updateUser(user)
      .subscribe(() => user);

    this.onEdit = false;
  }
}
