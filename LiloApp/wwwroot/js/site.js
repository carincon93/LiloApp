window.addBodyBlurPopup = () => {
    document.body.classList.add('blur-popup');

    // Find all elements with class 'slide-left' and add class 'slide-left-x' and 'relative'
    const slideLeftElements = document.querySelectorAll('.slide-left');
    slideLeftElements.forEach(element => {
        element.classList.remove('slide-left');
        element.classList.add('slide-left-x');
        element.classList.add('relative');
    });

    // Find all elements with class 'slide-right' and add class 'slide-right-x' and 'relative'
    const slideRightElements = document.querySelectorAll('.slide-right');
    slideRightElements.forEach(element => {
        element.classList.remove('slide-right');
        element.classList.add('slide-right-x');
        element.classList.add('relative');
    });
};

window.removeBodyBlurPopup = () => {
    document.body.classList.remove('blur-popup');

    // Find all elements with class 'slide-right-x' and revert to 'slide-right'
    const slideRightXElements = document.querySelectorAll('.slide-right-x');
    slideRightXElements.forEach(element => {
        element.classList.remove('slide-right-x');
        element.classList.add('slide-right');
        element.classList.remove('relative');
    });

    // Find all elements with class 'slide-left-x' and revert to 'slide-left'
    const slideLeftXElements = document.querySelectorAll('.slide-left-x');
    slideLeftXElements.forEach(element => {
        element.classList.remove('slide-left-x');
        element.classList.add('slide-left');
        element.classList.remove('relative');
    });
};