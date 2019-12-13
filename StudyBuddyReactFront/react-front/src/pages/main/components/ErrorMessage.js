import React from "react"

import Col from "react-bootstrap/Col"

import "../styles/ErrorMessage.css"

class ErrorMessage extends React.Component {

    render() {
        return (
            <Col lg={{ span: 12 }} >
                <div className={this.props.handleSuccess ? "search-success-error-wrapper" : "hidden search-success-error-wrapper"}>
                    Successfully matched !
                    </div>
            </Col>
        )
    }
}

export default ErrorMessage