import { Link } from 'react-router-dom';
import { ActionButton } from '../components/ActionButton/ActionButton';
import { ColumnDirective, ColumnsDirective, GridComponent, Inject, Sort, Search, Toolbar, Page,CommandColumn } from '@syncfusion/ej2-react-grids';
import { MessageComponent } from '@syncfusion/ej2-react-notifications';
import { useAppContext } from '../context/AppContext';

export const Companies = ({toggleSidebar}) => {

    const {openSidebar,currentAction,updateCurrentAction} = useAppContext()

    const data = [
        {
            'CompanyID' : 1,
            'CompanyName' : 'Hitachi Energy',
            'Address' : '123 Interlocken Pkwy, Broomfield, CO 80300',
            'PrimaryContact' : 'Linda Molyneux',
            'NextExpiration' : '4/16/2023'
        },
        {
            'CompanyID' : 2,
            'CompanyName' : 'Fake Company',
            'Address' : '123 Park St, City, CO 12345',
            'PrimaryContact' : 'Jane Doe',
            'NextExpiration' : '4/20/2023'
        }
    ]

    let grid;

    const handleActionClick = (action) => {
        console.log(`handleActionClick : ${action}`)
        updateCurrentAction(action)
        openSidebar()
        console.log(`${action} initiated`)
    }


    const sortingOptions = {
        columns:[{ field: 'NextExpiration', direction: 'Ascending'}]
    };

    
    const commands = [
        {
            buttonOption: {
                content: 'Renew', cssClass: 'e-flat'
            }
        }
    ];

    const commandClick = (args) => {
        if (grid) {
            console.log(args.rowData.CompanyName)
            handleActionClick('renew_company')
        }
    };

    const toolbarOptions = ['Search'];

    const companyNameTemplate = (props) => {
        const companyUrl = `/companies/${props.CompanyName.replace(/\s/g, '-')}`
      
        return (
          <Link to={companyUrl} style={{'color' : 'black'}}>{props.CompanyName}</Link>
        )
    };

    return(
        <div id='companies'>

            

            <h1>Companies</h1>

            {/* Possible Warning Message */}
            <MessageComponent 
            id="msg_warning" 
            content="There are 20 companies with upcoming expirations." 
            severity="Warning">
            </MessageComponent>
            
            <GridComponent dataSource={data} allowSorting={true} sortSettings={sortingOptions} toolbar={toolbarOptions} allowPaging={true} commandClick={commandClick} ref={g => grid = g}>
                <ColumnsDirective>
                    <ColumnDirective field='CompanyID' headerText='ID' width='50'/>
                    <ColumnDirective field='CompanyName' headerText='Company Name' width='175' template={companyNameTemplate}/>
                    <ColumnDirective field='Address' />
                    <ColumnDirective field='PrimaryContact' headerText='Primary Contact' width='150'/>
                    <ColumnDirective field='NextExpiration' headerText='Next Expiration' width='150'/>
                    <ColumnDirective headerText='Options' width='120' commands={commands}/>
                </ColumnsDirective>
                <Inject services={[Sort, Search, Toolbar, Page, CommandColumn]}/>
            </GridComponent>
            <div className='btn-container'>
            <ActionButton id='add-cmpny-btn' handleClick={() => handleActionClick('add_company')} label='+' />
            </div>
        </div>
    )
}
