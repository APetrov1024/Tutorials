import { Component } from '@angular/core';
@Component({
    selector: 'child-comp',
    template: `
        <div class="child-component component-wraper">
            <h2>{{text}}</h2>
            <ng-content></ng-content>
        </div>
    `,
    styles: [`h2, p { color: black; }`, `.child-component {background-color: salmon; padding: 0.3em;}`]
})
export class ChildComponent {
    text = 'Это вложенный компонент';
}