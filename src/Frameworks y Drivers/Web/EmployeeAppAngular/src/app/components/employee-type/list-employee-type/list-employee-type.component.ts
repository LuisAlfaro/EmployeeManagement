import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { EmployeeType } from '../../../interfaces/employee-type';

const listEmployeeTypes: EmployeeType[] = [
  { name: 'Vendedor', salary: 235000.00 },
  { name: 'Vendedor 2', salary: 245000.00 },
  { name: 'Vendedor 3', salary: 255000.00 },
  { name: 'Administrador', salary: 300000.00 },
  { name: 'Bodeguero', salary: 235000.00 }
];

@Component({
  selector: 'app-list-employee-type',
  templateUrl: './list-employee-type.component.html',
  styleUrls: ['./list-employee-type.component.css']
})
export class ListEmployeeTypeComponent {
  displayedColumns: string[] = ['name', 'salary', 'actions'];
  dataSource = new MatTableDataSource<EmployeeType>(listEmployeeTypes);

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    this.paginator._intl.itemsPerPageLabel = 'Items por pagina';
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
}
