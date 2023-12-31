import { useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import './Breadcrumb.scss'
import { BreadcrumbComponent, BreadcrumbItemDirective, BreadcrumbItemsDirective } from '@syncfusion/ej2-react-navigations';

export const Breadcrumb = () => {

    const location = useLocation();

    useEffect(() => {

    },[location])

    const breadcrumbDirectives = () => {
        // Split the path by '/' characters
        const parts = location.pathname.split('/');

        // Capitalize each part and join them back with '/'
        const capitalizedParts = parts.map(part => part.charAt(0).toUpperCase() + part.slice(1));

        const breadcrumbs = capitalizedParts.map((part,index) => {

            if(part !== ''){
                const basePath = 'http://localhost:3000'
                const urlPath = `${basePath}${parts.slice(0, index + 1).join('/')}`;

                return(
                    <BreadcrumbItemDirective key={index} text={part} url={urlPath}/>
                );
            }else{
                return null
            }
        
        })

        return breadcrumbs;
    }


    return(
        <div className="breadcrumb">
            <BreadcrumbComponent enableNavigation={true}>
                <BreadcrumbItemsDirective>
                    {breadcrumbDirectives()}
                </BreadcrumbItemsDirective>
            </BreadcrumbComponent>
        </div>
    )
}