import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmployeeShopComponent } from './list-employee-shop.component';

describe('ListEmployeeShopComponent', () => {
  let component: ListEmployeeShopComponent;
  let fixture: ComponentFixture<ListEmployeeShopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmployeeShopComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmployeeShopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
