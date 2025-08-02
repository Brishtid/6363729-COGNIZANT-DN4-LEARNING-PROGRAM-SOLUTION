import React, { useState } from 'react';

function App() {
  const [count, setCount] = useState(0);
  const [amount, setAmount] = useState('');
  const [currency, setCurrency] = useState('');

  // ✅ 1. Increment (invokes 2 methods)
  const increment = () => {
    setCount(prev => prev + 1);
    sayHello();
  };

  const decrement = () => {
    setCount(prev => prev - 1);
  };

  const sayHello = () => {
    alert("Hello Member1");
  };

  // ✅ 2. Say Welcome
  const sayWelcome = (msg) => {
    alert(msg);
  };

  // ✅ 3. OnPress - Synthetic Event
  const onPress = (e) => {
    alert("I was clicked");
  };

  // ✅ 4. Currency Converter (₹ to €)
  const handleSubmit = (e) => {
    e.preventDefault();
    if (currency.toLowerCase() === "euro") {
      const euroAmount = parseFloat(amount) * 0.012; // Example rate: ₹1 = €0.012
      alert(`Converting to Euro Amount is ${euroAmount}`);
    } else {
      alert("Please enter a valid currency (e.g., Euro)");
    }
  };

  return (
    <div style={{ margin: "20px" }}>
      <h2>{count}</h2>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
      <button onClick={() => sayWelcome("welcome")}>Say welcome</button>
      <button onClick={onPress}>Click on me</button>

      <h2 style={{ color: "green" }}>Currency Convertor!!!</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Amount: <input type="text" value={amount} onChange={(e) => setAmount(e.target.value)} />
        </label>
        <br />
        <label>
          Currency: <input type="text" value={currency} onChange={(e) => setCurrency(e.target.value)} />
        </label>
        <br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default App;
