package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import Engine.XO;
import GUI.Gui;
import GUI.Players;

public class Restartgame implements ActionListener{
	Gui g;
	Players p;
	static int count;
	public Restartgame(Gui g,Players p){
		this.g=g;
		this.p=p;
	}
	
	public void actionPerformed(ActionEvent e) {
		java.awt.Toolkit.getDefaultToolkit().beep();
		count++;
		g.setCountlose(0);
		g.setVisible(false);
		XO xo=new XO();
		new Gui(xo,p);


	}
	public int getCount() {
		return count;
	}

	public static void setCount(int count) {
		Restartgame.count = count;
	}

}
