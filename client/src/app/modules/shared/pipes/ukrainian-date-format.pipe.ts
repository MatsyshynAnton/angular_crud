import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'ukrainianDateFromat'
})
export class UkrainianDateFromatPipe implements PipeTransform {

  transform(value: Date | string): string {
    
    value = new Date(value);
    let result = value.getDate().toString() + ' ';

    switch(value.getMonth()) {
      case 1 : {
        result+= 'січня';
        break;
      }
      case 2 : {
        result+= 'лютого';
        break;
      }
      case 3 : {
        result+= 'березня';
        break;
      }
      case 4 : {
        result+= 'квітня';
        break;
      }
      case 5 : {
        result+= 'травня';
        break;
      }
      case 6 : {
        result+= 'червня';
        break;
      }
      case 7 : {
        result+= 'липня';
        break;
      }
      case 8 : {
        result+= 'серпня';
        break;
      }
      case 9 : {
        result+= 'вересня';
        break;
      }
      case 10 : {
        result+= 'жовтня';
        break;
      }
      case 11 : {
        result+= 'листопада';
        break;
      }
      case 12 : {
        result+= 'грудня';
        break;
      }
    }

    result +=  ', ' + value.getFullYear().toString();
    return result;
  }

}
