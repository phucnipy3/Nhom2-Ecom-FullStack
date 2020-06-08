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
  receiverPhone:string = '037 767 0509';
  emailOrderer:string = 'Anny.123@hotmail.com';
  invoiceAddress:string = '1642 Cambridge Drive, Phoenix, 85029 Arizona Arizona Phoenix';
  invoiceDate:string = 'Saturday, April 07 2019';
  dueDate:string = 'Sunday, April 19 2019';

  invoiceStatus:string = "Pending";
  invoiceStatusChange:string = "Pending";
  isSave:boolean = false;

  invoicePrice:number = 150;
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

  ChangeInvoiceStatus(){
    if(this.invoiceStatusChange == "Paid"){
      this.invoiceStatusChange = "Pending";
    }else if(this.invoiceStatusChange == "Pending"){
      this.invoiceStatusChange = "Transporting";
    }else if (this.invoiceStatusChange == "Transporting"){
      this.invoiceStatusChange = "Paid";
    }

    this.isSave =  this.invoiceStatusChange  != this.invoiceStatus;
    
  }

}
