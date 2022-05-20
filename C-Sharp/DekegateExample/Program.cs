

using DelegateExample;

Calculation obj = new Calculation(CalculationMath.Addition);
obj.Invoke(22, 22);
obj(11,11);