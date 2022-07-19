import java.util.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner input = new Scanner(System.in);
		int counter = 1;
		int testcases = input.nextInt();
		while (testcases != 0) {
			Vector<Integer> salaries = new Vector<>();
			salaries.add(input.nextInt());
			salaries.add(input.nextInt());
			salaries.add(input.nextInt());
			salaries.remove(Collections.max(salaries));
			salaries.remove(Collections.min(salaries));
			System.out.printf("Case %d: %d\n", counter++, salaries.elementAt(0));
			salaries.clear();
			testcases--;
		}
		input.close();
	}

}
