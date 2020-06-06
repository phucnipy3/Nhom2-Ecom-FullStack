import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit {

  pageActive:number = 0;
  @Input() public amountPage:number = 1;
  @Output() public pageChange = new EventEmitter<number>();
  constructor() { }

  ngOnInit(): void {
  }

  // Select Page
  SelectPage(numPage:number){
    this.pageActive = numPage;  
    this.pageChange.emit(this.pageActive);
    return false;
  }

  // Select Prev Page
  SelectPrevPage(){
    if(this.pageActive > 0){
      this.pageActive--;
      this.pageChange.emit(this.pageActive);
    }
    
    return false;
  }

  // Select Next Page
  SelectNextPage(){
    if(this.pageActive < this.amountPage - 1){
      this.pageActive++;
      this.pageChange.emit(this.pageActive);
    }
    return false;
  }

  CreateArray(amountPage){
    return new Array(amountPage);
  }

}
