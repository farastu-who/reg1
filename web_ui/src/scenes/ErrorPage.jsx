export const ErrorPage = ({errorTitle,errorMessage}) => {
    return(
        <>
        <h1>{errorTitle}</h1>
        <p>{errorMessage}</p>
        </>
    )
}