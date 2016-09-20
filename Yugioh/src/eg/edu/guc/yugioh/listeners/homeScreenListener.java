package eg.edu.guc.yugioh.listeners;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;

import javax.swing.JOptionPane;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.board.player.Player;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.exceptions.UnexpectedFormatException;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.HomeScreen;

public class homeScreenListener implements ActionListener {

	private String player1;
	private String player2;
	private HomeScreen homeScreen;
	private Board board;
	public HomeScreen getHomeScreen() {
		return homeScreen;
	}

	public Board getBoard() {
		return board;
	}

	private static int NumNames;
	private GameSimulation gameSimulation;

	public GameSimulation getGameSimulation() {
		return gameSimulation;
	}

	public homeScreenListener(HomeScreen homeScreen, Board board) {
		this.homeScreen = homeScreen;
		this.board = board;
		homeScreen.getButtonEnter().addActionListener(this);

		NumNames = 0;
	}

	public void actionPerformed(ActionEvent b) {
	
		if (b.getSource() == homeScreen.getButtonEnter()) {

			if (homeScreen.getPlayerNameBox().getText().equals("")) {
				JOptionPane.showMessageDialog(homeScreen,
						"Please Enter A Name Please", "Can not start the game",
						JOptionPane.ERROR_MESSAGE);
			} else {
				if (NumNames == 0) {

					player1 = homeScreen.getPlayerNameBox().getText();
					//					try {
					//						Card.getBoard().setActivePlayer(new Player (player1)) ;
					//					} catch (IOException e) {
					//						// TODO Auto-generated catch block
					//						e.printStackTrace();
					//					} catch (UnexpectedFormatException e) {
					//						// TODO Auto-generated catch block
					//						e.printStackTrace();
					//					}


					NumNames++;
					homeScreen.getPlayerNameBox().setText("");
					homeScreen.getButtonEnter().setText("Enter Player 2 Name");
					return;

				}


				if (NumNames == 1) {

					player2 = homeScreen.getPlayerNameBox().getText();
					//					try {
					//						Card.getBoard().setOpponentPlayer(new Player (player2)) ;
					//					} catch (IOException e) {
					//						// TODO Auto-generated catch block
					//						e.printStackTrace();
					//					} catch (UnexpectedFormatException e) {
					//						// TODO Auto-generated catch block
					//						e.printStackTrace();
					//					}

					NumNames++;
					if (!player2.equals(""))
						try {
							Card.getBoard().startGame(new Player (player1), new Player (player2));
						} catch (IOException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						} catch (UnexpectedFormatException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}


					homeScreen.getHomeWindow().setVisible(false);
					gameSimulation = new GameSimulation(homeScreen, board);
					gameSimulation.setVisible(true);
				}

			}

		}

	}

	public String getPlayer1() {
		return player1;
	}

	public String getPlayer2() {
		return player2;
	}

	public static int getNumNames() {
		return NumNames;
	}

	public void setNumNames(int numNames) {
		NumNames = numNames;
	}

}
