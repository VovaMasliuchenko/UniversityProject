import React from "react";
import { Redirect, Switch, Route, Router, BrowserRouter } from "react-router-dom";
import RouteGuard from "./components/RouteGuard"

//pages
import HomePage from "./pages/HomePage"
import LoginPage from "./pages/Login"

function Routes() {
    return (
        <BrowserRouter>
            <Switch>
                <RouteGuard
                    exact
                    path="/home"
                    component={HomePage}
                />
                <Route
                    path="/login"
                    component={LoginPage}
                />
            </Switch>
        </BrowserRouter>
    );
}

export default Routes
