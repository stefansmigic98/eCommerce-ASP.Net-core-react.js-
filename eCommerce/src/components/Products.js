import React, { Component } from 'react';
import ReactDom from 'react-dom';
import Product from './Product';
import { url } from '../consts';
import ProductsFilters from './ProductsFilters';


export default class Products extends Component {

    constructor(props) {
        super(props);
        this.state = {
            products: []
        }

    }

    componentDidMount() {
        this.fetchData();
    }

    fetchData = (query = '') => {
        console.log(query);
        this.setState({
            products: []
        });
        fetch(url + '/products' + query)
            .then(response => response.json())
            .then(data => {
                this.setState({
                    products: data
                })
            }
            );
    };

    render() {

        return (
            <div >
                <ProductsFilters onchange={this.fetchData} />
                <div className='products'>
                    {this.state.products.length ?
                        this.state.products.map(product => <Product key={product.name} product={product} />) :
                        <img src='/images/200.gif'></img>}
                </div>
            </div>
        );
    };
};
