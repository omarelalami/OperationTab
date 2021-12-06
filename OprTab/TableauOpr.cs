using System;
using System.Collections.Generic;
using System.Text;

namespace OprTab
{
    class TableauOpr
    {
        private static int dim;
        private int dimB;
        private static int ajouteE=0;
        private string TypeT;
        private string[] TableauString;
        private int[] TableauInt;
        private double[] TableauDouble;
        private float[] TableauFloat;

        public TableauOpr(int n, string TypeT)

        {
            TableauString = new string[n];
            dim = n;
            dimB = n;
            this.TypeT = TypeT;
        }
         

        public int GetDim()
        {   
            return dim;
        }
        public string GetElment(int i)
        {
            return TableauString[i];

        }
        public string GetTypeT()
        {
            return TypeT;
        }

        public void Ajouter(string valeur)
        {   
            
            
            
            if (ajouteE== dimB)
            {
                TableauString[ajouteE] = valeur;

                ajouteE++;
            }


        }

        public void Modifier(string valeur, int index)
        {


            TableauString[index] = valeur;



        }

        public void Supprimer(int index)

        {
            for (int i = index; i <= dimB; i++)
            {
                TableauString[i] = TableauString[i + 1];


                dimB--;
            }



        }
        public bool IsRange()
        {
            
            
            bool m = true;
            if (TypeT == "int")
            {
                TableauInt = new int[dimB];
                
                for (int i = 0; i <= dimB; i++)

                {
                    if (TableauInt[i] > TableauInt[i + 1])

                    {
                        m = false;
                        break;
                    }





           
                }
            }
            

            else if(TypeT=="double")
            {  TableauDouble= new double[dimB];
                for (int i = 0; i <= dimB; i++)
                    if (TableauDouble[i] > TableauDouble[i + 1])

                {
                    m = false;
                    break;
                }


                
            }
            else if (TypeT == "Float")
            {
                TableauFloat = new float[dimB];
                for (int i = 0; i <= dimB; i++)
                    if (TableauFloat[i] > TableauFloat[i + 1])

                    {
                        m = false;
                        break;
                    }



            }

            return m;
        }
        public string [] Concatnat(TableauOpr T)
        {
            string[] Taide = new string[T.GetDim() + dim];

            for(int i=0;i<dimB;i++)
            {

                Taide[i] = TableauString[i];


             }

            for (int i = dim, j = 0; i < dim + T.GetDim(); i++, j++)

                Taide[i] = T.GetElment(j);

            return Taide;

        }

        public bool Existe(string txt)
        {
            bool m = false;
            for (int i = 0; i < dimB; i++)
                if (txt == TableauString[i])
                {
                    m = true;
                    break;

                }
            return m;


        }
        public int CheckPos(string txt)
        {
            int l=-1;
            for(int i=0;i<dimB;i++)
            {
                if (txt == TableauString[i])
                    l = i;


            }

            return l;
        }

        public void Range()

        {
            if (TypeT == "int") ;



        }









                   
          

        




     }
















        


        










          
        
















    }

