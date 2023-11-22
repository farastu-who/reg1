import './Sidebar.scss'
import { useAppContext } from '../../context/AppContext';
import { AddCompanySidebar } from './AddCompanySB';
import { RenewCompanySidebar } from './RenewCompanySB';

export const MySidebar = () => {

  const {isSidebarOpen,closeSidebar,currentAction,updateCurrentAction} = useAppContext()

  const company = {
    'CompanyID' : '1',
    'CompanyName' : 'Hitachi Energy'
  }


  const onClose = () => {
    updateCurrentAction(null)
    closeSidebar()
    console.log(`Sidebar closed : ${currentAction}`)
  }

  if(!isSidebarOpen){
    return null
  }

  return (

    <div className={`cstm-sidebar-${isSidebarOpen ? 'open' : 'close'}`}>
      <div className='sidebar-content'>

        {/* Close Sidebar Button */}
        <button id='close-btn' onClick={() => onClose()}>X</button>
        
        {/* --- Map currentAction to sidebar content --- */}
        {currentAction === 'add_company' ? <AddCompanySidebar/> : null}
        {currentAction === 'renew_company' ? <RenewCompanySidebar company={company}/> : null}
        
      </div>


    </div>
  )
}

