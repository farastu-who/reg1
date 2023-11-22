import './CompanyProfile.scss'
import { useParams } from "react-router-dom"
import { CheckBoxComponent, ButtonComponent } from "@syncfusion/ej2-react-buttons";
import { DropDownListComponent } from '@syncfusion/ej2-react-dropdowns';

export const CompanyProfile = (props) => {

    // Note: Does not currently verify if company exists when
    // you type in /companies/Company-Name




    const {name} = useParams()

    const companyUsers = ['Jane Doe', 'John Doe', 'Jenny Doe']

    const primaryContact = ['Jane Doe','1234567890','jane.doe@hitachienergy.com']

    return(
        <div id="cmpny-profile">
            <h1>{name}</h1>
            <h3>ID : 4</h3>

            <form>
                {/* ----- Company Details ----- */}
                <div className="form-section">
                <legend>Company Details</legend>

                <section id='company-details'>
                {/* Company Name */}
                <div className='field' id='company-name'>
                <label className="e-label-top" htmlFor="name">Name</label>
                <input className="e-input" type="text" placeholder={name} />
                </div>

                {/* Company Prefix */}
                <div className='field' id='prefix'>
                <label className="e-label-top" htmlFor="name">Prefix</label>
                <input className="e-input" type="text" placeholder={'prefix'} />
                </div>

                {/* Status Dropdown */}
                <div className='field' id='status'>
                <label className="e-label-top" htmlFor="name">Status</label>
                <input className="e-input" type="text" placeholder={'status'} />
                </div>

                {/* Suite */}
                <div className='field' id='suite'>
                <label className="e-label-top" htmlFor="name">Suite</label>
                <input className="e-input" type="text" placeholder={'Suite'} />
                </div>

                {/* Street Address */}
                <div className='field' id='street-address'>
                <label className="e-label-top" htmlFor="name">Street Address</label>
                <input className="e-input" type="text" placeholder={'Street Address'} />
                </div>

                {/* City */}
                <div className='field' id='city'>
                <label className="e-label-top" htmlFor="name">City</label>
                <input className="e-input" type="text" placeholder={'City'} />
                </div>


                {/* Country */}
                <div className='field' id='country'>
                <label className="e-label-top" htmlFor="name">Country</label>
                <input className="e-input" type="text" placeholder={'Country'} />
                </div>

                {/* State */}
                <div className='field' id='state'>
                <label className="e-label-top" htmlFor="name">State</label>
                <input className="e-input" type="text" placeholder={'State'} />
                </div>

                {/* Postal Code */}
                <div className='field' id='postal-code'>
                <label className="e-label-top" htmlFor="name">Postal Code</label>
                <input className="e-input" type="text" placeholder={'Postal Code'} />
                </div>

                <CheckBoxComponent label="Requires VSO Approval" />
                </section>
                </div>

                <br/>

                {/* ----- Primary Contact ----- */}

                <div className="form-section">
                <legend>Primary Contact</legend>

                <section id='primary-contact'>

                <div className='field' id='contact-name'>  
                {/* Primary Contact Name */}
                <label className="e-label-top" htmlFor="name">Name</label>
                <DropDownListComponent id="primary-contact-dropdown" dataSource={companyUsers} placeholder={companyUsers[0]}/>
                </div>

                {/* Primary Contact Phone */}
                <div className='field' id='contact-phone'>
                <label className="e-label-top" htmlFor="name">Phone Number</label>
                <input className="e-input" type="text" placeholder={primaryContact[1]} />
                </div>

                {/* Primary Contact Email */}
                <div className='field' id='contact-email'>
                <label className="e-label-top" htmlFor="name">Email Address</label>
                <input className="e-input" type="text" placeholder={primaryContact[2]} />
                </div>

                </section>
                </div>

                <br/>

                {/* ----- Buttons ----- */}
                <ButtonComponent>Cancel</ButtonComponent>
                <ButtonComponent>Update</ButtonComponent>
                
                
            </form>
        </div>
    )
}