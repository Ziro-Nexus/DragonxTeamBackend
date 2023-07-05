import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { routerConsts } from './shared/const/routes/route_consts';
import { MainComponent } from './layout/main/main.component';
import { BreadcrumbConst } from './shared/const/routes/breadcrumb_consts';
import { CoreModule } from './pages/core/core.module';
import { BlankComponent } from './layout/blank/blank.component';
import { commonRouteConsts } from './shared/const/routes/common_router-consts';

const routes: Routes = [
  {
    path: routerConsts.pathEmpty,
    component: MainComponent,
    data: {
      breadcrumb: BreadcrumbConst.empty,
    },
    children: [
      {
        path: routerConsts.pathCore,
        redirectTo: routerConsts.pathCore,
        pathMatch: 'full',
      },
      {
        path: routerConsts.pathCore,
        title: routerConsts.title,
        data:{
          breadcrumb: BreadcrumbConst.empty
        },
        loadChildren: () => import('./pages/core/core.module').then((m) => m.CoreModule),
      }
    ]
  },
  {
    path: routerConsts.pathAuth,
    title: routerConsts.title,
    component:BlankComponent,
    data: {
      breadcrumb: BreadcrumbConst.empty
    },
    loadChildren: () => import('./pages/auth/auth.module').then((m) => m.AuthModule),
  },
  {
    path: routerConsts.pahtCommon,
    title: routerConsts.title,
    component:BlankComponent,
    data: {
      breadcrum: BreadcrumbConst.empty,
    },
    loadChildren: () => import('./pages/common/common.module').then((m) => m.CommonModule),
  },
  {
    path: routerConsts.fullMatch,
    redirectTo: routerConsts.pahtCommon + '/' + commonRouteConsts.notFound,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
