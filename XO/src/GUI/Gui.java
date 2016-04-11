package GUI;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.util.Random;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import Controllar.Action;
import Controllar.Action2;
import Controllar.Action3;
import Controllar.Action4;
import Controllar.Action5;
import Controllar.Action6;
import Controllar.Action7;
import Controllar.Action8;
import Controllar.Action9;
import Controllar.License;
import Controllar.Newgame;
import Controllar.Restartgame;
import Controllar.Return;
import Engine.XO;

public class Gui extends JFrame{
	XO xo;
	int countlose;
	Players p;
	Return r;
	boolean stop;
	boolean update;
	static int  countp1;
	static int countp2;
	Newgame  newgame;
	Action  action1;
	Action2 action2;
	Action3 action3;
	Action4 action4;
	Action5 action5;
	Action6 action6;
	Action7 action7;
	Action8 action8;
	Action9 action9;
	JPanel panel ;
	Restartgame restartgame;
	License license;
	boolean Endgame2;
	JMenuBar menubar;
	JMenu file;
	JMenu file2;
	JMenuItem item;
	JMenuItem item2;
	JMenuItem item3;
	JMenuItem item4;
	JLabel p1;
	JLabel p2;
	JLabel winner;
	public Gui(XO xo,Players p){
			this.p=p;
		newgame=new Newgame(this, p,restartgame);
		setTitle("TIC TOC");
		this.xo=xo;
		license=new License();
		r=new Return(this);
		action1=new Action(this, xo);
		action2=new Action2(this, xo);
		action3=new Action3(this, xo);
		action4=new Action4(this, xo);
		action5=new Action5(this, xo);
		action6=new Action6(this, xo);
		action7=new Action7(this, xo);
		action8=new Action8(this, xo);
		action9=new Action9(this, xo);
		restartgame=new Restartgame(this,p);
		menubar=new JMenuBar();
		setJMenuBar(menubar);
		file=new JMenu("Options");
		file2=new JMenu("About");
		menubar.add(file);
		menubar.add(file2);
		item3=new JMenuItem("New Game");
		item4=new JMenuItem("Main Menu");
		item=new JMenuItem("Restart Game");
		item2=new JMenuItem("License");
		file.add(item4);
		file.add(item3);
		file.add(item);
		file2.add(item2);
		item.addActionListener(restartgame);
		item2.addActionListener(license);
		item3.addActionListener(newgame);
		item4.addActionListener(r);
		
		setVisible(true);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setSize(600, 600);
		panel = new JPanel(new GridLayout(4, 3));
		add(panel);

		buttons();



	}
	public JPanel getPanel() {
		return panel;
	}
	public void buttons(){
		if(stop==true)
			return;
		countlose++;
		panel.removeAll();
		
		p1=new JLabel(""+p.getText1().getText()+":"+getCountp1());
		p2=new JLabel(""+p.getText2().getText()+":"+getCountp2());
		winner=new JLabel("Score "+restartgame.getCount());
		p1.setFont(new Font("Serif", Font.BOLD, 56));
		winner.setFont(new Font("Serif", Font.BOLD, 56));
		p2.setFont(new Font("Serif", Font.BOLD, 56));
		winner.setForeground(Color.red);
		panel.add(p1);
		panel.add(winner);
		panel.add(p2);
		if(action1.getCount()==0){
			JButton a = new JButton();
			panel.add(a);
			a.addActionListener(action1);
		}
		else{
			if(xo.photo(0, 0)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action2.getCount()==0){
			JButton b = new JButton();
			panel.add(b);
			b.addActionListener(action2);
		}
		else{
			if(xo.photo(0, 1)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action3.getCount()==0){
			JButton c = new JButton();
			panel.add(c);
			c.addActionListener(action3);
		}
		else{
			if(xo.photo(0, 2)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}

		if(action4.getCount()==0){
			JButton d = new JButton();
			panel.add(d);
			d.addActionListener(action4);
		}
		else{
			if(xo.photo(1, 0)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action5.getCount()==0){
			JButton e = new JButton();
			panel.add(e);
			e.addActionListener(action5);
		}
		else{
			if(xo.photo(1, 1)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action6.getCount()==0){
			JButton f = new JButton();
			panel.add(f);
			f.addActionListener(action6);
		}
		else{
			if(xo.photo(1, 2)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action7.getCount()==0){
			JButton g = new JButton();
			panel.add(g);
			g.addActionListener(action7);
		}
		else{
			if(xo.photo(2, 0)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action8.getCount()==0){
			JButton h = new JButton();
			panel.add(h);
			h.addActionListener(action8);
		}
		else{
			if(xo.photo(2, 1)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}
		if(action9.getCount()==0){
			JButton i = new JButton();
			panel.add(i);
			i.addActionListener(action9);
		}
		else{
			if(xo.photo(2, 2)==true){
				panel.add(new JButton(new ImageIcon("X.jpg")));
			}
			else{
				panel.add(new JButton(new ImageIcon("O.jpg")));
			}
		}



		revalidate();
		repaint();
		validate();

		if(xo.isEndgame()==true){
			Endgame2=true;

		}

		if(Endgame2==true){
			if(update==true)
				return;
			if(xo.isWhowins()==true){
				java.awt.Toolkit.getDefaultToolkit().beep();
				countp1++;
				
					JOptionPane.showMessageDialog(this, "Alf Alf mabrouk ya "+p.getText1().getText());
				update=true;
				buttons();
			}
			else{
				java.awt.Toolkit.getDefaultToolkit().beep();
				countp2++;
				
					JOptionPane.showMessageDialog(this,"Alf Alf mabrouk ya "+p.getText2().getText());
				update=true;
				buttons();
			}
			stop=true;
			return;

		}
		if(countlose==10){
			java.awt.Toolkit.getDefaultToolkit().beep();
			JOptionPane.showMessageDialog(this, "Game Over ");
			return;
		}

	}
	public void setCountlose(int countlose) {
		this.countlose = countlose;
	}
	public static void setCountp1(int countp1) {
		Gui.countp1 = countp1;
	}
	public static void setCountp2(int countp2) {
		Gui.countp2 = countp2;
	}
	public static int getCountp1() {
		return countp1;
	}
	public static int getCountp2() {
		return countp2;
	}
}