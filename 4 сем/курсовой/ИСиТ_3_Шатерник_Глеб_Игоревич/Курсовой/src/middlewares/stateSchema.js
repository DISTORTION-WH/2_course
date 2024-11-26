export default {
  "$schema": "http://json-schema.org/draft-06/schema#",
  "$ref": "#/definitions/Welcome",
  "definitions": {
      "Welcome": {
          "type": "object",
          "additionalProperties": false,
          "properties": {
              "cart": {
                  "type": "array",
                  "items": {
                      "$ref": "#/definitions/Cart"
                  }
              },
              "products": {
                  "$ref": "#/definitions/Products"
              }
          },
          "required": [
              "cart"
          ],
          "title": "Welcome"
      },
      "Cart": {
          "type": "object",
          "additionalProperties": false,
          "properties": {
              "Номер": {
                  "type": "string",
                  "format": "integer"
              },
              "Название": {
                  "type": "string"
              },
              "Цена": {
                  "type": "integer"
              },
              "Количество": {
                  "type": "integer"
              }
          },
          "required": [
              "Номер",
              "Цена",
              "Название",
              "Количество"
          ],
          "title": "Cart"
      },
      "Products": {
          "type": "object",
          "additionalProperties": false,
          "properties": {
              "allProducts": {
                  "type": "array",
                  "items": {
                      "$ref": "#/definitions/ProductDetails"
                  }
              },
              "productDetails": {
                  "$ref": "#/definitions/ProductDetails"
              }
          },
          "required": [
          ],
          "title": "Products"
      },
      "ProductDetails": {
          "type": "object",
          "additionalProperties": false,
          "properties": {
              "Номер": {
                  "type": "string",
                  "format": "integer"
              },
              "Название": {
                  "type": "string"
              },
              "Категория": {
                  "type": "string"
              },
              "Подгатегория": {
                  "type": "string"
              },
              "Производство": {
                  "type": "string"
              },
              "Contents": {
                  "type": "string"
              },
              "Описание": {
                  "type": "string"
              },
              "Без ГМО": {
                  "type": "boolean"
              },
              "ImageUrl": {
                  "type": "string",
                  "format": "uri",
                  "qt-uri-protocols": [
                      "http"
                  ],
                  "qt-uri-extensions": [
                      ".jpg"
                  ]
              },
              "Стартовая цена": {
                  "type": "integer"
              },
              "Цена": {
                  "type": "integer"
              },
              "Компании": {
                  "type": "array",
                  "items": {
                      "type": "string"
                  }
              },
              "IsNew": {
                  "type": "boolean"
              }
          },
          "required": [
              "Номер",
              "ImageUrl",
              "Производство",
              "Стартовая цена",
              "Без ГМО",
              "Цена",
              "Подкатегория",
              "Название"
          ],
          "title": "ProductDetails"
      }
  }
}
