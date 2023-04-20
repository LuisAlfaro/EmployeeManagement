import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssingEmployeeShopComponent } from './assing-employee-shop.component';

describe('AssingEmployeeShopComponent', () => {
  let component: AssingEmployeeShopComponent;
  let fixture: ComponentFixture<AssingEmployeeShopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssingEmployeeShopComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AssingEmployeeShopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
