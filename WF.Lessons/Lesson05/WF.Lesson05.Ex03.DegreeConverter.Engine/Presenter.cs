using System;

namespace DegreeConverter.Engine
{
	public class Presenter
	{
		private Model _model = new Model();
		private IView _view;

		public Presenter(IView view)
		{
			_view = view;
			_view.CelsiusSetted += new EventHandler<EventArgs>(OnSetCelsius);
			_view.FarenheitSetted += new EventHandler<EventArgs>(OnSetFarenheit);
			RefreshView();
		}

		/// <summary>
		/// ��������� �������, ��������� ������ �������� �������� �� ����������
		/// </summary>
		private void OnSetFarenheit(object sender, EventArgs e)
		{
			_model.valueFahrenheit = _view.InputDegree;
			RefreshView();
		}

		/// <summary>
		/// ��������� �������, ��������� ������ �������� �������� �������
		/// </summary>
		private void OnSetCelsius(object sender, EventArgs e)
		{
			_model.valueCelsius = _view.InputDegree;
			RefreshView();
		}

		/// <summary>
		/// ���������� ����c�������� ������ ���������� ������.
		/// �� ���� Binding (��������) �������� ������ � �������������. 
		/// </summary>
		private void RefreshView()
		{
			_view.SetCelsius(_model.valueCelsius);
			_view.SetFarenheit(_model.valueFahrenheit);
		}
	}
}