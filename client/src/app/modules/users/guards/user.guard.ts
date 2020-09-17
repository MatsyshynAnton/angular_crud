import { Injectable } from '@angular/core';
import { CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { UsersComponent } from '../components/users/users.component';

@Injectable({
  providedIn: 'root'
})
export class UserGuard implements CanDeactivate<UsersComponent> {
  canDeactivate(
    component: UsersComponent,
    currentRoute: ActivatedRouteSnapshot,
    currentState: RouterStateSnapshot,
    nextState?: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const editFormsSaved = component.userComponents.filter(t => t.editUserComponent?.editForm.dirty).length == 0;
      const addFormSaved = !component.addUserComponent?.form.dirty;
      return editFormsSaved && addFormSaved || window.confirm("Page may contain unsaved changes. Continue?");
  }
  
}
