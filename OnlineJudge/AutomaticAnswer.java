import java.util.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner input = new Scanner(System.in);
		int testcases = input.nextInt();
		while(testcases != 0) {
			int number = input.nextInt();
			number *= 567;
			number /= 9;
			number += 7492; 
			number *= 235; 
			number /= 47;
			number -= 498;
			System.out.println(Math.abs((number % 100) / 10));
			testcases--;
		}
		input.close();
	}

}

// https://onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&page=show_problem&problem=2542
