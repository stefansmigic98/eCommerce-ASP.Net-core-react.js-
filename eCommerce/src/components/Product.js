import React from 'react';
import ReactDom from 'react-dom';
import { Link } from 'react-router-dom';
import { url } from '../consts';

const Product = ({ product }) => (
    <div className='products__card'>
        <Link to={'product/' + product.id} className='products__name'><h3 className='products__name'>{product.name}</h3>
            {
                console.log(product)
            }
            <img className='products_card-image' src={url + '/' + product.imageUrl} />
        </Link>
        <p>{product.price}</p>
        <button className='button'>Add to cart</button>
    </div>
);

export default Product;