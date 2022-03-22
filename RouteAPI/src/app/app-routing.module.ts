import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './add/add.component';
import { DetailComponent } from './detail/detail.component';
import { EditComponent } from './edit/edit.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {
    path:'',
    component:HomeComponent,
  },
  {
    path:'home',
    component:HomeComponent,
  },
  {
    path:'edit/:id',
    component:EditComponent,
  },
  {
    path:'detail',
    
    component:DetailComponent,
  },
  {
    path:'add',
    component:AddComponent
  },
  {
    path: 'home', loadChildren:() => import('./home/home.module').then(m => m.HomeModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
