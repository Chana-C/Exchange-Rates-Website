import axios from 'axios';

const apiUrl = 'http://localhost:5002/api/currency';

export const getCurrencies = async () => {
  try {
 const response = await axios.get(`${apiUrl}/currencies`);
    return response.data;
  } catch (error) {
    console.error('שגיאה בקריאת ה-API:', error);
    throw error;
  }
};

// Function to get the exchange rates for a certain base currency
export const getExchangeRates = async (baseCurrency) => {
  try {
    const response = await axios.get(`${apiUrl}/exchange-rates/${baseCurrency}`);
    return response.data;
  } catch (error) {
    console.error('שגיאה בקריאת ה-API:', error);
    throw error;
  }
};
