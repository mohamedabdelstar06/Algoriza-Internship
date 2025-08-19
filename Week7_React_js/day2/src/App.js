import React, { Component } from "react";
import HomePage from "./Home Page/HomePage";
import Cart from "./Cart";
import "./App.css";

export class App extends Component {
  

  render(props) {

    return (
      <div className="text-center">
        <HomePage />
        <br></br>
        <br></br>
        <br></br>
        <Cart/>
       
      </div>
    );
  }
}

export default App;














/*
  state = {
    persons: [
      { name: "Ali", age: "54" , id :1},
      { name: "Abdelstar", age: "60", id :2},
      { name: "Yousef", age: "90",id :3 },
      { name: "Esraa", age: "12" ,id :4},
      { name: "Amira", age: "30" ,id :5},
    ],
  };



  SwitchName = () => {
    this.setState({
      persons: [
        { name: "Omar", age: "40" },
        { name: "Mostafa", age: "55" },
        { name: "Sara", age: "25" },
      ],
    });
  };
*/