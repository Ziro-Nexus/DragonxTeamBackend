import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SigUpComponent } from './sig-up/sig-up.component';

const routes: Routes = [
  {
    path: '',
    component: SigUpComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
