﻿var ids = [], reminders = "", tab = "", CURRENT_URL = window.location.href.split("#")[0].split("?")[0], $BODY = $("body"), $MENU_TOGGLE = $("#menu_toggle"), $SIDEBAR_MENU = $("#sidebar-menu"), $SIDEBAR_FOOTER = $(".sidebar-footer"), $LEFT_COL = $(".left_col"), $RIGHT_COL = $(".right_col"), $NAV_MENU = $(".nav_menu"), $FOOTER = $("footer"); $(document).ready(function () { $(".Mayusculas").keyup(function () { this.value = this.value.toUpperCase() }); var e = function () { $RIGHT_COL.css("min-height", $(window).height()); var e = $BODY.outerHeight(), i = $BODY.hasClass("footer_fixed") ? -10 : $FOOTER.height(), t = $LEFT_COL.eq(1).height() + $SIDEBAR_FOOTER.height(), a = e < t ? t : e; a -= $NAV_MENU.height() + i, $RIGHT_COL.css("min-height", a) }; $SIDEBAR_MENU.find("a").on("click", function (i) { var t = $(this).parent(); t.is(".active") ? (t.removeClass("active active-sm"), $("ul:first", t).slideUp(function () { e() })) : (t.parent().is(".child_menu") || ($SIDEBAR_MENU.find("li").removeClass("active active-sm"), $SIDEBAR_MENU.find("li ul").slideUp()), t.addClass("active"), $("ul:first", t).slideDown(function () { e() })) }), $MENU_TOGGLE.on("click", function () { $BODY.hasClass("nav-md") ? ($SIDEBAR_MENU.find("li.active ul").hide(), $SIDEBAR_MENU.find("li.active").addClass("active-sm").removeClass("active")) : ($SIDEBAR_MENU.find("li.active-sm ul").show(), $SIDEBAR_MENU.find("li.active-sm").addClass("active").removeClass("active-sm")), $BODY.toggleClass("nav-md nav-sm"), e(), $(".dataTable").each(function () { $(this).dataTable().fnDraw() }) }), $SIDEBAR_MENU.find('a[href="' + CURRENT_URL + '"]').parent("li").addClass("current-page"), $SIDEBAR_MENU.find("a").filter(function () { return this.href == CURRENT_URL }).parent("li").addClass("current-page").parents("ul").slideDown(function () { e() }).parent().addClass("active"), e(), $.fn.mCustomScrollbar && $(".menu_fixed").mCustomScrollbar({ autoHideScrollbar: !0, theme: "minimal", mouseWheel: { preventDefault: !0 } }) }), $(document).ready(function () { $(".collapse-link").on("click", function () { var e = $(this).closest(".x_panel"), i = $(this).find("i"), t = e.find(".x_content"); e.attr("style") ? t.slideToggle(200, function () { e.removeAttr("style") }) : (t.slideToggle(200), e.css("height", "auto")), i.toggleClass("fa-chevron-up fa-chevron-down") }), $(".close-link").click(function () { $(this).closest(".x_panel").remove() }) }), $(document).ready(function () { $(".js-switch")[0] && Array.prototype.slice.call(document.querySelectorAll(".js-switch")).forEach(function (e) { new Switchery(e, { color: "#26B99A" }) }) }), $(document).ready(function () { $("input.flat")[0] && $(document).ready(function () { $("input.flat").iCheck({ checkboxClass: "icheckbox_flat-green", radioClass: "iradio_flat-green" }) }) });