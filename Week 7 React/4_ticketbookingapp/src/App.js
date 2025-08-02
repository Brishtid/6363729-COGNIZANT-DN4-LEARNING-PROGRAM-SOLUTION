import React, { useState } from 'react';
import Greeting from './components/Greeting';
import LoginButton from './components/LoginButton';
import LogoutButton from './components/LogoutButton';
import UserPage from './components/UserPage';
import GuestPage from './components/GuestPage';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  return (
    <div style={{ textAlign: 'center', marginTop: '50px' }}>
      <Greeting isLoggedIn={isLoggedIn} />
      {isLoggedIn ? (
        <>
          <LogoutButton onClick={handleLogout} />
          <UserPage />
        </>
      ) : (
        <>
          <LoginButton onClick={handleLogin} />
          <GuestPage />
        </>
      )}
    </div>
  );
}

export default App;
