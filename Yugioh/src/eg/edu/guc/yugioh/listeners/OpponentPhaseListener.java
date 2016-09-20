package eg.edu.guc.yugioh.listeners;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.board.player.Phase;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.gui.ActivePlayerPhase;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutDGActive;

public class OpponentPhaseListener implements ActionListener {

	ActivePlayerPhase activePlayerPhase;
	GameSimulation gameSimulation;
	Board board;

	public OpponentPhaseListener(ActivePlayerPhase opponentPlayerPhase,
			GameSimulation gameSimulation, Board board) {
		this.activePlayerPhase = opponentPlayerPhase;
		this.board = board;
		this.activePlayerPhase.getMainphase().addActionListener(this);
		this.gameSimulation = gameSimulation;

	}

	public void actionPerformed(ActionEvent y) {
		
		if (y.getSource() == activePlayerPhase.getMainphase()) {
			
			if (gameSimulation.getPlayerCounter()==0){   //------> Active Player Check if ON

			if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.MAIN1) {

				Card.getBoard().getActivePlayer().endPhase();
				JOptionPane.showMessageDialog(gameSimulation,
						"Battle Phase MotherFuckerz", "Phase Selection",
						JOptionPane.INFORMATION_MESSAGE);

			} else if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.BATTLE) {

				Card.getBoard().getActivePlayer().endPhase();
				JOptionPane.showMessageDialog(gameSimulation, "Main Phase 2",
						"Phase Selection", JOptionPane.INFORMATION_MESSAGE);
			}

			else if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.MAIN2) {

				Card.getBoard().getActivePlayer().endTurn();
				//gameSimulation.setPlayerCounter(0);
				gameSimulation.getGrLayoutDGActive().getCurrentTurn().setText(""+Card.getBoard().getActivePlayer().getName()+"'s"+" Turn");

				JOptionPane.showMessageDialog(gameSimulation,
						"Next Player Turn, Main Phase 1", "Switch Player",
						JOptionPane.INFORMATION_MESSAGE);

			}
			gameSimulation.getGrLayoutDGActive().getCurrentPhase().setText(""+Card.getBoard().getActivePlayer().getField().getPhase());
			gameSimulation.getGrLayoutDGActive().getCurrentPhase().setHorizontalAlignment(SwingConstants.CENTER);
			gameSimulation.getGrLayoutDGActive().getCurrentPhase().updateUI();
			
			gameSimulation.getGrLayoutDGActive().getNumDeck().setText(""+Card.getBoard().getActivePlayer().getField().getDeck().getDeck().size());
			gameSimulation.getGrLayoutDGActive().getNumDeck().setHorizontalAlignment(SwingConstants.CENTER);
			gameSimulation.getGrLayoutDGActive().getNumDeck().updateUI();

		}
		}
	}
}
