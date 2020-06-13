import { Component, OnInit, Input } from '@angular/core';

declare var $:any;

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  @Input() productId = "ACT21105 - QD21088";
  @Input() productTitle = "Set Tập Yoga Nữ Ngắn Tay AT3";
  @Input() productDesc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
  @Input() productPrice = "550.50";
  @Input() productSize = "S, M, X, Xl";
  @Input() productColor = "White, Black";
  
  constructor() { }

  ngOnInit(): void {
  }

}
