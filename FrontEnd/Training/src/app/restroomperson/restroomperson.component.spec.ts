/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { RestroompersonComponent } from './restroomperson.component';

describe('RestroompersonComponent', () => {
  let component: RestroompersonComponent;
  let fixture: ComponentFixture<RestroompersonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestroompersonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestroompersonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
