package GUI;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import Controllar.Action2pc;
import Controllar.Action3pc;
import Controllar.Action4pc;
import Controllar.Action5pc;
import Controllar.Action6pc;
import Controllar.Action7pc;
import Controllar.Action8pc;
import Controllar.Action9pc;
import Controllar.Actionpc;
import Controllar.License;
import Controllar.Returnpc;
import Controllar.Newgame2;
import Controllar.Restartgame2;
import Engine.XO;

public class GUI2 extends JFrame{

	XO xo;
	int countlose;
	Players p;
	Returnpc r;
	boolean stop;
	boolean update;
	static int  countp1;
	static int countp2;
	Newgame2  newgame;
	Actionpc  action1;
	Action2pc action2;
	Action3pc action3;
	Action4pc action4;
	Action5pc action5;
	Action6pc action6;
	Action7pc action7;
	Action8pc action8;
	Action9pc action9;
	JPanel panel ;
	Restartgame2 restartgame;
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
	
	public GUI2(XO xo){

		newgame=new Newgame2(this,restartgame);
		setTitle("TIC TOC");
		this.xo=xo;
		license=new License();
		r=new Returnpc(this);
		action1=new Actionpc(this, xo);
		action2=new Action2pc(this, xo);
		action3=new Action3pc(this, xo);
		action4=new Action4pc(this, xo);
		action5=new Action5pc(this, xo);
		action6=new Action6pc(this, xo);
		action7=new Action7pc(this, xo);
		action8=new Action8pc(this, xo);
		action9=new Action9pc(this, xo);
		restartgame=new Restartgame2(this);
		menubar=new JMenuBar();
		setJMenuBar(menubar);
		file=new JMenu("Options");
		file2=new JMenu("About");
		menubar.add(file);
		menubar.add(file2);
		item3=new JMenuItem("New Game");
		item=new JMenuItem("Restart Game");
		item2=new JMenuItem("License");
		item4=new JMenuItem("Main Menu");
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
		
		xo.AI();
		panel.removeAll();
		p1=new JLabel("PC :"+countp1);
		p2=new JLabel("YOU :"+countp2);
		winner=new JLabel("Score "+restartgame.getCount());
		p1.setFont(new Font("Serif", Font.BOLD, 56));
		winner.setFont(new Font("Serif", Font.BOLD, 56));
		p2.setFont(new Font("Serif", Font.BOLD, 56));
		winner.setForeground(Color.red);
		panel.add(p1);
		panel.add(winner);
		panel.add(p2);

		if(xo.Check(0, 0)==false){
			
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
		if(xo.Check(0, 1)==false){
			
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
		if(xo.Check(0, 2)==false){
			
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
		if(xo.Check(1, 0)==false){
			
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
		if(xo.Check(1, 1)==false){
			
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
		if(xo.Check(1, 2)==false){
			
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
		if(xo.Check(2, 0)==false){
			
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
		if(xo.Check(2, 1)==false){
			
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
		if(xo.Check(2, 2)==false){
			
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

				JOptionPane.showMessageDialog(this, "PC Wins");
				update=true;
				buttons();
			}
			else{
				java.awt.Toolkit.getDefaultToolkit().beep();
				countp2++;

				JOptionPane.showMessageDialog(this,"YOU Wins");
				update=true;
				buttons();
			}
			stop=true;
			return;

		}
		if(countlose==5){
			System.out.print(countlose);
			java.awt.Toolkit.getDefaultToolkit().beep();
			JOptionPane.showMessageDialog(this, "Game Over ");
			return;
		}

	}
	public void setCountlose(int countlose) {
		this.countlose = countlose;
	}
	public static void setCountp1(int countp1) {
		GUI2.countp1 = countp1;
	}
	public static void setCountp2(int countp2) {
		GUI2.countp2 = countp2;
	}
	public static int getCountp1() {
		return countp1;
	}
	public static int getCountp2() {
		return countp2;
	}
}