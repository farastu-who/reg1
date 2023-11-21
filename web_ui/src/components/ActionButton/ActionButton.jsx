import './ActionButton.scss'

export const ActionButton = ({handleClick,label}) => {
    return (
        <div className="actn-btn" onClick={() => handleClick()}>
        {label !== '' ? label : 'label'}
        </div>
    )
}