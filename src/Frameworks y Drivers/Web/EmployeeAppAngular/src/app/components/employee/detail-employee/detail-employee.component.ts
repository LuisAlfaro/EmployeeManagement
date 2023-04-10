import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../../../interfaces/employee';
import { EmployeeService } from '../../../services/employee.service';

@Component({
  selector: 'app-detail-employee',
  templateUrl: './detail-employee.component.html',
  styleUrls: ['./detail-employee.component.css']
})
export class DetailEmployeeComponent {
  //id!: number;
  employee!: Employee;


  constructor(private _employeeService: EmployeeService,
    public dialogRef: MatDialogRef<DetailEmployeeComponent>,
    @Inject(MAT_DIALOG_DATA) public id: number) { }

  //constructor(private _employeeService: EmployeeService,
  //  private aRoute: ActivatedRoute) {
  //  this.id = Number(this.aRoute.snapshot.paramMap.get('id'));
  //}

  ngOnInit(): void {
    this.getEmployee();
  }

  ngOnDestroy(): void {
  }

  getEmployee() {
    this._employeeService.getEmployee(this.id).subscribe(data => {
      this.employee = data;
    })
  }

}
