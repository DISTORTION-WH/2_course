import React, { Component } from 'react';
import Home from './Home';
import ShoppingCart from './ShoppingCart';
import ProductDetailsPage from './ProductDetailsPage';
import PageNotFound from '../views/PageNotFound';
import NavContainer from '../containers/NavContainer';
import Footer from '../views/Footer';
import About from './About';
import Other from './Other';
import News from './News';
export default class BasePage extends Component {
  render() {
    let componentRendered = '';
    switch (this.props.pageName) {
      case "Home":
        componentRendered = <Home {...this.props}/>;
        break;
      case "ProductDetailsPage":
        componentRendered = <ProductDetailsPage {...this.props}/>;
        break;
      case "ShoppingCart":
        componentRendered = <ShoppingCart {...this.props}/>;
        break;
      case "About":
        componentRendered = <About {...this.props}/>;
        break;
      case "Other":
        componentRendered = <Other {...this.props}/>;
        break;
      case "News":
        componentRendered = <News {...this.props}/>;
        break;
      default:
        componentRendered = <PageNotFound {...this.props}/>;
    };
    return(
      <div className="App">
        <NavContainer />
        {componentRendered}
        <Footer />
      </div>
    );
  }
}
