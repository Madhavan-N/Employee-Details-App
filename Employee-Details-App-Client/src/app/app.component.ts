import { Component } from '@angular/core';
import { EmployeeDetail } from "../_models/EmployeeDetail";
import { EmployeeDetailService } from '../_services/EmployeeDetailsService';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Employee Details App';
  selectedEmployee: EmployeeDetail;
  employees: EmployeeDetail[] = [];

  constructor(private employeeService: EmployeeDetailService) {
    employeeService.GetEmployees().subscribe(emp => {
      console.log(emp);
      this.employees = [...emp];
    });
  }
  onSelect(employeeGuid: string): void {
    this.employeeService.GetEmployeeDetail(employeeGuid).subscribe(emp => {
      this.selectedEmployee = emp;
    });
  }
  clearEmployeeDetails() {
    this.selectedEmployee = null;
  }
}
