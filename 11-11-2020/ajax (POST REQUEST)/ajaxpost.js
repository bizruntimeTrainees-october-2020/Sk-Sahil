console.log('i have a js AJAX file');

 let fetchBtn= document.getElementById('fetchBtn');
 fetchBtn.addEventListener('click',fetchButtonEventhandler);
 
 function fetchButtonEventhandler(){ 

    console.log('fetch button clicked')
     const xhr=new XMLHttpRequest();

     xhr.open('POST','https://postman-echo.com/post',true);
     xhr.setRequestHeader('content-type','application/x-www-form-urlencoded')

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
     params='POST /hi/there?hand=wave';
     xhr.send(params);

 }