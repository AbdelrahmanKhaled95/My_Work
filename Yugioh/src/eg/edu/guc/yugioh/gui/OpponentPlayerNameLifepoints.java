package eg.edu.guc.yugioh.gui;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;

public class OpponentPlayerNameLifepoints extends JPanel{
	
	JLabel lifepoints;
	HomeScreen homeScreen;
	Board board;
	GameSimulation gameSimulation;
	public JLabel getLifepoints() {
		return lifepoints;
	}

	public OpponentPlayerNameLifepoints(GameSimulation gameSimulation, Board board,HomeScreen homeScreen){
		this.homeScreen=homeScreen;
		this.board=board;
		viewlifepoints(gameSimulation,board,homeScreen);
		this.gameSimulation=gameSimulation;
		
	}
	public void viewlifepoints(GameSimulation gameSimulation,Board board,HomeScreen homeScreen){
		this.removeAll();
		JLabel name2=new JLabel(""+homeScreen.getPlayerNameBox().getText(),SwingConstants.CENTER);
		name2.setFont(new Font("Serif", Font.BOLD, 30));
		name2.setForeground(Color.RED);
		setLayout(new GridLayout(2,1));
		setBounds(100, 110, 170, 50);
		setVisible(true);
		setBackground(Color.black);
		 lifepoints=new JLabel(""+Card.getBoard().getOpponentPlayer().getLifePoints()+"",SwingConstants.CENTER);
		add(name2);
		add(lifepoints);
		updateUI();
		repaint();
		validate();
		
		lifepoints.setFont(new Font("Serif", Font.BOLD, 30));
		lifepoints.setForeground(Color.RED);
		
	}

}
