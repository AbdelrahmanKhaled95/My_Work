package eg.edu.guc.yugioh.listeners;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutActive;
import eg.edu.guc.yugioh.gui.HomeScreen;
import eg.edu.guc.yugioh.gui.OpponentPlayerNameLifepoints;

public class Opponentmouse implements MouseListener{
	GrLayoutActive x;
	OpponentPlayerNameLifepoints opp;
	JFrame m;
	GameSimulation gameSimulation;
	int indexmonsterarea;
	MouseHand mon;
	HomeScreen homeScreen;
	Board board;

	@Override
	public void mouseClicked(MouseEvent e) {
		
		
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
				m.add(new JLabel(new ImageIcon(Card.getBoard().getOpponentPlayer().getField().getMonstersArea().get(index).getName()+"b.png")));
				m.validate();
				m.repaint();
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		m.removeAll();
		m.validate();
		m.repaint();
		m.setVisible(false);
		m.validate();
		m.repaint();

		
	}

	@Override
	public void mousePressed(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

}
