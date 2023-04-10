import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmployeeTypeComponent } from './list-employee-type.component';

describe('ListEmployeeTypeComponent', () => {
  let component: ListEmployeeTypeComponent;
  let fixture: ComponentFixture<ListEmployeeTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmployeeTypeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmployeeTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
