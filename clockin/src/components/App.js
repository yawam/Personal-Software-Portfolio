import React from "react";
import Form from "./form";
import Display from "./display";

function App() {
  return (
    <div>
      <Form />
      {/* <Display /> */}
    </div>
  );
}

// Creating an App to calculate employee clock in and clock outs.
// Create a clock in form and display submit on another page(log page)
// log page should have timestamp or the time form was submitted. It should also calculate pay

// To do's
// -- Implement Time Difference Function and display hours worked, and Pay if possible(create pay input)
// -- do CSS

export default App;
