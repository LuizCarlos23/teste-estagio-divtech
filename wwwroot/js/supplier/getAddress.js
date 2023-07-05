async function searchAdress(cep = "") {
    let url = `https://viacep.com.br/ws/${cep}/json/`
    showLoading() 
    fetch(url)
        .then(response => {
            hideLoading() 
            if (response.status != 200) {
                throw new Error(`Response status ${response.status}`)
            } else {
                return response.json()
            }
        })
        .then(data => {
            if (data.erro) {
                changeAdressError()
            } else {
                changeAdress(data)
            }
        })
        .catch(err => {
            hideLoading()
            changeAdressError()
            document.getElementById("inputAddress").value = ""
            console.log(err)
        })
}

function changeAdress(data = { bairro: "", localidade: "", logradouro: "", uf: "" }) {
    let element = document.getElementById("inputAddress")
    element.value = `${data.logradouro}, ${data.bairro}, ${data.localidade} - ${data.uf}`
    element.removeAttribute("disabled");
    document.getElementById("submitBtn").removeAttribute("disabled")
}

function changeAdressError() {
    let element = document.getElementById("inputAddress")
    element.value = "Endereço inválido!"
    element.setAttribute("disabled", "disabled")
    document.getElementById("submitBtn").setAttribute("disabled", "disabled")
    document.getElementById("inputCep").focus()
}

document.getElementById("inputCep").addEventListener("change", (e) => {
    let value = e.target.value
    if (value.length == 8) {
        searchAdress(value)
    }
})
