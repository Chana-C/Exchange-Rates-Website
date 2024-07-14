import React, { useState, useEffect } from 'react';
import { getCurrencies, getExchangeRates } from '../services/api';

const CurrencyExchangeTable = () => {
  const [exchangeRates, setExchangeRates] = useState([]);
  const [baseCurrency, setBaseCurrency] = useState('USD');
  const [currencies, setCurrencies] = useState([]);

  // Fetch currencies on component mount
  useEffect(() => {
    const fetchCurrencies = async () => {
      try {
        const data = await getCurrencies();
        console.log('Fetched currencies:', data); // Log to see the received data
 
        setCurrencies(data);
        // setBaseCurrency(data[0]); // Set the initial base currency
      } catch (error) {
        console.error('Error fetching currencies:', error);
      }
    };
    fetchCurrencies();
  }, []);

  // Fetch exchange rates when baseCurrency changes
  useEffect(() => {
    if (baseCurrency) {
      const fetchRates = async () => {
        try {
          const data = await getExchangeRates(baseCurrency);
          console.log('Fetched exchange rates:', data); // Log to see the received data
          setExchangeRates(data);
        } catch (error) {
          console.error('Error fetching exchange rates:', error);
        }
      };
      fetchRates();
    }
  }, [baseCurrency]);

  return (
    <div>
      <h2>Exchange Rates for {baseCurrency}</h2>
      <select value={baseCurrency} onChange={(e) => setBaseCurrency(e.target.value)}>
        {currencies.map(currency => (
          <option key={currency} value={currency}>{currency}</option>
        ))}
      </select>
      <table>
        <thead>
          <tr>
            <th>Base Currency </th>
            <th>Target Currency </th>
            <th>Exchange Rate </th>
          </tr>
        </thead>
        <tbody>
           {exchangeRates.map((rate, index) => (
            <tr key={index}>
            {/* <tr key={rate.Currency}> */}
              <td>{baseCurrency}</td>
              <td>{rate.currency}</td>
              <td>{rate.value}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default CurrencyExchangeTable;




