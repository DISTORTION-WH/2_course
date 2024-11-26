import React from 'react';

export default (props) => {
  const start = props.currentPageItemStart + 1;
  let end = props.currentPageItemEnd;
  if (props.currentPageItemEnd > props.totalProductCount) {
    end = props.totalProductCount;
  }
  return(
    <div>
      <p>Показано {start} - {end} из {props.totalProductCount} товаров</p>
    </div>
  );
}
