import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, CanDeactivate } from '@angular/router';
import { Observable } from 'rxjs';
import { TeamsComponent } from '../components/teams/teams.component';

@Injectable({
  providedIn: 'root'
})
export class TeamGuard implements CanDeactivate<TeamsComponent> {
  canDeactivate(component: TeamsComponent, currentRoute: ActivatedRouteSnapshot, currentState: RouterStateSnapshot, nextState?: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
    const editFormsSaved = component.teamComponents.filter(t => t.editTeamComponent?.editForm.dirty).length == 0;
    const addFormSaved = !component.addTeamComponent?.form.dirty;
    return editFormsSaved && addFormSaved || window.confirm("Page may contain unsaved changes. Continue?");
  }  
}
