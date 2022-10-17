import java.util.*;

public class MainProgram {

    public MainProgram(){

    }

    public static void main(String[] args) {
        Scanner scanner;
        String characters;

        scanner = new Scanner(System.in);
        System.out.println("Type your text:");
        characters = scanner.nextLine();
        System.out.println("Coded text: " + countCharacters(characters));
    }

    private static Map<Character, Integer> countCharacters(String characters) {
        Map<Character, Integer> codedCharPairs = new HashMap<>();

        for (Character character : getDuplicatesToDelete(characters)) {
            int numberOfDuplicates = 0;


            for (Character compare : characters.toCharArray()) {
                if (compare.equals(character)) {
                    numberOfDuplicates++;
                }
            }
            codedCharPairs.put(character, numberOfDuplicates);
        }
        return codedCharPairs;
    }

    private static HashSet<Character> getDuplicatesToDelete(String characters){
        HashSet<Character> duplicatesToDelete = new HashSet<>();
        for (int i = 0; i < characters.length(); i++) {
            duplicatesToDelete.add(characters.charAt(i));
        }
        return duplicatesToDelete;
    }
}
