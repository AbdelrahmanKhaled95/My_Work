package eg.edu.guc.yugioh.listeners;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.board.player.Phase;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.exceptions.UnexpectedFormatException;
import eg.edu.guc.yugioh.gui.ActivePlayerPhase;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutDGActive;
import eg.edu.guc.yugioh.gui.HomeScreen;
import eg.edu.guc.yugioh.gui.MainLaunch;

public class ActivePhaseListener implements ActionListener {

	ActivePlayerPhase activePlayerPhase;
	GameSimulation gameSimulation;
	Board board;
	HomeScreen homeScreen;

	public ActivePhaseListener(ActivePlayerPhase activePlayerPhase,
			GameSimulation gameSimulation, Board board,HomeScreen homeScreen) {
		this.activePlayerPhase = activePlayerPhase;
		this.board = board;
		this.homeScreen=homeScreen;
		this.activePlayerPhase.getMainphase().addActionListener(this);
		this.gameSimulation = gameSimulation;

	}

	public void actionPerformed(ActionEvent y) {
		
		
		if (y.getSource() == activePlayerPhase.getMainphase()) {
			

			//----------------------------Player 1 ------------------------------
			
			
			if (gameSimulation.getPlayerCounter()==0){   //------> Active Player Check if ON

			if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.MAIN1) {

				Card.getBoard().getActivePlayer().endPhase();
				JOptionPane.showMessageDialog(gameSimulation,
						"Battle Phase ", "Phase Selection",
						JOptionPane.INFORMATION_MESSAGE);

			} else if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.BATTLE) {

				Card.getBoard().getActivePlayer().endPhase();
				JOptionPane.showMessageDialog(gameSimulation, "Main Phase 2",
						"Phase Selection", JOptionPane.INFORMATION_MESSAGE);
			}

			else if (Card.getBoard().getActivePlayer().getField().getPhase() == Phase.MAIN2) {
				if (Card.getBoard().isGameOver()){
					System.out.println("inside");
					JOptionPane.showMessageDialog(gameSimulation,
							"Do you want to play again ", " PLAY AGAIN",
							JOptionPane.ERROR_MESSAGE);
					try {
						new MainLaunch();
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					} catch (UnexpectedFormatException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					
				}
				
				Card.getBoard().getActivePlayer().endTurn();
				//------------------------------------
				gameSimulation.getActivePlayerHand().viewhand();
				gameSimulation.getActivePlayerHand().updateUI();
				gameSimulation.getActivePlayerHand().repaint();
				gameSimulation.getActivePlayerHand().validate();
				//------------------------------------------
				gameSimulation.getGrLayoutActive().viewmonsters();
				gameSimulation.getGrLayoutActive().updateUI();
				gameSimulation.getGrLayoutActive().repaint();
				//--------------------------------------------
				gameSimulation.getGrLayoutActive().viewspells();
				gameSimulation.getGrLayoutActive().updateUI();
				gameSimulation.getGrLayoutActive().repaint();
				//-------------------------------------------
				gameSimulation.getGrLayoutOpponent().launchOH();
				gameSimulation.getGrLayoutOpponent().updateUI();
				gameSimulation.getGrLayoutOpponent().repaint();
				//---------------------------------------------
				gameSimulation.getGrLayoutOpponent().viewspells();
				gameSimulation.getGrLayoutOpponent().updateUI();
				gameSimulation.getGrLayoutOpponent().repaint();
				//----------------------------------------------
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO();
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO().updateUI();
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO().repaint();
				//--------------------------------------------------------
				
				gameSimulation.getOpponentPlayerHand().viewhand();
				gameSimulation.getOpponentPlayerHand().updateUI();
				gameSimulation.getOpponentPlayerHand().repaint();
				//-----------------------------------------------
				gameSimulation.getGrLayoutDGActive();
				gameSimulation.getGrLayoutDGActive().updateUI();
				gameSimulation.getGrLayoutDGActive().repaint();
				//--------------------------------------------------------------
				gameSimulation.getActivePlayerNameLifepoints().viewlifepoints(homeScreen);
				gameSimulation.getActivePlayerNameLifepoints().getLifepoints();
				gameSimulation.getActivePlayerNameLifepoints().getLifepoints().updateUI();
				gameSimulation.getActivePlayerNameLifepoints().getLifepoints().repaint();
				
				gameSimulation.getActivePlayerNameLifepoints().getNamee();
				gameSimulation.getActivePlayerNameLifepoints().getNamee().updateUI();
				gameSimulation.getActivePlayerNameLifepoints().getNamee().repaint();
				//----------------------------------------------------------------
				gameSimulation.getOpp().viewlifepoints(gameSimulation, board, homeScreen);
				gameSimulation.getOpp().updateUI();
				//gameSimulation.getOpp().repaint();
				
				
				
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
			//------------------------------Player 2------------------------
			
			if (gameSimulation.getPlayerCounter()==1){
				if (Card.getBoard().getOpponentPlayer().getField().getPhase() == Phase.MAIN1) {

					Card.getBoard().getOpponentPlayer().endPhase();
					JOptionPane.showMessageDialog(gameSimulation,
							"Battle Phase ", "Phase Selection",
							JOptionPane.INFORMATION_MESSAGE);

				} else if (Card.getBoard().getOpponentPlayer().getField().getPhase() == Phase.BATTLE) {

					Card.getBoard().getOpponentPlayer().endPhase();
					JOptionPane.showMessageDialog(gameSimulation, "Main Phase 2",
							"Phase Selection", JOptionPane.INFORMATION_MESSAGE);
				}

				else if (Card.getBoard().getOpponentPlayer().getField().getPhase() == Phase.MAIN2) {
					//gameSimulation.getActivePlayerHand().viewhand();
					Card.getBoard().getOpponentPlayer().endTurn();
					//gameSimulation.getActivePlayerHand().viewhand();
					gameSimulation.getGrLayoutActive().viewmonsters();
					gameSimulation.getGrLayoutActive().viewspells();
					//gameSimulation.setPlayerCounter(0);
					gameSimulation.getGrLayoutDGActive().getCurrentTurn().setText(""+Card.getBoard().getActivePlayer().getName()+"'s"+" Turn");

					JOptionPane.showMessageDialog(gameSimulation,
							"Next Player Turn, Main Phase 1", "Switch Player",
							JOptionPane.INFORMATION_MESSAGE);
					gameSimulation.getOpponentPlayerHand().viewhand();
					gameSimulation.getOpponentPlayerHand().updateUI();
					gameSimulation.getOpponentPlayerHand().repaint();
					gameSimulation.getOpponentPlayerHand().validate();

				}
//				gameSimulation.getGrLayoutDGOpponent().getCurrentPhase().setText(""+Card.getBoard().getActivePlayer().getField().getPhase());
//				gameSimulation.getGrLayoutDGOpponent().getCurrentPhase().setHorizontalAlignment(SwingConstants.CENTER);
//				gameSimulation.getGrLayoutDGOpponent().getCurrentPhase().updateUI();
				
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO().setText(""+Card.getBoard().getOpponentPlayer().getField().getDeck().getDeck().size());
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO().setHorizontalAlignment(SwingConstants.CENTER);
				gameSimulation.getGrLayoutDGOpponent().getNumDeckO().updateUI();
				//--------------------------------------------
				//gameSimulation.getActivePlayerHand().viewhand();
				gameSimulation.getActivePlayerHand().updateUI();
				gameSimulation.getActivePlayerHand().repaint();
				//---------------------------------------//
				gameSimulation.getGrLayoutActive().viewmonsters();
				gameSimulation.getGrLayoutActive().updateUI();
				gameSimulation.getGrLayoutActive().repaint();
				//------------------------------------------
				gameSimulation.getGrLayoutActive().viewspells();
				gameSimulation.getGrLayoutActive().updateUI();
				gameSimulation.getGrLayoutActive().repaint();
				//-----------------------------------------------
				gameSimulation.getGrLayoutOpponent().launchOH();
				gameSimulation.getGrLayoutOpponent().viewspells();
				
				
				gameSimulation.getActivePlayerHand().validate();
				
			}
			
			
		}
	}
}
