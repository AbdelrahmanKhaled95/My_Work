package eg.edu.guc.yugioh.listeners;

import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.ImageIcon;
import javax.swing.JFrame;




import javax.swing.JLabel;
import javax.swing.JOptionPane;

import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.cards.spells.ChangeOfHeart;
import eg.edu.guc.yugioh.cards.spells.GracefulDice;
import eg.edu.guc.yugioh.cards.spells.HeavyStorm;
import eg.edu.guc.yugioh.cards.spells.MagePower;
import eg.edu.guc.yugioh.cards.spells.SpellCard;
import eg.edu.guc.yugioh.gui.GameSimulation;
import eg.edu.guc.yugioh.gui.GrLayoutActive;
import eg.edu.guc.yugioh.gui.GrLayoutDGActive;

public class MouseSpells implements MouseListener{
	JFrame m;
	GrLayoutActive grLayoutActive;
	GameSimulation gameSimulation;
	
	public MouseSpells(GrLayoutActive grLayoutActive,
			GameSimulation gameSimulation) {
		this.gameSimulation=gameSimulation;
		this.grLayoutActive=grLayoutActive;

		
		m=new JFrame();
	}
	@Override
	public void mouseClicked(MouseEvent e) {
		int index=grLayoutActive.getSpells().indexOf(e.getSource());
		SpellCard spell=Card.getBoard().getActivePlayer().getField().getSpellArea().get(index);
		if(spell instanceof ChangeOfHeart||spell instanceof MagePower||spell instanceof HeavyStorm||spell instanceof GracefulDice){
		JOptionPane.showMessageDialog(gameSimulation,
				"Please select a monster ", "active spell",
				JOptionPane.ERROR_MESSAGE);
		//Card.getBoard().getActivePlayer().activateSpell(spell, monster)
		gameSimulation.getGrLayoutActive().viewmonsters();
		gameSimulation.getGrLayoutActive().viewspells();
		gameSimulation.getGrLayoutActive().updateUI();
		gameSimulation.getGrLayoutActive().repaint();
		//---------------------------------------------
		gameSimulation.getActivePlayerHand().viewhand();
		gameSimulation.getActivePlayerHand().updateUI();
		gameSimulation.getActivePlayerHand().repaint();
		//---------------------------------------------
		gameSimulation.getGrLayoutOpponent().launchOH();
		gameSimulation.getGrLayoutOpponent().viewspells();
		gameSimulation.getGrLayoutOpponent().updateUI();
		gameSimulation.getGrLayoutOpponent().repaint();
		}
		else{
			Card.getBoard().getActivePlayer().activateSpell(spell, null);
			gameSimulation.getGrLayoutActive().viewmonsters();
			gameSimulation.getGrLayoutActive().viewspells();
			gameSimulation.getGrLayoutActive().updateUI();
			gameSimulation.getGrLayoutActive().repaint();
			//---------------------------------------------
			gameSimulation.getActivePlayerHand().viewhand();
			gameSimulation.getActivePlayerHand().updateUI();
			gameSimulation.getActivePlayerHand().repaint();
			//---------------------------------------------
			gameSimulation.getGrLayoutOpponent().launchOH();
			gameSimulation.getGrLayoutOpponent().viewspells();
			gameSimulation.getGrLayoutOpponent().updateUI();
			gameSimulation.getGrLayoutOpponent().repaint();
			new GrLayoutDGActive();
			//-------------------------------------------
			gameSimulation.getGrLayoutDGOpponent();
			gameSimulation.getGrLayoutDGOpponent().updateUI();
			gameSimulation.getGrLayoutDGOpponent().repaint();
			//--------------------------------------------
			gameSimulation.getGrLayoutDGActive();
			gameSimulation.getGrLayoutDGActive().updateUI();
			gameSimulation.getGrLayoutDGActive().repaint();
		
		}
		
		
	}
	@Override
	public void mouseEntered(MouseEvent e) {
		m.validate();
		m.repaint();
		m=new JFrame();
		int index=grLayoutActive.getSpells().indexOf(e.getSource());
				m.setVisible(true);
				m.setSize(400, 600);
				m.add(new JLabel(new ImageIcon(Card.getBoard().getActivePlayer().getField().getSpellArea().get(index).getName()+"b.png")));
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
