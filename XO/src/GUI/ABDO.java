package GUI;

import java.awt.BorderLayout;


import javax.swing.JFrame;
import javax.swing.JLabel;

public class ABDO extends JFrame{
	JLabel label1;
	JLabel label2;
	JLabel label3;
	public ABDO(){
		setVisible(true);
		setSize(300, 100);
		label1=new JLabel("PROUD TO SAY");
		label2=new JLabel("Made By:AbdoKhaledHD");
		label3=new JLabel("Copyright © All Rights Reserved");
		add(label1,BorderLayout.NORTH);
		add(label2,BorderLayout.CENTER);
		add(label3,BorderLayout.SOUTH);
		
	}
}