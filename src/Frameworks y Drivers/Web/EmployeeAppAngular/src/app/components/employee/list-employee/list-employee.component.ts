import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Employee } from '../../../interfaces/employee';
import { EmployeeShop } from '../../../interfaces/employee-shop';
import { EmployeeService } from '../../../services/employee.service';
import { MatDialog } from '@angular/material/dialog';
import { DetailEmployeeComponent } from '../detail-employee/detail-employee.component';
import { CreateEditEmployeeComponent } from '../create-edit-employee/create-edit-employee.component';
import { AssingEmployeeShopComponent } from '../../employee-shop/assing-employee-shop/assing-employee-shop.component';

@Component({
  selector: 'app-list-employee',
  templateUrl: './list-employee.component.html',
  styleUrls: ['./list-employee.component.css']
})

export class ListEmployeeComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['name', 'type', 'telephone', 'address', 'employmentDate', 'actions'];
  dataSource = new MatTableDataSource<Employee>();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _employeeService: EmployeeService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getEmployees();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;    
    this.paginator._intl.itemsPerPageLabel = '';    
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  getEmployees() {
    this._employeeService.getEmployees().subscribe(data => {      
      this.dataSource.data = data;
    })
  }

  openViewDialog(id: number) {
    const dialogRef = this.dialog.open(DetailEmployeeComponent, {
          data: id,
          height: '400px',
          width: '600px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  openCreateDialog() {
    this.openEditDialog(0);
  }

  openEditDialog(id: number) {
    const dialogRef = this.dialog.open(CreateEditEmployeeComponent, {
      data: id,
      height: '600px',
      width: '800px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
      window.location.reload();
    });
  }

  deleteEmployee(id: number, name: string) {
    if (confirm("Esta seguro que desea eliminar el empleado" + name)) {
      this._employeeService.deleteEmployee(id).subscribe(() => {
        this.getEmployees();
      });
    }
  }

  openAssingDialog(idEmployee: number) {
    var employeeShop: EmployeeShop = {
      id : 0,
      idEmployee: idEmployee,
      idShop: 0,     
      date: new Date(),
      isSupervisor: false
    };
    const dialogRef = this.dialog.open(AssingEmployeeShopComponent, {
      data: employeeShop,
      height: '400px',
      width: '600px',
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

}
