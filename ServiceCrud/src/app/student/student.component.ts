import { Component, OnInit } from '@angular/core';
import { Student } from '../Module/student.model';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.scss']
})
export class StudentComponent implements OnInit {
  students: Student[] = [];
  constructor(private studentservice:StudentService) { }

  ngOnInit(): void {
    this.students=this.studentservice.onGet();
  }
  onDelete(id:Number){
    this.studentservice.onDelete(id);
  }
  

}
