package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JOptionPane;

import Engine.XO;
import GUI.Gui;

public class Action6 implements ActionListener{
	Gui g;
	XO xo;
	int count;
	public int getCount() {
		return count;
	}
	public Action6(Gui g,XO xo){
		this.g=g;
		this.xo=xo;
	}
	public void actionPerformed(ActionEvent e) {
		xo.insert(1,2);
		count++;
		g.buttons();
		
	}
}
