import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RemoveSlideComponent } from './remove-slide.component';

describe('RemoveSlideComponent', () => {
  let component: RemoveSlideComponent;
  let fixture: ComponentFixture<RemoveSlideComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RemoveSlideComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RemoveSlideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
