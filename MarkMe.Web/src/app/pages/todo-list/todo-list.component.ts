import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TodoList } from 'src/app/shared/models/todo-list.model';
import { TodoListService } from 'src/app/shared/services/todo-list.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.sass']
})
export class TodoListComponent implements OnInit {

  todoList: TodoList;

  constructor(
    private route: ActivatedRoute,
    private todoListService: TodoListService
  ) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      let todoListId = params['id'];

      if (!todoListId) return;

      this.todoListService.getById(todoListId).subscribe(response => {
        this.todoList = response;
      })
    });
  }

}
