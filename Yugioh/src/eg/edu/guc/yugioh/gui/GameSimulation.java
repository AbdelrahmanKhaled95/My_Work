package eg.edu.guc.yugioh.gui;

import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import eg.edu.guc.yugioh.board.Board;
import eg.edu.guc.yugioh.cards.Card;
import eg.edu.guc.yugioh.listeners.ActivePhaseListener;
import eg.edu.guc.yugioh.listeners.MouseHand;
import eg.edu.guc.yugioh.listeners.MouseMonsters;
import eg.edu.guc.yugioh.listeners.OpponentPhaseListener;
import eg.edu.guc.yugioh.listeners.homeScreenListener;

public class GameSimulation extends JFrame {

	private int PlayerCounter; // 0-----> OFF | 1 -------> ON
	ActivePlayerHand activePlayerHand;
	OpponentPlayerNameLifepoints opp;
	ActivePlayerNameLifepoints ActivePlayerNameLifepoints;


	OpponentPlayerHand opponentPlayerHand;
	public OpponentPlayerHand getOpponentPlayerHand() {
		return opponentPlayerHand;
	}

	GrLayoutActive  grLayoutActive;
	GrLayoutOpponent grLayoutOpponent;

	ActivePlayerPhase activePlayerPhase;
	GrLayoutDGActive grLayoutDGActive;
	GrLayoutDGOpponent grLayoutDGOpponent;




	JPanel Gr = new JPanel();

	public void setActivePlayerPhase(ActivePlayerPhase activePlayerPhase) {
		this.activePlayerPhase = activePlayerPhase;
	}

	public void setGrLayoutDGActive(GrLayoutDGActive grLayoutDGActive) {
		this.grLayoutDGActive = grLayoutDGActive;
	}

	public GrLayoutDGActive getGrLayoutDGActive() {
		return grLayoutDGActive;
	}



	public Board getBoard() {
		return board;
	}





	public void setGr(JPanel gr) {
		Gr = gr;
	}

	public static void setHand(JButton hand) {
		Hand = hand;
	}

	public void setBoard(Board board) {
		this.board = board;
	}

	static JButton Hand;
	Board board;

	// ---------------------------------------------------------------------------

	public GameSimulation(HomeScreen homeScreen,Board board) {


		this.board=board;
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		setSize(1920, 1080);

		setTitle("Let The Game Begin!");

		setContentPane(new JLabel(new ImageIcon("Yu-Gi-Oh!.full.186187.jpg")));

		//-----------------Active Player GUI---------------
		add(new OpponentPlayerNameLifepoints(this, board, homeScreen));
		// activePlayerSpells = new ActivePlayerSpells();
		activePlayerPhase = new ActivePlayerPhase();
		grLayoutDGActive = new GrLayoutDGActive();
		grLayoutActive=new GrLayoutActive(this, board, opp, homeScreen);
		activePlayerHand=new ActivePlayerHand(this, board, homeScreen);
		opponentPlayerHand=new OpponentPlayerHand(this, board, homeScreen);
		getContentPane().add(activePlayerHand);
		add(opponentPlayerHand);
		grLayoutActive=new GrLayoutActive(this, board, opp, homeScreen);
		add(grLayoutActive);
		add(grLayoutActive.getjPanel2());
		ActivePlayerNameLifepoints=new ActivePlayerNameLifepoints(homeScreen);
		ActivePlayerNameLifepoints.viewlifepoints(homeScreen);
		add(ActivePlayerNameLifepoints);

		add(ActivePlayerNameLifepoints.getNamee());
		add(ActivePlayerNameLifepoints.getLifepoints());


		grLayoutOpponent=new  GrLayoutOpponent(this, board, opp, homeScreen, null);

		add(grLayoutOpponent);
		add(grLayoutOpponent.getOpponentPlayerspells());

		opp=new OpponentPlayerNameLifepoints(this, board, homeScreen);
		add(opp.getLifepoints());
		add(opp);
		grLayoutDGActive=new GrLayoutDGActive();
		add(grLayoutDGActive);
		add(grLayoutDGActive.getDeckNumbWindow());
		add(grLayoutDGActive.getCurrentPhaseWindow());

		new ActivePhaseListener(activePlayerPhase, this, board, homeScreen);

		add(activePlayerPhase.getActivePlayerPhase());
		//add(new ActivePlayerMonsters().getActivePlayerMonsters());


		//-------------------Opponent Player GUI---------------------
		grLayoutDGOpponent = new GrLayoutDGOpponent();



		grLayoutDGOpponent=new GrLayoutDGOpponent();
		add(grLayoutDGOpponent);
		add(new GrLayoutDGOpponent().getDeckNumbWindowO());






		setVisible(true);

	}

	public ActivePlayerNameLifepoints getActivePlayerNameLifepoints() {
		return ActivePlayerNameLifepoints;
	}

	public GrLayoutOpponent getGrLayoutOpponent() {
		return grLayoutOpponent;
	}

	public ActivePlayerHand getActivePlayerHand() {
		return activePlayerHand;
	}

	public OpponentPlayerNameLifepoints getOpp() {
		return opp;
	}

	public GrLayoutActive getGrLayoutActive() {
		return grLayoutActive;
	}

	public ActivePlayerPhase getActivePlayerPhase() {
		return activePlayerPhase;
	}

	public GrLayoutDGOpponent getGrLayoutDGOpponent() {
		return grLayoutDGOpponent;
	}

	public static JButton getHand() {
		return Hand;
	}

	public JPanel getGr() {
		return Gr;
	}

	public int getPlayerCounter() {
		return PlayerCounter;
	}

	public void setPlayerCounter(int playerCounter) {
		PlayerCounter = playerCounter;
	}






	// ---------------------------------------------------------------------------

}