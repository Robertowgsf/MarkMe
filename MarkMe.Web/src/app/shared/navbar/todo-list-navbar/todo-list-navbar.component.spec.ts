import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoListNavbarComponent } from './todo-list-navbar.component';

describe('TodoListNavbarComponent', () => {
  let component: TodoListNavbarComponent;
  let fixture: ComponentFixture<TodoListNavbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TodoListNavbarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TodoListNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
