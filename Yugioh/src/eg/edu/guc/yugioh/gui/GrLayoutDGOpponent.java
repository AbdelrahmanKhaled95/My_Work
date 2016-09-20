package eg.edu.guc.yugioh.gui;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.listeners.Mouse;

public class GrLayoutDGOpponent extends JPanel{
	
	private JPanel DeckNumbWindowO;
	private JLabel NumDeckO;
	private JLabel NumDeckNameO;
	
	private JPanel CurrentPhaseWindowO;
	private JLabel CurrentPhaseO;
	private JLabel CurrentTurnO;

	public GrLayoutDGOpponent(){
		
		
		
		setBounds(1240, 90, 80, 230);
		setVisible(true);
		setLayout(new GridLayout(2,1));// Field
		
		DeckNumbWindowO = new JPanel();
		NumDeckO = new JLabel("        "+Card.getBoard().getOpponentPlayer().getField().getDeck().getDeck().size());
		NumDeckO.setBounds(1200, 5, 160, 80);
		NumDeckO.setVisible(true);
		NumDeckO.setFont(new Font("Serif", Font.BOLD, 30));
		NumDeckO.setForeground(Color.red);
		
		NumDeckNameO = new JLabel("        "+ "No of Cards");
		NumDeckNameO.setForeground(Color.red);
		NumDeckNameO.setFont(new Font("Serif", Font.BOLD, 18));
		
		
		JButton deck=new JButton(new ImageIcon("Card.png"));
		//deck.addMouseListener(mouse);
		JButton graveyard=new JButton("Graveyard");
		
		add(deck);
		
		if(Card.getBoard().getOpponentPlayer().getField().getGraveyard().size()==0){
			add(new JButton("Graveyard"));


		}
		else{
			int size=Card.getBoard().getOpponentPlayer().getField().getGraveyard().size();
			add(new JButton(new ImageIcon(Card.getBoard().getOpponentPlayer().getField().getGraveyard().get(size-1)+"")));
			



		}

		
		DeckNumbWindowO.setBounds(1200, 5, 160, 80);
		DeckNumbWindowO.setVisible(true);
		DeckNumbWindowO.setLayout(new GridLayout(2,1));
		DeckNumbWindowO.setBackground(Color.black);
		DeckNumbWindowO.add(NumDeckO);
		DeckNumbWindowO.add(NumDeckNameO);
	

	}





	public JPanel getDeckNumbWindowO() {
		return DeckNumbWindowO;
	}





	public JLabel getNumDeckO() {
		return NumDeckO;
	}





	public JLabel getNumDeckNameO() {
		return NumDeckNameO;
	}





	

}
