import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Task } from 'src/app/models/Task';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.scss']
})
export class AddTaskComponent {

  task = {} as Task;
  @Output() onAddNewtask = new EventEmitter<Task>();
  @ViewChild("taskForm") form: NgForm;

  constructor() { }

  addNewTask(): void {
    this.task.createdAt = new Date();
    this.onAddNewtask.emit(this.task);
  }
}
