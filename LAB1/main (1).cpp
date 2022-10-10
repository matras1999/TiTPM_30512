#include<iostream>
#include <cstring>

using namespace std;

void cezar(int key, char *tab)
{
	int x=strlen(tab);
	if(!(key>=-26 && key<=26)) return;
	
	if(key>=0)
		for(int i=0;i<x;i++)
		if(tab[i]+key<='z')
			tab[i]+=key;
		else
			tab[i]=tab[i]+key-26; 
	else
		for(int i=0;i<x;i++)
		if(tab[i]+key>='a')
			tab[i]+=key;
		else
			tab[i]=tab[i]+key+26;
}
int main()
{
	char tab[1001]; 
	
	int key;
	
	cout<<"podaj slowo do zaszyfrowania(male litery,bez polskich znakow):"<<endl;cin>>tab;
	cout<<"Podaj klucz od -26 do 26:"<<endl;cin>>key;
	cezar(key,tab); //szyfrowanie
	cout<<"twoj szyfr:"<<tab<<endl;
	

	return 0;
}
