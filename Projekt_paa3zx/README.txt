A megvalósított projekt egy árfolyamelemző program.

A Formon megtalálható két vezérlő, amelyekkel dátumok alapján szűrhetünk különböző időszakokra és egy vezérlő amellyel a kívánt pénznemet érhetjük el.

A kért adatok megjelennek egy datagridviewban amelyben a különböző sorokban lévő értékek aszerint szineződnek piros és zöld színre, hogy azok a kijelölt időszakban az átlagos érték felett vagy éppen alatt vannak. Ezeket a megjelenített adatokat továbbá lehetősége van CSV formátumban kiexportálnia a felhasználónak.

Található egy vonaldiagram is amely a datagridviewban megjelített információkhoz egy adatvizualizációs eszköz (az x tengelyen a dátumok helyezkednek el az y tengelyen pedig az értékek).

A felületen még további két datagridview is található, ezek arra szolgálnak hogy megjelenítsék a különböző időintervallumban a kiugró értékeket, amelyeket az átlagostól vett 5 százalékos eltérés alapján határoztam meg.

a Form alsó sarkában megjelenik egy váltó, amely a záró dátum alapján vett értéket megszorozza a felhasználó által beírt számmal és ezzel a szorzattal kaphat eredményt, illetve található további hat adat (átlag, maximum, minimum, legkorábbi adat, legfrisebb adat és változás), amelyek a feltételek mellett megadott időintervallumokban megjeleníti a releváns adatokat. Itt az utolsó változást mutató textbox aszerint szineződik piros és zöld színre, hogy a változást mutató százalékos érték negatív-e vagy pozitív.