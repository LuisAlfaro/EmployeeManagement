import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Employee } from '../../../interfaces/employee';
import { EmployeeShop } from '../../../interfaces/employee-shop';
import { Shop } from '../../../interfaces/shop';
import { EmployeeShopService } from '../../../services/employee-shop.service';
import { EmployeeService } from '../../../services/employee.service';
import { ShopService } from '../../../services/shop.service';

@Component({
  selector: 'app-assing-employee-shop',
  templateUrl: './assing-employee-shop.component.html',
  styleUrls: ['./assing-employee-shop.component.css']
})
export class AssingEmployeeShopComponent implements OnInit {
  form: FormGroup;
  employeeShop?: EmployeeShop;
  employees: Employee[] =[];
  shops: Shop[] = [];
  

  constructor(private formBuilder: FormBuilder,
    private _employeeService: EmployeeService,
    private _shopService: ShopService,
    private _employeeShopService: EmployeeShopService,
    public dialogRef: MatDialogRef<AssingEmployeeShopComponent>,
    @Inject(MAT_DIALOG_DATA) public data: EmployeeShop) {
    this.form = this.formBuilder.group({      
      idEmployee: ['', Validators.required],
      idShop: ['', Validators.required],
      date: ['', Validators.required],
      isSupervisor: [''],
    });
    this.employeeShop = data;
    
  }

  ngOnInit(): void {
    this.getEmployees();
    this.getShops();
    this.loadEmployeeShop();
  }

  loadEmployeeShop() {
    this.form.setValue({
      idEmployee: this.employeeShop?.idEmployee,
      idShop: this.employeeShop?.idShop,
      date: this.employeeShop?.date,
      isSupervisor: this.employeeShop?.isSupervisor,
    });
  }

  getEmployees() {
    this._employeeService.getEmployees().subscribe(data => {
      this.employees = data;
    })
  }

  getShops() {
    this._shopService.getShops().subscribe(data => {
      this.shops = data;
    })
  }

  assingEditEmployeeShop() {
    const newEmployeeShop: EmployeeShop = {
      idEmployee: this.form.value.idEmployee,
      idShop: this.form.value.idShop,
      date: this.form.value.date,
      isSupervisor: this.form.value.isSupervisor,
    }

    if (this.employeeShop?.id != null && this.employeeShop?.id != 0) {
      newEmployeeShop.id = this.employeeShop?.id;
      this.editEmployeeShop(this.employeeShop?.id,newEmployeeShop);
    } else {
      this.assingEmployeeShop(newEmployeeShop);
    }
  }

  editEmployeeShop(id: number, employeeShop: EmployeeShop) {
    this._employeeShopService.editEmployeeShop(id,employeeShop).subscribe(() => { });
  }

  assingEmployeeShop(employeeShop: EmployeeShop) {
    this._employeeShopService.assingEmployeeShop(employeeShop).subscribe(data => { });
  }

}
