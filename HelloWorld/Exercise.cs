using System;


namespace Coding.Exercise
{
	public class Run
	{
		public delegate float OperationDelegate(float leftfield, float rightfield);

		public static float Add(float leftField, float rightField)
		{
			return leftField + rightField;
		}
		public static float Subtract(float leftField, float rightField)
		{
			return leftField - rightField;
		}
		public static float Multiply(float leftField, float rightField)
		{
			return leftField * rightField;
		}
		public static float Divide(float leftField, float rightField)
		{
			return leftField / rightField;
		}
		public static float ApplyOperation(float leftField, float rightField, OperationDelegate operation)
		{
			return operation(leftField, rightField);
		}
	}
}

