# OldPhoneKeypad
old phone keypad with alphabetical letters, a backspace key, and a send  button code in C#

# Explanation
Keypad Mapping: A dictionary is used to map each digit to its corresponding letters.

Result Construction: A StringBuilder is used to construct the output string.

Consecutive Key Press Handling: The program tracks the last key pressed and the count of consecutive presses to determine the correct letter.

Special Keys: The * key is used for backspace, and the # key marks the end of the input.


# Test Cases
OldPhonePad("33#") should output E.

OldPhonePad("227*#") should output B.

OldPhonePad("4433555 555666#") should output HELLO.

OldPhonePad("8 88777444666*664#") will depend on how the backspace affects the final result.
