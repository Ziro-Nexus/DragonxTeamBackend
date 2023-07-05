import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthComponent } from './pages/auth/auth/auth.component';
import { CommonComponent } from './pages/common/common/common.component';
import { AccessDeniedComponent } from './pages/common/access-denied/access-denied.component';
import { CoreComponent } from './pages/core/core.component';
import { BlankComponent } from './layout/blank/blank.component';
import { BreadcrumbComponent } from './layout/breadcrumb/breadcrumb.component';
import { FooterComponent } from './layout/footer/footer.component';
import { MainComponent } from './layout/main/main.component';
import { SedeBarComponent } from './layout/sede-bar/sede-bar.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthComponent,
    CommonComponent,
    AccessDeniedComponent,
    CoreComponent,
    BlankComponent,
    BreadcrumbComponent,
    FooterComponent,
    MainComponent,
    SedeBarComponent,
    TopBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
