using System;

public class MathHelper {

    public static int GetPercentByMaxAndMin(int value, int minValue, int maxValue) {
        if (minValue == 0 && maxValue == 0) {
            return 100;
        }

        int percent = Math.Abs((minValue - value)) * 100 / (maxValue - minValue);

        if (percent > 100) {
            percent = 100;
        } else if (percent < 0) {
            percent = 0;
        }

        return percent;
    }

}