package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.GUI3;
import GUI.WhoStarts;


public class Newgame3 implements ActionListener{
	GUI3 g;
	Restartgame3 r;
	
	public Newgame3(GUI3 g,Restartgame3 r){
		this.g=g;
		this.r=r;
	}
		public void actionPerformed(ActionEvent e) {
			java.awt.Toolkit.getDefaultToolkit().beep();
			g.setCountlose(0);
			g.setVisible(false);
			XO xo=new XO();
			new WhoStarts();
			g.setCountp1(0);
			g.setCountp2(0);
			r.setCount(0);

			
			
		}

	}



