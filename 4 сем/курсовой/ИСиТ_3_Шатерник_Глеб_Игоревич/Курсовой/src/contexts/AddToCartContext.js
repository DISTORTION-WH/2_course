import React from 'react';

// Создание AddToCartContext, поскольку он может использоваться в любом дочернем элементе.
export const AddToCartContext = React.createContext({action: null});
