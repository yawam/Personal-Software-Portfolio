import React, { useState } from "react";

function Form() {

  const [name, setName] = useState("");

  const clockIn = new Date().toLocaleTimeString();
  const [In, setIn] = useState("");
  const clockOut = new Date().toLocaleTimeString();
  const [Out, setOut] = useState("");

  function handleName(event) {
    setName(event.target.value);

  }

  function handleClockIn(e) {
    e.preventDefault();
    setIn(clockIn)
    console.log(`${name} clocked in at ${In}`);
  }


  function handleClockOut(e) {
    e.preventDefault();
    setOut(clockOut)
    console.log(`${name} clocked out at ${Out}`);
  }

  return (
    <div>
      <h1>Clock In</h1>
      <div>
        <form className="form">
        
          <label>
            Enter Your Name:
            <input onChange={handleName} type="text" name="name" value={name} />
          </label>
          <button onClick={handleClockIn}>Clock-In</button>
          <button onClick={handleClockOut}> Clock-Out</button>
        </form>
      </div>
      <div>
            <table>
            <thead>
            <tr>
                    <th>Employee Name</th>
                    <th>Time-In</th>
                    <th>Time-Out</th>
                </tr>
            </thead>
            <tbody>
            <tr>
                    <td>{name}</td>
                    <td>{In }</td>
                    <td>{Out}</td>
                </tr>
            </tbody>
                
                
            </table>
        </div>
    </div>
  );
}

export default Form;
