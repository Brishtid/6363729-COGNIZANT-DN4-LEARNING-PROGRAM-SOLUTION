import React from 'react';
import './App.css'; 

function App() {
  
  const officeSpaces = [
    { Name: 'DBS', Rent: 50000, Address: 'Chennai' },
    { Name: 'Brishti', Rent: 6363729, Address: 'Odisha' }
  ];

  return (
    <div className="App">
      <h1>Office Space, At Affordable Range</h1>

      {}
      {officeSpaces.map((space, index) => {
        
        const rentStyle = {
          color: space.Rent < 60000 ? 'red' : 'green' 
        };

        return (
          
          <div key={index} style={{ marginBottom: '20px', border: '1px solid #ccc', padding: '10px', borderRadius: '8px' }}>
            <img
              src="https://images.unsplash.com/photo-1551766472-62096056b476?q=80&w=2036&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
              alt="Office Space"
              style={{ width: '20%', minWidth: '150px', height: 'auto', display: 'block', margin: '0 auto 10px', borderRadius: '4px' }}
            />
            <h2>Name: {space.Name}</h2>
            <h3 style={rentStyle}>Rent: Rs. {space.Rent}</h3> {}
            <h3>Address: {space.Address}</h3>
          </div>
        );
      })}
    </div>
  );
}

export default App;