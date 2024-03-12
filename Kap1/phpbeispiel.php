<?php
$wert="Wer reitet so spät durch Nacht und Wind?";
$reg="/[abc]/";
  if(preg_match($reg, $wert,$ergebnis)){
    echo "Treffer";
  }else{
    echo "Kein Treffer";
  }
  echo "<br />";
  print_r($ergebnis);
?>
