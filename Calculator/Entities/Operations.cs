namespace Calculator.Entities {
    class Operations {

        public int FirstNum { get; set; }
        public int SecondNum { get; set; }

        public Operations() { }

        public Operations(int firstNum, int secondNum) {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }

        public int Summing(int num1, int num2) {
            return num1 + num2;
        }

        public int Subtracting(int num1, int num2) {
            return num1 - num2;
        }

        public int Multiplying(int num1, int num2) {
            return num1 * num2;
        }

        public int Dividing(int num1, int num2) {
            return num1 / num2;
        }

        public int RestOfDivision(int num1, int num2) {
            return num1 % num2;
        }

        public int Exponentiation(int num1, int num2) {
            int tot = 1;

            for (int i = 0; i < num2; i++) {
                tot *= num1;
            }

            return tot;
        }
    }
}
