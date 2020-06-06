import { Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-select-option',
  templateUrl: './select-option.component.html',
  styleUrls: ['./select-option.component.css']
})
export class SelectOptionComponent implements OnInit {
  optionSlects =  [
    {val: 1, title: "1"},
    {val: 15, title: "15"},
    {val: 25, title: "25"},
    {val: 50, title: "50"},
    {val: 100, title: "100"}
  ];

  optionSlected:string = '0';

  constructor() { }

  ngOnInit(): void {
  }

}
