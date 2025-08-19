//Function base componant 
import  react  from "react";
import Navbar from "./Navbar";
import Header from './Header';
import About  from "./About";
import Device from "./Device";
import Age from "./Age";
import Download from "./Download";
import Footer from "./Footer";
import "./App.css";
import App2 from "./App2";

function App(){
  return (
    <div>
      <Navbar/>
      <Header/>
      <About/>
      <Device/>
      <Age/>
      <Download/>
      <App2/>
      <Footer/>
      
    </div>
  )
}
export default App;