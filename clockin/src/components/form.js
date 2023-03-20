import React, { useState } from "react";

function Form() {
  const [name, setName] = useState("");

  const clockIn = new Date().toLocaleTimeString(); //"2023-03-20T12:00:00Z"
  const [In, setIn] = useState("");
  const clockOut = new Date().toLocaleTimeString(); //"2023-03-20T18:30:00Z"
  const [Out, setOut] = useState("");

  

  function handleName(event) {
    setName(event.target.value);
  }

  function handleClockIn(e) {
    e.preventDefault();
    setIn(clockIn);
    // console.log(`${name} clocked in at ${In}`);
  }

  function handleClockOut(e) {
    e.preventDefault();
    setOut(clockOut);
    // console.log(`${name} clocked out at ${Out}`);
  }

  const [pay, setPay] = useState();

  function handlePay(e){
    setPay(e.target.value)
  }

  
    const dateDiff = clockOut - clockIn;
    const diffHrs = dateDiff / 3600000;

    const totalPay = diffHrs * pay
    console.log();


  return (
    <div>
      {/* <h1>Clock In</h1> */}
      <div className="card">
        <form className="form">
          <div className="form-group">
            <label>Enter Your Name:</label>
            <input onChange={handleName} type="text" name="name" value={name}/>
            <label>Pay per hour: </label>
            <input onChange={handlePay} type="number" name="pay" value={pay}/>
          </div>
          <div className="button-group">
          <button onClick={handleClockIn}>Clock-In</button>
          <button onClick={handleClockOut}> Clock-Out</button>
          </div>
          
        </form>
      </div>
      <div className="table-div">
        <table>
          <thead>
            <tr>
              <th>Employee Name</th>
              <th>Time-In</th>
              <th>Time-Out</th>
              <th>Hours</th>
              <th>Pay</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>{name}</td>
              <td>{In}</td>
              <td>{Out}</td>
              <td>{diffHrs}</td>
              <td>{totalPay}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default Form;
