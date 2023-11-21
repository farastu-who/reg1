import './Products.scss'
import { ColumnDirective, ColumnsDirective, GridComponent, Toolbar, ExcelExport, Inject} from '@syncfusion/ej2-react-grids';

export const Products = () => {


    const data = [
        {
            'ProductName' : 'AcuPower',
            'LicensedUsers' : 4,
            'ActiveUsers' : 16,
            'ViewCompanies' : 'Dropdown'
        },
        {
            'ProductName' : 'C Three Group Financials',
            'LicensedUsers' : 2,
            'ActiveUsers' : 10,
            'ViewCompanies' : 'Dropdown'
        },
        {
            'ProductName' : 'Client Imports',
            'LicensedUsers' : 10,
            'ActiveUsers' : 10,
            'ViewCompanies' : 'Dropdown'
        }
    ]

    let grid;
    const toolbar = ['ExcelExport'];
    const toolbarClick = (args) => {
        if (grid && args.item.id === 'grid_excelexport') {
            grid.excelExport();
        }
    };


    return(
        <div className='Products'>
            <h1>Products</h1>

            <GridComponent id='grid' dataSource={data} toolbar={toolbar} allowExcelExport={true} toolbarClick={toolbarClick} ref={g => grid = g} >
                <ColumnsDirective>
                    <ColumnDirective field='ProductName'/>
                    <ColumnDirective field='LicensedUsers'/>
                    <ColumnDirective field='ActiveUsers'/>
                    <ColumnDirective field='ViewCompanies'/>
                </ColumnsDirective>
                <Inject services={[Toolbar,ExcelExport]}/>
            </GridComponent>
        </div>
    )
}

export default Products;