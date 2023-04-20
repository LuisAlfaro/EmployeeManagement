import { Component, Inject, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Employee } from '../../../interfaces/employee';
import { EmployeeType } from '../../../interfaces/employee-type';
import { EmployeeTypeService } from '../../../services/employee-type.service';
import { EmployeeService } from '../../../services/employee.service';

@Component({
  selector: 'app-create-edit-employee',
  templateUrl: './create-edit-employee.component.html',
  styleUrls: ['./create-edit-employee.component.css']
})
export class CreateEditEmployeeComponent implements OnInit{
  form: FormGroup;
  id: number;
  employeeTypes: EmployeeType[] = [];

  operacion: string = 'Agregar';
 
  constructor(private formBuilder: FormBuilder,
    private _employeeService: EmployeeService,
    private _employeeTypeService: EmployeeTypeService,
    public dialogRef: MatDialogRef<CreateEditEmployeeComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number) {
    this.form = this.formBuilder.group({
      name: ['', Validators.required],
      type: ['', Validators.required],
      telephone: ['', Validators.required],
      address: ['', Validators.maxLength(500)],
      employmentDate: ['', Validators.required],
    });

    this.id = data;
  }

  ngOnInit(): void {
    this.getEmployeeTypes();
      if (this.id != 0) {
        this.operacion = 'Editar';
        this.getEmployee(this.id);
      }
  }

  getEmployee(id: number) {  
    this._employeeService.getEmployee(id).subscribe(data => {
      this.form.setValue({
        name: data.name,
        type: data.type,
        telephone: data.telephone,
        address: data.address,
        employmentDate: data.employmentDate,
      });
    });
  }
     
  createEditEmployee() {
     const employee: Employee = {
      name: this.form.value.name,
      type: this.form.value.type,
      telephone: this.form.value.telephone,
      address: this.form.value.address,
      employmentDate: this.form.value.employmentDate,
    }

    if (this.id != 0) {
      employee.id = this.id;
      this.editEmployee(this.id, employee);
    } else {
      this.createEmployee(employee);
    }
  }

  editEmployee(id: number, employee: Employee) {
    this._employeeService.updateEmployee(id, employee).subscribe(() => { });
  }

  createEmployee(employee: Employee) {
    this._employeeService.createEmployee(employee).subscribe(data => { });
  }

  getEmployeeTypes() {
    this._employeeTypeService.getEmployeeTypes().subscribe(data => {
      this.employeeTypes = data
    });
  }

}
