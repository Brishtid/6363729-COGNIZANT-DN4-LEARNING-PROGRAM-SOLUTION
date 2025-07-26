import styles from './components/CohortDetails.module.css'; // Adjust filename as needed

function App() {
  return (
    <div className={styles.box}>
      <h2>Cohorts Details</h2>
      <div className={styles.cohortsContainer}>
        {/* Cohort 1 */}
        <div className={styles.card}>
          <h4 className={styles.blue}>INTADMDF10 - .NET FSD</h4>
          <p><strong>Started On</strong><br />22-aug-2025</p>
          <p><strong>Current Status</strong><br />Scheduled</p>
          <p><strong>Coach</strong><br />Anup Das</p>
          <p><strong>Trainer</strong><br />Brishti Das</p>
        </div>

        {/* Cohort 2 */}
        <div className={styles.card}>
          <h4 className={styles.green}>ADM21JF014 - Java FSD</h4>
          <p><strong>Started On</strong><br />11-aug-2025</p>
          <p><strong>Current Status</strong><br />Ongoing</p>
          <p><strong>Coach</strong><br />Apoorv</p>
          <p><strong>Trainer</strong><br />Brishti Saha</p>
        </div>

        {/* Cohort 3 */}
        <div className={styles.card}>
          <h4 className={styles.green}>CDBJF21025 - Java FSD</h4>
          <p><strong>Started On</strong><br />24-Sept-2025</p>
          <p><strong>Current Status</strong><br />Ongoing</p>
          <p><strong>Coach</strong><br />Monica</p>
          <p><strong>Trainer</strong><br />River Roy</p>
        </div>
      </div>
    </div>
  );
}

export default App;
