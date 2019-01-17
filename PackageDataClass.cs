using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirondackShippingLtd
{
    class PackageInfoClass
    {
        // PDMS
        private string pckgContents;
        private int shipMiles;
        private float pckgLength;
        private float pckgWidth;
        private float pckgHeight;
        private float pckgWeight;
        private float pckgSize;
        private float shipCost;

        //  CONSTRUCTOR
        public PackageInfoClass()
        {
            pckgContents = "";
            shipMiles = 0;
            pckgLength = 0f;
            pckgWidth = 0f;
            pckgHeight = 0f;
            pckgWeight = 0;
            pckgSize = 0f;
            shipCost = 0f;
        }

        // NON-DEFAULT CONSTRUCTOR
        public PackageInfoClass(PackageInfoClass copyPackage)
        {
            this.pckgContents = copyPackage.pckgContents;
            this.shipMiles = copyPackage.shipMiles;
            this.pckgLength = copyPackage.pckgLength;
            this.pckgWidth = copyPackage.pckgWidth;
            this.pckgHeight = copyPackage.pckgHeight;
            this.pckgWeight = copyPackage.pckgWeight;

        }

        // GET/SET

        /* pre: class values have been initialized to 0
        * post: value was received and stored to class PDM
        * Purpose: can get and set the value of pckgContents
        */
       
        public string GetPackageContents
        {
            get { return pckgContents; }
            set { pckgContents = value;}
        }

        /* pre: class values have been initialized to 0
       * post: value was received and stored to class PDM
       * Purpose: can get and set the value of shipMiles
       */
        public int GetShipMiles
        {
            get { return shipMiles; }
            set { shipMiles = value; }
        }

        /* pre: class values have been initialized to 0
       * post: value was received and stored to class PDM
       * Purpose: can get and set the value of pckgLength
       */
        public float GetPckgLength
        {
            get { return pckgLength; }
            set { pckgLength = value; }

        }

        /* pre: class values have been initialized to 0
       * post: value was received and stored to class PDM
       * Purpose: can get and set the value of pckgWidth
       */
        public float GetPckgWidth
        {
            get { return pckgWidth; }
            set { pckgWidth = value;}
        }

        /* pre: class values have been initialized to 0
       * post: value was received and stored to class PDM
       * Purpose: can get and set the value of pckgHeight
       */
        public float GetPckgHeight
        {
            get { return pckgHeight;}
            set { pckgHeight = value;}
        }

        /* pre: class values have been initialized to 0
       * post: value was received and stored to class PDM
       * Purpose: can get and set the value of pckgWeight
       */
        public float GetPckgWeight
        {
            get { return pckgWeight;}
            set { pckgWeight = value;}
        }

        

        // PUBLIC METHODS

        /* pre: submit button has not been hit yet, all text fields must be filled
         * post: shipping costs group is active and displaying the volume
         * purpose: Calculates the volume of the package entered based on L x W X H and returns it
         */
        public float CalculateVolume()
        {

            pckgSize = (pckgLength * pckgWidth * pckgHeight);

            return pckgSize;
        }

        /* pre: submit button has not been hit yet, all text fields must be filled in first
         * post: shipping costs group is active and displaying the shipping cost
         * purpose: Calculates the cost to ship based on the miles entered and weight of package and returns the cost
         */
        public float CalculateCost()
        {
            if (pckgWeight < 10)
            {
                shipCost = (float).50 * (float)shipMiles; 
            }

            else if (pckgWeight < 30)
            {
                shipCost = (float)1 * (float)shipMiles;
            }

            else if (pckgWeight > 100)
            {
                shipCost = (float).01 * (float)shipMiles;
            }

            else 
                shipCost = (float)2 * (float)shipMiles;

            return shipCost;
        }


    }
}
