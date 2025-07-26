import './App.css';
import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Brishti Das"
        Superset id="6363729"
        University="KIIT University"
        total={88.2}
        goal={100}
      />
    </div>
  );
}

export default App;
