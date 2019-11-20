import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { EmployeeDetail } from 'src/_models/EmployeeDetail';

@Injectable()
export class EmployeeDetailService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {
  }

  GetEmployees(): Observable<EmployeeDetail[]> {
    return this.http.get<EmployeeDetail[]>(`${this.apiUrl}/EmployeeDetails`);
  }

  GetEmployeeDetail(employeeGuid:String):Observable<EmployeeDetail>{
    return this.http.get<EmployeeDetail>(`${this.apiUrl}/EmployeeDetails/${employeeGuid}`)
  }
}