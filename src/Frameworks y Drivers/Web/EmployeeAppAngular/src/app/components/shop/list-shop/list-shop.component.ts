import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Shop } from '../../../interfaces/shop';

const listShop: Shop[] = [
  { name: 'Local 15', telephone: '29405483', address: 'Mall San Pedro', },
  { name: 'Local 35', telephone: '29903654', address: 'Plaza Rofas', },
  { name: 'Local 22', telephone: '25542339', address: 'Multiplaza Escazu', },
  { name: 'Local 66', telephone: '24627855', address: 'Paseo de las Flores', },
  { name: 'Local 99', telephone: '23904232', address: 'Lincoln Plaza', },
];


@Component({
  selector: 'app-list-shop',
  templateUrl: './list-shop.component.html',
  styleUrls: ['./list-shop.component.css']
})
export class ListShopComponent {
  displayedColumns: string[] = ['name', 'telephone', 'address', 'actions'];
  dataSource = new MatTableDataSource<Shop>(listShop);

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
