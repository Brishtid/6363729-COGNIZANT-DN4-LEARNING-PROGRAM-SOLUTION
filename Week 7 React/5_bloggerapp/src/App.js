import React, { useState } from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

import { books } from './data/books';
import { blogs } from './data/blogs';
import { courses } from './data/courses';

function App() {
  const [view, setView] = useState('all');

  // Inline Function Rendering
  const renderComponent = () => {
    switch (view) {
      case 'book':
        return <BookDetails books={books} />;
      case 'blog':
        return <BlogDetails blogs={blogs} />;
      case 'course':
        return <CourseDetails courses={courses} />;
      default:
        return (
          <>
            <BookDetails books={books} />
            <BlogDetails blogs={blogs} />
            <CourseDetails courses={courses} />
          </>
        );
    }
  };

  return (
    <div className="App">
      <h1>Blogger App</h1>
      <div>
        <button onClick={() => setView('book')}>Book</button>
        <button onClick={() => setView('blog')}>Blog</button>
        <button onClick={() => setView('course')}>Course</button>
        <button onClick={() => setView('all')}>All</button>
      </div>

      {/* 1. Using Ternary */}
      {view === 'book' ? <BookDetails books={books} /> : null}

      {/* 2. Using Logical && */}
      {view === 'blog' && <BlogDetails blogs={blogs} />}

      {/* 3. Using Inline Function */}
      {renderComponent()}
    </div>
  );
}

export default App;
