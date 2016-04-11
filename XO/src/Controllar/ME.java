package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.GUI3;
import GUI.WhoStarts;

public class ME implements ActionListener{

	WhoStarts s;
	
	public ME(WhoStarts s){
		this.s=s;
	}
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		s.setVisible(false);
		XO xo=new XO();
		new GUI3(xo);
		


	}


}
