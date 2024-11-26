import { combineReducers } from 'redux';

// редьюсер
import cartReducer from './cartReducer';
import productsReducer from './productsReducer';

// комбинированный редьюсер
export default combineReducers({
  cart: cartReducer,
  products: productsReducer
});
