//Function base componant 
import  react  from "react";
import Navbar from "../Navbar";
import Header from './Header';
import About  from "./About";
import Device from "./Device";
import Age from "./Age";
import Download from "./Download";
import Footer from "./Footer";


function HomePage(){
  return (
    <div>
      <Navbar/>
      <Header/>
      <About/>
      <Device/>
      <Age/>
      <Download/>
      <Footer/>
    </div>
  )
}
export default HomePage;