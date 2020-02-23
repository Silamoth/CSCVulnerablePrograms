#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Enter a 16-character word: ");
    char *word = (char *)malloc(17 * sizeof(char));
    gets(word);
    printf("Your word is: %s\n", word);

    return 0;
}

void secretSecret()
{
    printf("This is a hidden part of the code no one is supposed to access...\n");
}
