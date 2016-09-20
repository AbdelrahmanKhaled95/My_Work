package eg.edu.guc.yugioh.gui;

import java.awt.Color;
import java.awt.GridLayout;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.listeners.Mouse;
import eg.edu.guc.yugioh.listeners.MouseHand;

public class ActivePlayerHand extends JPanel{
	
	GameSimulation gameSimulation;
	Board board;
	int  count=0;
	MouseHand mouse;
	HomeScreen homeScreen;
	ArrayList<JButton>hand;
	
	
	public ArrayList<JButton> getHand() {
		return hand;
	}

	public ActivePlayerHand(GameSimulation gameSimulation,Board board,HomeScreen homeScreen){
		this.gameSimulation=gameSimulation;
		hand=new ArrayList<JButton>();
		this.homeScreen=homeScreen;
		
		this.board=board;
			 mouse=new MouseHand(this,gameSimulation, board, homeScreen);
			 count++;
			viewhand();
			
			updateUI();
			repaint();
			validate();
			revalidate();
			repaint();
		
		
		
	}
	public void viewhand(){
		this.removeAll();

		setBounds(580, 600, 450, 75);
		setLayout(new GridLayout(1,Card.getBoard().getActivePlayer().getField().getHand().size()));
		// setBackground(Color.black);
		if(count==0){
		for(int i=0;i<Card.getBoard().getActivePlayer().getField().getHand().size();i++){
			hand.add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getHand().get(i).getName()+".png")));
			add(hand.get(i));
			hand.get(i).addMouseListener(mouse);
			updateUI();
			revalidate();
			repaint();

		}
		}
		else{
			hand.clear();
			for(int i=0;i<Card.getBoard().getActivePlayer().getField().getHand().size();i++){
				hand.add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getHand().get(i).getName()+".png")));
				add(hand.get(i));
				hand.get(i).addMouseListener(mouse);
				revalidate();
				repaint();
		
	}
		}

	
}
}
