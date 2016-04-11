package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JOptionPane;

import Engine.XO;
import GUI.Gui;

public class Action implements ActionListener{
	Gui g;
	XO xo;
	int count;
	public int getCount() {
		return count;
	}
	public Action(Gui g,XO xo){
		this.g=g;
		this.xo=xo;
	}
	public void actionPerformed(ActionEvent e) {
		xo.insert(0,0);
		count++;
		g.buttons();
		

			
		// TODO Auto-generated method stub




	}

}
