def encode(user):
    result  = " "
    preChar = " "
    count   = 1
    for index, char in enumerate(user):
        if index  == 0:
            preChar = char
            continue   
        if preChar == char:
            count  += 1
            if index == len(user)-1:
                result += f"{count}{preChar}"
            else:
                if index != len(user)-1:
                    print("added result")
                    result += f"{count}{preChar}"
                    count = 1
                else:
                    result += f"{count}{preChar}1{char}"

            if count >=10:
                result += f"5{preChar}"
                count -=5
            
            preChar = char
            print(preChar, char, result)
        return result
    
    def decode(user):
        result  = ""
        user = list(user)
        amounts = []
        chars = []
        for cahr in user[::2]:
         if char != None:
            amounts.append(chars)
         for char in user[1::2]:
             if char != None:
                chars.append(char)
    for index, amount in enumerate(amount):
        for i in range(int(amount)):
            result += char[index]

        return result
    
if __name__ == "__main__":
    print(encode("AAAAAAAADCDEEEEE"))
            
