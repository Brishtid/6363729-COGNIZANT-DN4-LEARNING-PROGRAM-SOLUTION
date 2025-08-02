import React from 'react';

function ListofIndianPlayersMerged({ IndianPlayers }) {
  return (
    <div>
      {IndianPlayers.map((player, index) => (
        <li key={index}>Mr. {player}</li>
      ))}
    </div>
  );
}

export default ListofIndianPlayersMerged;
