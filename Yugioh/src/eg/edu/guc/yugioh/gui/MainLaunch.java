package eg.edu.guc.yugioh.gui;

import java.io.IOException;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.exceptions.UnexpectedFormatException;

import eg.edu.guc.yugioh.listeners.Mouse;

import eg.edu.guc.yugioh.listeners.homeScreenListener;

public class MainLaunch {

	public MainLaunch() throws IOException, UnexpectedFormatException{
		
		HomeScreen x = new HomeScreen();
		Board y = new Board();
//		
		new homeScreenListener(x, y);
		
		
		
		
	}
	
	public static void main(String[] args) throws IOException, UnexpectedFormatException {
		new MainLaunch();
		
		
	}
}
