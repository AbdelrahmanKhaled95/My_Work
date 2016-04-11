package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import GUI.Choose;
import GUI.WhoStarts;

public class One implements ActionListener{

	Choose o;
	public One(Choose o){
		this.o=o;
	}
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		new WhoStarts();
		o.setVisible(false);
		
	}

}
