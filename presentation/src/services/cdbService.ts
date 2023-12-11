import { HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, Observable, of, throwError } from "rxjs";
import { CDBRequest } from "../model/cdbRequest";
import { ApiClient } from "./apiClient";

@Injectable({
  providedIn: 'root'
})
export class CDBService
{
  errorMsg: any;
  constructor(private apiClient: ApiClient) {

  }
  calculateCDBInvestments(request: CDBRequest): Observable<any> {
    return this.apiClient.post('/cdb',request)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          if (error.status === 404) {
            return of(undefined);
          } else {
            return throwError(`Failed to calculate cdb investment`);
          }
        })
      );
  }
}
