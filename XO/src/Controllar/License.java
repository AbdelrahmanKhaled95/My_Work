package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import GUI.ABDO;

public class License implements ActionListener{

	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		java.awt.Toolkit.getDefaultToolkit().beep();
		new ABDO();
		
		
	}

}
