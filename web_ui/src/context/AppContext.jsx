import React, { createContext, useContext, useReducer } from 'react';

const AppContext = createContext();


// Note to self : add companyId and then that can be referenced as actions are performed and updated.
// Plus, use react-router-dom useNavigation to make openning the sidebar its own path

// Questions for self: Is it better to have 2 methods for updating the current action: Initiate and terminate?
// Or is it fine to have it as a single UPDATE_CURRENT_ACTION?

const initialState = {
  isSidebarOpen: false,
  currentAction: null
};

const appReducer = (state, action) => {
    const {type,payload} = action


  switch (type) {
    case 'OPEN_SIDEBAR':
      return { ...state, isSidebarOpen: true }
    case 'CLOSE_SIDEBAR':
      return { ...state, isSidebarOpen: false }
    case 'UPDATE_CURRENT_ACTION':
        return {...state, currentAction: payload.currentAction}
    default:
      return state;
  }
};

const AppContextProvider = ({ children }) => {
  const [state, dispatch] = useReducer(appReducer, initialState);

  const openSidebar = () => {
    console.log('AppContext.jsx : open sidebar')
    dispatch(
        {
            type: 'OPEN_SIDEBAR', 
            payload: {
                isSidebarOpen : true
            }
        });
  };

  const closeSidebar = () => {
    console.log('AppContext.jsx : close sidebar')
    dispatch(
        {
            type: 'CLOSE_SIDEBAR', 
            payload: {
                isSidebarOpen : false
            }
        });
  };

  const updateCurrentAction = (action) => {
    console.log(`AppContext.jsx : updated action - ${action}`)
    dispatch(
        {
            type: 'UPDATE_CURRENT_ACTION', 
            payload: {
                currentAction: action
            }
        });
  }


  const value = {
    isSidebarOpen: state.isSidebarOpen,
    currentAction: state.currentAction,
    openSidebar,
    closeSidebar,
    updateCurrentAction
  }

  return (
    <AppContext.Provider value={value}>
      {children}
    </AppContext.Provider>
  );
};

const useAppContext = () => {
  const context = useContext(AppContext);
  if (!context) {
    throw new Error('useAppContext must be used within an AppContextProvider');
  }
  return context;
};

export { AppContextProvider, useAppContext };
