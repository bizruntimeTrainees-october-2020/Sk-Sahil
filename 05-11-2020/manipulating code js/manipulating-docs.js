const link = document.querySelector('a');
link.textContent = 'Mozilla Developer Network';

let text = document.getElementById('divA').textContent;
document.getElementById('divA').textContent = 'This text is different!';


const sect = document.querySelector('section');
const para = document.createElement('p');
para.textContent = 'We hope you enjoyed the ride.';
sect.appendChild(para);

para.setAttribute('class', 'highlight');