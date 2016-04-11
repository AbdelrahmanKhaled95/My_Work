package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.Choose;
import GUI.GUI2;


public class Returnpc implements ActionListener{
	GUI2 g;
	public Returnpc(GUI2 g){
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
