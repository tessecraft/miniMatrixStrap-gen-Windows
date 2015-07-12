using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniMatrixStrap_gen
{
    class FileData
    {
        public Boolean[,] data;
        public int width;
        public int height;
        public Boolean modified = false;
        public Boolean newFile = true;
                
        
        public FileData(int _width, int _height)
        {
            width = _width;
            height = _height;

            data = new Boolean[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    data[i, j] = false;
                }
            }

        }

    }
}
