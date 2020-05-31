import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  apiUrl = "https://localhost:44349/api/Home"
  constructor(private http: HttpClient) { }

  getSampleData(): Observable<string>{
    return this.http.get(this.apiUrl + "/GetSampleData", {responseType: 'text'}).pipe(map((res: string)=> {return res}));
  }
}
