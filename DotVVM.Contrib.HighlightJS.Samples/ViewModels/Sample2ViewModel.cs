namespace DotVVM.Contrib.HighlightJS.Samples.ViewModels;

public class Sample2ViewModel : MasterViewModel
{
    public string Code { get; set; } = "function vlanCanvas(element: HTMLElement, props: { [key: string]: any }): DotvvmJsComponent {\r\n\r\n    let canvas = document.createElement(\"canvas\")\r\n    elm.appendChild(canvas)\r\n    update(props)\r\n    \r\n    function update(updatedProps) {\r\n        const { color } = props\r\n        const ctx = canvas.getContext('2d');\r\n        \r\n        context.clearRect(0, 0, canvas.width, canvas.height)\r\n        const computedColor = getComputedStyle(canvas).getPropertyValue(\"--color-vlan-\" + color)\r\n        ctx.fillStyle = computedColor || 'white'\r\n        ctx.fillRect(6, 7, 38, 25)\r\n        ctx.fillRect(11, 32, 28, 6)\r\n        ctx.fillRect(17, 37, 16, 6)\r\n    }\r\n \r\n\r\n    return {\r\n        updateProps(updatedProps) {\r\n            props = { ...props, ...updatedProps }\r\n            update(updatedProps)\r\n        }\r\n    }\r\n}\r\n\r\nexport default context => ({\r\n    $controls: { create: vlanCanvas }\r\n})";
}

