import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { TodoList } from '../models/todo-list.model';

@Injectable({
  providedIn: 'root'
})
export class TodoListService {

  private endpoint: string;
  private headers = {
    'Content-Type': 'application/json'
  }

  constructor(private http: HttpClient) {
    this.endpoint = `${environment.apiUrl}/TodoList`
  }

  get(): Observable<any> {
    return this.http.get(this.endpoint, { headers: this.headers });
  }

  getById(id: number): Observable<any> {
    return this.http.get(`${this.endpoint}/${id}`, { headers: this.headers });
  }

  add(todoList: TodoList): Observable<any> {
    return this.http.post(this.endpoint, todoList, { headers: this.headers });
  }
}
