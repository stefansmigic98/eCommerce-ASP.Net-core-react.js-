import { createStore, combineReducers, applyMiddleware, compose } from 'redux';
import categoriesReducer from '../reducers/categories';
import thunk from 'redux-thunk';


const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

export default () => {
    const store = createStore(
        combineReducers({
            categories: categoriesReducer,

        }),
        composeEnhancers((applyMiddleware(thunk)))

    );
    return store;
}