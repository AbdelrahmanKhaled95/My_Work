package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import GUI.Choose;
import GUI.Players;


public class Two implements ActionListener{

	Choose c;
	public Two(Choose c){
		this.c=c;
	}
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		c.setVisible(false);
		new Players();
		
	}

}
