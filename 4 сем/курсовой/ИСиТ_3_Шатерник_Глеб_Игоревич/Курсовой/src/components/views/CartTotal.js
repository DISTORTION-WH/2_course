import React from 'react';

export default (props) =>
  <tbody className="thead-light">
    <tr>
      <th scope="col"></th>
      <th scope="col">Итог</th>
      <th scope="col">${props.cartCount.cartTotal}</th>
      <th scope="col">Количество продуктов:{props.cartCount.cartItemCount} </th>
    </tr>
  </tbody>
