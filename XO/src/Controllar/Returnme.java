package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.Choose;
import GUI.GUI3;


public class Returnme implements ActionListener{
	GUI3 g;
	public Returnme(GUI3 g){
		this.g=g;
	}

	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		g.setVisible(false);
		new Choose();
		new XO();
		g.setCountp1(0);
		g.setCountp2(0);
		
	}

}

