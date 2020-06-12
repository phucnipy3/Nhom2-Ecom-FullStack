import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BtnPrevComponent } from './btn-prev.component';

describe('BtnPrevComponent', () => {
  let component: BtnPrevComponent;
  let fixture: ComponentFixture<BtnPrevComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BtnPrevComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BtnPrevComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
