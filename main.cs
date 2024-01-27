using System;

class Program {
  public static void Main (string[] args) {
    
    int[] unsorted_array = { 5, 12, 8, 3, 17, 8, 25, 10, 14, 6, 21, 15, 9, 11, 5, 20, 13, 18, 7, 16 };

    bubblesort(unsorted_array);
    
    for (int i = 0; i < unsorted_array.Length; i++){
      Console.WriteLine(unsorted_array[i]);
    }
  }

  public static void bubblesort(int[] array){
    int temp = 0;

    for (int i = 0; i < array.Length; i++){
      for (int j = 0; j < array.Length; j++){
        if (array[i] < array[j]){
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
      }
    }
  }
}