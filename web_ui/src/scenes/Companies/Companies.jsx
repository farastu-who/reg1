import './Companies.scss'
import { Link } from 'react-router-dom';
import { ActionButton } from '../../components/ActionButton/ActionButton';
import { ColumnDirective, ColumnsDirective, GridComponent, Inject, Sort, Search, Toolbar, Page } from '@syncfusion/ej2-react-grids';
import { MessageComponent } from '@syncfusion/ej2-react-notifications';

export const Companies = () => {


    const data = [
        {
            'CompanyID' : '1',
            'CompanyName' : 'Hitachi Energy',
            'Address' : '123 Interlocken Pkwy, Broomfield, CO 80300',
            'PrimaryContact' : 'Linda Molyneux',
            'NextExpiration' : '4/16/2023',
            'Options' : 'Edit'
        },
        {
            'CompanyID' : '2',
            'CompanyName' : 'Fake Company',
            'Address' : '123 Park St, City, CO 12345',
            'PrimaryContact' : 'Jane Doe',
            'NextExpiration' : '4/20/2023',
            'Options' : 'Edit'
        }
    ]

    const sortingOptions = {
        columns:[{ field: 'NextExpiration', direction: 'Ascending'}]
    };

    const toolbarOptions = ['Search'];

    const companyNameTemplate = (props) => {
        const companyUrl = `/companies/${props.CompanyName.replace(/\s/g, '-')}`;
      
        return (
          <Link to={companyUrl} style={{'color' : 'black'}}>{props.CompanyName}</Link>
        );
    };

    const companyOptionsTemplate = (props) => {
        // const companyUrl = `/companies/${props.CompanyName.replace(/\s/g, '-')}`;

        return (
            <>
            <button>Renew</button>
            </>
        )
    }

    return(
        <div className='Companies'>

            

            <h1>Companies</h1>

            {/* Possible Warning Message */}
            <MessageComponent 
            id="msg_warning" 
            content="There are 20 companies with upcoming expirations." 
            severity="Warning">
            </MessageComponent>
            
            <GridComponent dataSource={data} allowSorting={true} sortSettings={sortingOptions} toolbar={toolbarOptions} allowPaging={true} >
                <ColumnsDirective>
                    <ColumnDirective field='CompanyID' headerText='ID' width='50'/>
                    <ColumnDirective field='CompanyName' headerText='Company Name' width='200' template={companyNameTemplate}/>
                    <ColumnDirective field='Address' />
                    <ColumnDirective field='PrimaryContact' headerText='Primary Contact' width='175'/>
                    <ColumnDirective field='NextExpiration' headerText='Next Expiration' width='150'/>
                    <ColumnDirective field='Options' textAlign='right' width='125' template={companyOptionsTemplate}/>
                </ColumnsDirective>
                <Inject services={[Sort, Search, Toolbar, Page]}/>
            </GridComponent>
            <div className='btn-container'>
            <ActionButton id='add-cmpny-btn' handleClick={() => console.log('click')} label='+' />
            </div>
        </div>
    )
}

export default Companies;