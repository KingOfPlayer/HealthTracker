$(document).ready(function () {
    $(document.body).on("click", function (e) {
        let target = $(e.target.closest(".UI"));
        if (target.hasClass("UI")) {
            if (target.hasClass("Toggler")) {
                let toTarget;
                if (target.get()[0].tagName == "a" || target.get()[0].tagName == "A") {
                    toTarget = target.attr('href');
                } else {
                    toTarget = target.attr("UI-element");
                }
                $(toTarget).toggleClass("show");
                console.log(target.get());
                console.log(toTarget);
                return false;
            }
        } else {
            console.log(target);
            return false;
        }
    });
});