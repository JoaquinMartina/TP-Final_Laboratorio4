$("#img").change(function () {

    //alert("Se ejecuto el evento change");
    readURL(this);
}
);

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#image").attr("src", e.target.result);
        }

        reader.readAsDataURL(input.files[0]); //leer el archivo string base64
    }
}