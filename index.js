const {app, BrowserWindow} = require('electron');
const url = require('url');

function boot(){
    win = new BrowserWindow()
    win.loadURL('file://' + __dirname + '/index.html');
}

app.on('ready', boot);