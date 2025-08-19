import React, { Component } from "react";
import { Card, Button, CardBody, CardSubtitle, CardTitle, CardText, Container, Col, Row ,Table} from "reactstrap";
class Cart extends Component {


  render() {
    return (
      <div>
        <Container md="floid" >
          <Row>
            <Col md="3" className="mb-4 d-flex justify-content-center">

              <Card
                style={{
                  width: '18rem'
                }}
              >
                <img
                  alt="Sample"
                  src="https://picsum.photos/300/200"
                />
                <CardBody>
                  <CardTitle tag="h5">
                    Card title
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    Card subtitle
                  </CardSubtitle>
                  <CardText>
                    Some quick example text to build on the card title and make up the bulk of the card‘s content.
                  </CardText>
                  <Button>
                    Button
                  </Button>
                </CardBody>
              </Card>
            </Col>
            <Col md="3" className="mb-4 d-flex justify-content-center">

              <Card
                style={{
                  width: '18rem'
                }}
              >
                <img
                  alt="Sample"
                  src="https://picsum.photos/300/200"
                />
                <CardBody>
                  <CardTitle tag="h5">
                    Card title
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    Card subtitle
                  </CardSubtitle>
                  <CardText>
                    Some quick example text to build on the card title and make up the bulk of the card‘s content.
                  </CardText>
                  <Button>
                    Button
                  </Button>
                </CardBody>
              </Card>
            </Col>






            <Col md="3" className="mb-4 d-flex justify-content-center">

              <Card
                style={{
                  width: '18rem'
                }}
              >
                <img
                  alt="Sample"
                  src="https://picsum.photos/300/200"
                />
                <CardBody>
                  <CardTitle tag="h5">
                    Card title
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    Card subtitle
                  </CardSubtitle>
                  <CardText>
                    Some quick example text to build on the card title and make up the bulk of the card‘s content.
                  </CardText>
                  <Button>
                    Button
                  </Button>
                </CardBody>
              </Card>
            </Col>

            <Col md="3" className="mb-4 d-flex justify-content-center">

              <Card
                style={{
                  width: '18rem'
                }}
              >
                <img
                  alt="Sample"
                  src="https://picsum.photos/300/200"
                />
                <CardBody>
                  <CardTitle tag="h5">
                    Card title
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    Card subtitle
                  </CardSubtitle>
                  <CardText>
                    Some quick example text to build on the card title and make up the bulk of the card‘s content.
                  </CardText>
                  <Button>
                    Button
                  </Button>
                </CardBody>
              </Card>
            </Col>
          </Row>
        </Container>




        <br></br>
        <br></br>
        <br></br>

        <Table>
          <thead>
            <tr>
              <th>
                Class
              </th>
              <th>
                Heading
              </th>
              <th>
                Heading
              </th>
            </tr>
          </thead>
          <tbody>
            <tr className="table-primary">
              <td>
                primary
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-secondary">
              <td>
                secondary
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-success">
              <td> success </td>
              <td> Cell </td>
              <td> Cell</td>
            </tr>
            <tr className="table-danger">
              <td>
                danger
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-warning">
              <td>
                warning
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-info">
              <td>
                info
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-light">
              <td>
                light
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
            <tr className="table-dark">
              <td>
                dark
              </td>
              <td>
                Cell
              </td>
              <td>
                Cell
              </td>
            </tr>
          </tbody>
        </Table>
      </div>
    );
  }
}

export default Cart;



// changeName =(event)=>{
//     this.setState(
//       {
//        persons: [
//       { name: "Ali", age: "54" },
//       { name: event.target.value, age: "60" },
//       { name: "Yousef", age: "90" },
//     ],
//   }
//     )
//   }

//   state = {

//   persons: [
//     { name: "Ali", age: "54" },
//     { name: "Abdelstar", age: "60" },
//     { name: "Yousef", age: "90" },
//    ],
// };

