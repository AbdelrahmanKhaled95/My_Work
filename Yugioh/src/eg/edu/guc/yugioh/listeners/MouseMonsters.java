package eg.edu.guc.yugioh.listeners;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.board.player.Phase;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.cards.MonsterCard;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutActive;
import eg.edu.guc.yugioh.gui.HomeScreen;
import eg.edu.guc.yugioh.gui.OpponentPlayerNameLifepoints;

public class MouseMonsters implements MouseListener{
	GrLayoutActive x;
	OpponentPlayerNameLifepoints opp;
	JFrame m;
	GameSimulation gameSimulation;
	int indexmonsterarea;
	MouseHand mon;
	HomeScreen homeScreen;
	Board board;
	boolean attacked;
	ArrayList<MonsterCard> sacrifices;
	public int getIndexmonsterarea() {
		return indexmonsterarea;
	}

	public MouseMonsters(GrLayoutActive x,GameSimulation gameSimulation2,Board board,OpponentPlayerNameLifepoints opp,HomeScreen homeScreen,MouseHand mon){
		this.gameSimulation=gameSimulation2;
		sacrifices = new ArrayList<MonsterCard>();
		this.x=x;
		this.opp=opp;
		this.board=board;
		this.homeScreen=homeScreen;
		this.mon=mon;
		
		m=new JFrame();
		// TODO Auto-generated constructor stub
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		int index=x.getMonsters().
				indexOf(e.getSource());
		MonsterCard monster=Card.getBoard().getActivePlayer().getField().getMonstersArea().get(index);
		if(Card.getBoard().getActivePlayer().getField().getPhase()==Phase.BATTLE){


			if(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().size()==0){

				Card.getBoard().getActivePlayer().declareAttack(monster);
				
				gameSimulation.getOpp().viewlifepoints(gameSimulation, board, homeScreen);
				gameSimulation.getOpp().getLifepoints().updateUI();
				gameSimulation.getOpp().getLifepoints().repaint();
				gameSimulation.getOpp().getLifepoints().validate();
			}
			else{ JOptionPane.showMessageDialog(gameSimulation,
					"Please select a monster to attack ", " Choose to attack",
					JOptionPane.ERROR_MESSAGE);
			attacked=true;
			//Card.getBoard().getActivePlayer().declareAttack(monster, opponentMonster);
			}

			gameSimulation.getOpp()
			.viewlifepoints
			(gameSimulation
					,board
					, homeScreen);

			gameSimulation.getOpp().getLifepoints().updateUI();
			gameSimulation.getOpp().getLifepoints().repaint();
			gameSimulation.getOpp().getLifepoints().validate();
			gameSimulation.getOpp().getLifepoints().setText(""+Card.getBoard().getOpponentPlayer().getLifePoints());
			gameSimulation.getOpp().getLifepoints().setHorizontalAlignment(SwingConstants.CENTER);
			gameSimulation.getOpp().getLifepoints().updateUI();
			gameSimulation.getOpp().getLifepoints().repaint();
			gameSimulation.getOpp().getLifepoints().validate();
		}
		else{
			if(mon.isSacrifiace()==false){
				Card.getBoard().getActivePlayer().switchMonsterMode(monster);
			monster.setHidden(false);
			gameSimulation.getGrLayoutActive().viewmonsters();
			gameSimulation.getGrLayoutActive().repaint();
			gameSimulation.getGrLayoutActive().validate();
			}
			else
				sacrifices.clear();
			sacrifices.add(monster);
				
				Card.getBoard().getActivePlayer().summonMonster(monster, sacrifices);
				gameSimulation.getGrLayoutActive().viewmonsters();
				gameSimulation.getGrLayoutActive().repaint();
				gameSimulation.getGrLayoutActive().validate();

		}
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		m.validate();
		m.repaint();
		m=new JFrame();
		int index=x.getMonsters().
				indexOf(e.getSource());
				m.setVisible(true);
				m.setSize(400, 600);
				m.add(new JLabel(new ImageIcon(Card.getBoard().getActivePlayer().getField().getMonstersArea().get(index).getName()+"b.png")));
				m.validate();
				m.repaint();
				
	}

	public void setIndexmonsterarea(int indexmonsterarea) {
		this.indexmonsterarea = indexmonsterarea;
	}

	@Override
	public void mouseExited(MouseEvent arg0) {
		m.removeAll();
		m.validate();
		m.repaint();
		m.setVisible(false);
		m.validate();
		m.repaint();

	}

	@Override
	public void mousePressed(MouseEvent arg0) {
		// TODO Auto-generated method stub

	}

	@Override
	public void mouseReleased(MouseEvent arg0) {
		// TODO Auto-generated method stub

	}

}
