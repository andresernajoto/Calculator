namespace Calculator.Entities {
    class Operations {

        // atributes
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        // construct with no parameters
        public Operations() { }

        // construct with atributes
        public Operations(double firstNum, double secondNum) {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }

        // does the sum calcule
        public double Summing(double num1, double num2) {
            return num1 + num2;
        }

        // does the subtraction calcule
        public double Subtracting(double num1, double num2) {
            return num1 - num2;
        }

        // does the multiplication calcule
        public double Multiplying(double num1, double num2) {
            return num1 * num2;
        }

        // does the division calcule
        public double Dividing(double num1, double num2) {
            if (num1 == 0 || num2 == 0) {
                return 0;
            } else {
                return num1 / num2;
            }
            
        }

        // does the rest of division calcule
        public double RestOfDivision(double num1, double num2) {
            return num1 % num2;
        }

        // does the exponentiation calcule
        public double Exponentiation(double num1, double num2) {
            double tot = 1;

            for (double i = 0; i < num2; i++) {
                tot *= num1;
            }

            return tot;
        }
    }
}
