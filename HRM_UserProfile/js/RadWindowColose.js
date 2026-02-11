function getRadWindow() {
           var oWindow = null;
           if (window.radWindow)
               oWindow = window.radWindow;
           else if (window.frameElement.radWindow)
               oWindow = window.frameElement.radWindow;
           return oWindow;
       }

// Reload parent page
function refreshParentPage() {
    getRadWindow().BrowserWindow.location.href = "overview.aspx";    
    getRadWindow().Close();
}

// Reload parent page
function CloseThisPage() {
    getRadWindow().Close();
}

