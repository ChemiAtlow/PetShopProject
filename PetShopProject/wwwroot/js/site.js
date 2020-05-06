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