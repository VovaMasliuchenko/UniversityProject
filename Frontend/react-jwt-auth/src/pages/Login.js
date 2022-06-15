import React from "react";
import axios from "axios";
import { setAuthToken } from "../helpers/setAuthToken"
import { getFormJSON } from "../helpers/formParser";
import Routes from "../routes";

function Login() {

  const handleSubmit = (form) => {
    //reqres registered sample user
    const loginPayload = getFormJSON(form);

    console.log(loginPayload);
    axios.post("https://localhost:7074/api/Authenticate/login", loginPayload)
      .then(response => {
        //get token from response
        const token = response.data.token;

        //set JWT token to local
        localStorage.setItem("token", token);

        //set token to axios common header
        setAuthToken(token);

        //redirect user to home page
        window.location.href = '/'

      })
      .catch(err => console.log(err));
  };

  return (
    <main className="form-container form-signin m-auto mt-5">
  <form 
  onSubmit={(event) => {
        event.preventDefault()
        const form = event.target;
        handleSubmit(form);
      }}>
    <h1 className="h3 mb-3 fw-normal">Welcome</h1>

    <div className="form-floating">
      <input type="text" className="form-control" id="username" name="username" placeholder="Name"/>
      <label htmlFor="username">Username</label>
    </div>
    <div className="form-floating">
      <input type="password" className="form-control" id="password" name="password" placeholder="Password"/>
      <label htmlFor="password">Password</label>
    </div>

    <div className="checkbox mb-3">
      <label>
        <input type="checkbox" value="remember-me"/> Remember me
      </label>
    </div>
    <button className="w-100 btn btn-lg btn-primary" type="submit" value="Submit">Sign in</button>
    <button className="w-50 btn btn-lg btn-primary mt-2" onClick={() => window.location.href = '/register'}>Register</button>
  </form>
</main>
  );
}
export default Login