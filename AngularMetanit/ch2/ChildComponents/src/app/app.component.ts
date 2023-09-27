import {Component} from '@angular/core';

@Component({
    selector: 'my-app',
    template: `
        <div class="parent-component component-wraper">
            <child-comp><p>Это текст из родительского компонента, переданный через ng-content. Он использует стиль родительского компонента</p></child-comp>
            <p>{{text}}</p>
            <hr>
            <label>Имя пользователя <input type="text" [(ngModel)]="userName" /></label>
            <br>
            <label>Возраст <input type="number" [(ngModel)]="age" /></label>
            <hr>
            <input-props-comp [userName]="userName" [age]="age"></input-props-comp>
        </div>
    `,
    styles: [ `.parent-component, h2 { background-color: darkgreen; padding: 1em; color: yellow; }`, `.component-wraper { border: 1px solid black; border-radius: 4px;}` ]
})
export class AppComponent {
    text = 'Это родительский компонент';
    userName: string = "";
    age:number = 18;
}