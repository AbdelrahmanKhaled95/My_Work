package eg.edu.guc.yugioh.listeners;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.gui.ActivePlayerHand;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutDGActive;
import eg.edu.guc.yugioh.gui.HomeScreen;
import eg.edu.guc.yugioh.gui.OpponentPlayerHand;

public class Mouse implements MouseListener{
	OpponentPlayerHand x;
	GameSimulation gameSimulation;
	Board board;
	JFrame f=new JFrame();
	GrLayoutDGActive y;
	public Mouse(OpponentPlayerHand x,GameSimulation gameSimulation, Board board ){
		
		


	}
	@Override
	public void mouseClicked(MouseEvent arg0) {
		// TODO Auto-generated method stub

	}

	@Override
	public void mouseEntered(MouseEvent e) {
		// TODO Auto-generated method stub

		f.setVisible(true);
		f.setSize(400, 567);
		f.setContentPane(new JLabel(new ImageIcon("CardView.png")));
		f.validate();
		f.repaint();
		//		if(e.getSource()==x.getHand().get(0))
		//		System.exit(0);
		//		new JFrame("try");


	}

	@Override
	public void mouseExited(MouseEvent arg0) {
		// TODO Auto-generated method stub
		f.setVisible(false);

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
