import * as React from "react";
import { createRoot } from "react-dom/client";
import {
  createBrowserRouter,
  RouterProvider,

} from "react-router-dom";
import App from "./App";
import FeaturesPage from "./Features/FeaturesPage";
import DownloadPage from "./DownloadPage/downloadPage";

const router = createBrowserRouter([
  {
    path: "/",
    element:<App/>,
  },
  {
    path: "features",
    element: <FeaturesPage/>,
  },
  {
    path: "download",
    element: <DownloadPage/>,
  },
]);

createRoot(document.getElementById("root")).render(
  <RouterProvider router={router} />
);    



// import React from 'react';
// import ReactDOM from 'react-dom/client';
// import './index.css';
// import App from './App.js';



// const root = ReactDOM.createRoot(document.getElementById('root'));
// root.render(
//   <React.StrictMode>
//     <App />
//     {/* <Navbar/> */}
//   </React.StrictMode>
// );


