import React from 'react';

const CourseDetails = ({ courses }) => {
  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {courses.map((course, index) => (
        <div key={index}>
          <h3>{course.cname}</h3>
          <p>{course.cdate}</p>
        </div>
      ))}
    </div>
  );
};

export default CourseDetails;
