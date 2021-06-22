namespace DegreeConverter.Engine
{
	public class Model
	{
		private double _valueFahrenheit = 32;
		private double _valueCelsius = 0;

		/// <summary>
		/// ������� � ����� ����������
		/// </summary>
		public double valueFahrenheit
		{
			get { return _valueFahrenheit; }
			set 
			{ 
				_valueFahrenheit = value;
				_valueCelsius = (_valueFahrenheit - 32) * 5 / 9;
			}
		}

		/// <summary>
		/// ������� � ����� �������
		/// </summary>
		public double valueCelsius
		{
			get { return _valueCelsius; }
			set 
			{ 
				_valueCelsius = value;
				_valueFahrenheit = _valueCelsius * 9 / 5 + 32;
			}
		}
	}
}