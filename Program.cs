namespace gazi.odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("How many numbers do you want to sort?");
            byte count = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number:");
            byte end = byte.Parse(Console.ReadLine());

            List<int> sonuc1 = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int mrv;
                do
                {
                    mrv = rnd.Next(start, end + 1);
                } while (sonuc1.Contains(mrv));
                sonuc1.Add(mrv);

            }

            Console.WriteLine(String.Join(" ", sonuc1));

        }
    }
}
import './App.css';
import React, { useState } from 'react';

function App() {
    const [text, setText] = useState('');
    const [todos, setTodos] = useState([]);

    const handleAdd = (e) => {
        e.preventDefault();
        if (text.trim()) {
            setTodos([...todos, text]);
            setText('');
        }
    };

    const handleDelete = (index) => {
        const newTodos = todos.filter((_, i) => i !== index);
        setTodos(newTodos);
    };

    return (
        <div className="App">
            <div>
                <form onSubmit={handleAdd}>
                    <h2>Todo List App</h2>
                    <input 
                        type='text' 
                        name='text' 
                        value={text} 
                        onChange={(e) => setText(e.target.value)} 
                    />
                    <button type="submit">Add</button>
                </form>
                <ul>
                    {todos.map((todo, index) => (
                        <li key={index}>
                            {todo}
                            <button onClick={() => handleDelete(index)}>Delete</button>
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    );
}

export default App;
