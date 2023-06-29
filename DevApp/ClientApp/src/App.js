import { useEffect, useState } from "react";

const App = () => {
    const [developer, setDeveloper] = useState([])
    const [showForm, setShowForm] = useState(false)
    const [updateDeveloper, setUpdateDeveloper] = useState(false)
    const [fromData, setFormData] = useState({
        id: "",
        name: "",
        founded: "",
        headquarters: ""
    })

    const fetchDevelopers = () => {
        fetch("api/Developer/AllDevelopers")
            .then(response => { return response.json() })
            .then(responseJson => {
                setDeveloper(responseJson)
            })
            .catch(error => {
                console.error(error);
            })
    }

    useEffect(() => {
        fetchDevelopers();
    }, [])

    const handleDeveloperUpdate = developerInfo => {
        setFormData({
            id: developerInfo.id,
            name: developerInfo.name,
            founded: developerInfo.founded,
            headquarters: developerInfo.headquarters
        })
        setShowForm(true);
        setUpdateDeveloper(true);
    }

    const handleDeveloperDelete = developerId => {
        fetch(`api/Developer/DeleteDeveloper/${developerId}`, {
            method: "DELETE"
        })
            .then(() => {
                fetchDevelopers();
                console.log("Developer Deleted.");
            })
            .catch(error => {
                console.error(error);
            })
    }

    //useEffect(() => {
    //    fetch("api/Developer/AllDevelopers")
    //        .then(response => { return response.json() })
    //        .then(responseJson => {

    //            setDeveloper(responseJson)
    //        })
    //}, [])

    return (
        <div className="container">
            <h1>Developers</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Name</th>
                                <th>Founded</th>
                                <th>Headquarters</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                developer.map((developers) => (
                                    <tr>
                                        <td>{developers.id}</td>
                                        <td>{developers.name}</td>
                                        <td>{developers.founded}</td>
                                        <td>{developers.headquarters}</td>
                                        <td>
                                            <button onClick={() => handleDeveloperUpdate(developers)}>Update</button>
                                        </td>
                                        <td>
                                            <button onClick={() => handleDeveloperDelete(developers.id)}>Delete</button>
                                        </td>
                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </div>)
}

export default App;