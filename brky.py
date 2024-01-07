## This is a calculator that calculates your %40 midterm and %60 final score and prints your lecture score.
print("Please follow the steps below.");
mid = int(input("Please enter your midterm score."));
final = int(input("Please enter your final score."));
score = mid * 0.4 + final * 0.6;
print(score);
if score < 50 :
    print("FAILED !");
else :
    print("PASSED ! ");
