console.log('i have a js AJAX file');

 let fetchBtn= document.getElementById('fetchBtn');
 fetchBtn.addEventListener('click',fetchButtonEventhandler);
 
 function fetchButtonEventhandler(){ 

    console.log('fetch button clicked')
     const xhr=new XMLHttpRequest();

     xhr.open('GET','https://jsonplaceholder.typicode.com/posts/1',true);

     xhr.onprogress=function(){
         console.log('It is on Progress');
     }

     xhr.onreadystatechange=function () {
        console.log('ready state is : ',xhr.readyState);
         
     }

     xhr.onload=function () {
         if (this.status===200) {
             
             console.log(this.responseText);
         }
         else{
             console.log('some error occured');
         }


     }
     xhr.send();

 }