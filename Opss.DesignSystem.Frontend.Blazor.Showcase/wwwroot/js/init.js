function initGOVUKFrontend() {
    if (!document.body.classList.contains('govuk-frontend-supported')) {
        window.GOVUKFrontend.initAll();
        window.MOJFrontend.initAll()
    }
}