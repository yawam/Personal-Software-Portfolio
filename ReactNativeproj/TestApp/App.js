import React, { useState } from "react";
import { StyleSheet, View, Text, TextInput, Button } from "react-native";

export default function App() {
  const [todo, setTodo] = useState("");
  const [todos, setTodos] = useState([]);

  const addTodo = () => {
    setTodos([...todos, todo]);
    setTodo("");
  };

  return (
    <View style={styles.container}>
      <Text style ={styles.text}>
        T0-D0 APP
      </Text>
      <TextInput
        style={styles.input}
        placeholder="Add a To-Do"
        value={todo}
        onChangeText={setTodo}
      />
      <Button title="Add" onPress={addTodo} />
      {todos.map((item, index) => (
        <Text key={index} style={styles.item}>
          {item}
        </Text>
      ))}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    marginTop:50,
    flex: 1,
    padding: 24,
  },
  text: {
    padding: 10,
    fontSize: 30,
  },
  input: {
    height: 48,
    borderWidth: 1,
    borderColor: "#ddd",
    padding: 8,
    marginBottom: 16,
  },
  item: {
    backgroundColor: "#ddd",
    padding: 8,
    marginVertical: 8,
  },
});