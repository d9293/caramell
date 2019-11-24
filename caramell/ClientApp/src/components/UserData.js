import React, { Component } from 'react';

export class UserData extends Component {
    static displayName = UserData.name;

    constructor(props) {
        super(props);
        this.state = { users: [], loading: true };
    }

    componentDidMount() {
        this.populateUserData();
    }

    render() {
        // let contents = this.state.loading
        //   ? <p><em>Loading...</em></p>
        //   : FetchData.renderForecastsTable(this.state.forecasts);
        const { users } = this.state;
        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>id</th>
                            <th>name</th>
                            <th>surname</th>
                            <th>middlename</th>
                        </tr>
                    </thead>
                    <tbody>
                        {users.map(d =>
                            <tr key={d.id}>
                                <td>{d.id}</td>
                                <td>{d.name}</td>
                                <td>{d.surname}</td>
                                <td>{d.middlename}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    async populateUserData() {
        const response = await fetch('api/weatherforecast/GetUsers');
        const data = await response.json();
        this.setState({ users: data, loading: false });
    }
}