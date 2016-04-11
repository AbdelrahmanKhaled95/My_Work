package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import Engine.XO;
import GUI.GUI3;


public class Restartgame3 implements ActionListener{
	GUI3 g;
	static int count;
	public Restartgame3(GUI3 g){
		this.g=g;
		
	}
	
	public void actionPerformed(ActionEvent e) {
		java.awt.Toolkit.getDefaultToolkit().beep();
		count++;
		g.setCountlose(0);
		g.setVisible(false);
		XO xo=new XO();
		new GUI3(xo);
		


	}

	public static void setCount(int count) {
		Restartgame2.count = count;
	}

	public int getCount() {
		return count;
	}

}

