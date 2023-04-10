import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Employee } from '../../../interfaces/employee';
import { EmployeeService } from '../../../services/employee.service';
import { MatDialog } from '@angular/material/dialog';
import { DetailEmployeeComponent } from '../detail-employee/detail-employee.component';
import { CreateEditEmployeeComponent } from '../create-edit-employee/create-edit-employee.component';

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

  constructor(private _employeeServices: EmployeeService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getEmployees();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    if (this.dataSource.data.length > 0) {
      this.paginator._intl.itemsPerPageLabel = 'Items por pagina';
    }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  getEmployees() {
    this._employeeServices.getEmployees().subscribe(data => {      
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
      this._employeeServices.deleteEmployee(id).subscribe(() => {
        this.getEmployees();
      });
    }
  }

}
