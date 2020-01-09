$(document).ready(function () {
    "use strict";
    $(".responsive-menu").click(function (e) {
        $(".main-nav>ul").css({display: "block"});
        e.stopPropagation();
        if (e.preventDefault)
            e.preventDefault();
        return false;
    });
    $("body").click(function () {
        $(".main-nav>ul").css({display: "none"});
    });
    (jQuery().swipebox) ? $(".swipebox").swipebox() : null;
    new WOW().init();


    var video = $('noscript').text();

    if(video.trim().search('iframe') === 1) {
      $('noscript').parent().append(video);      
    }
    if ($("iframe[src^='//player.vimeo.com'], iframe[src^='//www.youtube.com']").length) {
        $("body").fitVids({ customSelector: "iframe[src^='//player.vimeo.com'], iframe[src^='//www.youtube.com']"});
    };
});





