

async function displayfarmdetails(FARM_ID) {
    const response = await fetch('https://localhost:7081/api/Farms/${FARM_ID}')
    const data = await response.json();
    document.getElementById('farmName').innerHTML = data = [0].name;
    document.getElementById('farmName').style.visibilty = "visible";



}