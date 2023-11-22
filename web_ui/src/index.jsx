import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter as Router } from 'react-router-dom';
import { registerLicense } from '@syncfusion/ej2-base';
import './index.scss';
import App from './App';
// import reportWebVitals from './reportWebVitals'

// Registering Syncfusion license key
registerLicense('ORg4AjUWIQA/Gnt2VlhhQlJCfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn9TdEJiUH5YcHJcQGZf');

const root = ReactDOM.createRoot(document.getElementById('WebApp'));

root.render(
  <React.StrictMode>
    <Router>
      <App />
    </Router>
  </React.StrictMode>
)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
//reportWebVitals()

