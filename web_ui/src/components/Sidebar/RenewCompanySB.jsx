export const RenewCompanySidebar = ({company}) => {

    const {CompanyName,CompanyID} = company;

    if(!company){
        return (
            <h1>Company not found.</h1>
        )
    }

    return (
        <>
            <h1>License Renewal</h1>
            <h3>{`${CompanyName} (ID : ${CompanyID})`}</h3>

            <form>
                {/* Earliest Expiring Product (Read Only) */}
                <section>
                
                    <h3>Earliest Expiring License</h3>

                    <h5>Start Date</h5>
                    <p>1/1/23</p>

                    <h5>End Date</h5>
                    <p>1/1/24</p>

                </section>


                {/* --- Company Info (Read Only) --- */}
                <section>

                    <h3>Company Info</h3>

                    <h5>Address</h5>
                    <p>Street Address</p>
                    <p>City, State Zip Code</p>

                    <h5>Primary Contact</h5>
                    <p>Contact Name</p>
                    <p>Contact Phone</p>
                    <p>Contact Email</p>

                    <h5>Last Validation</h5>
                    <p>1/1/23</p>

                </section>

                {/* --- Quick Action (Modify all products' start and end date) --- */}
                <section>
                    <h3>Quick Action</h3>

                    {/* Modify all start dates */}
                    <div className="form-field">
                        <label className="e-label-top" htmlFor="startDate">Start Date</label>
                        <input className="e-input" type="text" placeholder={'1/1/23'} />
                    </div>
                    {/* Modify all end dates */}
                    <div className="form-field">
                        <label className="e-label-top" htmlFor="endDate">End Date</label>
                        <input className="e-input" type="text" placeholder={'1/1/24'} />
                    </div>
                </section>

                {/* --- Individual Product Licensing --- */}
                <section>
                    <h3>Individual Product Licensing</h3>
                    
                    <ul>
                        <li>EV Power</li>
                        <li>New Entrants</li>
                        <li>Velocity Suite</li>
                    </ul>
                </section>
            </form>
            
            
        </>
    )
}