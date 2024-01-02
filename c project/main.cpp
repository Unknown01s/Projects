#include <iostream>
#include <stdio.h>
#include <stdlib.h>


int printRandoms(int lower, int upper,
                            int count)
{
    int i;
    for (i = 0; i < count; i++) {
        int num = (rand() %
        (upper - lower + 1)) + lower;
        //printf("%d ", num);
        return num;
    }
}

void matrisYazdir(int dizi[4][4]){
    int i;
    int j;
    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            printf("%d\t", dizi[i][j]);
        }
        printf("\n");
    }
}

void matrisAta(int dizi[4][4]){
    int i;
    int j;
    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            dizi[i][j] = printRandoms(-5,5,4);
        }

    }
}

void matrisTopla(int dizi1[4][4], int dizi2[4][4]){
    int matrisToplam[4][4];


    int i;
    int j;

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            matrisToplam[i][j] = dizi1[i][j] + dizi2[i][j];
        }
    }

    matrisYazdir(matrisToplam);
}


void matrisCikarma(int dizi1[4][4], int dizi2[4][4]){
    int matrisFark[4][4];


    int i;
    int j;

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            matrisFark[i][j] = dizi1[i][j] - dizi2[i][j];
        }
    }

    matrisYazdir(matrisFark);
}

void matrisCarp(int dizi1[4][4], int dizi2[4][4]){
    int matrisCarpim[4][4];


    int i;
    int j;

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
            matrisCarpim[i][j] = dizi1[i][j];dizi2[j][i];
        }
    }

    matrisYazdir(matrisCarpim);
}

void matrisTranspose(int dizi1[4][4]){

    int transpose[4][4];



    int i;
    int j;

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){
        transpose[i][j] = dizi1[j][i];
        }
    }

    matrisYazdir(transpose);
}
void matrisTransposeb(int dizi2[4][4]){
    int transposeb[4][4];


    int i;
    int j;

    for(i = 0; i < 4; i++){
        for(j = 0; j < 4; j++){

            transposeb[i][j] = dizi2[j][i];
        }
    }

    matrisYazdir(transposeb);
}



int main(int argc, char *argv[]) {

    int matris1[4][4];
    int matris2[4][4];

    //srand(time(0));

    matrisAta(matris1);
    matrisAta(matris2);


    printf("Birinci Matrisi \n");
    matrisYazdir(matris1);
    printf("\n\n\n");

    printf("İkinci Matris \n");
    matrisYazdir(matris2);
    printf("\n\n\n");

    printf("Matrislerin Toplami:\n");
    matrisTopla(matris1, matris2);

    printf("\n\n\n");
    printf("Matrislerin Farki:\n");
    matrisCikarma(matris1, matris2);

    printf("\n\n\n");
    printf("Matrislerin Carpimi:\n");
    matrisCarp(matris1, matris2);

    printf("\n\n\n");
    printf("Birinci Matrisin Transpose u:\n");
    matrisTranspose(matris1);

    printf("\n\n\n");
    printf("İkinci Matrisin Transpose u:\n");
    matrisTransposeb(matris2);



    return 0;
}