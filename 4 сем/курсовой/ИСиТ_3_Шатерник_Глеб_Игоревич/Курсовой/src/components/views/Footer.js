import React from 'react';

export default () => {
  return(
    <footer className="section footer-classic context-dark bg-image">
        <div className="container">
          <div className="row row-30 footer-row">
            <div className="col-md-4 col-xl-5">
              <div className="pr-xl-4">
                <p>Наша компания занимается выращиванием, транспортировкой, распространением, селекцией винограда.  </p>
                <p className="rights"><span>ИП</span><span className="copyright-year"> Шатерник Г.И.</span><span> </span><span></span><span></span></p>
              </div>
            </div>
            <div className="col-md-4">
              <h5>Контакты</h5>
              <dl className="contact-list">
                <dt>Адрес:</dt>
                <dd>Беларусь, Могилевская область, Деревня Калинино, улица Шоссейная, дом 27</dd>
              </dl>
              <dl className="contact-list">
                <dt>Электронная почта:</dt>
                <dd><a href="mailto:#">grapeworld@gmail.com</a></dd>
              </dl>
              <dl className="contact-list">
                <dt>Телефон:</dt>
                <dd><a href="tel:#">+375445625902</a> <span>или</span> <a href="tel:#">+375291729644</a>
                </dd>
              </dl>
            </div>

            <div className="col-md-4 col-xl-3">
              <h5>Links</h5>
              <ul className="nav-list dott">
                <li><a href="/about">О нас</a></li>
                <li><a href="/other">Другие проекты</a></li>
                <li><a href="/news">Новости</a></li>
                <li><a href="/contacts">Контакты</a></li>
                <li><a href="/">Цены</a></li>
              </ul>
            </div>
            
          </div>
        </div>
        <div className="row no-gutters social-container">
          <div className="col"><a className="social-inner" href="#vk"><span className="icon mdi mdi-facebook"></span><span>Вконтакте</span></a></div>
          <div className="col"><a className="social-inner" href="#instagram"><span className="icon mdi mdi-instagram"></span><span>instagram</span></a></div>
          <div className="col"><a className="social-inner" href="#telegram"><span className="icon mdi mdi-telegram"></span><span>Telegram</span></a></div>
          <div className="col"><a className="social-inner" href="#gmail"><span className="icon mdi mdi-gmail"></span><span>Gmail</span></a></div>
        </div>
      </footer>
  );
}
