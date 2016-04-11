package Engine;

import java.util.Random;

public class XO {

	char[][] field ;
	boolean Endgame;
	public boolean isEndgame() {
		return Endgame;
	}
	public char[][] getField() {
		return field;
	}
	int Turn;

	int countlose=0;

	boolean Whowins;
	public XO(){

		this.field= new char[3][3];

	}


	public boolean Winner(){
		char a=field[0][0];
		char b=field[1][1];
		char c=field[2][2];
		char d=field[0][2];
		char e=field[2][0];
		char f=field[0][1];
		char g=field[2][1];
		char h=field[1][0];
		char i=field[1][2];
		if(a==b&&b==c&&c=='x'){
			Whowins=true;
			return true;
		}
		if(d==b&&e==b&&b=='x'){
			Whowins=true;
			return true;
		}
		if(f==b&&g==b&&b=='x'){
			Whowins=true;
			return true;
		}
		if(a==f&&d==f&&f=='x'){
			Whowins=true;
			return true;
		}
		if(h==b&&i==b&&b=='x'){
			Whowins=true;
			return true;
		}
		if(e==g&&c==g&&g=='x'){
			Whowins=true;
			return true;
		}
		if(a==h&&h==e&&e=='x'){
			Whowins=true;
			return true;
		}
		if(d==i&&i==c&&c=='x'){
			Whowins=true;
			return true;
		}
		if(a==b&&b==c&&c=='o'){
			Whowins=false;
			return true;
		}
		if(d==b&&e==b&&b=='o'){
			Whowins=false;
			return true;
		}
		if(f==b&&g==b&&b=='o'){
			Whowins=false;
			return true;
		}
		if(a==f&&d==f&&f=='o'){
			Whowins=false;
			return true;
		}
		if(h==b&&i==b&&b=='o'){
			Whowins=false;
			return true;
		}
		if(e==g&&c==g&&g=='o'){
			Whowins=false;
			return true;
		}
		if(a==h&&h==e&&e=='o'){
			Whowins=false;
			return true;
		}
		if(d==i&&i==c&&c=='o'){
			Whowins=false;
			return true;
		}

		return false;



	}
	public boolean isWhowins() {
		return Whowins;
	}
	public void insert(int row,int col){
		if(Endgame==true){
			return;
		}
		if(Turn%2==0)
			field[row][col]='x';
		else
			field[row][col]='o';
		Turn++;
		if(Winner()==true){
			Endgame=true;
		}

	}



	public boolean  photo(int row,int col){
		if(field[row][col]=='x')
			return true;
		else
			return false;

	}
	public void AI(){

		Random r=new Random();
		int rows=r.nextInt(3);
		int cols=r.nextInt(3);
		if(field[rows][cols]!='x'&&field[rows][cols]!='o'){

			insert(rows, cols);
			return;
		}
		AI();


	}
	
	public boolean Check(int rows,int cols){
		if(field[rows][cols]=='x'||field[rows][cols]=='o')
			return true;
		else 
			return false;
	}


}
