#include <iostream>
#include <ctime>
using namespace std;

int fibonacci(int number) {
    if (number == 0) { return 0; }
    else if (number == 1) { return 1; }
    else {
        int t1 = fibonacci(number - 1);
        int t2 = fibonacci(number - 2);
        return t1 + t2;
    }
}

int main() {
    fibonacci(30); //warmup
    for (int i = 10; i < 50; i += 5) {
        int start = clock();
        fibonacci(i);
        int stop = clock();
        cout << int((stop - start)/double(CLOCKS_PER_SEC)*1000) << endl;
    }
    return 0;
}

