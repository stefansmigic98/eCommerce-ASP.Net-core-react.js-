import React from 'react';
import ReactDom from 'react-dom';
import { Router, Switch, Route } from 'react-router-dom';
import Header from '../components/Header';
import HomePage from '../components/HomePage';
import createHistory from 'history/createBrowserHistory';
import NotFountPage from '../components/NotFoundPage';
import ProductPage from '../components/ProductPage';

const history = createHistory();


const AppRouter = () => (
    <Router history={history}>
        <div>
            <Header />
            <div className='content-container'>
                <Switch>
                    <Route exact={true} path='/' component={HomePage} />
                    <Route exact={true} path='/product/:id' component={ProductPage} />
                    <Route component={NotFountPage} />
                </Switch>
            </div>
        </div>
    </Router>

);

export default AppRouter;