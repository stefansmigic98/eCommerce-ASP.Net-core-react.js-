import React from 'react';
import ReactDOM from 'react-dom';

class ProductsFilters extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            queryString: '',
            priceRange: '',
            orderBy: ''
        };
    }

    changePriceRange = (val) => {

        this.setState({
            priceRange: val == 'PriceRange' ? '' : 'pricerange=' + val
        }, () => {
            if (!this.state.orderBy) {
                this.props.onchange('?' + this.state.priceRange);
            }
            else {
                this.props.onchange('?' + this.state.orderBy + '&' + this.state.priceRange);
            }
        });


    };

    changeOrderBy = (val) => {
        this.setState({
            orderBy: val == 'OrderBy' ? '' : 'orderBy=' + val
        }, () => {
            if (!this.state.orderBy) {
                this.props.onchange('?' + this.state.priceRange);
            }
            else {
                this.props.onchange('?' + this.state.orderBy + (this.state.priceRange ? '&' : '') + this.state.priceRange);
            }
        });
    }

    render() {

        return (
            <div>
                <select onChange={(event) => this.changePriceRange(event.target.value)}>
                    <option value='PriceRange'>Price Range</option>
                    <option value='0-10000'>0-10000</option>
                    <option value='10000-20000'>10000-20000</option>
                </select>

                <select onChange={(event) => this.changeOrderBy(event.target.value)}>
                    <option selected>Order by</option>
                    <option value='newest'>Newest</option>
                    <option value='oldest'>Oldest</option>
                    <option value='priceDescending'>Price Descending</option>
                    <option value='priceAscending'>Price Ascending</option>

                </select>
            </div>
        )
    };


};

export default ProductsFilters;