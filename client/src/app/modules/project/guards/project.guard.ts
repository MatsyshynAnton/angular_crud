import { Injectable } from '@angular/core';
import { CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { ProjectService } from '../services/project.service';
import { ProjectsComponent } from '../components/projects/projects.component';

@Injectable({
  providedIn: 'root'
})
export class ProjectGuard implements CanDeactivate<ProjectsComponent> {
  canDeactivate(
    component: ProjectsComponent,
    currentRoute: ActivatedRouteSnapshot,
    currentState: RouterStateSnapshot,
    nextState?: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const editFormsSaved = component.projectComponents.filter(t => t.editProjectComponent?.editForm.dirty).length == 0;
      const addFormSaved = !component.addProjectComponent?.form.dirty;
      return editFormsSaved && addFormSaved || window.confirm("Page may contain unsaved changes. Continue?");
    }
  
}
