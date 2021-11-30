using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Algos
{
    public class BoxDistributor
    {
        public string move(int start, int end)
        {
            string direction = string.Empty;

            while (start != end)
            {
                if (start > end)
                {
                    direction += "LEFT|";
                    start--;
                }
                else
                {
                    direction += "RIGHT|";
                    start++;
                }
            }
            return direction;
        }

        //To find the first place from where to take box
        // and also the first place to put the box on , from left to right
        public Tuple<int, int> findFirstPositions(int[] list, int capacity)
        {
            int toTake = -1, toPut = -1;

            for (int i = 0; i < list.Length; i++)
            {
                // Stop, if the positions are found
                if (toTake != -1 && toPut != -1)
                    break;

                if (list[i] < capacity && toPut == -1)
                {
                    toPut = i;
                }

                if (list[i] > capacity && toTake == -1)
                {
                    toTake = i;
                }
            }

            return new Tuple<int, int>(toTake, toPut);
        }

        //To verify if boxes are equally distributed
        public bool verifyEqualDistrbution(int[] list, int equalSize)
        {
            foreach (var item in list)
                if (item > equalSize || item < equalSize)
                    return false;
            return true;
        }


        public  string solve(int clawPos, int[] boxes, bool clawHold)
        {
            string result = string.Empty;

            int capacity, totalBoxes = 0;

            //Calculate the total number of boxes
            foreach (var box in boxes)
            {
                totalBoxes += box;
            }

            // position capacity in odrer to have an equal distrubtion
            capacity = totalBoxes / boxes.Length;

            while (!verifyEqualDistrbution(boxes, capacity))
            {
                //find postitions
                Tuple<int, int> position = findFirstPositions(boxes, capacity);

                //Move claw to the pick position
                result += move(clawPos, position.Item1);
                clawPos = position.Item1;

                //Pick up
                result += "PICK|";
                boxes[position.Item1]--;

                // Move to put the box
                result += move(position.Item1, position.Item2);
                clawPos = position.Item2;

                //Put the box
                boxes[position.Item2]++;
                result += "PUT|";
            }

            return result;
        }

    }
}
