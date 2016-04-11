package GUI;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.GridLayout;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import Controllar.AI;
import Controllar.ME;

public class WhoStarts extends JFrame{
	JButton me;
	JButton pc;
	ME myself;
	AI computer;
	JPanel panel;
	public WhoStarts(){
		
		
		me=new JButton("Me");
		pc=new JButton("PC");
		myself=new ME(this);
		computer=new AI(this);
		setVisible(true);
		setSize(300,320);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setTitle("TIC TOC");
		setContentPane(new JLabel(new ImageIcon("tic-tac-toe.png")));
		getContentPane().setLayout(new GridBagLayout());
		me.addActionListener(myself);
		pc.addActionListener(computer);
		add(me);
		add(pc);
		
	}
}
