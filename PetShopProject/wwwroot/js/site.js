/*Navigation*/
const backdrop = $(".backdrop");
const sideDrawer = $(".main-header__nav");
const menuToggle = $("#side-menu-toggle");

backdrop.on("click", function () {
    $(this).hide();
    sideDrawer.removeClass("open");
});

menuToggle.on("click", function () {
    backdrop.show("fast");
    sideDrawer.addClass("open");
});

$(window).resize(function () {
    if ($(window).width() > 768) {
        backdrop.hide();
        sideDrawer.removeClass("open");
    }
})