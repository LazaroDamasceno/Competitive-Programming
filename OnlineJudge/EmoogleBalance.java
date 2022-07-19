import java.util.*;
import java.util.stream.*;

public class Main {

	public static void main(String[] args) {
		Scanner token = new Scanner(System.in);
		int cases = 1;
		while (true) {
			int length = token.nextInt();
			if (length == 0) break;
			int[] treats = new int[length];
			for (int i = 0; i < length; i++) {
				treats[i] = token.nextInt();
			}
			int givenTreats = (int) IntStream.of(treats).filter(i->i==0).count();
			int migthGivenTreats = (int) IntStream.of(treats).filter(i->i!=0).count();
			System.out.printf("Case %d: %d\n", cases++, migthGivenTreats - givenTreats);
		}
		token.close();
	}

}
