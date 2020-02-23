

def __main__():
    print('Account creation')
    print('-------------------\n')
    print('Enter a username: ')
    username = input()
    print('Enter a password: ')
    password = input()

    f = open("logininfo.txt", "w")
    f.write(username + ',' + password)
    f.close()


__main__()
