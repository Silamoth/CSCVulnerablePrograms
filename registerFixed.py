import hashlib, os, binascii


def __main__():
    print('Account creation')
    print('-------------------\n')
    print('Enter a username: ')
    username = input()
    print('Enter a password: ')
    password = input()
    salt = hashlib.sha3_256(os.urandom(60)).hexdigest().encode('ascii')
    passwordHash = hashlib.pbkdf2_hmac('sha512', password.encode('utf-8'), salt, 100000)
    passwordHash = binascii.hexlify(passwordHash)
    toStore = (salt + passwordHash).decode('ascii')

    f = open("logininfo.txt", "w")
    f.write(username + ',' + toStore)
    f.close()


__main__()
