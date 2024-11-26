import React from 'react';
import { Provider } from 'react-redux';
import { BrowserRouter as Router } from 'react-router-dom';
import getStore from './store';

export default ({ children, initialState = {}, env = '' }) => {
  const store = getStore(initialState, env);
// Это для повторного использования кода тега провайдера и маршрутизатора. Ссылки должны быть обернуты <Router>.
  // Его можно повторно использовать в модульных тестах.
  return(
    <Provider store={store}>
      <Router>
        {children}
      </Router>
    </Provider>
  );
}
