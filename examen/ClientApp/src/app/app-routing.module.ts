import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormGetComponent } from './reactive-forms/formGet/form-get/form-get.component';

const routes: Routes = [
  {
    path: 'formGet',
    component: FormGetComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
