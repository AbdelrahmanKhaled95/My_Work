package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.GUI2;

public class Action6pc implements ActionListener{
	GUI2 g;
	XO xo;
	int count;
	public int getCount() {
		return count;
	}
	public Action6pc(GUI2 g,XO xo){
		this.g=g;
		this.xo=xo;
	}
	public void actionPerformed(ActionEvent e) {
		xo.insert(1,2);
		count++;
		g.buttons();
		

			
		// TODO Auto-generated method stub




	}

}

