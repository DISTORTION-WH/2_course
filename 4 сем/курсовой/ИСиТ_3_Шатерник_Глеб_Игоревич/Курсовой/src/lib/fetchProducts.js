export function fetchProducts() {
  return fetch("/data/ProductData.json")
    .then(handleErrors)
    .then(res => res.json())
    .then(json => {
      return json.Products;
    });
}

export function fetchProductDetails(id) {
  return fetch("/data/ProductData.json")
    .then(handleErrors)
    .then(res => res.json())
    .then(json => {
      return json.Products.filter(product => {
        if (product.Id === id) {
          return true;
        }
        else {
          return false;
        }
      });
    });
}

// Обработка ошибок HTTP, поскольку выборка не выполняется.
function handleErrors(response) {
  if (!response.ok) {
    throw Error(response.statusText);
  }
  return response;
}
