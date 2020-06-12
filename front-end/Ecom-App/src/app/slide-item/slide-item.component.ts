import { Component, OnInit } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-slide-item',
  templateUrl: './slide-item.component.html',
  styleUrls: ['./slide-item.component.css']
})
export class SlideItemComponent implements OnInit {

  itemImageUrl:string = '../../assets/img/upload.png';
  constructor() { }

  ngOnInit(): void {
  }


}
