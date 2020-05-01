# Strings can be enclosed in single quotes ['] or double quotes ["]
print("# Strings can be enclosed in single quotes ['] or double quotes [""]")
print("--------------------------------------------------------------------")
print('Print within single quotes')
print("Print within double quotes")

# string variable assignment and print the variable
print("\n\n# string variable assignment and print the variable")
print("-------------------------------------------------------")
str1 = "this string is assigned toa variable and printed"
print(str1)

# print strings in multiple lines
print("\n\n# print strings in multiple lines")
print("-------------------------------------")
multiLineStr = "First line\nSecond line"
print(multiLineStr)

# print strings with tab spacing
print("\n\n# print strings with tab spacing")
print("------------------------------------")
tabbedStr = "the below strings are tab spaced\nFirst string\tSecond string"
print(tabbedStr)

# print multi-line strings without newline character
print("\n\n# print multi-line strings without newline character")
print("--------------------------------------------------------")
multilineStr = """Lorem ipsum dolor sit amet,
consectetur adipiscing elit,
sed do eiusmod tempor incididunt
ut labore et dolore magna aliqua."""
print(multilineStr)

# Find and print the length of a string
print("\n\n# Find and print the length of a string")
print("-------------------------------------------")
print("Length of this string is: {}".format(len(multilineStr)))

# print the string containing multiple variables inline, using string.format(var1,var2,...)
print("\n\n# print the string containing multiple variables inline, using string.format(var1,var2,...)")
print("-----------------------------------------------------------------------------------------------")
son = "Eashan V Kumar"
daughter = "Ishitha V"
print("My son's name is {} and my daughter's name is {}".format(son, daughter))

# print the string containing multiple variables inline, using % (var1,var2,...)
print("\n\n# print the string containing multiple variables inline, using %(var1,var2,...)")
print("-----------------------------------------------------------------------------------")
myself = "Vinoj Kuamr V"
wife = "Preethi NG"
print("My name is %s and my wife's name is %s" % (myself, wife))

# print the string containing multiple variables inline, using +
print("\n\n# print the string containing multiple variables inline, +")
print("--------------------------------------------------------------")
myself = "Vinoj Kuamr V"
wife = "Preethi NG"
print("My name is " + myself + " and my wife's name is " + wife)
