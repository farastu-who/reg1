import './Layout.scss'
import { NavBar } from "../components/NavBar/NavBar"
import { Breadcrumb } from "../components/Breadcrumb/Breadcrumb"
import { Companies } from "./Companies"
import { CompanyProfile } from "./CompanyProfile/CompanyProfile"
import { Products } from "./Products"
import { About } from './About'
import { ErrorPage } from './ErrorPage'
import { Route, Routes, Navigate } from "react-router-dom"
import { MySidebar } from '../components/Sidebar/Sidebar'
import { useAppContext } from '../context/AppContext'


export const Layout = () => {

    const {isSidebarOpen} = useAppContext()

    return(
        <>
        <header>
            {/* ------- NavBar ------- */}
            <NavBar/>
        </header>
        <main>

            <div className={`content-container ${isSidebarOpen ? 'sidebar-open' : ''}`}>


            {/* ------- Breadcrumb ------- */}
            <Breadcrumb/>



            {/* ----- Routes ----- */}
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

            {/* ----- Sidebar ----- */}
            <MySidebar />
        </main>
        <footer></footer>
        </>
    )

}