import React from "react";
import { Redirect, Switch, Route, Router, BrowserRouter } from "react-router-dom";
import RouteGuard from "./components/RouteGuard"

//pages
import HomePage from "./pages/HomePage"
import LoginPage from "./pages/Login"
import Register from "./pages/Register";

function Routes() {
    return (
        <BrowserRouter>
            <Switch>
                <RouteGuard
                    exact
                    path="/"
                    component={HomePage}
                />
                <Route
                    path="/login"
                    component={LoginPage}
                />
                <Route
                    path="/register"
                    component={Register}
                />
            </Switch>
        </BrowserRouter>
    );
}

export default Routes
