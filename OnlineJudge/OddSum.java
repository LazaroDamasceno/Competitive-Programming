import java.util.*;
import java.util.stream.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner scanner = new Scanner(System.in);
		int counter = 0;
		int testcases = scanner.nextInt();
		while (testcases > 0) {
			int sum = 0;
			int begin = scanner.nextInt();
			int end = scanner.nextInt();
			for (int i = begin; i <= end; i++) if (i % 2 != 0) sum += i;
			System.out.printf("Case %d: %d\n", ++counter, sum);
			sum = 0;
			testcases--;
		}
		scanner.close();
	}

}
