import React from 'react';
import { Link } from 'react-router-dom';

export default (props) => {
  return(
        <div className="central-body">
          <img className="image-404" alt="404" src="/img/404.svg" width="300px" />
          <Link to="/" className="btn-go-home">ВЕРНУТЬСЯ НА ГЛАВНУЮ</Link>
        </div>
  );
}
