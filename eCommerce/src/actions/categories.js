import { url } from '../consts';


export const setExpenses = (categories) => ({
    type: 'SET_CATEGORIES',
    categories
});

export const startSetCategories = () => {
    return (dispatch, getState) => {
        return fetch(url + '/category')
            .then((response) => response.json())
            .then((data) => dispatch(setExpenses(data)));
    };
}



