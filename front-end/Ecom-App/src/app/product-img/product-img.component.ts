import { Component, OnInit, Input } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-product-img',
  templateUrl: './product-img.component.html',
  styleUrls: ['./product-img.component.css']
})
export class ProductImgComponent implements OnInit {

  @Input() lstImage = [
    'assets/img/dashboard/pd-1.jpg',
    'assets/img/dashboard/pd-2.jpg', 
    'assets/img/dashboard/pd-3.jpg',
    'assets/img/dashboard/pd-1.jpg',
    'assets/img/dashboard/pd-3.jpg'
  ];
  
  slideImage:number = 5;
  indexActive:number = 0;
  constructor() { }

  ngOnInit(): void {
  }

  SelectImg(num:number) : void{
    this.indexActive = num;
  }

  prevActiveImage(){
    if(this.indexActive > 0 ){
      this.indexActive = this.indexActive - 1;
    }else{
      this.indexActive = this.slideImage - 1;
    }
    
    // if(this.indexActive >= 4 && this.indexActive < this.slideImage){
    //   var widthSlide = $('ol.carousel-indicators li').width();
    //   var posFirstSlide = -(widthSlide + 10) * (this.indexActive - 3) + 5;
    //   $('ol.carousel-indicators li').eq(0).css('margin-left', posFirstSlide);
    // }else if (this.indexActive < 4){
    //   $('ol.carousel-indicators li').eq(0).css('margin-left', 5);
    // }
  }

  nextActiveImage(){
    if(this.indexActive < this.slideImage - 1){
      this.indexActive = this.indexActive + 1;
    }else{
      this.indexActive = 0;
    }

    // if(this.indexActive >= 4 && this.indexActive < this.slideImage){
    //   var widthSlide = $('ol.carousel-indicators li').width();
    //   var posFirstSlide = -(widthSlide + 10) * (this.indexActive - 3) + 5;
    //   $('ol.carousel-indicators li').eq(0).css('margin-left', posFirstSlide);
    // }else{
    //   $('ol.carousel-indicators li').eq(0).css('margin-left', 5);
    // }

    // $('ol.carousel-indicators li:nth-of-type(0)').css('margin-left', '100px');
  }

}
