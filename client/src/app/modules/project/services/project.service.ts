import { Injectable } from "@angular/core";
import { HttpInternalService } from 'src/app/services/http-internal.service';
import { Project } from 'src/app/models/Project';
import { Observable } from 'rxjs';

@Injectable()
export class ProjectService {

    private readonly endpoint: string = "api/project/";
    constructor(private httpService: HttpInternalService) {}

    getAllProjects(): Observable<Project[]> {
        return this.httpService.getRequest<Project[]>(this.endpoint);
    }

    createProject(newProject: Project): Observable<Project> {
        return this.httpService.postRequest<Project>(this.endpoint, newProject);
    }
    
    updateProject(project: Project): Observable<any> {
        return this.httpService.putRequest(this.endpoint, project);
    }

    deleteProject(projectId: number) : Observable<any> {
        return this.httpService.deleteRequest(this.endpoint + projectId);
    }
}