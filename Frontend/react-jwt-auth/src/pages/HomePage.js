import axios from "axios";
import { useEffect, useState } from "react";
import { Carousel,Card,Button,Row,Col,Pagination } from "react-bootstrap";
import { useHistory } from "react-router-dom";


function HomePage() {

  const [userData, setUserData] = useState()

  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(()=> {
    getUserData();
  }, [])

  function handleClick() {
    window.location.href = '/login';
    localStorage.removeItem("token");
  }

  function getUserData() {
    axios.get("https://localhost:7074/api/Authenticate/Me")
      .then(response => {
        setUserData(response.data);
        console.log(userData);
      })
      .catch(err => console.log(err));
  } 
  
    return (
      <div>
        <header className="p-3 bg-dark text-white">
    <div className="container">
      <div className="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
        <a href="/" className="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none">
          {/* <svg className="bi me-2" width="40" height="32" role="img" aria-label="Bootstrap"><use xlink:href="#bootstrap"></use></svg> */}
        </a>

        <ul className="nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
          <li><a href="#" className="nav-link px-2 text-secondary">Home</a></li>
          <li><a href="#" className="nav-link px-2 text-white">Features</a></li>
          <li><a href="#" className="nav-link px-2 text-white">Pricing</a></li>
          <li><a href="#" className="nav-link px-2 text-white">FAQs</a></li>
          <li><a href="#" className="nav-link px-2 text-white">About</a></li>
        </ul>

        <form className="col-12 col-lg-auto mb-3 mb-lg-0 me-lg-3" role="search">
          <input type="search" className="form-control form-control-dark text-white bg-dark" placeholder="Search..." aria-label="Search"/>
        </form>

        <div className="text-end d-flex align-items-center justify-content-center">
        <ul className="nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
          <li className="m-1">{userData ? <h3>{userData.userName}</h3> : null}</li>
          <li className="m-1">{userData ? <h3>{userData.email}</h3> : null}</li>
          <li className="m-1">{userData ? <h3>{userData.role}</h3> : null}</li>
        </ul>
          <button type="button" className="btn btn-warning m-2" onClick={ () => handleClick()} >Logout</button>
        </div>
      </div>
    </div>
  </header>

  <Carousel>
  <Carousel.Item>
    <img
      className="slide d-block w-100"
      src="https://wallpaperaccess.com/full/284466.jpg"
      alt="First slide"
    />
    <Carousel.Caption>
      <h3>Найкраші ціни</h3>
      <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
    </Carousel.Caption>
  </Carousel.Item>
  <Carousel.Item>
    <img
      className="slide d-block w-100"
      src="https://cdn.wallpapersafari.com/56/34/s3TwbF.jpg"
      alt="Second slide"
    />

    <Carousel.Caption>
      <h3>Незабутні подорожі</h3>
      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
    </Carousel.Caption>
  </Carousel.Item>
  <Carousel.Item>
    <img
      className="slide d-block w-100"
      src="https://cdn.wallpapersafari.com/95/23/JzxVkO.jpg"
      alt="Third slide"
    />

    <Carousel.Caption>
      <h3>Багато років на ринку</h3>
      <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
    </Carousel.Caption>
  </Carousel.Item>
</Carousel>



      <div className="cards m-5">
        <Row>
          {[0,1,2,3].map(item => (
            <Col className="m-3">
      <Card>
      <Card.Img variant="top" src="https://wallpapercave.com/wp/4xZdAJ6.jpg" />
      <Card.Body>
      <Card.Title>Card Title</Card.Title>
      <Card.Text>
      Some quick example text to build on the card title and make up the bulk of
      the card's content.
      </Card.Text>
      <Button variant="dark">Дізнатись більше</Button>
      </Card.Body>
      </Card>
      </Col>
      ))}
      </Row>
      <Row>
          {[0,1,2,3].map(item => (
            <Col className="m-3">
      <Card>
      <Card.Img variant="top" src="https://wallpapercave.com/wp/4xZdAJ6.jpg" />
      <Card.Body>
      <Card.Title>Card Title</Card.Title>
      <Card.Text>
      Some quick example text to build on the card title and make up the bulk of
      the card's content.
      </Card.Text>
      <Button variant="dark">Дізнатись більше</Button>
      </Card.Body>
      </Card>
      </Col>
      ))}
      </Row>
      </div>

      <Pagination className="d-flex justify-content-center">
  <Pagination.First />
  <Pagination.Prev />
  <Pagination.Item>{1}</Pagination.Item>
  <Pagination.Ellipsis />

  <Pagination.Item>{10}</Pagination.Item>
  <Pagination.Item>{11}</Pagination.Item>
  <Pagination.Item active>{12}</Pagination.Item>
  <Pagination.Item>{13}</Pagination.Item>
  <Pagination.Item disabled>{14}</Pagination.Item>

  <Pagination.Ellipsis />
  <Pagination.Item>{20}</Pagination.Item>
  <Pagination.Next />
  <Pagination.Last />
</Pagination>

          <div className="container">
  <footer className="py-4 my-4">
    <ul className="nav justify-content-center border-bottom pb-3 mb-3">
      <li className="nav-item"><a href="#" className="nav-link px-2 text-muted">Home</a></li>
      <li className="nav-item"><a href="#" className="nav-link px-2 text-muted">Features</a></li>
      <li className="nav-item"><a href="#" className="nav-link px-2 text-muted">Pricing</a></li>
      <li className="nav-item"><a href="#" className="nav-link px-2 text-muted">FAQs</a></li>
      <li className="nav-item"><a href="#" className="nav-link px-2 text-muted">About</a></li>
    </ul>
    <p className="text-center text-muted">© 2022 Company, Inc</p>
  </footer>
</div>
      </div>
    );
  }
export default HomePage;