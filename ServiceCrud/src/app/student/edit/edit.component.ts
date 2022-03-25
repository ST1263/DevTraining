import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/services/student.service';
import { Student } from 'src/app/Module/student.model';
@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {

id!:number;
header!:string;
student: Student ={
  id:0,
  name:''
}
   Student: Student | undefined;
  constructor(private router: Router, private route: ActivatedRoute, private studnetService: StudentService) { }

  ngOnInit(): void {
    Number(this.route.snapshot.paramMap.get('id'))
    // this.id = +this.route.snapshot.paramMap.get('id');
   this.header =this.id === 0? 'Add':'Edit';
   if(this.id!=0){
     this.student !=this.studnetService.onGetStudent(this.id);
   }
  }

  

  onSubmit(form: NgForm){
    console.log(form.value);
    let student: Student ={
      id:form.value.id,
      name:form.value.name, 
    }
    
    if(this.id === 0){
      this.studnetService.onUpdate(student);
    }
  
      this.studnetService.onAdd(student);
    
  
    this.router.navigateByUrl('');
  }
}
