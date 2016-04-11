package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import Engine.XO;
import GUI.GUI2;


public class Restartgame2 implements ActionListener{
	GUI2 g;
	static int count;
	public Restartgame2(GUI2 g){
		this.g=g;
		
	}
	
	public void actionPerformed(ActionEvent e) {
		java.awt.Toolkit.getDefaultToolkit().beep();
		count++;
		g.setCountlose(0);
		g.setVisible(false);
		XO xo=new XO();
		new GUI2(xo);
		


	}

	public static void setCount(int count) {
		Restartgame2.count = count;
	}

	public int getCount() {
		return count;
	}

}
