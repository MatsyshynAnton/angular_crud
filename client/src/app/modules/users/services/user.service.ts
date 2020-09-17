import { HttpInternalService } from 'src/app/services/http-internal.service';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/Users';
import { Injectable } from '@angular/core';

@Injectable()
export class UserService {

    private readonly endpoint: string = "api/user/";

    constructor(private httpService: HttpInternalService) { }
    
    getAllUsers(): Observable<User[]> {
        return this.httpService.getRequest<User[]>(this.endpoint);
    }

    createUser(user: User): Observable<User> {
        return this.httpService.postRequest<User>(this.endpoint, user);
    }

    updateUser(user: User): Observable<any> {
        return this.httpService.putRequest<User>(this.endpoint, user);
    }

    deleteUser(user: User): Observable<any> {
        return this.httpService.deleteRequest(this.endpoint+user.id);
    }
}