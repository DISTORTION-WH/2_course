import React from 'react';
import { Link } from 'react-router-dom';

export default (props) => {
  return(
    <div>
      <Link id="nav-view-cart-link" to="/shopping-cart" className="btn btn-secondary">
        Корзина ({ props.cartItemCount })
      </Link>
    </div>
  );
}
