import { useEffect, useState } from "react";

const App = () => {
    const [developer, setDeveloper] = useState([])
    const [showForm, setShowForm] = useState(false)
    const [updateDeveloper, setUpdateDeveloper] = useState(false)
    const [formData, setFormData] = useState({
        id: "",
        name: "",
        founded: "",
        headquarters: ""
    })
    //const [showAddForm, setShowAddForm] = useState(false)
    //const [addDeveloper, setAddDeveloper] = useState(false)
    //const [addFormData, setAddFormData] = useState({
    //    name: "",
    //    founded: "",
    //    headquarters: ""
    //})

    const fetchDevelopers = () => {
        fetch("api/Developer/AllDevelopers")
            .then(response => { return response.json() })
            .then(responseJson => {
                setDeveloper(responseJson)
                console.log(responseJson);
            })
            .catch(error => {
                console.error(error);
            })
    }

    useEffect(() => {
        fetchDevelopers();
    }, [])

    const handleFormSubmit = (e) => {
        e.preventDefault();
        if (!updateDeveloper) {
            fetch(`api/Developer/AddNewDeveloper`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(formData)
            })
            fetchDevelopers();
        }
        else {
            fetch(`api/Developer/UpdateDeveloper/${formData.id}`, {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(formData)
            })
            fetchDevelopers();
        }
    }

    const handleCancelButton = () => {
        setFormData({
            id: "",
            name: "",
            founded: "",
            headquarters: ""
        });
        setShowForm(false);
        setUpdateDeveloper(false);
    }

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

    const resetForm = () => {
        handleCancelButton();
        setShowForm(true);
    }

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
                    <button onClick={() => resetForm()}>Add Developer</button>
                    {showForm &&
                        <div>
                            <form onSubmit={handleFormSubmit}>
                                <div>
                                    <label>Developer Name:</label>
                                    <input type="text" placeholder="Enter Developer Name" id="formName" className="form-control" value={formData.name} onChange={(e) => setFormData({ ...formData, name: e.target.value })} required />
                                </div>
                                <div>
                                    <label>Date Founded:</label>
                                    <input type="text" placeholder="Enter the Date the Developer was Founded" id="formFounded" className="form-control" value={formData.founded} onChange={(e) => setFormData({ ...formData, founded: e.target.value })} required />
                                </div>
                                <div>
                                    <label>Developer Headquarters:</label>
                                    <input type="text" placeholder="Enter Developer Headquarter Location" id="formHeadquarters" className="form-control" value={formData.headquarters} onChange={(e) => setFormData({ ...formData, headquarters: e.target.value })} required />
                                </div>
                                <button type="submit">Submit</button>
                            </form>
                            <button onClick={() => handleCancelButton()}>Cancel</button>
                        </div>
                        }
                </div>
            </div>
        </div>)
}

export default App;