package eg.edu.guc.yugioh.gui;



import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.util.ArrayList;





import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JPasswordField;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.cards.Mode;
import eg.edu.guc.yugioh.listeners.MouseMonsters;
import eg.edu.guc.yugioh.listeners.MouseSpells;

public class GrLayoutActive extends JPanel {
	Board board;
	int count;
	JPanel jPanel2;






	public JPanel getjPanel2() {
		return jPanel2;
	}





	ArrayList<JButton>monsters;
	GameSimulation gameSimulation;
	MouseMonsters mouseMonsters;
	ArrayList<JButton>spells;
	MouseSpells mouseSpells;
	HomeScreen homeScreen;
	OpponentPlayerNameLifepoints opp;

	public GrLayoutActive(GameSimulation gameSimulation,Board board,OpponentPlayerNameLifepoints opp,HomeScreen homeScreen) {
		this.opp=opp;

		jPanel2=new JPanel();
		this.gameSimulation=gameSimulation;
		this.board=board;
		this.homeScreen=homeScreen;
		spells=new ArrayList<JButton>();
		monsters=new ArrayList<JButton>();

		mouseSpells=new MouseSpells(this,gameSimulation);
		mouseMonsters=new MouseMonsters(this,gameSimulation,board, opp, homeScreen, null);


		jPanel2.setBounds(520, 460, 580, 100);
		setBounds(520, 360, 580, 100);
		setLayout(new GridLayout(1, 5));
		jPanel2.setLayout(new GridLayout(1,5));



		launchAF();
		viewmonsters();


		setVisible(true);

		updateUI();

	}





	public void launchAF() {


		for(int i=0;i<5;i++){

			monsters.add(new JButton(""+i));
			add(monsters.get(i));
		}
		for(int i=0;i<5;i++){
			spells.add(new JButton("s"));
			jPanel2.add(spells.get(i));
		}

		updateUI();
	}




	public void viewmonsters(){

		for(int i=0;i<monsters.size();i++){
			this.remove(monsters.get(i));
		}
		monsters.clear();
		for(int i=0;i<Card.getBoard().getActivePlayer().getField().getMonstersArea().size();i++){
			if(Card.getBoard().getActivePlayer().getField().getMonstersArea().get(i).getMode()==Mode.ATTACK){
			monsters.add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getMonstersArea().get(i).getName()+".png")));

			add(monsters.get(i));
			monsters.get(i).addMouseListener(mouseMonsters);


		}
		
			else{
				
				if(Card.getBoard().getActivePlayer().getField().getMonstersArea().get(i).isHidden()==true)
					monsters.add(new JButton(new ImageIcon("Card spellr.png")));
				else
				monsters.add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getMonstersArea().get(i).getName()+"r.png")));

					add(monsters.get(i));
					monsters.get(i).addMouseListener(mouseMonsters);
				
			}
			
		}
		if(Card.getBoard().getActivePlayer().getField().getMonstersArea().size()<5){
			int count=Card.getBoard().getActivePlayer().getField().getMonstersArea().size();
			while(count<5){
				monsters.add(new JButton(""));
				add(monsters.get(count));
				count++;

			}
		}

	}
	public void viewspells(){
		spells.clear();
		
			jPanel2.removeAll();
			for(int i=0;i<Card.getBoard().getActivePlayer().getField().getSpellArea().size();i++){
				if(Card.getBoard().getActivePlayer().getField().getHand().get(i).isHidden()){
					spells.add(new JButton(new ImageIcon("Card spell.png")));
					jPanel2.add(spells.get(i));
					spells.get(i).addMouseListener(mouseSpells);
				}
				else{
					spells.add(i,new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getSpellArea().get(i).getName()+".png")));
					add(spells.get(i));
					spells.get(i).addMouseListener(mouseSpells);
				}
			}
			if(Card.getBoard().getActivePlayer().getField().getSpellArea().size()<5){
				int count2=Card.getBoard().getActivePlayer().getField().getSpellArea().size();
				while(count2<5){
					spells.add(new JButton(""));
					jPanel2.add(spells.get(count2));
					count2++;
				}
			}
		
	}





	public ArrayList<JButton> getSpells() {
		return spells;
	}





	public ArrayList<JButton> getMonsters() {
		return monsters;
	}
}


