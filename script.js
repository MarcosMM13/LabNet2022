//traer valores de los elementos del DOM
let Nombre, Apellido, edad, empresa, radioMasc
let Boton = document.getElementById("boton")
let botonLimpiar = document.getElementById("botonLimpiar")

//funcion de validacion que los campos no esten vacios
function GetAll() {
    Nombre = document.getElementById("Nombre").value
    Apellido = document.getElementById("Apellido").value
    if (Nombre === "") {
        console.warn("Esto es un error por nulidad de un campo.")
        document.getElementById("errorMessageNombre").textContent = "esto error de validacion"
    }
    if (Apellido === "") {
        console.warn("Esto es un error por nulidad de un campo.")
        document.getElementById("errorMessageApellido").textContent = "esto error de validacion"
    }
    if (Nombre.replace(/\s+/g, '').length == 0){
                console.warn("Esto es un error por nulidad de un campo.")
        document.getElementById("errorMessageNombre").textContent = "Ingrese por favor el Nombre"
    }
    if (Apellido.replace(/\s+/g, '').length == 0){
        console.warn("Esto es un error por nulidad de un campo.")
        document.getElementById("errorMessageApellido").textContent = "Ingrese por favor el Apellido"        
    }
}

function LimpiarCampos() {
    Nombre = document.getElementById("Nombre").value = ""
    Apellido = document.getElementById("Apellido").value = ""
    edad = document.getElementById("Edad").value = null
    empresa = document.getElementById("Empresa").value = ""
    radioMasc = document.querySelector('#flexRadioDefault2').checked = true
}

//evento para llamar a la funcion con el boton mostrar mensaje
Boton.addEventListener("click", function (e) {
    e.preventDefault()
    document.getElementById("errorMessageNombre").textContent = ""
    document.getElementById("errorMessageApellido").textContent = ""
    GetAll()
})
botonLimpiar.addEventListener("click", function (e) {
    e.preventDefault()
    document.getElementById("errorMessageNombre").textContent = ""
    document.getElementById("errorMessageApellido").textContent = ""
    LimpiarCampos()
})

//fijarse en validacion de nombre y apellido
//usar validacion isNaN para nombre y apellido
//ver logica de los input para borrar el msj dentro
