import hashlib


def __main__():
    print('Account creation')
    print('-------------------\n')
    print('Enter a username: ')
    username = input()
    print('Enter a password: ')
    password = input()

    f = open("logininfo.txt", "w")
    f.write(username + ',' + hashlib.md5(password.encode('utf-8')).hexdigest())
    f.close()


__main__()