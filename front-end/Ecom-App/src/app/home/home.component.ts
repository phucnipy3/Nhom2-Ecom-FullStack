import { Component, OnInit } from '@angular/core';
import { HomeService } from '../home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  sample = ''
  constructor(private httpService: HomeService) { }

  ngOnInit(): void {
    this.getSampleData();
  }

  getSampleData(){
    this.httpService.getSampleData().subscribe((res:string) => {
      this.sample = res;
    })
  }
}
