import React from 'react';
import './App.css';
import Dropdown from './components/Dropdown';
import CurrencyExchangeTable from './components/CurrencyExchangeTable';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Currency Exchange Rates</h1>
        <Dropdown />
        <CurrencyExchangeTable />
      </header>
    </div>
  );
}

export default App;
