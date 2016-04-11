package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JOptionPane;

import Engine.XO;
import GUI.GUI3;


public class Action2me implements ActionListener{
	GUI3 g;
	XO xo;
	int count;
	public int getCount() {
		return count;
	}
	public Action2me(GUI3 g,XO xo){
		this.g=g;
		this.xo=xo;
	}
	public void actionPerformed(ActionEvent e) {
		xo.insert(0,1);
		count++;
		g.buttons();
	}
}
