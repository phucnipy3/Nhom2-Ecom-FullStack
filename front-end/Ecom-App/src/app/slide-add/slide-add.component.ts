import { Component, OnInit } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-slide-add',
  templateUrl: './slide-add.component.html',
  styleUrls: ['./slide-add.component.css']
})
export class SlideAddComponent implements OnInit {

  slideImage:number = 4;
  imageActive:number = 0;
  constructor() { }

  ngOnInit(): void {
  }

  counter(i: number) {
    return new Array(i);
  }

  prevActiveImage(){
    if(this.imageActive > 0 ){
      this.imageActive = this.imageActive - 1;
    }else{
      this.imageActive = this.slideImage - 1;
    }
    
    if(this.imageActive >= 4 && this.imageActive < this.slideImage){
      var widthSlide = $('.slide-item').parent().width();
      var posFirstSlide = -(widthSlide + 10) * (this.imageActive - 3) + 5;
      $('.slide-item').eq(0).parent().css('margin-left', posFirstSlide);
    }else if (this.imageActive < 4){
      $('.slide-item').eq(0).parent().css('margin-left', 5);
    }
  }

  nextActiveImage(){
    if(this.imageActive < this.slideImage - 1){
      this.imageActive = this.imageActive + 1;
    }else{
      this.imageActive = 0;
    }

    if(this.imageActive >= 4 && this.imageActive < this.slideImage){
      var widthSlide = $('.slide-item').parent().width();
      var posFirstSlide = -(widthSlide + 10) * (this.imageActive - 3) + 5;
      $('.slide-item').eq(0).parent().css('margin-left', posFirstSlide);
    }else{
      $('.slide-item').eq(0).parent().css('margin-left', 5);
    }
  }

  addSlide(){
    this.slideImage++;
    this.imageActive = this.slideImage - 1;

    if(this.imageActive >= 4 && this.imageActive < this.slideImage){
      var widthSlide = $('.slide-item').parent().width();
      var posFirstSlide = -(widthSlide + 10) * (this.imageActive - 3) + 5;
      $('.slide-item').eq(0).parent().css('margin-left', posFirstSlide);
    }else{
      $('.slide-item').eq(0).parent().css('margin-left', 5);
    }
  }

  removeSlide(){
    if(this.slideImage > 4){
      this.slideImage--;
      this.imageActive--;
    }

    if(this.imageActive >= 4 && this.imageActive < this.slideImage){
      var widthSlide = $('.slide-item').parent().width();
      var posFirstSlide = -(widthSlide + 10) * (this.imageActive - 3) + 5;
      $('.slide-item').eq(0).parent().css('margin-left', posFirstSlide);
    }else if (this.imageActive < 4){
      $('.slide-item').eq(0).parent().css('margin-left', 5);
    }
  }
}
