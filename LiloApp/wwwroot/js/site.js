window.addBodyNoScroll = () => {
    document.body.classList.add('blur-popup');

    // Find all elements with class 'slide-left' and add class 'slide-left-x' and 'relative'
    const slideLeftElements = document.querySelectorAll('.slide-left');
    slideLeftElements.forEach(element => {
        element.classList.remove('slide-left');
        element.classList.add('slide-left-x');
        element.classList.add('relative');
    });
};

window.removeBodyNoScroll = () => {
    document.body.classList.remove('blur-popup');

    // Find all elements with class 'slide-left-x' and revert to 'slide-left'
    const slideLeftXElements = document.querySelectorAll('.slide-left-x');
    slideLeftXElements.forEach(element => {
        element.classList.remove('slide-left-x');
        element.classList.add('slide-left');
        element.classList.remove('relative');
    });
};