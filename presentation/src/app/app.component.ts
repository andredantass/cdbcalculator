import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CDBRequest } from '../model/cdbRequest';
import { CDBService } from '../services/cdbService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  cdbform: FormGroup;
  grossValue:any;
  netValue: any;

  ngOnInit() {

  }
  constructor(private service: CDBService) {
    this.cdbform = new FormGroup({
      monetary: new FormControl(null, [Validators.required]),
      period: new FormControl(null, [Validators.required]),
      grossValue: new FormControl({ value: '', disabled: true }),
      netValue: new FormControl({ value: '', disabled: true })
    })
  }

  limpar() {
    this.cdbform.reset();
  }
  calculateCDB() {

    if (this.cdbform.valid) {
      let request = new CDBRequest();
      request.monetaryValue = this.cdbform.get('monetary') != null ? this.cdbform?.get('monetary')?.value : 0;
      request.period = this.cdbform.get('period') != null ? this.cdbform?.get('period')?.value : 0;;

      this.service.calculateCDBInvestments(request).subscribe(result => {
        console.log(result);
        this.grossValue = result.grossValue;
        this.netValue = result.netValue;

      }, error => console.error(error));
    }
    else {
      this.cdbform.markAllAsTouched();
    }
  }

}
