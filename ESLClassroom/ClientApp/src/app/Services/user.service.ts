import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { User } from 'oidc-client';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  url: string = "api/Classroom";

  constructor(private http: HttpClient, @Inject ('BASE_URL') private baseUrl: string) { }


  getUserByTeacherId(teacherId:string): Observable <User>{
    return this.http.get<User>(`${this.baseUrl}${this.url}/UserByteacherId?teacherId=${teacherId}`);
  }
}
