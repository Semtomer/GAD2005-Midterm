
public static class TetrominoShapeData
{

    public static int[,] getShapeDataForDegrees(TetrominoType type, int rotationAngle) 
    {
        if (rotationAngle == 0)
        {
            switch (type)
            {
                case TetrominoType.LShaped2x1:
                    return new int[,] { { 1, 0 }, { 1, 1 } };

                case TetrominoType.LShaped3x2:
                    return new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };

                case TetrominoType.Square1x1:
                    return new int[,] { { 1 } };

                case TetrominoType.Square2x2:
                    return new int[,] { { 1, 1 }, { 1, 1 } };

                case TetrominoType.Square3x3:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                case TetrominoType.Rod2x1:
                    return new int[,] { { 1, 1 } };

                case TetrominoType.Rod3x1:
                    return new int[,] { { 1, 1, 1 } };

                case TetrominoType.Rod4x1:
                    return new int[,] { { 1, 1, 1, 1 } };

                case TetrominoType.Rod5x1:
                    return new int[,] { { 1, 1, 1, 1, 1 } };
            }
        }
        else if (rotationAngle == 90) 
        {
            switch (type)
            {
                case TetrominoType.LShaped2x1:
                    return new int[,] { { 1, 1 }, { 1, 0 } };

                case TetrominoType.LShaped3x2:
                    return new int[,] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } };

                case TetrominoType.Square1x1:
                    return new int[,] { { 1 } };

                case TetrominoType.Square2x2:
                    return new int[,] { { 1, 1 }, { 1, 1 } };

                case TetrominoType.Square3x3:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                case TetrominoType.Rod2x1:
                    return new int[,] { { 1 }, { 1 } };

                case TetrominoType.Rod3x1:
                    return new int[,] { { 1 }, { 1 }, { 1 } };

                case TetrominoType.Rod4x1:
                    return new int[,] { { 1 }, { 1 }, { 1 }, { 1 } };

                case TetrominoType.Rod5x1:
                    return new int[,] { { 1 }, { 1 }, { 1 }, { 1 }, { 1 } };
            }
        }
        else if (rotationAngle == 180)
        {
            switch (type)
            {
                case TetrominoType.LShaped2x1:
                    return new int[,] { { 1, 1 }, { 0, 1 } };

                case TetrominoType.LShaped3x2:
                    return new int[,] { { 1, 1, 1 }, { 0, 0, 1 }, { 0, 0, 1 } };

                case TetrominoType.Square1x1:
                    return new int[,] { { 1 } };

                case TetrominoType.Square2x2:
                    return new int[,] { { 1, 1 }, { 1, 1 } };

                case TetrominoType.Square3x3:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                case TetrominoType.Rod2x1:
                    return new int[,] { { 1, 1 } };

                case TetrominoType.Rod3x1:
                    return new int[,] { { 1, 1, 1 } };

                case TetrominoType.Rod4x1:
                    return new int[,] { { 1, 1, 1, 1 } };

                case TetrominoType.Rod5x1:
                    return new int[,] { { 1, 1, 1, 1, 1 } };
            }
        }
        else if (rotationAngle == 270)
        {
            switch (type)
            {
                case TetrominoType.LShaped2x1:
                    return new int[,] { { 0, 1 }, { 1, 1 } };

                case TetrominoType.LShaped3x2:
                    return new int[,] { { 0, 0, 1 }, { 0, 0, 1 }, { 1, 1, 1 } };

                case TetrominoType.Square1x1:
                    return new int[,] { { 1 } };

                case TetrominoType.Square2x2:
                    return new int[,] { { 1, 1 }, { 1, 1 } };

                case TetrominoType.Square3x3:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                case TetrominoType.Rod2x1:
                    return new int[,] { { 1 }, { 1 } };

                case TetrominoType.Rod3x1:
                    return new int[,] { { 1 }, { 1 }, { 1 } };

                case TetrominoType.Rod4x1:
                    return new int[,] { { 1 }, { 1 }, { 1 }, { 1 } };

                case TetrominoType.Rod5x1:
                    return new int[,] { { 1 }, { 1 }, { 1 }, { 1 }, { 1 } };
            }
        }
  
        return null;
    }
}
