using IronSoftware.Challenge.Phone;
using Xunit;

namespace IronSoftware.Challenge.Tests.Phone {
    public class KeyboardTests {
        public static IEnumerable<object[]> KeyboardInputs => [
            ["33#", "E"],
            ["227*#", "B"],
            ["4433555 55566#", "HELLO"],
            ["8 8877744466*664#", "?"]
        ];


        [Theory]
        [MemberData(nameof(KeyboardInputs))]
        public void TestKeyboardInputs(string keyboardInput, string expectedOutput) {
            // Arrange

            // Act
            var result = Keyboard.OldPhonePad(keyboardInput);

            // Assert
            Assert.Equal(expectedOutput, result);
        }
    }
}
