import React from 'react';
import { NavLink } from 'react-router-dom';

export default (props) => {
  return(
    <React.Fragment>
      <a className="navbar-brand" target="_self" href="./">
       <h2>Grape World</h2>
      </a>





      <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
        <span className="navbar-toggler-icon"></span>
      </button>

      <div className="collapse navbar-collapse" id="collapsibleNavbar">
        <ul className="navbar-nav mr-auto">


          
          <li className="nav-item">
            <NavLink exact={true} to="/" activeClassName='active' className="nav-link">Главная</NavLink>
          </li>
       
          <li className="nav-item">
            <NavLink to="/about" activeClassName='active' className="nav-link">О нас</NavLink>
          </li>
          <li className="nav-item">
            <NavLink to="/other" activeClassName='active' className="nav-link">Другие проекты</NavLink>
          </li>
          <li className="nav-item">
            <NavLink to="/news" activeClassName='active' className="nav-link">Новости</NavLink>
          </li>
        </ul>
      </div> 
    </React.Fragment>
  );
}
