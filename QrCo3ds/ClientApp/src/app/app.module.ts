import { registerLocaleData } from "@angular/common"
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http"
import en from "@angular/common/locales/en"
import { NgModule } from "@angular/core"
import { FormsModule } from "@angular/forms"
import { BrowserModule } from "@angular/platform-browser"
import { RouterModule } from "@angular/router"
import { NgZorroAntdModule, NZ_I18N, en_US } from "ng-zorro-antd"

import { AppComponent } from "./app.component"
import { NavMenuComponent } from "./nav-menu/nav-menu.component"
import { HomeComponent } from "./home/home.component"
import { CounterComponent } from "./counter/counter.component"
import { FetchDataComponent } from "./fetch-data/fetch-data.component"

registerLocaleData(en)

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    FormsModule,
    HttpClientModule,
    NgZorroAntdModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "counter", component: CounterComponent },
      { path: "fetch-data", component: FetchDataComponent },
    ]),
  ],
  providers: [
    { provide: NZ_I18N, useValue: en_US },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }