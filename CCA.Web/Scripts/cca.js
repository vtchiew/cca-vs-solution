function initLang(lang, cul, controller, action, id)
{
    $('#langSelect').empty();
    var language = lang + "-" + cul;



    //alert(loc);
    var langs = [{ val: "en-US", text: "English" },
        { val: "zh-CN", text: "中文" }
    ];
    

    $(langs).each(function () {
        var s = $("<option>");
        if (this.val == language) {
            s.attr("selected", "selected");
        }

        s.val(this.val).text(this.text).appendTo($("#langSelect"));
    });

    $('#langSelect').change(function () {
        var loc = "/" + $('#langSelect').val() + "/" + controller + "/" + action;
        if (id != null && id != "")
            loc += "/" + id;
        location.href = loc;
    });
}

