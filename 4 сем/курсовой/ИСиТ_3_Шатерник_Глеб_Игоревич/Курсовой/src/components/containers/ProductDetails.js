import React, { Component } from 'react';
import { connect } from 'react-redux';

import * as actions from '../../actions';
import AddToCart from '../views/AddToCart';
import { AddToCartContext } from '../../contexts/AddToCartContext';

class ProductDetails extends Component {
  constructor(props) {
    super(props);
    this.state = {productDetails: {}};
  }

  componentWillMount() {
    const productId = this.props.productId; 
    this.props.getProductDetails(productId);
  }

  // Передача AddToCartContext, поскольку он может использоваться в любом дочернем элементе.
  render() {
    return(
      <AddToCartContext.Provider value={{action: this.props.addToCartAction}}>
        <div>
          { typeof this.props.productDetails !== 'undefined' &&
            <React.Fragment>
              <h3 className="center">Подробнее - {this.props.productDetails.Title}</h3>
              Краткая информация о товаре.
              <div className="product-box card mb-3">
                <div className="card-body">
                  <div className="text-center">
                    <img className="card-more" alt={this.props.productDetails.Title} src={this.props.productDetails.ImageUrl} />
                  </div>
                  <p className="card-text description">
                    {this.props.productDetails.Description}
                  </p>
                  <p className="card-text"><b>Категория:</b> {this.props.productDetails.Category}</p>
                  <p className="card-text"><b>Выращен в:</b> {this.props.productDetails.Manufacturer}</p>
                  <p className="card-text"><b>Добавки:</b> {this.props.productDetails.Organic ? 'Без ГМО' : 'Обработан' }</p>
                  <p className="card-text"><b>Цена:</b> ${this.props.productDetails.Price}</p>

                  <AddToCart product={this.props.productDetails} />
                </div>
              </div>
            </React.Fragment>
          }
        </div>
      </AddToCartContext.Provider>
    );
  }
}

const mapStateToProps = state => {
  return {productDetails: state.products.productDetails};
}

export default connect(mapStateToProps, actions)(ProductDetails);
