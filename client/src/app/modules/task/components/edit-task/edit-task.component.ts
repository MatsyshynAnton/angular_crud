import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Task } from 'src/app/models/Task';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-edit-task',
  templateUrl: './edit-task.component.html',
  styleUrls: ['./edit-task.component.scss']
})
export class EditTaskComponent {

  @Input() task: Task;
  @Output() onUpdateTask = new EventEmitter<Task>();

  @ViewChild("taskForm") editForm: NgForm;

  constructor() { }

  updateTask() {
    this.task.createdAt = new Date();
    this.onUpdateTask.emit(this.task);
  }
}
