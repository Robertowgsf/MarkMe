import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PagesComponent } from './pages.component';

const routes: Routes = [
  {
    path: '',
    component: PagesComponent,
    children: [
      { path: 'todo-list', loadChildren: () => import('./todo-list/todo-list.module').then(m => m.TodoListModule) },
      { path: 'todo-list/:id', loadChildren: () => import('./todo-list/todo-list.module').then(m => m.TodoListModule) }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PagesRoutingModule { }
