package eg.edu.guc.yugioh.gui;

import java.awt.GridLayout;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JPanel;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.listeners.Mouse;
import eg.edu.guc.yugioh.listeners.MouseHand;

public class OpponentPlayerHand extends JPanel{
	GameSimulation gameSimulation;
	Board board;
	int  count=0;
	MouseHand mouse;
	HomeScreen homeScreen;
	ArrayList<JButton>hand=new ArrayList<JButton>();
	
	
	public ArrayList<JButton> getHand() {
		return hand;
	}


	public OpponentPlayerHand(GameSimulation gameSimulation,Board board,HomeScreen homeScreen){
		this.gameSimulation=gameSimulation;
		this.homeScreen=homeScreen;
		
		this.board=board;
		setBounds(520, 600, 600, 200);
		setLayout(new GridLayout(1,Card.getBoard().getOpponentPlayer().getField().getHand().size()));
			 
			viewhand();
			count++;
			updateUI();
			repaint();
			validate();
			revalidate();
			repaint();
		}
	public void viewhand(){
		this.removeAll();
		
		setBounds(580, 10, 450, 75);
		setLayout(new GridLayout(1,Card.getBoard().getOpponentPlayer().getField().getHand().size()));
		// setBackground(Color.black);
		if(count==0){
		for(int i=0;i<Card.getBoard().getOpponentPlayer().getField().getHand().size();i++){
			hand.add(new JButton(new ImageIcon("Card spell.png")));
			add(hand.get(i));
			
			updateUI();
			revalidate();
			repaint();

		}
		}
		else{
			hand.clear();
			for(int i=0;i<Card.getBoard().getOpponentPlayer().getField().getHand().size();i++){
				hand.add(new JButton(new ImageIcon("Card spell.png")));
				add(hand.get(i));
				
				revalidate();
				repaint();
		
	}
		}

	
}
	}


