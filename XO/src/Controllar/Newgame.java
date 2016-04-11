package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.Gui;
import GUI.Main;
import GUI.Players;

public class Newgame implements ActionListener{
	Gui g;
	Players p;
	Restartgame r;
	public Newgame(Gui g,Players p,Restartgame r){
		this.g=g;
		this.p=p;
		this.r=r;
	}
		public void actionPerformed(ActionEvent e) {
			java.awt.Toolkit.getDefaultToolkit().beep();
			g.setCountlose(0);
			g.setVisible(false);
			XO xo=new XO();
			new Players();
			g.setCountp1(0);
			g.setCountp2(0);
			r.setCount(0);

			
			
		}

	}


