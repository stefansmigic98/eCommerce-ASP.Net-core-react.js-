import React from 'react';
import ReactDom from 'react-dom';
import { url } from '../consts';

class ProductPage extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            product: undefined
        };
    }

    componentDidMount() {
        const productID = this.props.match.params.id;
        fetch(url + '/products/' + productID)
            .then((result) => result.json())
            .then((data) => {

                this.setState({
                    product: data
                });
            });

    }

    render() {
        return (
            <div>
                <h3>Product Page</h3>
                {this.state.product ? <div><h3>{this.state.product.name}</h3>
                    <img src={url + '/' + this.state.product.imageUrl} />
                    <p>{this.state.product.price}</p>
                </div>
                    : <p>Loading</p>}

            </div>
        );
    };
};

export default ProductPage;