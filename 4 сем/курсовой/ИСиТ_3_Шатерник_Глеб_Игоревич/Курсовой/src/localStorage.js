export const loadState = () => {
// localStorage.getItem может завершиться ошибкой, если режим конфиденциальности пользователя не позволяет использовать localStorage.  
try {
    const serializedState = localStorage.getItem('state');
    if (serializedState === null) {
      return undefined;
    }
    return JSON.parse(serializedState);
  } catch (err) {
    return undefined;
  }
};

export const saveState = (state) => {
  try {
    const serializedState = JSON.stringify(state);
    localStorage.setItem('state', serializedState);
  } catch {
// игнорируем ошибки записи
  }
};
