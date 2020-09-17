import { HttpInternalService } from 'src/app/services/http-internal.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Task } from 'src/app/models/Task';

@Injectable()
export class TaskService {

    private readonly endpoint: string = "api/task/";

    constructor(private httpService: HttpInternalService) {}

    getAllTasks(): Observable<Task[]> {
        return this.httpService.getRequest<Task[]>(this.endpoint);
    }

    createTask(task: Task): Observable<Task> {
        return this.httpService.postRequest<Task>(this.endpoint, task);
    }

    updateTask(task: Task): Observable<any> {
        return this.httpService.putRequest<any>(this.endpoint, task);
    }

    deleteTask(taskId: number) : Observable<any> {
        return this.httpService.deleteRequest(this.endpoint + taskId);
    }
}