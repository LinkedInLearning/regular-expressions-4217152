import re
wert = "Wer reitet so spät durch Nacht und Wind?"
reg = "[a-c]" 
treffer = re.search(reg, wert)
if treffer:
    print("Treffer")
else:
    print("Kein Treffer")
