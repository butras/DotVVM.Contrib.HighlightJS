ko.bindingHandlers["dotvvm-contrib-HighlightJS"] = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {        

        var value = ko.unwrap(valueAccessor());
        element.innerHTML = value;
        hljs.highlightElement(element);
        var linenumbers = element.getAttribute("linenumbers");
        if (linenumbers === 'true') {
            hljs.initLineNumbersOnLoad();
        };        
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = ko.unwrap(valueAccessor());
        
    }
};
