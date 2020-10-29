import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { TodoListNavbarComponent } from './navbar/todo-list-navbar/todo-list-navbar.component';
import { AutoFocusDirective } from './directives/auto-focus.directive';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [NavbarComponent, TodoListNavbarComponent, AutoFocusDirective],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [NavbarComponent]
})
export class SharedModule { }
