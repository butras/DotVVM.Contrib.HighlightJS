ko.bindingHandlers["dotvvm-contrib-HighlightJS"] = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {        
            
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = ko.unwrap(valueAccessor());
        if (value !== undefined) {
            element.innerHTML = value;
        }        
        element.removeAttribute('data-highlighted');
        hljs.highlightElement(element);
        var linenumbers = element.getAttribute("linenumbers");
        if (linenumbers === 'true') {
            hljs.initLineNumbersOnLoad();
        };       
    }
};
