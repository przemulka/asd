<? if(!isset($_GET['url'])) {

 include"includes/to co pojawi się na stronie głównej.php"; }

 else if ($_GET['url']=='1') {

 include"includes/następna podstrona.php"; }

 else if($_GET['url']=='2') {

 include"includes/kolejna podstrona.php"; }

 else if($_GET['url']=='3') {

 include"includes/jeszcze jedna podstrona.php"; }

  else if($_GET['url']=='4') {

 include"includes/ipowtarzamy tak długo ile chcemy mieć podstron.php"; }

 else {

 echo("<b>404</b><br />wpisujemy komunikat błędu który wyświetli się kiedy podstrona nie zostanie znaleziona"); } ?>
