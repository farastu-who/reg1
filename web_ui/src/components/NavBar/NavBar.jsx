import './NavBar.scss'
import logo from '../../assets/hitachi-energy-mark-red.svg'
import { Link, useLocation } from 'react-router-dom';
import { useEffect } from 'react';

export const NavBar = () =>  {

  const location = useLocation();

  useEffect(() => {

  },[location])

    return (
        <div id="nav-bar">

        {/* Hitachi Energy logo */}
        <Link to='/about'>
          <img id='logo' src={logo} alt="Hitachi Energy logo" />
        </Link>
        

        <h1 id='title'>VS Registration</h1>
    
        {/* --- Nav-items --- */}
        <nav>
          {/* Companies Tab */}
          <Link to='/companies' className={`nav-tab ${location.pathname.includes('/companies') ? 'active' : ''}`}>
            Companies
          </Link>

          {/* Products Tab */}
          <Link to='/products' className={`nav-tab ${location.pathname.includes('/products') ? 'active' : ''}`}>
            Products
          </Link>
        </nav>
      </div>
    )
}