function oknoPrompt() {
    var name = prompt('Name');
    var message = prompt('Message');
    if (name != null) {
        alert('Witaj ' + name);
    } else {
        alert('Anulowałeś akcję');
    }
}

document.getElementById('message').addEventListener('click', function() {
    oknoPrompt()
});
