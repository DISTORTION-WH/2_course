import React, { Component } from 'react';
import { confirmAlert } from 'react-confirm-alert';
import { connect } from 'react-redux'
import $ from 'jquery';
import 'react-confirm-alert/src/react-confirm-alert.css';

import { countCart } from '../../lib/cartLib';
import * as actions from '../../actions';
import CartItem from '../views/CartItem';
import CartTotal from '../views/CartTotal';
import { highLightCartButton } from '../../lib/cartLib';

class CartList extends Component {
  constructor(props) {
    super(props);

    const cartForm = {};
    this.props.cart.map((product, index) =>
      cartForm[product.Id] = {Id: product.Id, quantity: product.quantity}
    );
    this.state = {cartForm};

    this.tableRef = React.createRef();
  }

  handleChangeCartQuantity = (e, productId) => {
    const cartForm = Object.assign({}, this.state.cartForm);
    cartForm[productId].quantity = parseInt(e.target.value);
    this.setState(cartForm);
  }

  // фокус на выбранную строку.
  handleClickRow = (productId) => {
    $(this.tableRef.current).find('tr').each((i, el) => {
      $(el).removeClass('table-active');
    });
    $(this.tableRef.current).find('tr.row-' + productId).addClass('table-active');
  }

  handleRemoveCartItem = (product) => {
 
    confirmAlert({
      customUI: ({ onClose }) => {
        return (
          <div className="react-confirm-alert-body">
            <h1>Удалить {product.Title}</h1>
            <p>Вы уверены что хотите удалить этот товар из корзины?</p>
            <div className="react-confirm-alert-button-group">
              <button onClick={onClose}>Нет</button>
              <button id="btn-confirm-delete-cart"
                onClick={() => {
                  this.props.removeFromCart(product.Id);
                  onClose();
                }}
              >
                Да, удалить!
              </button>
            </div>
          </div>
        );
      }
    });
  }

  render() {
    const cartItemsMarkUp = this.props.cart.map((product, index) =>
      <CartItem product={product} key={product.Id}
        cartFormElement={this.state.cartForm[product.Id]}
        handleClickRow={this.handleClickRow}
        handleRemoveCartItem={this.handleRemoveCartItem}
        counter={index + 1} handleChangeCartQuantity={this.handleChangeCartQuantity} />
    );
    return(
      <div className="container">
        <h3 className="center my-cart">Корзина ({this.props.cartCount.cartItemCount}):</h3>
        {this.props.cartCount.cartItemCount > 0
          ?
          <form id="cart-form" onSubmit={e => this.props.updateCart(e, this.state.cartForm)}>
            <div className="table-responsive">
              <table className="table table-hover" ref={this.tableRef}>
                <thead className="thead-light">
                  <tr>
                    <th scope="col">#</th>
                    <th scope="col">Название</th>
                    <th scope="col">Цена</th>
                    <th scope="col">Количество</th>
                  </tr>
                </thead>
                <tbody>
                  {cartItemsMarkUp}
                </tbody>
                <CartTotal cartCount={this.props.cartCount} />
              </table>
            </div>

            <div className="row justify-content-end container-proceed-cart">
              <div className="col-lg-3 col-md-5 col-sm-6 col-xs-8">
                <div className="btn-group" role="group" aria-label="Update Cart">
                  <button type="submit" className="btn btn-primary">Обновить чек</button>
                </div>
               
              </div>
            </div>
          </form>
          :
          <h4 className="row justify-content-center cart-empty">Ваша корзина пуста!</h4>
        }

      </div>
    );
  }
}

const mapStateToProps = state => {
  const cartCount = countCart(state.cart);
  return {cart: state.cart, cartCount}
}

const mapDispatchToProps = dispatch => {
  return {
    removeFromCart: productId => {
      highLightCartButton();
      return dispatch(actions.removeFromCartAction(productId))
    },

    updateCart: (e, cartForm) => {
      e.preventDefault();
      highLightCartButton();
      return dispatch(actions.updateCartAction(cartForm));
    },
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CartList);
