import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SlideAddComponent } from './slide-add.component';

describe('SlideAddComponent', () => {
  let component: SlideAddComponent;
  let fixture: ComponentFixture<SlideAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SlideAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SlideAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
