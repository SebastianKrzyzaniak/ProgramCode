function ShowChannelsCombo() {
    var str = '<form action="https://secure.tpay.com" method="post" name="payment">' +
        '<input name="id" value="16726" type="hidden">' +
        '<input name="kwota" value="1.00" type="hidden">' +
        '<input name="opis" value="opis transakcji" type="hidden">' +
        '<input name="akceptuje_regulamin" value="1" type="hidden">' +
        '<table><tr>';
    for (var i = 0; i < tr_groups.length; i++) {
        str += "<td style='padding:4px'><input type='radio' id='tr_" + tr_groups[i][0] + "' name='grupa' value='" + tr_groups[i][0] + "' /><label for='tr_" + tr_groups[i][0] + "'>&nbsp;" + tr_groups[i][1] + "</label></td>";
        if (i % 2 == 1)
            str += "</tr><tr>";
    }   
    str += "</tr></table><br><input type=\"submit\" value=\"Wyślij\" /></form>";
    document.getElementById('content').innerHTML = str;
}

window.onload = ShowChannelsCombo;