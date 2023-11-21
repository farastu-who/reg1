import './App.scss'
import { useEffect } from 'react';
import { Routes, Route, Navigate, useLocation } from 'react-router-dom';
import NavBar from './components/NavBar/NavBar';
import { Companies } from './scenes/Companies/Companies';
import { Products } from './scenes/Products/Products';
import { About } from './scenes/About/About';
import { ErrorPage } from './scenes/ErrorPage';
import { Breadcrumb } from './components/Breadcrumb/Breadcrumb';
import { CompanyProfile } from './scenes/CompanyProfile/CompanyProfile';

function App() {



  // Location is updated anytime the path changes... used for Breadcrumb and NavBar
  const location = useLocation();

  useEffect(() => {
    console.log('Changed location: ', location)
  },[location])


  return (
    <div className="App">

      {/* ------- NavBar ------- */}
      <NavBar location={location}/>

      {/* ------- Content ------- */}
      <div className='Content'>

        <div className="content-section">

          {/* ------- Breadcrumb ------- */}
          <Breadcrumb className='Breadcrumb' location={location}/>
          
          <Routes>
            <Route exact path='/' element={<Navigate to="/companies" replace={true} />}/>
            <Route path="/about" element={<About/>}/>
            <Route path="/products" element={<Products/>} />
            <Route path="/companies" element={<Companies/>}/>
            <Route path='/companies/:name' element={<CompanyProfile/>}/>


            {/* Path does not exist */}
            <Route path="*" element={
              <ErrorPage 
                errorTitle={'400 Bad Request'} 
                errorMessage={'The webpage cannot be found. Endpoint does not exist, or the format of path was incorrect. Check to see if you mistyped the URL.'}
              />
            } />
          </Routes>
          

        </div>

      </div>




      

    </div>


  );

}

export default App;
