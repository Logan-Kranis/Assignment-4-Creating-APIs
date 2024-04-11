
//async function displayFarmDetails(id) {
//    try {
//        const response = await fetch(`https://localhost:7197/api/Farms/${id}`);
//        const data = await response.json();

//        // Display farm details
//        document.getElementById('farmName').innerHTML = data[0].name;
//        document.getElementById('farmName').style.visibility = "visible";

//        document.getElementById('farmAddress').innerHTML = data[0].address;
//        document.getElementById('farmAddress').style.visibility = "visible";

//        document.getElementById('farmCity').innerHTML = `${data[0].city}, ${data[0].state}`;
//        document.getElementById('farmCity').style.visibility = "visible";
//    } catch (error) {
//        console.error('Error fetching farm details:', error);
//}



document.getElementById('searchForm').addEventListener('submit', async function (event) {
    event.preventDefault();

    const city = document.getElementById('cityInput').value.trim();
    if (city === '') {
        alert('Please enter a city name.');
        return;
    }

    try {
        const response = await fetch(`https://localhost:7197/api/Farms/${encodeURIComponent(city)}`);
        const data = await response.json();

        if (response.ok) {
            const farmDetailsHtml = `
                <p><strong>Name:</strong> ${data.name}</p>
                <p><strong>Address:</strong> ${data.address}</p>
                <p><strong>City:</strong> ${data.city}</p>
                <p><strong>State:</strong> ${data.state}</p>
                <p><strong>Zip Code:</strong> ${data.zipCode}</p>
                <p><strong>Latitude:</strong> ${data.latitude}</p>
                <p><strong>Longitude:</strong> ${data.longitude}</p>
            `;

            document.getElementById('farmDetails').innerHTML = farmDetailsHtml;

           
            const map = L.map('map').setView([data.latitude, data.longitude], 13);

            // Add the base map layer from Leaflet
            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
            }).addTo(map);

            // Add a marker for the farm's location
            L.marker([data.latitude, data.longitude]).addTo(map)
                .bindPopup(data.name)
                .openPopup();
        } else {
            alert('Farm details not found for the entered city.');
        }
    } catch (error) {
        console.error('Error fetching farm details:', error);
        // Handle error
    }
});



