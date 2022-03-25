import { Injectable } from '@angular/core';
import { Student } from '../Module/student.model';


@Injectable({
  providedIn: 'root'
})
export class StudentService {

  student: Student[] = [
    {
      id:1,
      name: "Shreyas"
    },
    {
      id:2,
      name: "Sarthak"
    },
    {
      id:3,
      name: "Tushar"
    },
    {
      id:4,
      name: "Tejas"
    },
  ];
  constructor() { }
 
  onGet(){
    return this.student;
  }
  onGetStudent(id: Number){
    return this.student.find(x=> x.id === id);
  }
  onAdd(student:Student){
    this.student.push(student);
  }
  onDelete(id: Number){
    let student =this.student.find(x=>x.id === id);
    let index = this.student.indexOf(student!,0);
    this.student.splice(index,1);
  }
  onUpdate(student :Student){
    let oldstudent= this.student.find(x=>x.id === student.id);
    oldstudent!.name=student.name;

  }
}
