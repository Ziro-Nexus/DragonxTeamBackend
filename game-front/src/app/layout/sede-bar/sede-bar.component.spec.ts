import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SedeBarComponent } from './sede-bar.component';

describe('SedeBarComponent', () => {
  let component: SedeBarComponent;
  let fixture: ComponentFixture<SedeBarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SedeBarComponent]
    });
    fixture = TestBed.createComponent(SedeBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
