window.anchorLink = {
    scrollIntoView: (targetId) => {
        var targetElement = document.getElementById(targetId);
        if (targetElement) {
            targetElement.scrollIntoView();
            window.location.hash = targetId;
        }
    }
}