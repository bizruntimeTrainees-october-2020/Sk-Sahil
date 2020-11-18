console.log($);
console.log('start jquery');

$(document).ready(function () {

    //mouse event 

    // $('p').click(function () {
    //     console.log('you clicked on p', this);
    //     $(this).hide()
    // });

// $('p').dblclick(function(){
//     console.log('you double clicked',this);
// });

// $('p').hover(function(){
//     console.log('you hovered ',this);
// });

$('p').on(
    {
        click: function () {
            console.log('Thanks for clicking', this);
        },
        mouseleave: function () {
            console.log("mouseleave");

        }
    });



    $('#but').click(function () {
        $('#wiki').toggle(1000,function(){
            console.log('done');
        });
    })

    // $('#but').click(function () {
    //     $('#wiki').fadeOut(1000);
    // })

    // $('#but').click(function () {
    //     $('#wiki').fadeIn(1000);
    // })

    
    
    
    // $('#but').click(function () {
    //     $('#wiki').slideUp(1000);
    // })
    
    // $('#but').click(function () {
    //     $('#wiki').slideDown(1000);
    // })
    


//fade in ,fadeout,slideup,slidedown



 //Animate function in jQuery
   
//  $('#wiki').animate({
//         opacity:0.3,
//         height: '150px',
//         width:'350px'

//     }, 2000)

 
//will do one by one

// $('#wiki').animate({ opacity: 0.3 }, 4000);
    // $('#wiki').animate({ opacity: 0.9 }, 1000);
    // $('#wiki').animate({ width: '350px' }, 12000);

   // $('#ta').val('setting it to sahil');
   // $('#wiki').text('you are good');
   // $('p').html('para changed');

 //  $('#wiki').css('color',"red")

//  $('#wiki').addClass("myclass");
//  $('#wiki').removeClass("myclass");

//get req. by jquery

$.get('https://code.jquery.com/jquery-3.5.1.js',function(data,status){
alert(data);
//alert(status);

});

// $.post('https://code.jquery.com/jquery-3.3.1.js',
    //     { name: 'sahil', posi: 'dev' },
    //     function (data, status) {alert(status) });


});

// $('p').click();

// $('#second').click();

// $('.odd').click();







