package eg.edu.guc.yugioh.gui;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javafx.scene.layout.BorderImage;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;
import javax.swing.border.Border;

import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.listeners.Mouse;

import java.awt.Font;

public class GrLayoutDGActive extends JPanel {

	private JPanel DeckNumbWindow;
	private JLabel NumDeck; //------------------>Size
	public void setCurrentTurn(JLabel currentTurn) {
		CurrentTurn = currentTurn;
	}

	private JLabel NumDeckName;
	private JPanel CurrentPhaseWindow;
	private JLabel CurrentPhase;
	private JLabel CurrentTurn;

	//-------------------------------------Constructor--------------------------
	
	public GrLayoutDGActive() {
		//-----------------------------Current Phase Text---------------------------
		
		CurrentPhase = new JLabel("" +Card.getBoard().getActivePlayer().getField().getPhase(),SwingConstants.CENTER);
//		updateUI();
		CurrentPhase.setFont(new Font("Serif", Font.BOLD, 15));
		CurrentPhase.setVisible(true);
		CurrentPhase.setBounds(360, 640, 120, 50);
		
		CurrentPhase.setForeground(Color.red);

		//------------------------------Current Turn Text----------------------

		CurrentTurn = new JLabel(""
				+ Card.getBoard().getActivePlayer().getName() + "'s" + " Turn",SwingConstants.CENTER);
		CurrentTurn.setFont(new Font("Serif", Font.BOLD, 15));
		CurrentTurn.setForeground(Color.red);

		//-----------------------------Number of Cards in Deck Text-----------------------------


		NumDeck = new JLabel("        "
				+ Card.getBoard().getActivePlayer().getField().getDeck()
				.getDeck().size());
		NumDeck.setBounds(1200, 620, 160, 80);
		NumDeck.setVisible(true);
		NumDeck.setFont(new Font("Serif", Font.BOLD, 30));
		NumDeck.setForeground(Color.red);

		NumDeckName = new JLabel("" + "No of Cards",SwingConstants.CENTER);
		
		NumDeckName.setForeground(Color.red);
		NumDeckName.setFont(new Font("Serif", Font.BOLD, 18));

		JButton deck = new JButton(new ImageIcon("Card.png"));
		
		if(Card.getBoard().getActivePlayer().getField().getGraveyard().size()==0){
			 
			add(new JButton("Graveyard"));
			
			
		
		}
		else{
			int size=Card.getBoard().getActivePlayer().getField().getGraveyard().size();
			add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getGraveyard().get(size-1)+"")));
		}
				
				
			
			
		
		

		// -----------------------------------Screen Windows-------------------------

		
		setBounds(1240, 380, 80, 230);
		setVisible(true);
		setLayout(new GridLayout(2, 1));// Field
		
		add(deck);

		DeckNumbWindow = new JPanel();
		DeckNumbWindow.setBounds(1200, 620, 160, 80);
		DeckNumbWindow.setVisible(true);
		DeckNumbWindow.setLayout(new GridLayout(2, 1));
		DeckNumbWindow.add(NumDeck);
		DeckNumbWindow.add(NumDeckName);
		DeckNumbWindow.setBackground(Color.black);
	

		CurrentPhaseWindow = new JPanel();
		CurrentPhaseWindow.setVisible(true);
		CurrentPhaseWindow.setLayout(new GridLayout(2, 1));
		CurrentPhaseWindow.setBounds(360, 610, 120, 50);
		CurrentPhaseWindow.setBackground(Color.black);
		CurrentPhaseWindow.add(CurrentPhase);
		CurrentPhaseWindow.add(CurrentTurn);

		updateUI();

	}

	public JLabel getCurrentTurn() {
		return CurrentTurn;
	}

	public JLabel getNumDeckName() {
		return NumDeckName;
	}

	public void setNumDeckName(JLabel numDeckName) {
		NumDeckName = numDeckName;
	}

	public JPanel getCurrentPhaseWindow() {
		return CurrentPhaseWindow;
	}

	public void setCurrentPhaseWindow(JPanel currentPhaseWindow) {
		CurrentPhaseWindow = currentPhaseWindow;
	}

	public JLabel getCurrentPhase() {
		return CurrentPhase;
	}

	public void setCurrentPhase(JLabel currentPhase) {
		CurrentPhase = currentPhase;
	}

	public void setDeckNumbWindow(JPanel deckNumbWindow) {
		DeckNumbWindow = deckNumbWindow;
	}

	public void setNumDeck(JLabel numDeck) {
		NumDeck = numDeck;
	}

	public JPanel getDeckNumbWindow() {
		return DeckNumbWindow;
	}

	public JLabel getNumDeck() {
		return NumDeck;
	}

	
}
