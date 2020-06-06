import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-invoice-detail',
  templateUrl: './invoice-detail.component.html',
  styleUrls: ['./invoice-detail.component.css']
})
export class InvoiceDetailComponent implements OnInit {

  // Info about invoice detail
  invoiceId:string = '135178';
  receiver:string = 'Anny Farisha';
  emailOrderer:string = 'Anny.123@hotmail.com';
  invoiceAddress:string = '1642 Cambridge Drive, Phoenix, 85029 Arizona Arizona Phoenix';
  invoiceDate:string = 'Saturday, April 07 2019';
  dueDate:string = 'Sunday, April 19 2019';
  lstProduct = [
    {productId: 1, productTitle: 'Green Crack', Qty: 1, Price: 30},
    {productId: 1, productTitle: 'Green Crack', Qty: 1, Price: 30},
    {productId: 1, productTitle: 'Green Crack', Qty: 1, Price: 30},
    {productId: 1, productTitle: 'Green Crack', Qty: 1, Price: 30},
    {productId: 1, productTitle: 'Green Crack', Qty: 1, Price: 30}
  ]
  invoiceTotal:number = 0;

  constructor() { }

  ngOnInit(): void {
  }

  ngAfterViewInit(){
    for (let product of this.lstProduct){
      this.invoiceTotal += product.Price * product.Qty;
    }
  }

}
