import { Injectable } from '@angular/core';
import { CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { TasksComponent } from '../components/tasks/tasks.component';

@Injectable({
  providedIn: 'root'
})
export class TaskGuard implements CanDeactivate<TasksComponent> {
  canDeactivate(
    component: TasksComponent,
    currentRoute: ActivatedRouteSnapshot,
    currentState: RouterStateSnapshot,
    nextState?: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const editFormsSaved = component.taskComponents.filter(t => t.editTaskComponent?.editForm.dirty).length == 0;
      const addFormSaved = !component.addTaskComponent?.form.dirty;
      return editFormsSaved && addFormSaved || window.confirm("Page may contain unsaved changes. Continue?");
  }
  
}
