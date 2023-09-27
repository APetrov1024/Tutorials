import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { AppComponent } from "./app.component";
import { ChildComponent } from "./child.component";
import { InputPropsComponent } from "./input-props.component";
@NgModule({
    imports: [ BrowserModule, FormsModule ],
    declarations: [ AppComponent, ChildComponent, InputPropsComponent ],
    bootstrap: [ AppComponent ]
})
export class AppModule {}