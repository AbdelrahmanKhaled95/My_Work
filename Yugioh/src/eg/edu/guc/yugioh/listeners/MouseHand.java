package eg.edu.guc.yugioh.listeners;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;

import org.omg.CORBA.SystemException;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.cards.Location;
import eg.edu.guc.yugioh.cards.MonsterCard;
import eg.edu.guc.yugioh.cards.spells.SpellCard;
import eg.edu.guc.yugioh.gui.ActivePlayerHand;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutActive;
import eg.edu.guc.yugioh.gui.GrLayoutDGActive;
import eg.edu.guc.yugioh.gui.HomeScreen;

public class MouseHand implements MouseListener {
	ActivePlayerHand x;

	GameSimulation gameSimulation;
	MouseMonsters mouseMonsters;
	JFrame z;
	Board board;
	boolean sacrifiace;
	HomeScreen homeScreen;
	GrLayoutDGActive y;
	

	public MouseHand(ActivePlayerHand x, GameSimulation gameSimulation,
			Board board,HomeScreen homeScreen) {
		
		z = new JFrame();
		this.gameSimulation = gameSimulation;
		this.homeScreen=homeScreen;
		this.board = board;
		 
		this.x = x;


	}

	@Override
	public void mouseClicked(MouseEvent e) {
		if(SwingUtilities.isLeftMouseButton(e)){

			int index = x.getHand().indexOf(e.getSource());
			if (Card.getBoard().getActivePlayer().getField().getHand().get(index) instanceof MonsterCard) {

				MonsterCard monster = (MonsterCard) Card.getBoard()
						.getActivePlayer().getField().getHand().get(index);

				int lvl = monster.getDefensePoints();

				if (lvl == 5 || lvl == 6) {


					if (Card.getBoard().getActivePlayer().getField()
							.getMonstersArea().size() < 1) {
						JOptionPane.showMessageDialog(gameSimulation,
								"You need atleast 1 monster to sacrifice ",
								"Can not summon", JOptionPane.ERROR_MESSAGE);
					}

					else {
						JOptionPane.showMessageDialog(gameSimulation,
								"Please select 1 monster to sacrifice ", " summon",
								JOptionPane.ERROR_MESSAGE);
						sacrifiace=true;





					}
				} else if (lvl == 7 || lvl == 8) {

					if (Card.getBoard().getActivePlayer().getField()
							.getMonstersArea().size() < 2) {
						JOptionPane.showMessageDialog(gameSimulation,
								"You need atleast 2 monster to sacrifices ",
								"Can not summon", JOptionPane.ERROR_MESSAGE);
					}

					else {
						JOptionPane.showMessageDialog(gameSimulation,
								"Please select 2 monster to sacrifice ", " summon",
								JOptionPane.ERROR_MESSAGE);
						sacrifiace=true;

					}
				}
			

			else {


				Card.getBoard().getActivePlayer().summonMonster(monster);
			}
			//new GrLayoutActive(gameSimulation, board, null,homeScreen );
			gameSimulation.getGrLayoutActive().viewmonsters();
			gameSimulation.getGrLayoutActive().updateUI();
			gameSimulation.getGrLayoutActive().repaint();
			gameSimulation.getGrLayoutActive().validate();
			gameSimulation.getActivePlayerHand().viewhand();
			gameSimulation.getActivePlayerHand().updateUI();
			gameSimulation.getActivePlayerHand().repaint();
			gameSimulation.getActivePlayerHand().validate();


			gameSimulation.getGrLayoutOpponent().launchOH();
			gameSimulation.getGrLayoutOpponent().updateUI();
			gameSimulation.getGrLayoutOpponent().viewspells();
			gameSimulation.getGrLayoutOpponent().repaint();
			gameSimulation.getGrLayoutOpponent().validate();
			//			gameSimulation.getOpponentPlayerHand().viewhand();
			//			gameSimulation.getOpponentPlayerHand().updateUI();
			//			gameSimulation.getOpponentPlayerHand().repaint();
			//			gameSimulation.getOpponentPlayerHand().validate();


			return;
		}



		if (Card.getBoard().getActivePlayer().getField().getHand().get(index) instanceof SpellCard) {

			Card.getBoard()
			.getActivePlayer()
			.setSpell(
					(SpellCard) Card.getBoard().getActivePlayer()
					.getField().getHand().get(index));



		}
		gameSimulation.getGrLayoutActive().viewspells();
		gameSimulation.getActivePlayerHand().updateUI();
		gameSimulation.getActivePlayerHand().repaint();
		gameSimulation.getActivePlayerHand().validate();




		gameSimulation.getActivePlayerHand().viewhand();
		gameSimulation.getActivePlayerHand().updateUI();
		gameSimulation.getActivePlayerHand().repaint();
		gameSimulation.getActivePlayerHand().validate();


		gameSimulation.getGrLayoutOpponent().launchOH();
		gameSimulation.getGrLayoutOpponent().updateUI();
		gameSimulation.getGrLayoutOpponent().viewspells();
		gameSimulation.getGrLayoutOpponent().repaint();
		gameSimulation.getGrLayoutOpponent().validate();
	}
	else {
		ArrayList<MonsterCard> sacrifices = new ArrayList<MonsterCard>();
		int index = x.getHand().indexOf(e.getSource());
		if (Card.getBoard().getActivePlayer().getField().getHand().get(index) instanceof MonsterCard) {

			MonsterCard monster = (MonsterCard) Card.getBoard()
					.getActivePlayer().getField().getHand().get(index);

			int lvl = monster.getDefensePoints();

			if (lvl == 5 || lvl == 6) {


				if (Card.getBoard().getActivePlayer().getField()
						.getMonstersArea().size() < 1) {
					JOptionPane.showMessageDialog(gameSimulation,
							"You need atleast 1 monster to sacrifice ",
							"Can not summon", JOptionPane.ERROR_MESSAGE);
				}

				else {
					JOptionPane.showMessageDialog(gameSimulation,
							"Please select 1 monster to sacrifice ", " summon",
							JOptionPane.ERROR_MESSAGE);
					sacrifiace=true;

				}
			} else if (lvl == 7 || lvl == 8) {

				if (Card.getBoard().getActivePlayer().getField()
						.getMonstersArea().size() < 2) {
					JOptionPane.showMessageDialog(gameSimulation,
							"You need atleast 2 monster to sacrifices ",
							"Can not summon", JOptionPane.ERROR_MESSAGE);
				}

				else {
					JOptionPane.showMessageDialog(gameSimulation,
							"Please select 2 monster to sacrifice ", " summon",
							JOptionPane.ERROR_MESSAGE);
					sacrifiace=true;

				}
			}

			else {


				Card.getBoard().getActivePlayer().setMonster(monster);
			}
			new GrLayoutActive(gameSimulation, board, null,homeScreen );
			gameSimulation.getGrLayoutActive().viewmonsters();
			gameSimulation.getGrLayoutActive().updateUI();

			gameSimulation.getGrLayoutActive().repaint();
			gameSimulation.getGrLayoutActive().validate();
			gameSimulation.getActivePlayerHand().viewhand();
			gameSimulation.getActivePlayerHand().updateUI();
			gameSimulation.getActivePlayerHand().repaint();
			gameSimulation.getActivePlayerHand().validate();

			return;
		}



		if (Card.getBoard().getActivePlayer().getField().getHand().get(index) instanceof SpellCard) {

			Card.getBoard()
			.getActivePlayer()
			.setSpell(
					(SpellCard) Card.getBoard().getActivePlayer()
					.getField().getHand().get(index));



		}
		gameSimulation.getGrLayoutActive().viewspells();
		gameSimulation.getActivePlayerHand().updateUI();
		gameSimulation.getActivePlayerHand().repaint();
		gameSimulation.getActivePlayerHand().validate();




		gameSimulation.getActivePlayerHand().viewhand();
		gameSimulation.getActivePlayerHand().updateUI();
		gameSimulation.getActivePlayerHand().repaint();
		gameSimulation.getActivePlayerHand().validate();
	}

}

public boolean isSacrifiace() {
		return sacrifiace;
	}



public void mouseEntered(MouseEvent e) {
z=new JFrame();
					z.setVisible(true);
					z.setSize(400, 600);
			      
					int index = x.getHand().indexOf(e.getSource());
			
					z.add(new JButton(new ImageIcon(Card.getBoard().getActivePlayer().getField().getHand()
							.get(index).getName()+"b.png")));
			
					
					
					z.validate();
					z.repaint();

}

@Override
public void mouseExited(MouseEvent arg0) {
z.removeAll();
	z.setVisible(false);

	z.validate();
	z.repaint();

}

@Override
public void mousePressed(MouseEvent e) {


}

@Override
public void mouseReleased(MouseEvent arg0) {
	// TODO Auto-generated method stub

}

}
