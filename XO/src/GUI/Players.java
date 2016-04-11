package GUI;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import Controllar.Button;

public class Players extends JFrame{
	JLabel label1;
	JLabel label2;
	JTextField text1;
	JTextField text2;
	JButton button;
	Button b;
	public Players(){
		setTitle("TIC TOC");
		getContentPane().setLayout(new GridLayout(3, 2));
		b=new Button(this);
		setVisible(true);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setSize(400, 300);
		label1=new JLabel("Player 1");
		label2=new JLabel("player 2");
		text1=new JTextField();
		text2=new JTextField();
		button=new JButton("Start");
		add(label1);
		add(text1);
		add(label2);
		add(text2);
		add(button);
		
		button.addActionListener(b);
		revalidate();
		repaint();
		validate();
		
	}
	public JTextField getText1() {
		return text1;
	}
	public JTextField getText2() {
		return text2;
	}

}
