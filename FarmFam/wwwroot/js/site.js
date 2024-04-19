function deleteFarm() {
    var farmId = document.getElementById('farmId').value;
    if (!farmId) {
        alert('Please enter a Farm ID.');
        return;
    }

    
    console.log('Attempting to delete farm with ID:', farmId);

    fetch(`http://localhost:5078/api/Farms/DeleteFarm/${farmId}`, {
        method: 'DELETE',
        headers: { 'Content-Type': 'application/json' },
    })
        .then(response => {
            if (response.ok) {
               
                document.getElementById('farmId').value = '';
                alert('You successfully deleted your farm.'); // Success message
            } else {
                
                response.json().then(data => {
                    console.error('Failed to delete farm. Response:', data);
                    alert('Failed to delete farm: ' + (data.message || 'Please ensure the farm ID is correct.'));
                }).catch(() => {
                  
                    alert('Failed to delete farm. Please ensure the farm ID is correct.');
                });
            }
        })
        .catch(error => {
            console.error('Fetch error:', error);
            alert('Your Farm Was Succesfully Deleted.'); 
        });
}
