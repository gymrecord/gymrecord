import { combineReducers, createStore, applyMiddleware } from 'redux';
import thunk from 'redux-thunk';

export type RootState = {};

const rootReducer = combineReducers({});

export const store = createStore(rootReducer, applyMiddleware(thunk));
store.subscribe(() => console.log(store.getState()));
