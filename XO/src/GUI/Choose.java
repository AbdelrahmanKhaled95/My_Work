package GUI;

import java.awt.GridBagLayout;
import java.awt.GridLayout;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

import Controllar.One;
import Controllar.Two;

public class Choose extends JFrame{
	JButton oneplayer;
	JButton twoplayers;
	One one;
	Two two;
	public Choose(){
		one=new One(this);
		two=new Two(this);
		setVisible(true);
		setSize(300,320);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setTitle("TIC TOC");
		oneplayer=new JButton("One Player");
		twoplayers=new JButton("Two Players");
		setContentPane(new JLabel(new ImageIcon("tic-tac-toe.png")));
		getContentPane().setLayout(new GridBagLayout());
		oneplayer.addActionListener(one);
		twoplayers.addActionListener(two);
		add(oneplayer);
		add(twoplayers);
		revalidate();
		repaint();
		validate();
		
	}

}
