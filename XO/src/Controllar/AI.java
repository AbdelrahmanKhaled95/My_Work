package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.GUI2;
import GUI.WhoStarts;


public class AI implements ActionListener{

	WhoStarts s;
	
	public AI(WhoStarts s){
		this.s=s;
	}
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		s.setVisible(false);
		XO xo=new XO();
		new GUI2(xo);
		
		
	}
	

}
