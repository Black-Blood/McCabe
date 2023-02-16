using NUnit.Framework;

namespace Test;

public class UnitTestMcCabe
{
    [Test]
    public void ZeroPositive_SumPositiveNumbers_Pass()
    {
        int A = -15, B = -17, C = -22;

        McCabe.McCabe.SumPositiveNumbers(A, B, C, out int S, out int N);

        Assert.Multiple(() =>
        {
            Assert.That(S, Is.EqualTo(0));
            Assert.That(N, Is.EqualTo(0));
        });
    }

    [Test]
    public void OnePositive_SumPositiveNumbers_Pass()
    {
        int A = -15, B = 17, C = -22;

        McCabe.McCabe.SumPositiveNumbers(A, B, C, out int S, out int N);

        Assert.Multiple(() =>
        {
            Assert.That(S, Is.EqualTo(17));
            Assert.That(N, Is.EqualTo(1));
        });
    }

    [Test]
    public void TwoPositive_SumPositiveNumbers_Pass()
    {
        int A = 15, B = -17, C = 22;

        McCabe.McCabe.SumPositiveNumbers(A, B, C, out int S, out int N);

        Assert.Multiple(() =>
        {
            Assert.That(S, Is.EqualTo(37));
            Assert.That(N, Is.EqualTo(2));
        });
    }
}