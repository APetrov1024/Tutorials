import { Component, Input } from '@angular/core';
@Component({
    selector: 'input-props-comp',
    template: `
        <div class="input-props-component component-wraper">
            <h2>{{text}}</h2>
            <p>Имя пользователя: {{userName}}</p>
            <p>Возраст: {{age}}</p>
        </div>
    `,
    styles: [`h2, p { color: black; }`, `.input-props-component {background-color: lightgray; padding: 0.3em;}`]
})
export class InputPropsComponent {
    text = 'Это вложенный компонент, получающий значения свойтсв из родительского';

    @Input() userName: string = '';

    #age: number = 0;

    @Input() set age(value:number){
        if (value < 0) 
            this.#age = 0;
        else if (value > 100)
            this.#age = 100;
        else
            this.#age = value;
    }

    get age() { return this.#age }
}