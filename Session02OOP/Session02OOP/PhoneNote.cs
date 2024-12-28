using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal struct PhoneNote
    {

        #region  Attributes
        //Attributes
        string[] Names;
        long[] Numbers;
        int size;
        #endregion

        #region  Property 
        public int Size//ReadOnly
        {
            get { return size; }
        }

        #endregion

        #region  Constructor 
        public PhoneNote(int _size)
        {
          
            size= _size>0?_size:10;
            Names = new string[size];
            Numbers = new long[size];
        }

        #endregion


        #region Method 

        //Add New Number
        public void AddNewNumber(int _position, String _Name, long _Number)
        {
            if (_position >= 0  && _position<size)
            {
                if (Names != null && Numbers != null)
                {
                    Names[_position] = _Name;
                    Numbers[_position] = _Number;
                }
             
            }

        }



        #endregion


        #region Property 

        #region Not Use Indexer

        //Get Number By Name 

        public long GetNumber(string _Name)
        {
            if (Names != null && Names != null)
            {

                for (int i = 0; i < Names.Length; i++)
                {
                    if (_Name == Names[i])
                    {
                        return Numbers[i];
                    }


                }

            }

            return -1;

        }

        //Set (Edit) Number By Name 

        public void SetNumber(string _Name, long _Number)
        {
            if (Names != null && Names != null)
            {

                for (int i = 0; i < Names.Length; i++)
                {
                    if (_Name == Names[i])
                    {
                        Numbers[i] = _Number;
                    }


                }

            }
        }

        #endregion

        #region Use Indexer 
        //Indexer => Is special Property  , Encapsulation Method 
        //1-Name Allows KeyWord => [(this)]
        //2-Can Take Parameter 
        public long this[string _Name]
        {
            get 
            {
                if (Names != null && Names != null)
                {

                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (_Name == Names[i])
                        {
                            return Numbers[i];
                        }


                    }

                }

                return -1;
            }
            set
            {
                if (Names != null && Names != null)
                {

                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (_Name == Names[i])
                        {
                            Numbers[i] = value;
                        }


                    }

                }
            }
        
        }
        #endregion


        #endregion


    }
}
