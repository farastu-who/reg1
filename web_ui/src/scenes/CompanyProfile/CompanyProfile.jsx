import './CompanyProfile.scss'
import { useParams } from "react-router-dom"
import { CheckBoxComponent, ButtonComponent } from "@syncfusion/ej2-react-buttons";
import { DropDownListComponent } from '@syncfusion/ej2-react-dropdowns';

export const CompanyProfile = (props) => {

    const {name} = useParams();

    const companyUsers = ['Jane Doe', 'John Doe', 'Jenny Doe'];

    const primaryContact = ['Jane Doe','1234567890','jane.doe@hitachienergy.com']

    return(
        <div className="cmpny-profile">
            <h1>{name}</h1>
            <h3>ID : 4</h3>

            <form>
                {/* ----- Company Details ----- */}
                <div className="form-section">
                <h4>Company Details</h4>

                {/* Company Name */}
                <label className="e-label-top" htmlFor="name">Name</label>
                <input className="e-input" type="text" placeholder={name} />
                

                {/* Company Prefix */}
                <label className="e-label-top" htmlFor="name">Prefix</label>
                <input className="e-input" type="text" placeholder={'prefix'} />

                {/* Status Dropdown */}

                {/* Street Address */}
                <label className="e-label-top" htmlFor="name">Street Address</label>
                <input className="e-input" type="text" placeholder={'Street Address'} />

                {/* Suite */}
                <label className="e-label-top" htmlFor="name">Suite</label>
                <input className="e-input" type="text" placeholder={'Suite'} />

                {/* Country */}
                <label className="e-label-top" htmlFor="name">Country</label>
                <input className="e-input" type="text" placeholder={'Country'} />

                {/* State */}
                <label className="e-label-top" htmlFor="name">State</label>
                <input className="e-input" type="text" placeholder={'State'} />

                {/* Zip Code */}
                <label className="e-label-top" htmlFor="name">Zip Code</label>
                <input className="e-input" type="text" placeholder={'Zip Code'} />

                <CheckBoxComponent label="Requires VSO Approval" />

                </div>

                <br/>

                {/* ----- Primary Contact ----- */}

                <div className="form-section">

                <h4>Primary Contact</h4>

                {/* Primary Contact Name */}
                <label className="e-label-top" htmlFor="name">Name</label>
                <DropDownListComponent id="primary-contact" dataSource={companyUsers} placeholder={companyUsers[0]}/>

                {/* Primary Contact Phone */}
                <label className="e-label-top" htmlFor="name">Phone Number</label>
                <input className="e-input" type="text" placeholder={primaryContact[1]} />

                {/* Primary Contact Email */}
                <label className="e-label-top" htmlFor="name">Email Address</label>
                <input className="e-input" type="text" placeholder={primaryContact[2]} />

                </div>

                <br/>

                {/* ----- Buttons ----- */}
                <ButtonComponent>Cancel</ButtonComponent>
                <ButtonComponent>Update</ButtonComponent>
                
                
            </form>
        </div>
    )
}