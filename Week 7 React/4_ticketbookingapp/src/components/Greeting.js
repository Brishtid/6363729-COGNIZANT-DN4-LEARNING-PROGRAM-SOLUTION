import React from 'react';

function Greeting({ isLoggedIn }) {
  return <h1>{isLoggedIn ? 'Welcome back!' : 'Please sign up.'}</h1>;
}

export default Greeting;
