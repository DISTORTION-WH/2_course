export default function({ dispatch, getState }) {
  return next => action => {
// Если загрузка не имеет свойства .then, отправить ее.
    if (!action.payload || !action.payload.then) {
      return next(action);
    }

// Убедитесь, что  действия выполнено
    action.payload
      .then(function(response) {
// создаем новое действие старого типа, но
// заменяем  данными ответа
        const newAction = { ...action, payload: response };
        dispatch(newAction);
      });
  }
}
