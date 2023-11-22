import './App.scss'
import { AppContextProvider } from './context/AppContext';
import { Layout } from './sections/Layout';

function App() {


  return (
    <div className="App">
      <AppContextProvider>
      <Layout/>
      </AppContextProvider>
    </div>


  )

}

export default App;
