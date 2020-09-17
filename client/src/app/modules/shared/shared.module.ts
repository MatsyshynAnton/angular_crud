import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UkrainianDateFromatPipe } from './pipes/ukrainian-date-format.pipe';



@NgModule({
  declarations: [UkrainianDateFromatPipe],
  imports: [
    CommonModule
  ],
  exports: [UkrainianDateFromatPipe]
})
export class SharedModule { }
