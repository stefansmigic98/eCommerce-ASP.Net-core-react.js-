import React from 'react';
import ReactDom from 'react-dom'
import { Link } from 'react-router-dom';

const Header = () => (
    <div className='content-container'>

        <div className='header'>
            <div className='header-flex-container'>
                <Link className='header-item' to='/'>Home</Link>
                <Link className='header-item' to='/'>Categories</Link>
            </div>
            <div className='header-flex-container'>
                <input type='text' placeholder='Search'></input>
                <Link className='header-item' to='/'>Cart</Link>
                <Link className='header-item' to='/'>Singin</Link>
            </div>
        </div>
    </div>

);


export default Header;