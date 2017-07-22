$(document).ready(function () {

    var page = +$('.blog-post').attr("page");
    var pagination = $('.pagination');

    function aFunc(spanApp, ref, aAtrr) {
        
        var liNav = document.createElement("li");
        var aNav = document.createElement("a");
        var spanNav = document.createElement("span");
        spanNav.setAttribute("aria-hidden", "true");
        spanNav.append(spanApp);
        aNav.setAttribute("href", ref);
        aNav.setAttribute("aria-label", aAtrr);

        aNav.append(spanNav);
        liNav.append(aNav);
        pagination.append(liNav);

    }


    aFunc("	\xAB", "/home/index?id=" + (page - 1), "Previous");
    
    
    
    for (var i = 1; i <= pagination.attr("pagecount") ; i++) {

        var li = document.createElement("li");
        var a = document.createElement("a");
        a.setAttribute("href", "/home/index?id=" + i);
        a.append(i);
        if (i == page) {
            li.classList.add("active");
        }
        li.append(a);
        pagination.append(li);

    }


    
    aFunc("\xBB", "/home/index?id=" + (page+1), "Next");
   


});




    


