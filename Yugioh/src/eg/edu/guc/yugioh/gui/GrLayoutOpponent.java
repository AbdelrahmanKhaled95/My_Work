package eg.edu.guc.yugioh.gui;

import java.awt.Dimension;
import java.awt.GridLayout;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JPanel;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.cards.Mode;
import eg.edu.guc.yugioh.listeners.MouseMonsters;
import eg.edu.guc.yugioh.listeners.MouseSpells;
import eg.edu.guc.yugioh.listeners.Opponentmouse;

public class GrLayoutOpponent extends JPanel {
	Board board;
	JPanel opponentPlayerspells;
	ArrayList<JButton>spells;
	ArrayList<JButton>monsters;
	GameSimulation gameSimulation;
	HomeScreen homeScreen;
	OpponentPlayerNameLifepoints opp;
	Opponentmouse mose;

	public GrLayoutOpponent(GameSimulation gameSimulation,Board board,OpponentPlayerNameLifepoints opp,HomeScreen homeScreen,Opponentmouse mose) {
		
		this.gameSimulation=gameSimulation;
		this.board=board;
		this.homeScreen=homeScreen;
		this.mose=mose;
		spells=new ArrayList<JButton>();
		monsters=new ArrayList<JButton>();

		
		setBounds(520, 190, 580, 100);

		setLayout(new GridLayout(1, 5));// Field
		opponentPlayerspells = new JPanel();
		opponentPlayerspells.setBounds(520, 90, 580, 100);

		opponentPlayerspells.setLayout(new GridLayout(1, 5));
		
		//activePlayerHand.setSize(new Dimension(500, 200));
		 // Hand
		
		
		
		
		launchOF();
		launchOH();

		setVisible(true);
		opponentPlayerspells.setVisible(true);
	}

	public void launchOF() {

		for(int i=0;i<5;i++){

			monsters.add(new JButton(""+i));
			add(monsters.get(i));
		}
		for(int i=0;i<5;i++){
			spells.add(new JButton("s"));
			opponentPlayerspells.add(spells.get(i));
		}

		updateUI();
	}
	public void launchOH() {
		for(int i=0;i<monsters.size();i++){
			this.remove(monsters.get(i));
		}
		monsters.clear();
		for(int i=0;i<Card.getBoard().getOpponentPlayer().getField().getMonstersArea().size();i++){
			if(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().get(i).getMode()==Mode.ATTACK){
			monsters.add(new JButton(new ImageIcon(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().get(i).getName()+".png")));

			add(monsters.get(i));
			monsters.get(i).addMouseListener(mose);


		}
		
			else{
				
				if(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().get(i).isHidden()==true)
					monsters.add(new JButton(new ImageIcon("Card spellr.png")));
				else
				monsters.add(new JButton(new ImageIcon(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().get(i).getName()+"r.png")));

					add(monsters.get(i));
					
				
			}
			
		}
		if(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().size()<5){
			int count=Card.getBoard().getOpponentPlayer().getField().getMonstersArea().size();
			while(count<5){
				monsters.add(new JButton(""));
				add(monsters.get(count));
				count++;

			}
		}

	}
		


		
		
		

	
	public JPanel getOpponentPlayerspells() {
		return opponentPlayerspells;
	}

	public void viewspells(){
		spells.clear();
		
			opponentPlayerspells.removeAll();
			for(int i=0;i<Card.getBoard().getOpponentPlayer().getField().getSpellArea().size();i++){
				
					spells.add(new JButton(new ImageIcon("Card spell.png")));
					opponentPlayerspells.add(spells.get(i));
					
				
				
			}
			if(Card.getBoard().getOpponentPlayer().getField().getSpellArea().size()<5){
				int count2=Card.getBoard().getOpponentPlayer().getField().getSpellArea().size();
				while(count2<5){
					spells.add(new JButton(""));
					opponentPlayerspells.add(spells.get(count2));
					count2++;
				}
			}
	
	}
}


