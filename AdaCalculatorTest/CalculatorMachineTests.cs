using AdaCalculator;
using Moq;

namespace AdaCalculatorTest
{
    public class CalculatorMachineTests
    {
        private readonly CalculatorMachine _sut;
        private readonly Mock<ICalculator> _mock;

        public CalculatorMachineTests()
        {
            _mock = new Mock<ICalculator>(MockBehavior.Strict);
            _sut = new CalculatorMachine(_mock.Object);
        }
        [Fact]
        public void Calculate_WhenChosenSum_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("sum", 1, 1)).Returns(("sum", 2));
            var result = _sut.Calculate("sum", 1, 1);

            _mock.Verify(x => x.Calculate("sum", 1, 1), Times.Exactly(1));
            Assert.Equal(("sum", 2), result);
        }
        [Fact]
        public void Calculate_WhenChosenSubtract_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("subtract", 1, 1)).Returns(("subtract", 0));
            var result = _sut.Calculate("subtract", 1, 1);

            _mock.Verify(x => x.Calculate("subtract", 1, 1), Times.Exactly(1));
            Assert.Equal(("subtract", 0), result);
        }
        [Fact]
        public void Calculate_WhenChosenDivide_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("divide", 4, 2)).Returns(("divide", 2));
            var result = _sut.Calculate("divide", 4, 2);

            _mock.Verify(x => x.Calculate("divide", 4, 2), Times.Exactly(1));
            Assert.Equal(("divide", 2), result);
        }
        [Fact]
        public void Calculate_WhenDivideBy0_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("divide", 4, 0)).Returns(("divide", 0));
            var result = _sut.Calculate("divide", 4, 0);

            _mock.Verify(x => x.Calculate("divide", 4, 0), Times.Exactly(1));
            Assert.Equal(("divide", 0), result);
        }
        [Fact]
        public void Calculate_WhenChosenMultiply_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("multiply", 4, 2)).Returns(("multiply", 8));
            var result = _sut.Calculate("multiply", 4, 2);

            _mock.Verify(x => x.Calculate("multiply", 4, 2), Times.Exactly(1));
            Assert.Equal(("multiply", 8), result);
        }
        [Fact]
        public void Calculate_WhenMultiplyBy0_ShouldBeCorrect()
        {
            _mock.Setup(x => x.Calculate("multiply", 4, 0)).Returns(("multiply", 0));
            var result = _sut.Calculate("multiply", 4, 0);

            _mock.Verify(x => x.Calculate("multiply", 4, 0), Times.Exactly(1));
            Assert.Equal(("multiply", 0), result);
            // ?????
        }
    }
}