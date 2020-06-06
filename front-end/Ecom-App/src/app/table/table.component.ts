import { Component, OnInit, ViewChild} from '@angular/core';
import {SelectOptionComponent} from '../select-option/select-option.component'
declare var $:any;

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})



export class TableComponent implements OnInit {
  @ViewChild(SelectOptionComponent)
  optionSlects:SelectOptionComponent

  flagSort:string = '';
  sortBy:string = '';
  columns = [
    "Inovice Id",
    "Customer Receiver",
    "Invoice Generate Date",
    "Qty",
    "Price",
    "Status",
    "Action"
  ];
  data = [
    {id: "101", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "102", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "103", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "104", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "105", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "106", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "107", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"}, 
    {id: "108", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "109", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"}, 
    {id: "110", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "111", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "112", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "113", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"},
    {id: "114", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"}, 
    {id: "115", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"}, 
    {id: "116", CustomerReceiver: "Tran Le Anh Vu", CreateDate: "Saturday, April 07 2019", Qty: 2, Price: "1,200$", Status: "paid"}
  ];

  amountShow:number = 0;
  amountPage:number = 1;
  pageActive:number = 0;
  indexStart = 0;

  constructor() {
    
  }

  ngOnInit(): void {
  }

  ngAfterViewInit(){
    // initialization value for amount show data
    this.optionSlects.optionSlects = [
      {val: 10, title: "10"},
      {val: 15, title: "15"},
      {val: 25, title: "25"},
      {val: 50, title: "50"},
      {val: 100, title: "100"}
    ]

    // initialization value for amount show page
    this.amountShow = this.optionSlects.optionSlects[0].val;
    this.amountPage = Math.floor(this.data.length / this.amountShow);

    if(this.data.length % this.amountShow > 0){
      this.amountPage++;
    }

    // Active Pagination Page
    $('ul.pagination li:nth-of-type(' + (this.pageActive + 1) + ')').addClass('active');
  }

  CreateArray(i: number) {
    return new Array(i);
  }

  // Change amount show
  ChangeAmountShow(event){
    this.amountShow = event.target.value;
    this.amountPage = Math.ceil(this.data.length / this.amountShow);

  }

  // Sort data by column
  Sort(by:any){
    this.sortBy = by;
    this.flagSort = this.flagSort == 'down' ? 'up' : 'down';
    this.data.sort();
    this.data.reverse();

    
  }

  GetDataShow(indexStar:number, indexEnd:number){
    return this.data.slice(indexStar, indexEnd);
  }

  PageChange(num){
    this.indexStart = num * this.amountShow;
  }

}
