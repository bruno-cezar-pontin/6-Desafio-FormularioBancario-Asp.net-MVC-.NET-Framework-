document.addEventListener('DOMContentLoaded', () => {

    document.addEventListener('input', (event) => {
        cpf.addEventListener('input', function () { maskCPF() })


        if (event.target.getAttribute('name') == "TipoUsuario")
            if (event.target.value == 'CPF') {
                document.getElementById('CPF').style.display = "block";
                document.getElementById('CNPJ').style.display = "none";
            } else {
                document.getElementById('CPF').style.display = "none"
                document.getElementById('CNPJ').style.display = "block"
            }
    })
});