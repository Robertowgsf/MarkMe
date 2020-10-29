import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TodoList } from '../../models/todo-list.model';
import { TodoListService } from '../../services/todo-list.service';

@Component({
  selector: 'app-todo-list-navbar',
  templateUrl: './todo-list-navbar.component.html',
  styleUrls: ['../navbar.component.sass', './todo-list-navbar.component.sass']
})
export class TodoListNavbarComponent implements OnInit {

  todoLists = [];
  todoListFormGroup: FormGroup;
  preventSingleClick = false;
  preventSingleClickTimer = null;
  preventSingleClickDelay = 200;

  constructor(
    private todoListService: TodoListService,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.todoListService.get().subscribe(response => {
      this.todoLists = response;
    });
  }

  addNewTodoList(todoListFormGroupValue) {
    if (this.todoListFormGroup) {
      let todoList = new TodoList();
      todoList.nome = todoListFormGroupValue.nome;
      this.todoListService.add(todoList).subscribe(response => {
        this.todoLists.push(response);
        this.todoListFormGroup = null;
      },
        error => {
          this.setFormErrors(error.error);
        });
    }
    else {
      this.todoListFormGroup = this.fb.group({
        nome: []
      });
    }
  }

  private setFormErrors(error) {
    error.forEach(error => {
      let formControl = this.todoListFormGroup.get(error.propertyName);
      formControl.setErrors(error.errors);;
    });
  }

  handleNewTodoList() {
    this.todoListFormGroup = null;
  }

  loadTarefas(todoList: TodoList): void {
    this.router.navigate(["pages/todo-list", todoList.id])
  }
}
