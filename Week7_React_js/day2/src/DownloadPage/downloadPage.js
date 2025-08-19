import React, { Component } from 'react'
import Navbar from '../Navbar'
import Download from '../Home Page/Download'
import Footer from '../Home Page/Footer'

class DownloadPage extends Component {
  render() {
    return (
      <div>
        <Navbar/>
        <Download/>
        <Footer/>
      </div>
    )
  }
}

export default DownloadPage;
