import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { Task } from 'src/app/models/Task';
import { TaskService } from '../../services/task.service';
import { EditTaskComponent } from '../edit-task/edit-task.component';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})
export class TaskComponent {

  additionalInfo: boolean = false;
  onEdit = false;

  @Input() task: Task;
  @Output() onTaskDelete = new EventEmitter<Task>();

  @ViewChild(EditTaskComponent) editTaskComponent: EditTaskComponent;

  constructor(private taskService: TaskService) { }

  editClick(): void {
    this.additionalInfo = false;
    this.onEdit = !this.onEdit;
  }

  deleteClick(): void {
    this.onTaskDelete.emit(this.task);
  }

  changeAdditionalInfoState(): void {
    this.onEdit = false;
    this.additionalInfo = !this.additionalInfo;
  }

  onUpdateTaskHandler(task: Task): void {
    this.taskService.updateTask(task)
      .subscribe(() => task);

      this.onEdit = false;
  }
}
