function IssueCard(icno) {
    $.ajax({
        type: "POST",
        url: "http://172.19.116.11:9012",
        data: "<TransID>ACR1</TransID><Data><IPADDRESS>172.19.116.11</IPADDRESS><PORT>7020</PORT><INST_MSG>Please put the card</INST_MSG><FUNCTION>1</FUNCTION></Data>",
        dataType: 'xml',
        success: function (evt) {
            clientID = $(evt).find("SendToDSSResult").text();
            alert(clientID);
            tagid = $(clientID).find("TAGID").text();
            alert("tagid-->"+tagid);
            //alert(evt);

            //var xmlString = (new XMLSerializer()).serializeToString(data);
            //alert (xmlString.length);
            //alert (
            


        },
        error: function (xhr, statustext, errorthrown) {
            alert("There was error.We'll try to fix that.:)");
            var err = "Error for IssueCard " + " " + statustext + " " + errorthrown;
            alert(err);
        }


    });
}


function PairEcard(icno, tagid) {
    var ajaxURL = '@Url.Action("GetPeserta", "Peserta")';
    $.ajax({
        type: "POST",
        url: ajaxURL,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify({ 'ic': icno, '': tagid }),
        success: function (data) {

        },
        error: function (xhr, statustext, errorthrown) {
            alert("There was error.We'll try to fix that.:)");
            var err = "Error for PairEcard: " + " " + statustext + " " + errorthrown;
            alert(err);
        }


    });
}