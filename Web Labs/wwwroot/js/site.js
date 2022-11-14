let content = document.querySelector('.second .content');
content.innerHTML = "";

let form = document.createElement('form');
form.setAttribute('method',"post");
form.setAttribute('asp-action','Index');
form.style = 'display: flex; flex-direction:column';

let inputPos = document.createElement('input');
inputPos.setAttribute("name", 'position');
inputPos.setAttribute("type", "number");

let inputContent = document.createElement('textarea');
inputContent.style.margin = '5px 0';
inputContent.setAttribute('name',"content");

let button = document.createElement('button');
button.setAttribute('type',"submit");
button.textContent = 'Add';


content.insertAdjacentElement('afterbegin', form);

form.insertAdjacentElement('beforeend', inputPos);
form.insertAdjacentElement('beforeend', inputContent);
form.insertAdjacentElement('beforeend', button);

