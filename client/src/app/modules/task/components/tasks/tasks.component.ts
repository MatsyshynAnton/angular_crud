import { Component, OnInit, ViewChild, ViewChildren } from '@angular/core';
import { Task } from 'src/app/models/Task';
import { TaskService } from '../../services/task.service';
import { AddTaskComponent } from '../add-task/add-task.component';
import { TaskComponent } from '../task/task.component';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {

  tasks: Task[];

  @ViewChild(AddTaskComponent) addTaskComponent: AddTaskComponent;
  @ViewChildren(TaskComponent) taskComponents: TaskComponent[];

  onAddNewTask: boolean = false;

  constructor(private taskService: TaskService) { }

  ngOnInit(): void {
    this.taskService.getAllTasks()
      .subscribe(result => this.tasks = result.sort((t1, t2) => t2.id - t1.id));
  }

  addTaskHandler(task: Task): void {
    this.onAddNewTask = false;

    task.id = this.tasks[0].id + 1;
    this.tasks.unshift(task);

    this.taskService.createTask(task)
      .subscribe(result => task = result);
  }
  
  deleteTaskHandler(task: Task): void {
    this.tasks = this.tasks.filter(t => t.id != task.id);

    this.taskService.deleteTask(task.id)
      .subscribe(() => this.tasks);
  }

  changeAddNewState(): void {
    this.onAddNewTask = !this.onAddNewTask;
  }
}
