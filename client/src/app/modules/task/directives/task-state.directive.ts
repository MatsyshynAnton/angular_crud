import { Directive, Input, ElementRef, Renderer2, RendererFactory2, OnInit } from '@angular/core';
import { Task } from 'src/app/models/Task';

@Directive({
  selector: '[appTaskState]'
})
export class TaskStateDirective implements OnInit{

  @Input() stateId: number;

  constructor(private el: ElementRef) { }

  ngOnInit(): void {
    switch(this.stateId){
      case 3 : {
        this.el.nativeElement.style.background = "green";
        break
      }
      case 4 : {
        this.el.nativeElement.style.background = "red";
        break;
      }
      case undefined : {
        this.el.nativeElement.style.background = "yellow";
      }
    }
  }

}
