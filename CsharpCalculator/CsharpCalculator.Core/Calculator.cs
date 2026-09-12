namespace CsharpCalculator.Core;

enum CalculatorOp
{
    Add,
    Subtract,
    Multiply,
    Divide,
    Power,
}

class Calculator
{
    public static int Calculate(CalculatorOp[] ops, int[] nums, out int result)
    {
        if (ops.Length >= nums.Length)
        {
            result = 0;
            return 1;
        }
        result = nums[0];
        for (int i = 0; i < ops.Length; i++)
        {
            switch (ops[i])
            {
                case CalculatorOp.Add:
                    result += nums[i+1];
                    break;
                case CalculatorOp.Subtract:
                    result -= nums[i+1];
                    break;
                case CalculatorOp.Multiply:
                    result *= nums[i+1];
                    break;
                case CalculatorOp.Divide:
                    if (nums[i+1] == 0)
                    {
                        return 1;
                    }
                    else {
                        result /= nums[i+1];
                    }
                    break;
                case CalculatorOp.Power:
                    result = (int)Math.Pow(result, nums[i+1]);
                    break;
            }
        }
        return 0;
    }
}
