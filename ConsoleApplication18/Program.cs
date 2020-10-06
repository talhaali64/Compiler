using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace ta
{



   /* class A
    {
        private int i;
        public int a = 2, b = 3;
        public A[] ss = new A[2];
        public int s()
        {
            return 1;
        }
    }
    class B : A
    {


        private string v = "a";

        A add = new B();


        public void q(A[] a)
        {

            // add.ss[1].v = "A";
            // add.ss[1].
            B[] w = new B[2];
            A[] k = new A[2];
            int[] s = new int[] { };
            char[] b = new char[] { };
            char d = 'a';
            // a[1]++;
            k[1] = new A();
            int value = 5;
            for (int i = 0; i < k[3].a; i++)
            {

            }
            if (value < 1)
            {
                int j = 0;
            }
            else if (true)
            {
                int j = 1;
            }



        }
    }
    */ 



    class ICG
    {
        Queue a = new Queue();

        int label = 1;
        int temp = 1;
        public string CreateLabel()
        {
            return "L" + label++;
        }
        public string CreateTemp()
        {
            return "t" + temp++;
        }
        public void IC(string I)
        {
            a.Enqueue(I);
        }
        public void Write()
        {
            StreamWriter wr = new StreamWriter("E:\\ICG.txt");

            foreach (string q in a)
            {
                wr.WriteLine(q);

            }
            wr.Dispose();


        }
    }
    class Semantic
    {

        //B q = new B();


        Stack s = new Stack();
        string type = "", z = "";

        ArrayList Comp_Operators = new ArrayList() { "&&", "||", "<=", ">=", "!=", "==", "<", ">" };


        List<int> t = new List<int>();
        ArrayList Namea_RT = new ArrayList();
        ArrayList Typea_RT = new ArrayList();
        ArrayList Cata_RT = new ArrayList();
        ArrayList Parenta_RT = new ArrayList();

        ArrayList Namea_CT = new ArrayList();
        ArrayList Typea_CT = new ArrayList();
        ArrayList AMa_CT = new ArrayList();
        ArrayList TMa_CT = new ArrayList();
        ArrayList cna_CT = new ArrayList();
        ArrayList PLa_CT = new ArrayList();
        ArrayList Cona_CT = new ArrayList();
        ArrayList Paa_CT = new ArrayList();
        ArrayList Ret_CT = new ArrayList();

        ArrayList Namea_FT = new ArrayList();
        ArrayList Typea_FT = new ArrayList();
        ArrayList scopea_FT = new ArrayList();
        ArrayList cna_FT = new ArrayList();
        ArrayList conc_FT = new ArrayList();


        public Semantic()
        {

        }
        public bool Get_FN(string cna, int ch)
        {

            List<int> temp = new List<int>();


            for (int j = 0; j < Namea_FT.Count; j++)
            {
                if (cna == Namea_FT[j].ToString())
                {
                    if (ch == (int)scopea_FT[j])
                    {
                        return true;
                    }





                }
            }
            return false;
        }
        public List<int> Get_CN(string cna, ArrayList Input)
        {
            List<int> temp = new List<int>();


            for (int j = 0; j < Input.Count; j++)
            {
                if (cna == Input[j].ToString())
                {

                    temp.Add(j);


                }
            }
            return temp;
        }

        public List<int> Get_FN(int scope)
        {
            List<int> temp = new List<int>();


            for (int j = 0; j < scopea_FT.Count; j++)
            {
                if (scope == (int)scopea_FT[j])
                {

                    temp.Add(j);


                }
            }
            return temp;
        }
        /*     public List<int> Get_RN(string cna)
             {
                 List<int> temp = new List<int>();


                 if (cna_CT != null)
                 {
                     for (int j = 0; j < cna_CT.Count; j++)
                     {
                         if (cna == Namea_RT[j].ToString())
                         {

                             temp.Add(j);


                         }
                     }
                     return temp;
                 }
                 return temp;
             }
         */
        public List<int> Get_CN(string cna, ArrayList Input, ArrayList Input1, string ch)
        {
            List<int> temp = new List<int>();


            for (int j = 0; j < Input.Count; j++)
            {
                if (cna == Input[j].ToString() == true)
                {
                    if (ch == Input1[j].ToString() == true)
                    {
                        temp.Add(j);
                    }





                }
            }
            return temp;
        }

        public bool RT(string Name)
        {
            if (Check(Namea_RT, Name) == true)
            {
                return true;
            }
            return false;
        }
        public bool Lookup_R(string Name, string ch)
        {
            for (int j = 0; j < Namea_RT.Count; j++)
            {
                if (Name == Namea_RT[j].ToString() == true)
                {
                    if (ch == Cata_RT[j].ToString() == true)
                    {

                        return true;
                    }





                }
            }
            return false;

        }
        public string Comp(string Type1, string Type2, string op)
        {





            if (Check(Comp_Operators, op) == true)
            {
                if (Type1 == Type2)
                {
                    return Type1;
                }
                else if (Type1 == "int" && (Type2 != "string" && RT(Type2) == false))
                {
                    return Type1;
                }
                else if (Type1 == "float" && (Type2 != "string" && RT(Type2) == false))
                {
                    return Type1;
                }
                else if (Type1 == "char" && (Type2 != "string" && RT(Type2) == false))
                {
                    return Type1;
                }

            }
            else if (op == "+=" || op == "-=" || op == "*=" || op == "/=" || op == "%=")
            {

                if (Type1 == Type2)
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "int"))
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "int" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "float"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "int"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && RT(Type2) == true))
                {
                    return Type1;
                }
                else
                {
                    return "";
                }



            }
            else if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%")
            {
                if (Type1 == Type2)
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "int"))
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "int" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "float"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "int"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "string" && RT(Type2) == true))
                {
                    return Type1;
                }
                else
                {
                    return "";
                }

            }
            else if (op == "=")
            {
                if (Type1 == Type2)
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "int"))
                {
                    return Type1;
                }
                else if ((Type1 == "float" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((Type1 == "int" && Type2 == "char"))
                {
                    return Type1;
                }
                else if ((RT(Type1) == true && RT(Type2) == true))
                {
                    return Type1;
                }
                else
                {
                    return "";
                }
            }
            return "";

        }



        public bool Lookup(string Name, ArrayList Input)
        {
            if (Check(Input, Name) == true)
            {
                return true;
            }

            /*  int i = Input.BinarySearch(Name);
              if (i == -1)
              {
                  return true;
              }
             */
            return false;
        }
        public bool insertRT(string Name, string Type, string Cat, string Parent, int line)
        {



            if (Check(Namea_RT, Name) == false)
            {
                // if (Lookup_RT(Name) == false)
                // {                




                Namea_RT.Add(Name);
                Typea_RT.Add(Type);
                Cata_RT.Add(Cat);
                Parenta_RT.Add(Parent);


                return true;

            }
            else
            {
                Console.WriteLine("Redeclaration Error at ine " + line);
                return false;
            }



            //  }

            // return false;
            /*if (a.Equals(Name) == false)
            {
                a.Add(new Semantic() {Namea = Name, Typea = Type, Cata = Cat, Parenta = Parent, cna = cn});
            }
            return true;
             */


        }


        public bool insertCT(string Name, string Type, string AMM, string TM, string cna, int line, string PL, string conc, string Pa, string ret)
        {


            List<int> a = Get_CN(cna, cna_CT);
            if (Lookup_R(cna, "static") == true && Name != "main")
            {

                if (LookupCT(Name, cna, line, Type) == false && Name != cna && TM == "static" && Check(Namea_RT, Name) == false)
                {

                    Namea_CT.Add(Name);
                    Typea_CT.Add(Type);
                    AMa_CT.Add(AMM);
                    TMa_CT.Add(TM);
                    cna_CT.Add(cna);
                    PLa_CT.Add(PL);
                    Cona_CT.Add(conc);
                    Paa_CT.Add(Pa);
                    Ret_CT.Add(ret);

                    return true;
                }
                else if (Check(Namea_CT, Name) == false && TM == "static" && Check(Namea_RT, Name) == false)
                {


                    Namea_CT.Add(Name);
                    Typea_CT.Add(Type);
                    AMa_CT.Add(AMM);
                    TMa_CT.Add(TM);
                    cna_CT.Add(cna);
                    PLa_CT.Add(PL);
                    Cona_CT.Add(conc);
                    Paa_CT.Add(Pa);
                    Ret_CT.Add(ret);
                    return true;
                }

                return false;
            }

            else
            {



                if (Lookup_CT(Name, cna, line, "con") == true && line == -1)
                {

                    List<int> t = Get_CN(Name, Namea_CT, Cona_CT, "con");

                    foreach (int z in t)
                    {

                        Namea_CT[z] = Name;
                        Typea_CT[z] = Type;
                        AMa_CT[z] = AMM;
                        TMa_CT[z] = TM;
                        cna_CT[z] = cna;
                        PLa_CT[z] = PL;
                        Cona_CT[z] = conc;
                        Paa_CT[z] = Pa;
                        Ret_CT[z] = ret;
                        return true;
                    }
                }

                else if (LookupCT(Name, cna, line, Type) == false && Name != cna && Name != "main")
                {

                    Namea_CT.Add(Name);
                    Typea_CT.Add(Type);
                    AMa_CT.Add(AMM);
                    TMa_CT.Add(TM);
                    cna_CT.Add(cna);
                    PLa_CT.Add(PL);
                    Cona_CT.Add(conc);
                    Paa_CT.Add(Pa);
                    Ret_CT.Add(ret);
                    return true;
                }




                else if (Check(Namea_CT, Name) == false)
                {


                    Namea_CT.Add(Name);
                    Typea_CT.Add(Type);
                    AMa_CT.Add(AMM);
                    TMa_CT.Add(TM);
                    cna_CT.Add(cna);
                    PLa_CT.Add(PL);
                    Cona_CT.Add(conc);
                    Paa_CT.Add(Pa);
                    Ret_CT.Add(ret);
                    return true;
                }

                return false;
            }




        }
        public bool insertFT(string Name, string cn, string Type, int scope, int line, string conc)
        {

            /*if (LookupFT(Name, line, cn, ref type) == false)
            {
                Namea_FT.Add(Name);
                Typea_FT.Add(Type);
                scopea_FT.Add(scope);
                cna_FT.Add(scope);

                return true;
            }

             */
            if (Check(Namea_FT, Name) == false)
            {

                Namea_FT.Add(Name);
                Typea_FT.Add(Type);
                scopea_FT.Add(scope);
                cna_FT.Add(cn);
                conc_FT.Add(conc);

                return true;

            }

            else if (Check(Namea_FT, Name) == true)
            {



                if (Get_FN(Name, scope) == false)
                {

                    Namea_FT.Add(Name);
                    Typea_FT.Add(Type);
                    scopea_FT.Add(scope);
                    cna_FT.Add(cn);
                    conc_FT.Add(conc);



                    return true;
                }
                else if (Get_FN(Name, scope) == true)
                {

                    Console.WriteLine("Redeclaration Error at Line " + Name + line);
                }

            }
            /* else if (LookupFT(Name, line, cn, ref type) == true)
              {
                  int i = Namea_FT.BinarySearch(Name);
                  if (scope != (int)scopea_FT[i] && i != -1)
                  {
                      Namea_FT.Add(Name);
                      Typea_FT.Add(Type);
                      scopea_FT.Add(scope);

                      return true;
                  }
                  else
                  {
                      Console.WriteLine("Redeclaration Error at Line " + line);
                  }

              }
             */


            return false;
        }
        public bool Check_Inh(string name, int line)
        {
            if (Check(Namea_RT, name) == true)
            {


                if (Lookup_R(name, "static") == true)
                {
                    Console.WriteLine("Error: Class " + name + " is static and cannot be inherited");
                    return false;


                }
                else if (Lookup_R(name, "seal") == true)
                {
                    Console.WriteLine("Error: Class " + name + " is seal and cannot be inherited");
                    return false;


                }




            }
            else if (Check(Namea_RT, name) == false)
            {
                Console.WriteLine("Error: Class " + name + " doesn't exist");
                return false;


            }
            return true;

        }
        public void LookupCT(string name, string cn, int line, ref string type, ref string am, ref string tm)
        {

            //LookupCT(name, cn, line, "");
            List<int> a = Get_CN(cn, cna_CT);

            for (int i = 0; i < a.Count; i++)
            {

                if (Namea_CT[i].ToString() == name)
                {

                    type = Typea_CT[i].ToString();
                    am = AMa_CT[i].ToString();
                    tm = TMa_CT[i].ToString();
                }
            }
        }
        public bool LookupCT(string name, string cn, int line, ref string type, ref string z)
        {

            List<int> a = Get_CN(cn, cna_CT);


            foreach (int i in a)
            {

                if (Namea_CT[i].ToString() == name)
                {

                    type = Typea_CT[i].ToString();
                    z = Cona_CT[i].ToString();

                    return true;
                }
            }
            return false;
        }
        public bool CT(string name, string cn, int line, ref string type, ref string z, ref string x, ref string m, ref string n)
        {

            List<int> a = Get_CN(cn, cna_CT);


            foreach (int i in a)
            {

                if (Namea_CT[i].ToString() == name)
                {

                    type = Cona_CT[i].ToString();
                    z = PLa_CT[i].ToString();
                    x = Ret_CT[i].ToString();
                    m = AMa_CT[i].ToString();
                    n = Typea_CT[i].ToString();

                    return true;
                }
            }
            return false;
        }
        public string Lookup_CT(string name, string cn, int line, ref string Pa)
        {
            String Conc;
            List<int> a = Get_CN(cn, cna_CT);


            foreach (int i in a)
            {


                if (Namea_CT[i].ToString() == name)
                {




                    Conc = Cona_CT[i].ToString();
                    Pa = Paa_CT[i].ToString();


                    return Conc;



                }
            }


            return "";
        }
        public string Lookup_Obj(string Name, ref string Type2, ref string Type3)
        {
            string conc;
            for (int k = 0; k < Cona_CT.Count; k++)
            {

                if (Name == Namea_CT[k].ToString())
                {
                    if (Cona_CT[k].ToString() == "con" || Cona_CT[k].ToString() == "obj")
                    {
                        conc = Cona_CT[k].ToString();
                        Type2 = cna_CT[k].ToString();
                        Type3 = PLa_CT[k].ToString();

                        return conc;
                    }

                }
            }
            return null;
        }
        public string Lookup_Class(string Name)
        {
            string cn;
            for (int k = 0; k < Cona_CT.Count; k++)
            {

                if (Name == Namea_CT[k].ToString())
                {


                    cn = cna_CT[k].ToString();
                    return cn;


                }
            }
            return "";
        }

        public bool LookupCT(string name, string cn, int line, string PL)
        {


            List<int> a = Get_CN(cn, cna_CT);


            foreach (int i in a)
            {


                if (Namea_CT[i].ToString() == name)
                {

                    if (Typea_CT[i].ToString() == PL)
                    {

                        return true;
                    }

                }
            }

            return false;
        }
        public bool Lookup_CT(string name, string cn, int line, string Conc)
        {


            List<int> a = Get_CN(cn, cna_CT);


            foreach (int i in a)
            {

                if (Namea_CT[i].ToString() == name)
                {

                    if (Cona_CT[i].ToString() == Conc)
                    {

                        return true;
                    }

                }
            }

            return false;
        }
        public bool LookupFT(string name, int line, string cn, ref string type, ref string z)
        {
            t.Reverse();

            foreach (int j in t)
            {
                List<int> temp = Get_FN(j);
                foreach (int i in temp)
                {
                    if (Namea_FT[i].ToString() == name)
                    {
                        type = Typea_FT[i].ToString();
                        z = conc_FT[i].ToString();
                        return true;
                    }

                }
            }

            return false;
        }
        public void CreateScope(ref int scope)
        {
            scope++;
            s.Push(scope);
            t.Add(scope);

        }
        public void DestroyScope(ref int scope)
        {
            s.Pop();
        }



        public bool Check(ArrayList Input, string Check)
        {

            for (int k = 0; k < Input.Count; k++)
            {

                if (Check == Input[k].ToString())
                {

                    return true;
                }
            }
            return false;
        }
        public IEnumerator Check_AA(ArrayList Input, string Check)
        {
            IEnumerator e = Input.GetEnumerator();
            while (e.MoveNext())
            {
                Object obj = e.Current;

                if (Check == obj.ToString())
                {
                    return e;
                }

            }
            return e;

        }
        /*public int Check_I(ArrayList Input, string Check)
        {

            for (int k = 0; k < Input.Count; k++)
            {

                if (Check == Input[k].ToString())
                {
                    return k;
                }
            }
            return 0;
        }
        
         */

        public void Pr()
        {
            Console.WriteLine("\nReference Table: ");
            for (int i = 0; i < Namea_RT.Count; i++)
            {
                Console.WriteLine(Namea_RT[i] + " " + Typea_RT[i] + " " + Cata_RT[i] + " " + Parenta_RT[i]);
            }

            Console.WriteLine("\nClass Table: ");
            for (int i = 0; i < Namea_CT.Count; i++)
            {
                Console.WriteLine(Namea_CT[i] + " " + Typea_CT[i] + " " + AMa_CT[i] + " " + TMa_CT[i] + " " + cna_CT[i]/* + " " + Cona_CT[i] + " " + Paa_CT[i] + " " + PLa_CT[i]*/);
            }
            Console.WriteLine("\nFunction Table: ");
            for (int i = 0; i < Namea_FT.Count; i++)
            {
                Console.WriteLine(Namea_FT[i] + " " + Typea_FT[i] + " " + scopea_FT[i] /*+ " " + cna_FT[i] + " " + conc_FT[i]*/);
            }

        }

    }
    class Syntax
    {

        ICG w = new ICG();
        Semantic q = new Semantic();

        String Type, cn, Name, Name1, AMM, TM, Cat, op;
        String Type1, PLL, Type2, Type3, Type5;
        String P = "", Type4 = "", Type6 = "", Type7 = "", Type10 = "", Type9 = "";
        String Pa = "", ret = "", Name_1 = "", Name_2 = "", Type11 = "", Type_Conc = "", Type_PLL = "", Type_Ret = "", Type_AMM = "", Type_T = "";
        String temp = "";
        int a = 0, g = 0;
        int b = 0, c = 0;
        String conc = "";
        String var = "", var1 = "", var2 = "";
        String Parent = "";
        Stack s = new Stack();
      //  Stack fun = new Stack();

        string[] cp = new string[Node.c_part.Count];
        string[] vp = new string[Node.v_part.Count];
        int[] line = new int[Node.lin.Count];

        int scope, j = 0;

        public Syntax()
        {

        }
        public void Struce()
        {

            for (int i = 0; i < cp.Length; i++)
            {
                vp[i] = Node.v_part.Dequeue();
                cp[i] = Node.c_part.Dequeue();
                line[i] = Node.lin.Dequeue();
            }
            if (Class_Dec() == true)
            {
                Console.WriteLine("Syntax is Valid");
            }
            else
            {
                Console.WriteLine("Syntax isn't Valid at Line No." + line[j]);
            }
            q.Pr();
            w.Write();

        }

        

        public bool Class_Dec()
        {

            if (Cat_St(ref Cat) == true)
            {
                if (cp[j] == "class")
                {
                    Type = cp[j];
                    j++;
                    if (cp[j] == "Identifier")
                    {
                        cn = vp[j];
                        j++;
                        if (Inherit_St(ref Parent) == true)
                        {

                            if (Parent == "" || Parent != "")
                            {

                                if (Cat == "static" || Cat == "abstract")
                                {

                                    q.insertRT(cn, Type, Cat, Parent, line[j]);
                                }
                                else if (Parent == String.Empty)
                                {


                                    q.insertRT(cn, Type, Cat, Parent, line[j]);
                                    q.insertCT(cn, "void", "", "", cn, line[j], "void", "con", "", ret);
                                }
                                else if (Parent != String.Empty)
                                {

                                    q.insertRT(cn, Type, Cat, Parent, line[j]);

                                    q.insertCT(cn, "void", "", "", cn, line[j], "void", "con", Parent, ret);

                                }

                            }




                            if (cp[j] == "{")
                            {
                                j++;
                                if (Class_St(cn) == true)
                                {
                                    if (cp[j] == "}")
                                    {
                                        j++;


                                        if (Class_Dec() == true)
                                        {
                                            return true;
                                        }

                                    }
                                }
                            }
                        }
                    }

                }

            }

            else if (cp[j] == "$")
            {


                return true;
            }
            return false;
        }

        public bool Cat_St(ref string Cat)
        {


            if (cp[j] == "seal" || cp[j] == "static" || cp[j] == "abstract")
            {
                Cat = cp[j];
                j++;
                return true;
            }
            else if (cp[j] == "class")
            {
                Cat = "general";
                return true;
            }
            return false;
        }
        public bool Static_St(ref string TM)
        {
            if (cp[j] == "static")
            {
                TM = cp[j];
                j++;
                return true;
            }
            else if (cp[j] == "Datatype" || cp[j] == "Identifier" || cp[j] == "void" || cp[j] == "abstract")
            {
                TM = "";
                return true;
            }
            return false;
        }


        public bool Initialization_Class(string LT)
        {
            if (cp[j] == "=")
            {
                
               // q.insertCT("A", Type, AMM, TM, cn, line[j], P, conc, Pa, ret);
                op = "=";

                j++;
                if (Initialization_Class1(LT) == true)
                {
                    return true;
                }


            }
            else if (cp[j] == ";" || cp[j] == "," || cp[j] == ")")
            {
                return true;
            }
            return false;
        }
        public bool Initialization_Class1(string Type1)
        {
            if (cp[j] == "Identifier")
            {
                Name = vp[j];
                
                q.LookupCT(vp[j], cn, line[j], ref Type3, ref Type5);

                if (q.Comp(Type1, Type3, "=") == "")
                {
                    Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                }
                else
                {
                    Type = q.Comp(Type1, Type3, "=");
                }
                j++;




                if (Initialization_Class(Type) == true)
                {
                    return true;

                }

            }

            else if (Constant(ref Type2, ref Name) == true)
            {
                
                if (q.Comp(Type1, Type2, "=") == "")
                {
                    Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                }

                return true;
            }
            return false;
        }
        public bool List(string Name, string s, int c, string AMM, string TM, string Type, string cn)
        {
            if (cp[j] == ",")
            {
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    q.insertCT(Name, Type, AMM, TM, cn, line[j], P, conc, Pa, ret);

                    j++;
                    if (Initialization_Class(Type) == true)
                    {
                        if (List(Name,"",c, AMM, TM, Type, cn) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == ";")
            {
                if (c==1)
                {
                    string type = q.Lookup_CT(s, s, line[j], ref Pa);


                   if (type != "con")
                   {
                        Console.WriteLine("Error: Constructor does not exist on line " +line[j]);
                   }
                   if (type == "con")
                   {
                       if (q.Lookup_Obj(Name, ref Type2, ref Type3) == "obj")
                       {
                           Console.WriteLine("Error: Object redeclared on line " + line[j]);
                       }
                   }
                    
                    q.insertCT(Name, s, AMM, TM, cn, line[j], P, conc, Pa, ret);
                }
                j++;
                return true;
            }
            return false;
        }
        public bool Initialization_Func(string Na, string LT)
        {
            if (cp[j] == "=")
            {
              //  q.insertFT(Na, cn, LT, scope, line[j], conc);
                op = "=";
                j++;


                if (Initialization_Func1(Na, LT) == true)
                {
                    return true;
                }

            }
            else if (cp[j] == ";" || cp[j] == "," || cp[j] == ")")
            {
                w.IC(Na);

                return true;
            }
            return false;
        }
        public bool Initialization_Func1(string var1, string Type)
        {
            if (cp[j] == "Identifier")
            {
                q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5);
                if (q.Comp(Type, Type1, "=") == "")
                {
                    Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                }
                else
                {
                    Type = q.Comp(Type, Type1, "=");
                }
                Name = vp[j];
                
               
                w.IC(var1 + " = " + Name);
                var1 = "";


                j++;


                if (Initialization_Func(Name, Type) == true)
                {
                    return true;

                }


            }

            else if (Constant(ref Type1, ref Name) == true)
            {
                if (q.Comp(Type, Type1, "=") == "")
                {
                    Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                }
                else
                {
                    Type = q.Comp(Type, Type1, "=");
                }
                

                w.IC(var1 + " = " + Name);
                var1 = "";
         //       Console.WriteLine(Na + " = " + Name);
                return true;
            }
            return false;
        }
        public bool List_Func(string var1, string Name, string s, int c, int scope, string Type, String cn)
        {
            if (cp[j] == ",")
            {
                var1 += " , ";
                j++;
                if (cp[j] == "Identifier")
                {
                    
                    Name = vp[j];
                    var1 = Name;
                    q.insertFT(Name, cn, Type, scope, line[j], conc);

                    j++;
                    if (Initialization_Func(var1, Type) == true)
                    {
                        if (List_Func(var1, Name,"", 0, scope, Type, cn) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == ";")
            {

                
                if (c==1)
                {
                    w.IC(var1);
                    var1 = "";
                    string type = q.Lookup_CT(Name, Name, line[j], ref Pa);


                    if (type != "con")
                    {
                        Console.WriteLine("Error: Constructor does not exist on line " + line[j]);
                    }
                    if (type == "con")
                    {
                        if (q.LookupFT(s, line[j], cn, ref Type3, ref Type5) == true)
                        {
                            Console.WriteLine("Error: Redeclaration on line " + line[j]);
                        }
                    }

                    q.insertFT(s, cn, Name, scope, line[j], conc);
                }

                j++;
                return true;
            }
            return false;
        }
        public bool Constant(ref string Type, ref string Name)
        {

            if (cp[j] == "int")
            {
                Name = vp[j];
                Type = cp[j];
                j++;
                return true;
            }
            else if (cp[j] == "float")
            {
                Name = vp[j];
                Type = cp[j];
                j++;
                return true;
            }
            else if (cp[j] == "char")
            {
                Name = vp[j];
                Type = cp[j];
                j++;
                return true;
            }
            else if (cp[j] == "string")
            {
                Name = vp[j];
                Type = cp[j];
                j++;
                return true;
            }
            return false;
        }
        public bool Inherit_St(ref string Parent)
        {

            if (cp[j] == "inherit")
            {
                j++;
                if (cp[j] == "Identifier")
                {

                    Parent = vp[j];
                    if (q.Check_Inh(Parent, line[j]) == false)
                    {
                        Parent = String.Empty;

                    }









                    j++;
                    return true;
                }
            }
            else if (cp[j] == "{")
            {

                return true;
            }
            return false;
        }
        public bool Assignment(ref string op)
        {
            if (cp[j] == "Assignment Operators")
            {
                op = vp[j];
                j++;
                return true;
            }
            else if (cp[j] == "=")
            {
                op = vp[j];
                j++;
                return true;
            }
            return false;
        }
        public bool Body(ref string Type11, ref string Type5, int scope, int b, string Toype, string Mode)
        {
            if (cp[j] == ";")
            {
                j++;
                return true;
            }



            else if (Statement(ref Type11, ref Type5, scope, b, Toype, Mode) == true)
            {
                return true;
            }

            return false;
        }
        public bool Statement(ref string Type11, ref string Type5, int scope, int b, string Toype, string Mode)
        {
            if (Func_Main(ref Type11, ref Type5, scope, b, Toype, Mode) == true)
            {
                if (Statement(ref Type11, ref Type5, scope, b, Toype, Mode) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool Return_St(ref string Type11, ref string Type5, int b, string Toype, string Mode)
        {
            if (cp[j] == "return")
            {
                j++;
                if (Return_St1(ref Name_2, ref Type11, ref Type5, b) == true)
                {
                    w.IC("return "+ Name_2);
                    if (Type11 != "" && Toype == "void" && Mode == "void")
                    {

                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                    }
                    else if (Type11 != Toype && (Toype == "int" || Toype == "char" || Toype == "string" || Toype == "float") && Mode == "Datatype")
                    {

                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);


                    }
                    else if (Type11 != Toype && (q.RT(Toype) == true) && Mode == "obj")
                    {

                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);


                    }
                    else if (Mode == "array")
                    {
                        if (q.RT(Toype) == false)
                        {

                            if (Type11 != "int" && Type11 != "string" && Type11 != "char" && Type11 != "float" && q.RT(Type11) == false)
                            {
                                Console.WriteLine("Error: Class doesn't exist on line " + line[j]);
                            }
                            if (Type5 != "array")
                            {
                                Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                            }
                            else if (Type5 == "array")
                            {

                                if (Type11 != Toype)
                                {
                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                }
                            }

                        }
                        else if (q.RT(Toype) == true)
                        {

                            if (Type5 != "obj_arr")
                            {
                                Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                            }
                            else if (Type5 == "obj_arr")
                            {
                                if (Type11 != Toype)
                                {
                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                }
                            }
                        }
                    }
                    else if (Mode == "marray")
                    {
                        if (q.RT(Toype) == false)
                        {

                            if (Type11 != "int" && Type11 != "string" && Type11 != "char" && Type11 != "float" && q.RT(Type11) == false)
                            {
                                Console.WriteLine("Error: Class doesn't exist on line " + line[j]);
                            }
                            if (Type5 != "marray")
                            {
                                Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                            }
                            else if (Type5 == "marray")
                            {

                                if (Type11 != Toype)
                                {
                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                }
                            }

                        }
                        else if (q.RT(Toype) == true)
                        {

                            if (Type5 != "obj_marr")
                            {
                                Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                            }
                            else if (Type5 == "obj_marr")
                            {
                                if (Type11 != Toype)
                                {
                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                }
                            }
                        }
                    }





                    if (cp[j] == ";")
                    {

                        j++;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Return_St1(ref string Name_2, ref string Type11, ref string Type5, int b)
        {
            if (Expression(ref Name_2, scope, ref Type11, ref Type5, cn, b, 1) == true)
            {
                return true;
            }
            else if (cp[j] == ";")
            {
                return true;
            }
            return false;
        }
        public bool Id_Constant(ref string Type1, ref string N)
        {
            if (cp[j] == "Identifier")
            {
                N = vp[j];
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                    {
                        Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line " + line[j]);
                    }
                }
                j++;
                return true;
            }
            else if (Constant(ref Type1, ref N) == true)
            {
                return true;
            }
            return false;
        }
        public bool If_Else(int scope, string Toype, string Mode)
        {
            if (cp[j] == "if")
            {
                j++;
                if (cp[j] == "(")
                {
                    w.IC(w.CreateLabel());
                    string n = w.CreateLabel();
                    q.CreateScope(ref scope);
                    j++;
                    if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
                    {
                        w.IC("if ( " + Name_2 + " == false");
                        w.IC("jmp " + n);
                        if (cp[j] == ")")
                        {
                            j++;
                            if (cp[j] == "{")
                            {
                                j++;
                                if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                                {

                                    if (cp[j] == "}")
                                    {
                                        w.IC(n + ":");
                                        q.DestroyScope(ref scope);
                                        j++;
                                        if (OElse(Toype, Mode) == true)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool OElse(string Toype, string Mode)
        {
            if (cp[j] == "else")
            {
                j++;
                if (cp[j] == "{")
                {
                    q.CreateScope(ref scope);
                    j++;
                    if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                    {
                        if (cp[j] == "}")
                        {
                            w.IC(w.CreateLabel());
                            q.DestroyScope(ref scope);
                            j++;
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == "loop" || cp[j] == "switch" || cp[j] == "return" || cp[j] == "if" || cp[j] == "break" || cp[j] == "Increment Decrement" || cp[j] == "Identifier" || cp[j] == "Datatype" || cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool Switch_St(int scope, string Toype, string Mode)
        {
            if (cp[j] == "switch")
            {
                j++;
                if (cp[j] == "(")
                {
                    w.IC(w.CreateLabel()+":");
                    j++;
                    if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
                    {
                        
                        if (cp[j] == ")")
                        {
                            j++;
                            if (cp[j] == "{")
                            {
                                j++;
                                string la = w.CreateLabel();
                                if (Case_St(la,scope, Toype, Mode) == true)
                                {
                                    if (ODef(la,scope, Toype, Mode) == true)
                                    {
                                        if (cp[j] == "}")
                                        {
                                            
                                            w.IC(la + ":");
                                            j++;
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Case_St(string la, int s, string Toype, string Mode)
        {
            if (cp[j] == "case")
            {
                q.CreateScope(ref scope);
                j++;
                string n = "";
                if (Id_Constant(ref Type, ref n) == true)
                {
                    string l = w.CreateLabel();
                    w.IC(l+":");
                    w.IC(w.CreateTemp() + "= " + n);
                    if (cp[j] == ":")
                    {
                        j++;
                        if (cp[j] == "{")
                        {
                            j++;
                            if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                            {
                                if (cp[j] == "}")

                                {
                                    q.DestroyScope(ref scope);
                                    j++;
                                    if (cp[j] == "break")
                                    {
                                        j++;
                                        w.IC("jmp " + la);
                                        if (cp[j] == ";")
                                        {
                                            j++;
                                            if (Case_St(la, scope, Toype, Mode) == true)
                                            {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "def" || cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool ODef(string la, int scope, string Toype, string Mode)
        {
            if (cp[j] == "def")
            {
                q.CreateScope(ref scope);
                j++;
                if (cp[j] == ":")
                {
                    string l = w.CreateLabel();
                    w.IC(l + ":");
                    
                    j++;
                    if (cp[j] == "{")
                    {
                        j++;
                        if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                        {
                            if (cp[j] == "}")
                            {
                                q.DestroyScope(ref scope);
                                j++;
                                if (cp[j] == "break")
                                {
                                    j++;
                                    w.IC("jmp " + la);
                                    if (cp[j] == ";")
                                    {
                                        j++;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        
        public bool Dt_Id(ref string Type, ref string Type6, ref string conc)
        {
            if (cp[j] == "Datatype")
            {
                Type = vp[j];
                Type6 = cp[j];
                conc = "";
                j++;
                return true;
            }
            else if (cp[j] == "Identifier")
            {

                if (q.RT(vp[j]) == true)
                {
                    Type = vp[j];
                    Type6 = cp[j];
                    conc = "obj";
                }
                else if (q.RT(vp[j]) == false)
                {
                    Console.WriteLine("Error: Incorrect type on line " + line[j]);
                }


                j++;
                return true;
            }

            return false;
        }
        public bool Method_Dt(ref string Type, ref string Type6)
        {
            if (Dt_Id(ref Type, ref Type6, ref conc) == true)
            {
                if (Method_Dt1(Type, Type6, ref conc) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "void")
            {
                Type = cp[j];
                j++;
                return true;
            }
            return false;
        }
        public bool Method_Dt1(string Type, string Type6, ref string conc)
        {
            if (cp[j] == "[")
            {
                j++;
                if (Method_Dt2(Type, Type6, ref conc) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "Identifier" || cp[j] == "main")
            {

                return true;
            }
            return false;
        }
        public bool Method_Dt2(string Type, string Type6, ref string conc)
        {
            if (cp[j] == "]")
            {
                if (Type6 == "Datatype")
                {
                    conc = "array";
                }
                else if (q.RT(Type) == true)
                {
                    conc = "obj_arr";
                }
                j++;
                return true;
            }
            else if (cp[j] == ",")
            {
                j++;
                if (cp[j] == "]")
                {
                    if (Type6 == "Datatype")
                    {
                        conc = "marray";
                    }
                    else if (q.RT(Type) == true)
                    {
                        conc = "obj_marr";
                    }
                    j++;
                    return true;
                }
            }
            return false;
        }
        public bool Method_Dec(int scope, ref string PL)
        {


            if (Dt_Id(ref Type, ref Type6, ref conc) == true)
            {

                PL = Type;



                if (Method_Dt1(Type, Type6, ref conc) == true)
                {

                    if (cp[j] == "Identifier")
                    {

                        Name = vp[j];
                        q.insertFT(Name, cn, Type, scope, line[j], conc);
                        conc = "";
                        j++;
                        if (Initialization_Class(Type) == true)
                        {

                            if (Method_List(PL, scope, ref PL) == true)
                            {

                                return true;
                            }
                        }
                    }
                }
            }
            else if (cp[j] == ")")
            {
                PL = "void";
                return true;
            }
            return false;
        }
        public bool Method_List(string T, int scope, ref string PL)
        {
            if (cp[j] == ",")
            {
                j++;
                if (Dt_Id(ref Type, ref Type6, ref conc) == true)
                {


                    PL = T + "," + Type;


                    if (Method_Dt1(Type, Type6, ref conc) == true)
                    {

                        if (cp[j] == "Identifier")
                        {

                            Name = vp[j];
                            q.insertFT(Name, cn, Type, scope, line[j], conc);
                            conc = "";
                            j++;
                            if (Initialization_Class(Type) == true)
                            {

                                if (Method_List(PL, scope, ref PL) == true)
                                {

                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == ")")
            {


                return true;
            }
            return false;
        }
              
        public bool Main_Par(ref string PL)
        {
            if (cp[j] == "Datatype")
            {
                PL = vp[j];
                j++;

                if (cp[j] == "[")
                {
                    j++;
                    if (cp[j] == "]")
                    {
                        j++;
                        if (cp[j] == "args")
                        {
                            j++;
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == ")")
            {
                PL = "void";
                return true;
            }
            return false;
        }
        public bool Array(string var1, int scope, string Type, string Name, int a)
        {

            if (cp[j] == "[")
            {
                var1 += "[";
                if (a == 1)
                {
                    string type = q.Lookup_CT(Name, cn, line[j], ref Pa);


                    if (q.Lookup_Obj(Name, ref Type2, ref Type3) != "con")
                    {
                        Console.WriteLine("Error: Constructor does not exist on line " + Name + line[j]);
                    }
                }
                j++;
                if (Array_1(var1, scope, Type, Name, a) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Array_1(string var1, int scope, string Type, string Name, int a)
        {
            if (cp[j] == "]")
            {
             //   Console.WriteLine(line[j] + vp[j] + cp[j]);
                var1 += "]";
                j++;
                if (cp[j] == "Identifier")
                {
                    Name1 = vp[j];
                    var1 += Name1;
               //     Console.WriteLine(line[j] + vp[j] + cp[j]);
                    if (a == 0)
                    {
                        q.insertFT(Name1, cn, Type, scope, line[j], "array");
                    }
                    j++;
                    if (SArray_FuncB(var1, Name1, Name, scope, Type, a) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (cp[j] == "]")
                {
                    var1 += "]";
                    j++;
                    if (cp[j] == "Identifier")
                    {

                        Name1 = vp[j];
                        var1 += Name1;
                        if (a == 0)
                        {
                            q.insertFT(Name1, cn, Type, scope, line[j], "marray");
                        }
                        j++;
                        if (MArray_FuncB(var1, Name1, Name, scope, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool SArray_A( string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == ";")
            {
               
                if (a == 1)
                {
                    q.insertCT(Name, Type, AMM, "", cn, line[j], P, "obj_arr", Pa, ret);
                }
                if (a == 0)
                {

                    q.insertCT(Name, Type, AMM, TM, cn, line[j], P, "array", Pa, ret);
                }

                j++;
                return true;
            }
            else if (cp[j] == ",")
            {
               
                j++;
                if (cp[j] == "Identifier")
                {
                    
                    if (a == 0)
                    {
                        Name = vp[j];
                        
                        q.insertCT(Name, Type, AMM, TM, cn, line[j], P, "array", Pa, ret);
                    }

                    j++;
                    if (SArray_B(Name, cn, AMM, TM, Type, a) == true)
                    {

                        return true;
                    }
                }
            }
            return false;
        }
        public bool SArray_B(string Name, string cn, string AMM, string TM, string Type, int a)
        {

            if (cp[j] == "=")
            {
                
                j++;
                if (SArray_Initialization_Class( Name, cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }
            }
            else if (SArray_A( cn, AMM, TM, Type, a) == true)
            {
                return true;
            }
            return false;
        }
        public bool SArray_Initialization_Class(string Name, string cn, string AMM, string TM, string Type3, int a)
        {
            if (cp[j] == "new")
            {
               
                j++;

                string l = vp[j];
               
                if (Dt_Id(ref Type, ref Type6, ref conc) == true)
                {
                    if (a == 0)
                    {
                        if (Type3 != Type)
                        {
                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                        }
                    }
                    if (a == 1)
                    {
                        if (Name != l)
                        {
                            if (l != Type2)
                            {

                                Console.WriteLine("Error: Object incorrect on line " + line[j]);
                            }
                        }
                    }

                }


                if (cp[j] == "[")
                {
                    
                    j++;
                    string k = cp[j];

                    if (ICN(ref Type1) == true)
                    {
                        if (a == 0)
                        {
                            if (Type1 != Type)
                            {
                                Console.WriteLine("Error: Mistach Types in Array on line " + line[j]);
                            }
                        }
                        if (a == 1)
                        {
                            if (k != "int")
                            {
                                Console.WriteLine("Error: Mistach Types in Object Array on line " + line[j]);
                            }

                        }

                    }

                    if (cp[j] == "]")
                    {
                        
                        j++;
                        if (SArray_Initialization_Class1( cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }

                }
            }

            else if (cp[j] == "{")
            {
                
                j++;
                if (SArray_C( cn, AMM, TM, Type, a) == true)
                {
                    if (cp[j] == "}")
                    {
                        
                        j++;
                        if (SArray_A( cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool SArray_Initialization_Class1(string cn, string AMM, string TM, string Type, int a)
        {
            if (SArray_A( cn, AMM, TM, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "{")
            {
                
                j++;
                if (SArray_C( cn, AMM, TM, Type, a) == true)
                {
                    if (cp[j] == "}")
                    {
                       
                        j++;
                        if (SArray_A( cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool SArray_C(string cn, string AMM, string TM, string Type, int a)
        {


            if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, 1, g) == true)
            {
               
                if (a == 0)
                {
                    if (Type != Type1)
                    {
                        Console.WriteLine("Error: Type Mismtach on line" + line[j]);
                    }
                }
                if (SArray_D( cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }
            }

            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool SArray_D(string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == ",")
            {
               
                j++;

                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, 1, g) == true)
                {
                   
                    if (a == 0)
                    {
                        if (Type != Type1)
                        {
                            Console.WriteLine("Error: Type Mismtach on line" + line[j]);
                        }
                    }
                }
                if (SArray_D(cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }

            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool MArray_A(string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == ";")
            {
               
                if (a == 1)
                {
                    q.insertCT(Name, Type, AMM, "", cn, line[j], P, "obj_marr", Pa, ret);
                }
                if (a == 0)
                {

                    q.insertCT(Name, Type, AMM, TM, cn, line[j], P, "marray", Pa, ret);
                }


                j++;
                return true;
            }
            else if (cp[j] == ",")
            {
                
                j++;

                if (cp[j] == "Identifier")
                {
                    
                    if (a == 0)
                    {
                        Name = vp[j];
                        q.insertCT(Name, Type, AMM, TM, cn, line[j], P, "marray", Pa, ret);
                    }





                    j++;
                    if (MArray_B(Name, cn, AMM, TM, Type, a) == true)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public bool MArray_B(string Name, string cn, string AMM, string TM, string Type, int a)
        {
            if (MArray_A(cn, AMM, TM, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "=")
            {
                
                j++;
                if (MArray_Initialization_Class(Name, cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool MArray_Initialization_Class(string Name, string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == "new")
            {
               
                j++;
                string l = vp[j];
                
                if (Dt_Id(ref Type1, ref Type6, ref conc) == true)
                {
                    if (a == 0)
                    {
                        if (Type1 != Type)
                        {
                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                        }
                    }
                    if (a == 1)
                    {
                        if (Name != l)
                        {
                            q.Lookup_Obj(Name, ref Type2, ref Type3);
                            if (l != Type2)
                            {

                                Console.WriteLine("Error: Object incorrect on line " + line[j]);
                            }
                        }
                    }
                }
                if (cp[j] == "[")
                {
                    
                    j++;
                   
                    if (ICN(ref Type2) == true)
                    {
                        if (a == 0)
                        {
                            if (Type2 != Type1)
                            {
                                Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                            }
                        }
                        if (a == 1)
                        {
                            if (Type2 != "int")
                            {
                                Console.WriteLine("Error: Mistach Types in Object Array on line" + line[j]);
                            }
                        }
                    }
                    if (cp[j] == ",")
                    {
                       
                        j++;

                        
                        if (ICN(ref Type3) == true)
                        {
                            if (a == 0)
                            {
                                if (Type3 != Type2)
                                {
                                    Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                                }
                            }
                            if (a == 1)
                            {
                                if (Type3 != "int")
                                {
                                    Console.WriteLine("Error: Mistach Types in Object Array on line" + line[j]);
                                }
                            }

                        }
                        if (cp[j] == "]")
                        {
                            
                            j++;
                            if (MArray_Initialization_Class1(cn, AMM, TM, Type, a) == true)
                            {
                                return true;

                            }
                        }
                    }
                }



            }
            else if (cp[j] == "{")
            {
                
                j++;
                if (MArray_C( cn, AMM, TM, Type, a) == true)
                {
                    if (cp[j] == "}")
                    {
                        
                        j++;
                        if (MArray_A( cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool MArray_Initialization_Class1(string cn, string AMM, string TM, string Type, int a)
        {
            if (MArray_A(cn, AMM, TM, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "{")
            {
                
                j++;
                if (MArray_C(cn, AMM, TM, Type, a) == true)
                {
                    if (cp[j] == "}")
                    {
                        
                        j++;
                        if (MArray_A( cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool MArray_C(string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == "(")
            {

                j++;

                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, 1, g) == true)
                {
                    
                    if (a == 0)
                    {
                        if (Type != Type1)
                        {
                            Console.WriteLine("Error: Type Mismtach on line" + line[j]);
                        }
                    }
                }
                if (MArray_E(Name, cn, AMM, TM, Type, a) == true)
                {
                    if (cp[j] == ")")
                    {
                        j++;
                        if (MArray_D(cn, AMM, TM, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }

            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }

        public bool MArray_D(string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == ",")
            {
                
                j++;
                if (cp[j] == "(")
                {
                    j++;

                    if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, 1, g) == true)
                    {
                        
                        if (a == 0)
                        {
                            if (Type != Type1)
                            {
                                Console.WriteLine("Error: Type Mismtach on line" + line[j]);
                            }
                        }
                    }
                    if (MArray_E( Name, cn, AMM, TM, Type, a) == true)
                    {
                        if (cp[j] == ")")
                        {
                            j++;
                            if (MArray_D(cn, AMM, TM, Type, a) == true)
                            {
                                return true;
                            }
                        }
                    }
                }

            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;

        }
        public bool MArray_E(string Name, string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == ",")
            {
                
                j++;

                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, 1, g) == true)
                {
                    
                    if (a == 0)
                    {
                        if (Type != Type1)
                        {
                            Console.WriteLine("Error: Type Mismtach on line" + line[j]);
                        }
                    }
                }
                if (MArray_E(Name, cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }

            }
            else if (cp[j] == ")")
            {
                return true;
            }
            return false;
        }
        public bool ICN(ref string Type1)
        {

            if (cp[j] == "Identifier")
            {
                if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                {
                    Console.WriteLine("Error: Undeclared Variable " + vp[j] + " on line" + line[j]);

                }
                j++;
                return true;
            }
            else if (Constant(ref Type1, ref Name) == true)
            {

                return true;
            }
            else if (cp[j] == "," || cp[j] == "]")
            {
                return true;
            }
            return false;

        }
        public bool SArray_FuncA(string var1, string Name, string cl, int scope, string Type, int a)
        {
            if (cp[j] == ";")
            {
                w.IC(var1);
                var1 = "";
                if (a == 1)
                {
                    q.insertFT(Name, cl, cl, scope, line[j], "obj_arr");
                }

                j++;
                return true;
            }
            else if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += Name;
                    if (a == 0)
                    {

                        q.insertFT(Name, cn, Type, scope, line[j], "array");
                    }

                    j++;
                    if (SArray_FuncB(var1, Name, cl, scope, Type, a) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SArray_FuncB(string var1, string Name, string cl, int scope, string Type, int a)
        {

            if (cp[j] == "=")
            {
                var1 += "=";
                if (a == 1)
                {
                    if (q.LookupFT(Name, line[j], cn, ref Type3, ref Type5) == true)
                    {

                        Console.WriteLine("Error: Redeclaration "+Name+" on line " + line[j]);
                    }
                }
                j++;
                if (SArray_Initialization_Func(var1, Name, cl, scope, Type, a) == true)
                {
                    return true;
                }
            }
            else if (SArray_FuncA(var1, Name, cl, scope, Type, a) == true)
            {
                return true;
            }
            return false;
        }
        public bool SArray_Initialization_Func(string var1, string Name, string cl, int scope, string Type, int a)
        {
            if (cp[j] == "new")
            {
                var1 += "new";
                j++;
                string l = vp[j];
                var1 += l;
                if (Dt_Id(ref Type1, ref Type6, ref conc) == true)
                {
                    if (a == 0)
                    {
                        if (Type1 != Type)
                        {
                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                        }
                    }
                    if (a == 1)
                    {
                        if (cl != l)
                        {
                            q.Lookup_Obj(cl, ref Type2, ref Type3);

                            if (l != Type2)
                            {

                                Console.WriteLine("Error: Object incorrect on line " + line[j]);
                            }
                        }
                    }

                    if (cp[j] == "[")
                    {
                        var1 += "[";
                        j++;
                        var1 += vp[j];
                        if (ICN(ref Type2) == true)
                        {
                            if (a == 0)
                            {
                                if (Type2 != Type1)
                                {
                                    Console.WriteLine("Error: Mistach Types in Array on line " + line[j]);
                                }
                            }
                            if (a == 1)
                            {
                                if (Type2 != "int")
                                {
                                    Console.WriteLine("Error: Define size in Object Array on line " + line[j]);
                                }
                            }
                            if (cp[j] == "]")
                            {
                                var1 += "]";
                                j++;
                                if (SArray_Initialization_Func1(var1, Name, l, scope, Type, a) == true)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "{")
            {
                var1 += "{";
                j++;
                if (SArray_FuncC(ref var1, Name, scope, Type) == true)
                {
                    if (cp[j] == "}")
                    {
                        var1 += "}";
                        j++;
                        if (SArray_FuncA(var1, Name, cl, scope, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool SArray_Initialization_Func1(string var1, string Name, string cl, int scope, string Type, int a)
        {
            if (SArray_FuncA(var1, Name, cl, scope, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "{")
            {
                var1 += "{";
                j++;
                if (SArray_FuncC(ref var1, Name, scope, Type) == true)
                {
                    if (cp[j] == "}")
                    {
                        var1 += "}";
                        j++;
                        if (SArray_FuncA(var1, Name, cl, scope, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool SArray_FuncC(ref string var1, string Name, int scope, string Type)
        {
            if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
            {
                var1 += Name_2;
                if (Type1 != Type)
                {
                    Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                }
                if (SArray_FuncD(var1, Name, scope, Type) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool SArray_FuncD(string var1, string Name, int scope, string Type)
        {
            if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    var1 += Name_2;
                    if (Type1 != Type)
                    {
                        Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                    }
                    if (SArray_FuncD(var1, Name, scope, Type) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool MArray_FuncA(string var1, string Name, string cl, int scope, string Type, int a)
        {
            if (cp[j] == ";")
            {
                w.IC(var1);
                var1 = "";
                if (a == 1)
                {

                    q.insertFT(Name, cl, cl, scope, line[j], "obj_marr");
                }

                j++;
                return true;
            }
            else if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += Name;
                    if (a == 0)
                    {

                        q.insertFT(Name, cn, Type, scope, line[j], "marray");
                    }

                    j++;
                    if (MArray_FuncB(var1, Name, cl, scope, Type, a) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool MArray_FuncB(string var1,string Name, string cl, int scope, string Type, int a)
        {
            if (MArray_FuncA(var1, Name, cl, scope, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "=")
            {
                var1 += "=";
                j++;
                if (MArray_Initialization_Func(var1, Name, cl, scope, Type, a) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool MArray_Initialization_Func(string var1, string Name, string cl, int scope, string Type, int a)
        {
            if (cp[j] == "new")
            {
                j++;
                var1 += "new";
                string l = vp[j];
                var1 += l;
                if (Dt_Id(ref Type1, ref Type6, ref conc) == true)
                {
                    if (a == 0)
                    {
                        if (Type1 != Type)
                        {
                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                        }
                    }
                    if (a == 1)
                    {
                        if (cl != l)
                        {
                            q.Lookup_Obj(cl, ref Type2, ref Type3);
                            if (l != Type2)
                            {

                                Console.WriteLine("Error: Object incorrect on line " + line[j]);
                            }
                        }
                    }
                    if (cp[j] == "[")
                    {
                        var1 += "[";
                        j++;
                        var1 += vp[j];
                        if (ICN(ref Type2) == true)
                        {
                            if (a == 0)
                            {
                                if (Type2 != Type1)
                                {
                                    Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                                }
                            }
                            if (a == 1)
                            {
                                if (Type2 != "int")
                                {
                                    Console.WriteLine("Error: Define size in Object Array on line" + line[j]);
                                }
                            }
                            if (cp[j] == ",")
                            {
                                var1 += ",";
                                j++;
                                var1 += vp[j];
                                if (ICN(ref Type3) == true)
                                {
                                    if (a == 0)
                                    {
                                        if (Type3 != Type2)
                                        {
                                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                                        }
                                    }
                                    if (a == 1)
                                    {
                                        if (Type3 != "int")
                                        {
                                            Console.WriteLine("Error: Define size in Object Array on line" + line[j]);
                                        }
                                    }
                                    if (cp[j] == "]")
                                    {
                                        var1 += "]";
                                        j++;
                                        if (MArray_Initialization_Func1(var1, Name, cl, scope, Type) == true)
                                        {
                                            return true;

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "{")
            {
                var1 += "{";
                j++;
                if (MArray_FuncC(ref var1, Name, scope, Type) == true)
                {
                    if (cp[j] == "}")
                    {
                        var1 += "}";
                        j++;
                        if (MArray_FuncA(var1, Name, cl, scope, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool MArray_Initialization_Func1(string var1, string Name, string cl, int scope, string Type)
        {
            if (MArray_FuncA(var1, Name, cl, scope, Type, a) == true)
            {
                return true;
            }
            else if (cp[j] == "{")
            {
                var1 += "{";
                j++;
                if (MArray_FuncC(ref var1, Name, scope, Type) == true)
                {
                    if (cp[j] == "}")
                    {
                        var1 += "}";
                        j++;
                        if (MArray_FuncA(var1, Name, cl, scope, Type, a) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool MArray_FuncC(ref string var1, string Name, int scope, string Type)
        {
            if (cp[j] == "(")
            {
                var1 += "(";
                j++;
                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    var1 += Name_2;
                    if (Type1 != Type)
                    {
                        Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                    }
                    if (MArray_FuncE(var1, Name, scope, Type) == true)
                    {
                        if (cp[j] == ")")
                        {
                            var1 += ")";
                            j++;
                            if (MArray_FuncD(ref var1, Name, scope, Type) == true)
                            {
                                return true;

                            }
                        }
                    }
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }

        public bool MArray_FuncD(ref string var1, string Name, int scope, string Type)
        {
            if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (cp[j] == "(")
                {
                    var1 += "(";
                    j++;
                    if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
                    {
                        var1 += Name_2;
                        if (Type1 != Type)
                        {
                            Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                        }
                        if (MArray_FuncE(var1, Name, scope, Type) == true)
                        {
                            if (cp[j] == ")")
                            {
                                var1 += ")";
                                j++;
                                if (MArray_FuncD(ref var1, Name, scope, Type) == true)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;

        }
        public bool MArray_FuncE(string var1, string Name, int scope, string Type)
        {
            if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    var1 += Name_2;
                    if (Type1 != Type)
                    {
                        Console.WriteLine("Error: Mistach Types in Array on line" + line[j]);
                    }
                    if (MArray_FuncE(var1, Name, scope, Type) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == ")")
            {
                return true;
            }
            return false;
        }
        public bool Break_St(string Toype)
        {
            if (cp[j] == "break")
            {
                
                j++;
                if (cp[j] == ";")
                {
                    j++;
                    return true;
                }
            }
            return false;
        }

        public bool Expression(ref string var2, int scope, ref string Type, ref string Type5, string cn, int a, int g)
        {
            string var1 = "";
            if (A1(ref var1, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                if (Or(ref var1, ref var2, scope, Type, Type5, cn, a, g) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Or(ref string var1, ref string var2, int scope, string Type, string Type5, string cn, int a, int g)
        {
            if (cp[j] == "||")
            {
                string oooop = vp[j];
                j++;
                string var3 = "";
                if (A1(ref var3, scope, ref Type1, ref Type5, cn, a, g) == true)
                {

                    if (q.Comp(Type, Type1, oooop) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    else
                    {
                        Type = q.Comp(Type, Type1, oooop);
                    }
                     string t4 = w.CreateTemp();
                    w.IC(t4 + "=" + var1 + " " + oooop + " " + var3);
                    //     Console.WriteLine(t4 + "=" + N + " " + oooop + " " + Name_1);
                    if (Or(ref t4,  ref var2, scope, Type, Type5, cn, a, g) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == ")" || cp[j] == ";" || cp[j] == "]" || cp[j] == "}" || cp[j] == ",")
            {
                var2 = var1;
                return true;
            }
            return false;
        }
        public bool A1(ref string var2, int scope, ref string Type, ref string Type5, string cn, int a, int g)
        {
            string var1 = "";
            if (B1(ref var1, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                if (And(ref var1, ref var2, scope, Type, Type5, cn, a, g) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool And(ref string var1, ref string var2, int scope, string Type, string Type5, string cn, int a, int g)
        {
            if (cp[j] == "&&")
            {
                string ooop = vp[j];
                j++;
                string var3 = "";
                if (B1(ref var3, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    if (q.Comp(Type, Type1, ooop) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    else
                    {
                        Type = q.Comp(Type, Type1, ooop);
                    }
                    string  t3 = w.CreateTemp();
                    w.IC(t3 + "=" + var1 + " " + ooop + " " + var3);
                    //    Console.WriteLine(t3 + "=" + N + " " + ooop + " " + Name_1);
                    if (And(ref t3, ref var2, scope, Type, Type5, cn, a, g) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "||" || cp[j] == ")" || cp[j] == ";" || cp[j] == "]" || cp[j] == "}" || cp[j] == ",")
            {
                var2 = var1;
                return true;
            }
            return false;
        }
        public bool B1(ref string var2, int scope, ref string Type, ref string Type5, string cn, int a, int g)
        {
            string var1 = "";
            if (C1(ref var1, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                if (Comp(ref var1, ref var2, scope, Type, cn, a, g) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Comp(ref string var1, ref string var2, int scope, string Type, string cn, int a, int g)
        {
            if (cp[j] == "Comparisional Operators")
            {
                string oop = vp[j];
                j++;
                string var3 = "";
                
                if (C1(ref var3, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    if (q.Comp(Type, Type1, oop) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    else
                    {
                        Type = q.Comp(Type, Type1, oop);
                    }

                      string t2 = w.CreateTemp();
                    w.IC(t2 + " = " + var1 + " " + oop + " " + var3);
             //       Console.WriteLine(t2 + " = " + N + " " + oop + " " + Name_1);
                    if (Comp(ref t2, ref var2, scope, Type, cn, a, g) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "&&" || cp[j] == ")" || cp[j] == ";" || cp[j] == "]" || cp[j] == "}" || cp[j] == ",")
            {
                var2 = var1;
                return true;
            }
            return false;
        }
        public bool C1(ref string var2, int scope, ref string Type, ref string Type5, string cn, int a, int g)
        {
            string var1 = "";
            if (D1(ref var1, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                if (PM(ref  var1, ref var2, scope, Type, cn, a, g) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PM(ref string var1, ref string var2, int scope, string Type, string cn, int a, int g)
        {
            if (cp[j] == "Plus Minus")
            {
                string p = vp[j];
                j++;
                string var3 = "";
                if (D1(ref var3, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                   string t1 = w.CreateTemp();
                    w.IC(t1 + "=" + var1 + " " + p + " " + var3);
                    //     Console.WriteLine(t1 + "=" + N + " " + p + " " + Name_1);
                    if (q.Comp(Type, Type1, p) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    else
                    {
                        Type = q.Comp(Type, Type1, p);
                    }
                    if (PM(ref t1, ref var2, scope, Type, cn, a, g) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "Comparisional Operators" || cp[j] == "&&" || cp[j] == ")" || cp[j] == ";" || cp[j] == "]" || cp[j] == "}" || cp[j] == ",")
            {
                var2 = var1;
                return true;
            }
            return false;
        }
        public bool D1(ref string var2, int scope, ref string Type, ref string Type5, string cn, int a, int g)
        {
            string var1 = "";
            if (Check(ref var1, scope, ref Type, ref Type5, a, g) == true)
            {
                if (MDM(ref var1, ref var2,scope, Type, Type5, cn, a, g) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool MDM(ref string var1, ref string var2, int scope, string Type, string Type5, string cn, int a, int g)
        {
            if (cp[j] == "MDM")
            {
                string o = vp[j];
                j++;
                string var3 = "";
                if (Check(ref var3, scope, ref Type1, ref Type5, a, g) == true)
                {
                    string t = w.CreateTemp();
                    w.IC(t + "=" + var1 + " " + o + " " + var3);
                    //       Console.WriteLine(t + "=" + N + " " + o + " " + Name_1);
                    if (q.Comp(Type, Type1, op) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    else
                    {
                        Type = q.Comp(Type, Type1, op);
                    }

                    if (MDM(ref t,  ref var2, scope, Type, Type5, cn, a, g) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "Comparisional Operators" || cp[j] == "Plus Minus" || cp[j] == "&&" || cp[j] == ")" || cp[j] == ";" || cp[j] == "]" || cp[j] == "}" || cp[j] == ",")
            {
                var2 = var1;
                return true;
            }

            return false;
        }
        public bool Check(ref string var1, int scope, ref string Type9, ref string Type5, int a, int g)
        {

            if (cp[j] == "Identifier")
            {
                if (a == 0)
                {

                    if (q.LookupFT(vp[j], line[j], cn, ref Type9, ref Type5) == false)
                    {
                        //Type, conc
                        if (q.LookupCT(vp[j], cn, line[j], ref Type9, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line "+ line[j]);
                        }
                        else if (q.LookupCT(vp[j], cn, line[j], ref Type9, ref Type5) == true)
                        {
                             q.CT(vp[j], cn, line[j], ref Type5, ref Type3, ref Type4, ref Type6, ref Type9);
                        }
                    }
                }
                else if (a == 1)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type9, ref Type5) == false)
                    {
                        Console.WriteLine("Error: Undeclared Variable " + vp[j] + " on line " + line[j]);
                    }
                    q.CT(vp[j], cn, line[j], ref Type5, ref Type3, ref Type4, ref Type6, ref Type9);
                    //CONC, PLL, RET, AMM, TYPE
                }



                Name = vp[j];
                var1 = vp[j];
                Name_1 = vp[j];

                

                j++;
                if (g == 0)
                {
                    if (Type5 == "array" || Type5 == "obj_arr" || Type5 == "marray" || Type5 == "obj_marr")
                    {
                        if (cp[j] != "[")
                        {
                            Console.WriteLine("Error: [] missing on line " + line[j]);
                        }
                    }
                    if (Type5 == "method")
                    {
                        if (cp[j] != "(")
                        {
                            Console.WriteLine("Error: () missing on line " + line[j]);
                        }
                    }
                    if (Type5 != "array" || Type5 != "obj_arr" || Type5 != "marray" || Type5 != "obj_marr")
                    {
                        if (cp[j] == "[")
                        {
                            Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                        }
                    }
                    if (Type5 != "method")
                    {
                        if (cp[j] == "(")
                        {
                            Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                        }
                    }
                }
                //TYPE, NAME, SCOPE, CONC
                if (Check_1(ref Type9, ref var1, ref var2, Name, scope, Type1, Type5) == true)
                {
                    return true;
                }
            }
            else if (Constant(ref Type9, ref var1) == true)
            {
                return true;
            }
            else if (cp[j] == "(")
            {

                j++;

                if (Expression(ref var1, scope, ref Type1, ref Type5, cn, a, g) == true)
                {
                    if (cp[j] == ")")
                    {
                        j++;
                        return true;
                    }
                }
            }
            else if (cp[j] == "Not")
            {
                j++;
                if (Check(ref var1, scope, ref Type1, ref Type5, a, g) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "Increment Decrement")
            {
                op = cp[j];
                j++;
                if (cp[j] == "Identifier")
                {
                    if (op.Contains("+"))
                    {
                        w.IC(vp[j] + " = " + vp[j] + " + 1");
                    }
                    else if (op.Contains("-"))
                    {
                        w.IC(vp[j] + " = " + vp[j] + " - 1");
                    }

                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line " + line[j]);
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                    {
                        
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        
                    }

                    

                    j++;
                    if (g == 0)
                    {
                        if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                        {
                            if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                            {
                                if (Type5 == "array" || Type5 == "obj_arr" || Type5 == "marray" || Type5 == "obj_marr")
                                {
                                    if (cp[j] != "[")
                                    {
                                        Console.WriteLine("Error: [] missing on line " + line[j]);
                                    }
                                }
                                if (Type5 == "method")
                                {
                                    if (cp[j] != "(")
                                    {
                                        Console.WriteLine("Error: () missing on line " + line[j]);
                                    }
                                }
                                if (Type5 != "array" || Type5 != "obj_arr" || Type5 != "marray" || Type5 != "obj_marr")
                                {
                                    if (cp[j] == "[")
                                    {
                                        Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                    }
                                }
                                if (Type5 != "method")
                                {
                                    if (cp[j] == "(")
                                    {
                                        Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                    }
                                }
                            }
                        }
                        if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                        {

                            if (Type5 == "array" || Type5 == "obj_arr" || Type5 == "marray" || Type5 == "obj_marr")
                            {
                                if (cp[j] != "[")
                                {
                                    Console.WriteLine("Error: [] missing on line " + line[j]);
                                }
                            }
                            if (Type5 == "method")
                            {
                                if (cp[j] != "(")
                                {
                                    Console.WriteLine("Error: () missing on line " + line[j]);
                                }
                            }
                            if (Type5 != "array" || Type5 != "obj_arr" || Type5 != "marray" || Type5 != "obj_marr")
                            {
                                if (cp[j] == "[")
                                {
                                    Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                }
                            }
                            if (Type5 != "method")
                            {
                                if (cp[j] == "(")
                                {
                                    Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                }
                            }

                        }
                    }

                    return true;
                }
            }
            return false;
        }
        public bool Check_1(ref string Type9, ref string Name_1, ref string var2,  string Name, int scope, string Type, string Conc)
        {
            if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                //string ff = "";
                if (op.Contains("+"))
                {
                  
                    w.IC(Name + " = " + Name + " + 1");
                }
                else if (op.Contains("-"))
                {
                    w.IC(Name + " = " + Name + " - 1");
               
                }
               // Name_1 += Name;
             //   Name_1 += ff;
              //  var2 = Name_1;

 

                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                    {
                        if (Type1 != "int" && Type1 != "char")
                        {

                            Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                        }
                    }
                }
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                {

                    if (Type1 != "int" && Type1 != "char")
                    {

                        Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                    }

                }
                

                j++;
                return true;
            }
            else if (cp[j] == "(")
            {
                
                Type9 = Type7;
                if (q.CT(Name, cn, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                {
                    
                    //CONC, PLL,RET,AMM, Type
                    if (Type1 != "method")
                    {
                        Console.WriteLine("Error: Method does not exist on line " + line[j]);
                    }
                }
                string k = Type1;
                string aa = Type5;
                j++;
                Stack fun = new Stack();
                if (PL(ref Type1, a, ref fun) == true)
                {
                    if (q.CT(Name, cn, line[j], ref Type_Conc, ref Type_PLL, ref Type_Ret, ref Type_AMM, ref Type_T) == true)
                    {
                        if (k == "method")
                        {
                            if (Type1 != aa)
                            {
                                Console.WriteLine("Error: Incorrect Parameters in method on line" + line[j]);
                            }
                        }
                    }
                    if (cp[j] == ")")
                    {
                        int i = fun.Count;
                        while (fun.Count != 0)
                        {
                            w.IC("Param " + fun.Pop());
                        }
                        string var3 = w.CreateTemp();
                        w.IC(var3 + " = Call " + Name + "," + i);
                        Name = "";
                        j++;
                        if (Check_4(ref Name_1, ref var2, Type7) == true)
                        {
                            return true;
                        }

                    }
                }
            }
            else if (cp[j] == "[")
            {
                bool bbb = false;
                
                if (q.LookupFT(Name, line[j], cn, ref Type1, ref Type5) == true)
                {
                    bbb = true;
                    if (Type5 != "array" || Type5 != "obj_arr" || Type5 != "marray" || Type5 != "obj_marr")
                    {
                        Console.WriteLine("Error: Array doesn't exist on line " + line[j]);
                    }
                }
                if (q.LookupFT(Name, line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(Name, cn, line[j], ref Type1, ref Type5) == true)
                    {
                        bbb = true;
                        if (Type5 != "array" || Type5 != "obj_arr" || Type5 != "marray" || Type5 != "obj_marr")
                        {
                            Console.WriteLine("Error: Array doesn't exist on line " + line[j]);
                        }
                    }

                }
                 
                
                string k = Type5;
                string ass = Type1;
                
                j++;

                if (Expression(ref Name_2, scope, ref Type1, ref Type5, cn, a, g) == true)
                {

                    Name_1 += "["+Name_2;
                    //CONC, PLL,RET,AMM, Type
                    if (bbb == true)
                    {
                        if (k == "array" || k == "obj_arr" || k == "marray" || k == "obj_marr")
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {
                                Console.WriteLine("Error: Incorrect types on line " + line[j]);
                            }
                        }
                    }
                   


                    if (Check_2(ref Name_1, ref var2, Type1, ass, k, scope, cn) == true)
                    {
                        //Type of element, Array Type, Conc, scope, cn

                        return true;
                    }
                }
            }
            else if (cp[j] == ".")
            {
                j++;
                

                //CONC, PLL,RET,AMM, Type
                if (q.Lookup_R(Name, "static") == true)
                {
                    Type4 = Name;
                }
                if (q.Lookup_R(Name, "static") == false)
                {



                    if (q.LookupFT(Name, line[j], cn, ref Type4, ref Type5) == true)
                    {
                        if (Type5 != "obj" && Type5 != "obj_arr" && Type5 != "obj_marr")
                        {

                            Console.WriteLine("Error: Must use an instance on line " + line[j]);




                        }
                    }
                    if (q.LookupFT(Name, line[j], cn, ref Type4, ref Type5) == false)
                    {
                        if (q.LookupCT(Name, cn, line[j], ref Type4, ref Type5) == true)
                        {
                            if (Type5 != "obj" && Type5 != "obj_arr" && Type5 != "obj_marr")
                            {

                                Console.WriteLine("Error: Must use an instance on line " + line[j]);



                            }
                        }

                    }
                }
                string ad = Type4;

                
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    Name_1 += "." + Name;
                    if (q.CT(Name, ad, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == false)
                    {
                        Console.WriteLine("Error: Undeclared variable "+Name+" on line " + line[j]);
                    }
                    Type9 = Type4;

                    if (q.CT(Name, ad, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                    {
                        if (Type2 != "public")
                        {

                            if (ad != cn)
                            {
                                Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                            }
                        }
                    }

                    j++;
                    if (g == 0)
                    {

                        if (q.CT(Name, Type4, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                        {
                            if (Type2 == "public")
                            {

                                if (cn == Type4)
                                {
                                    if (Type1 == "array" || Type1 == "obj_arr" || Type1 == "marray" || Type1 == "obj_marr")
                                    {
                                        if (cp[j] != "[")
                                        {
                                            Console.WriteLine("Error: [] missing on line " + line[j]);
                                        }

                                    }
                                    if (Type1 == "method")
                                    {
                                        if (cp[j] != "(")
                                        {
                                            Console.WriteLine("Error: () missing on line " + line[j]);
                                        }
                                        Type9 = Type7;
                                    }
                                    if (Type1 != "array" || Type1 != "obj_arr" || Type1 != "marray" || Type1 != "obj_marr")
                                    {
                                        if (cp[j] == "[")
                                        {
                                            Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                        }
                                    }
                                    if (Type1 != "method")
                                    {
                                        if (cp[j] == "(")
                                        {
                                            Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                        }
                                    }
                                }
                            }
                        }

                    }
                    if (Check_1(ref Type9, ref Name_1, ref var2, Name, scope, Type4, Type1) == true)
                    {
                        return true;
                    }
                }
            }
            
            else if (cp[j] == "MDM" || cp[j] == "Comparisional Operators" || cp[j] == "Plus Minus" || cp[j] == "&&" || cp[j] == "||" || cp[j] == ")" || cp[j] == ";" || cp[j] == "," || cp[j] == "}" || cp[j] == "]")
            {


                return true;
            }
            return false;
        }
        public bool Check_2(ref string Name_1, ref string var2, string Type_E, string Type, string Conc, int scope, string cn)
        {

            //Type of element, Array Type, Conc, scope, cn
            if (g == 0)
            {
                if (Conc == "marray" || Conc == "obj_marr")
                {
                    if (cp[j] != ",")
                    {
                        Console.WriteLine("Error: [] missing on line " + line[j]);
                    }

                }
            }
            if (cp[j] == "]")
            {

                Name_1 += "]";
                
                j++;
                if (Check_3(ref Name_1, ref Type9, Type_E, Type, Conc) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == ",")
            {
                Name_1 += ",";
                j++;
                if (Expression(ref Name_2, scope, ref Type3, ref Type5, cn, a, g) == true)
                {
                    Name_1 += Name_2;
                    if (Conc == "array" || Conc == "obj_arr")
                    {
                        if (Type3 != "int" && Type3 != "char")
                        {
                            Console.WriteLine("Error: Incorrect types on line " + line[j]);
                        }
                    }

                    if (cp[j] == "]")
                    {
                        Name_1 += "]";
                        j++;
                        if (Check_3(ref Name_1, ref Type9, Type_E, Type, Conc) == true)
                        {
                            return true;
                        }
                    }
                }
            }


            return false;
        }
        public bool Check_3(ref string Name_1, ref string Type9, string Type_E, string Type, string Conc)
        {
            //Type of element, Array Type, Conc

            if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                if (Conc == "array" || Conc == "marray")
                {
                    if (Type_E != "int" && Type_E != "float" && Type_E != "char")
                    {
                        Console.WriteLine("Error: Cannot be incremented on line " + line[j]);
                    }
                }
                if (op.Contains("+"))
                {
                    //  ff = "+ 1";
                    w.IC(Name_1 + " = " + Name_1 + " + 1");
                }
                else if (op.Contains("-"))
                {
                    w.IC(Name_1 + " = " + Name_1 + " - 1");
                    //     ff = "- 1";
                }
                Name_1 = "";
                j++;
                return true;
            }

            else if (cp[j] == ".")
            {

                j++;
                if (Conc != "obj_arr" && Conc != "obj_marr")
                {
                    Console.WriteLine("Error: Incorrect use of array at line " + line[j]);
                }
                if (cp[j] == "Identifier")
                {

                    if (Conc == "obj_arr" || Conc == "obj_marr")
                    {
                        if (q.RT(Type) == false)
                        {


                            Console.WriteLine("Error: Class doesn't exist on line "  + line[j]);
                        }
                    }
                    Name = vp[j];
                    Name_1 = "." + Name;
                    if (Conc == "obj_arr" || Conc == "obj_marr")
                    {
                        if (q.RT(Type) == true)
                        {


                            if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == false)
                            {
                                //CONC, PLL,RET,AMM, Type
                                Console.WriteLine("Error: Undeclared Variable "+ Name+" on line " + line[j]);
                            }
                        }
                    }
                    if (Conc == "obj_arr" || Conc == "obj_marr")
                    {
                        if (q.RT(Type) == true)
                        {


                            if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                            {
                                //CONC, PLL,RET,AMM, Type
                                if (Type2 != "public")
                                {
                                    if (Type != cn)
                                    {
                                        Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                    }
                                }
                            }
                        }
                    }
                    Type9 = Type4;
                    j++;
                    if (g == 0)
                    {
                        if (Conc == "obj_arr" || Conc == "obj_marr")
                        {
                            if (q.RT(Type) == true)
                            {


                                if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                                {
                                    //CONC, PLL,RET,AMM, Type
                                    if (Type2 != "public")
                                    {
                                        if (Type == cn)
                                        {
                                            if (Type1 == "array" || Type1 == "obj_arr" || Type1 == "marray" || Type1 == "obj_marr")
                                            {
                                                if (cp[j] != "[")
                                                {
                                                    Console.WriteLine("Error: [] missing on line " + line[j]);
                                                }


                                            }
                                            if (Type1 == "method")
                                            {
                                                if (cp[j] != "(")
                                                {
                                                    Console.WriteLine("Error: () missing on line " + line[j]);
                                                }
                                                Type9 = Type7;
                                            }
                                            if (Type1 != "array" || Type1 != "obj_arr" || Type1 != "marray" || Type1 != "obj_marr")
                                            {
                                                if (cp[j] == "[")
                                                {
                                                    Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                                }
                                            }
                                            if (Type1 != "method")
                                            {
                                                if (cp[j] == "(")
                                                {
                                                    Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (Conc == "obj_arr" || Conc == "obj_marr")
                        {
                            if (q.RT(Type) == true)
                            {


                                if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                                {
                                    //CONC, PLL,RET,AMM, Type
                                    if (Type2 == "public")
                                    {
                                       
                                        
                                            if (Type1 == "array" || Type1 == "obj_arr" || Type1 == "marray" || Type1 == "obj_marr")
                                            {
                                                if (cp[j] != "[")
                                                {
                                                    Console.WriteLine("Error: [] missing on line " + line[j]);
                                                }


                                            }
                                            if (Type1 == "method")
                                            {
                                                if (cp[j] != "(")
                                                {
                                                    Console.WriteLine("Error: () missing on line " + line[j]);
                                                }
                                                Type9 = Type7;
                                            }
                                            if (Type1 != "array" || Type1 != "obj_arr" || Type1 != "marray" || Type1 != "obj_marr")
                                            {
                                                if (cp[j] == "[")
                                                {
                                                    Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                                }
                                            }
                                            if (Type1 != "method")
                                            {
                                                if (cp[j] == "(")
                                                {
                                                    Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                                }
                                            }
                                        
                                    }
                                }
                            }
                        }
                        
                    }
                    //Name, scope, Type, conc
                    if (Check_1(ref Type9, ref Name_1, ref var2, Name, scope, Type4, Type1) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "MDM" || cp[j] == "Comparisional Operators" || cp[j] == "Plus Minus" || cp[j] == "&&" || cp[j] == "||" || cp[j] == ")" || cp[j] == ";" || cp[j] == "," || cp[j] == "}" || cp[j] == "]")
            {
                return true;
            }

            return false;
        }
        public bool Check_4(ref string Name_1, ref string var2, string Ret)
        {

            if (cp[j] == ".")
            {
                if (q.RT(Ret) == false)
                {
                    Console.WriteLine("Error: Method doesn't have an object return on line " + line[j]);
                }
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    Name_1 = "." + Name;
                    if (q.RT(Ret) == true)
                    {
                        if (q.CT(Name, Ret, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+Name+" on line " + line[j]);
                        }
                        else if (q.CT(Name, Ret, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type4) == true)
                        {
                            if (Type2 != "public")
                            {
                                if (Ret != cn)
                                {
                                    Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                }
                            }
                           
                            //CONC, PLL,RET,AMM, TYPE
                        }
                    }
                    Type9 = Type4;
                    j++;
                    if (g == 0)
                    {
                        if (q.RT(Ret) == true)
                        {


                            if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type9) == true)
                            {
                                //CONC, PLL,RET,AMM, Type
                                if (Type2 == "public")
                                {


                                    if (Type1 == "array" || Type1 == "obj_arr" || Type1 == "marray" || Type1 == "obj_marr")
                                    {
                                        if (cp[j] != "[")
                                        {
                                            Console.WriteLine("Error: [] missing on line " + line[j]);
                                        }


                                    }
                                    if (Type1 == "method")
                                    {
                                        if (cp[j] != "(")
                                        {
                                            Console.WriteLine("Error: () missing on line " + line[j]);
                                        }
                                        Type9 = Type7;
                                    }
                                    if (Type1 != "array" || Type1 != "obj_arr" || Type1 != "marray" || Type1 != "obj_marr")
                                    {
                                        if (cp[j] == "[")
                                        {
                                            Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                        }
                                    }
                                    if (Type1 != "method")
                                    {
                                        if (cp[j] == "(")
                                        {
                                            Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                        }
                                    }

                                }
                            }
                        }
                        if (q.RT(Type) == true)
                        {


                            if (q.CT(Name, Type, line[j], ref Type1, ref Type5, ref Type7, ref Type2, ref Type9) == true)
                            {
                                //CONC, PLL,RET,AMM, Type
                                if (Type2 != "public")
                                {
                                    if (Type == cn)
                                    {
                                        if (Type1 == "array" || Type1 == "obj_arr" || Type1 == "marray" || Type1 == "obj_marr")
                                        {
                                            if (cp[j] != "[")
                                            {
                                                Console.WriteLine("Error: [] missing on line " + line[j]);
                                            }


                                        }
                                        if (Type1 == "method")
                                        {
                                            if (cp[j] != "(")
                                            {
                                                Console.WriteLine("Error: () missing on line " + line[j]);
                                            }
                                            Type9 = Type7;
                                        }
                                        if (Type1 != "array" || Type1 != "obj_arr" || Type1 != "marray" || Type1 != "obj_marr")
                                        {
                                            if (cp[j] == "[")
                                            {
                                                Console.WriteLine("Error: Incorrect use of [] on line " + line[j]);
                                            }
                                        }
                                        if (Type1 != "method")
                                        {
                                            if (cp[j] == "(")
                                            {
                                                Console.WriteLine("Error: Incorrect use of () on line " + line[j]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (Check_5(ref Name_1, Name, Type1, Type5, Type7, Type9) == true)
                    {
                        //Name, conc, PLL, RET, TYPE
                        return true;
                    }
                }
            }
            else if (cp[j] == "MDM" || cp[j] == "Comparisional Operators" || cp[j] == "Plus Minus" || cp[j] == "&&" || cp[j] == "||" || cp[j] == ")" || cp[j] == ";" || cp[j] == "," || cp[j] == "}" || cp[j] == "]")
            {
                return true;
            }
            return false;
        }
        public bool Check_5(ref string Name_1, string Name, string Conc, string Par, string Ret, string Type1)
        {
            if (cp[j] == "=")
            {
                j++;
                string n = "";
                if (Id_Constant(ref Type, ref n) == true)
                {

                    if (q.Comp(Type1, Type, "=") == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    w.IC(Name_1+" = "+n);
                    Name_1 = "";
                    return true;
                }
            }
            else if (cp[j] == "(")
            {
                //Name, conc, PLL, RET, TYPE

                j++;
                Stack fun = new Stack();
                if (PL(ref Type1, a, ref fun) == true)
                {
                    if (Conc != "method")
                    {
                        if (Type1 != Par)
                        {
                            Console.WriteLine("Error: Incorrect Paramters in method on line" + line[j]);
                        }
                    }
                    int i = fun.Count;
                    while (fun.Count != 0)
                    {
                        w.IC("Param " + fun.Pop());
                    }
                    string var3 = w.CreateTemp();
                    w.IC(var3 + " = Call " + Name + "," + i);
                    Name = "";
                    if (cp[j] == ")")
                    {
                        j++;
                        if (Check_4(ref Name_1, ref var2, Ret) == true)
                        {
                            return true;
                        }

                    }
                }
            }

            return false;
        }
       
        public bool PL(ref string PL, int a, ref Stack fun)
        {

            if (Expression(ref Name_2, scope, ref Type3, ref Type5, cn, a, 1) == true)
            {
                PL = Type3;
                
                fun.Push(Name_2);

                if (PL_List(ref fun, Type3, ref PL, a) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == ")")
            {
                PL = "void";
                return true;
            }
            return false;
        }
        public bool PL_List(ref Stack fun, string Type3, ref string PL, int a)
        {

            if (cp[j] == ",")
            {
                j++;
                if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, 1) == true)
                {
                    PL = Type3 + "," + Type;
                    fun.Push(Name_2);

                    if (PL_List(ref  fun, PL, ref PL, a) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == ")")
            {

                return true;
            }
            return false;
        }
        public bool Loop_St(int scope, string Toype, string Mode)
        {
            if (cp[j] == "loop")
            {

                j++;
                if (cp[j] == "(")
                {
                    q.CreateScope(ref scope);
                    j++;
                    if (Cond_1() == true)
                    {
                        string a = w.CreateLabel();
                        w.IC(a + ":");

                        string asd = "";
                        if (Cond_2(ref asd) == true)
                        {

                            string ss = w.CreateLabel();
                            w.IC("if ( "+ asd +  " == false)");
                            w.IC("jmp " + ss);
                            if (Cond_3(ref temp) == true)
                            {
                                if (cp[j] == ")")
                                {
                                    j++;
                                    if (cp[j] == "{")
                                    {
                                        j++;
                                        if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                                        {


                                            w.IC(temp);
                                            w.IC("jmp " + a);
                                            w.IC(ss+":");
                                            if (cp[j] == "}")
                                            {
                                                q.DestroyScope(ref scope);
                                                j++;
                                                return true;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Cond_1()
        {
            if (cp[j] == ";")
            {
                j++;
                return true;
            }
            else if (cp[j] == "Datatype")
            {
                Type = vp[j];
                
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 = Name;
                    q.insertFT(Name, cn, Type, scope, line[j], conc);
                    j++;
                    if (Initialization_Func(var1, Type) == true)
                    {
                        if (List_Func(var1, Name,"", c,scope, Type, cn) == true)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        public bool Cond_2(ref string Name_1)
        {
            if (Expression(ref Name_1, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                 
                
                if (cp[j] == ";")
                {
                    j++;
                    return true;
                }
            }
            else if (cp[j] == ";")
            {
                j++;
                return true;
            }
            return false;
        }
        public bool Cond_3(ref string temp)
        {
            if (cp[j] == "Identifier")
            {
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                    {
                        Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line " + line[j]);
                    }
                }
                Name_1 = vp[j];
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                    {
                        if (Type1 != "int" && Type1 != "char")
                        {

                            Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                        }
                    }
                }
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                    {
                        if (Type1 != "int" && Type1 != "char")
                        {

                            Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                        }
                    }
                }
                
                j++;
                if (Cond3_1(ref temp, Name_1, Type1) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "Increment Decrement")
            {
                j++;
                if (cp[j] == "Identifier")
                {
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable " +vp[j]+" on line " + line[j]);
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        }
                    }

                    
                    if (vp[j].Contains("+"))
                    {
                        temp = Name_1 + " = " + Name_1 + " + 1";
                    }
                    else if (vp[j].Contains("-"))
                    {
                        temp = Name_1 + " = " + Name_1 + " - 1";
                    }
                    j++;
                    return true;
                }

            }
            else if (cp[j] == ")")
            {
                return true;
            }
            return false;
        }
        public bool Cond3_1(ref string temp, string Name_1, string Type1)
        {
            if (cp[j] == "Increment Decrement")
            {
                if (vp[j].Contains("+"))
                {
                    temp = Name_1 + " = " + Name_1 + " + 1";
                }
                else if (vp[j].Contains("-"))
                {
                    temp = Name_1 + " = " + Name_1 + " - 1";
                }
                j++;
                return true;
            }
            else if (Assignment(ref op) == true)
            {
                if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
                {
                    if (q.Comp(Type1, Type, op) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    w.IC(Name_1 + op + Name_2);




                    return true;

                }
            }
            return false;
        }
        public bool Func_Main(ref string Type11, ref string Type5, int scope, int b, string Toype, string Mode)
        {
            if (Loop_St(scope, Toype, Mode) == true)
            {
                return true;
            }
            else if (Switch_St(scope, Toype, Mode) == true)
            {
                return true;
            }
            else if (Return_St(ref Type11, ref Type5, b, Toype, Mode) == true)
            {
                return true;
            }

            else if (If_Else(scope, Toype, Mode) == true)
            {
                return true;
            }
            else if (Break_St(Toype) == true)
            {
                return true;
            }
            else if (Try_St(scope, Toype, Mode) == true)
            {
                return true;
            }
            else if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                j++;
                if (cp[j] == "Identifier")
                {
                    if (op.Contains("+"))
                    {

                        w.IC(vp[j] + " = " + vp[j] + " + 1");
                    }
                    else if (op.Contains("-"))
                    {
                        w.IC(vp[j] + " = " + vp[j] + " - 1");

                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line "  +line[j]);
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        }
                    }
                    if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                    {
                        if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                        {
                            if (Type1 != "int" && Type1 != "char")
                            {

                                Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                            }
                        }
                    }
                    j++;


                    if (cp[j] == ";")
                    {
                        j++;
                        return true;
                    }
                }

            }
            else if (cp[j] == "Datatype")
            {
                var1 = Type;
                Type = vp[j];
                
                j++;

                if (Func_1(var1, Type) == true)
                {
                    //Func_2(Name);
                    
                    return true;
                }
            }
            else if (cp[j] == "Identifier")
            {
                Name = vp[j];
                var1 = Name;
                j++;
                if (Func_2(var1, Name) == true)
                {

                    return true;
                }
            }

            return false;
        }
        public bool Try_St(int scope, string Toype, string Mode)
        {
            if (cp[j] == "try")
            {
                j++;
                if (cp[j] == "{")
                {
                    w.IC(w.CreateLabel() + ":");
                    q.CreateScope(ref scope);
                    j++;
                    if (Body(ref Type1, ref Type5, scope, b, Toype, Mode) == true)
                    {
                        if (cp[j] == "}")
                        {
                            q.DestroyScope(ref scope);
                            j++;
                            if (Catch_St(scope, Toype, Mode) == true)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Catch_St(int scope, string Toype, string Mode)
        {
            if (cp[j] == "catch")
            {
                j++;
                if (cp[j] == "(")
                {
                    w.IC(w.CreateLabel() + ":");
                    q.CreateScope(ref scope);
                    j++;
                    if (cp[j] == "exception")
                    {
                        j++;
                        if (cp[j] == "Identifier")
                        {
                            j++;
                            if (cp[j] == ")")
                            {
                                j++;
                                if (cp[j] == "{")
                                {
                                    j++;
                                    if (Body(ref Type, ref Type5, scope, b, Toype, Mode) == true)
                                    {

                                        if (cp[j] == "}")
                                        {
                                            q.DestroyScope(ref scope);
                                            j++;
                                            return true;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Func_1(string var1, string Type)
        {
            if (cp[j] == "Identifier")
            {

                Name = vp[j];
                var1 = Name;
                q.insertFT(Name, cn, Type, scope, line[j], conc);

                j++;
                if (Initialization_Func(var1, Type) == true)
                {
                    if (List_Func(var1, Name,"", c, scope, Type, cn) == true)
                    {
                        return true;
                    }
                }
            }
            else if (Array(var1, scope, Type, "", a) == true)
            {
                return true;
            }
            return false;
        }
        public bool Func_2(string var1, string Name)
        {
            if (cp[j] == "Identifier")
            {
                Name1 = vp[j];
                var1 += Name1;
                j++;
                if (Func_3(var1, Name, Name1) == true)
                {
                    return true;
                }
            }
            else if (Array(var1, scope, Type, Name, 1) == true)
            {
                return true;
            }
            else if (cp[j] == "(")
            {
                q.CT(Name, cn, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5);
                //CONC, PLL, RET, AMM, TYPE
                if (Type != "method")
                {
                    Console.WriteLine("Error: Method doesn't exist on line " + line[j]);
                }
                j++;
                Stack fun = new Stack();
                if (PL(ref Type1, a, ref fun) == true)
                {
                    if (Type == "method")
                    {
                        if (Type2 != Type1)
                        {
                            Console.WriteLine("Error: Incorrect Parameters on line " + line[j]);
                        }
                    }
                    int i = fun.Count;
                    while (fun.Count != 0)
                    {
                        w.IC("Param " + fun.Pop());
                    }
                    string var3 = w.CreateTemp();
                    w.IC(var3 + " = Call " + Name + "," + i);

                   
                    if (cp[j] == ")")
                    {
                        j++;
                        if (cp[j] == ";")
                        {
                            j++;
                            return true;
                        }
                    }
                }

            }
            else if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                j++;
                if (op.Contains("+"))
                {

                    w.IC(Name + " = " + Name + " + 1");
                }
                else if (op.Contains("-"))
                {
                    w.IC(Name + " = " + Name + " - 1");

                }
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                    {
                        Console.WriteLine("Error: Undeclared Variable "+vp[j]+" on line " + line[j]);
                    }
                }

                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == false)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == true)
                    {
                        if (Type1 != "int" && Type1 != "char")
                        {

                            Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                        }
                    }
                }
                if (q.LookupFT(vp[j], line[j], cn, ref Type1, ref Type5) == true)
                {
                    if (q.LookupCT(vp[j], cn, line[j], ref Type1, ref Type5) == false)
                    {
                        if (Type1 != "int" && Type1 != "char")
                        {

                            Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                        }
                    }
                }
                if (cp[j] == ";")
                {
                    j++;
                    return true;
                }
            }
            else if (Assignment(ref op) == true)
            {
                var1 +=op;
                if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
                {
                    var1 += Name_2;
                    if (q.Comp(Name, Type, op) == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    w.IC(var1);
                    var1 = "";

                    if (cp[j] == ";")
                    {
                        j++;
                        return true;
                    }
                }
            }
            else if (cp[j] == ".")
            {
                if (q.Lookup_R(Name, "static") == true)
                {
                    

                    
                     Type1 = Name;
                }
                else if (q.Lookup_R(Name, "static") == false)
                {
                    if (q.LookupFT(Name, line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(Name, cn, line[j], ref Type1, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable " + Name + " on line " + line[j]);
                        }
                    }


                    if (q.LookupFT(Name, line[j], cn, ref Type1, ref Type5) == true)
                    {
                        if (Type5 != "obj")
                        {
                            Console.WriteLine("Error: Must use an instance on line " + line[j]);

                        }
                    }
                    if (q.LookupFT(Name, line[j], cn, ref Type1, ref Type5) == false)
                    {
                        if (q.LookupCT(Name, cn, line[j], ref Type1, ref Type5) == true)
                        {
                            if (Type5 != "obj")
                            {
                                Console.WriteLine("Error: Must use an instance on line " + line[j]);


                            }
                        }

                    }
                }
                
                    
                    
                
                string a = Name;

                //CONC, PLL, RET, AMM, TYPE
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += "." + Name;
                    if (Type5 == "obj" || q.Lookup_R(a, "static") == true)
                    {
                        if (q.CT(Name, Type1, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+Name+" on line " + line[j]);
                        }
                        if (q.CT(Name, Type1, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == true)
                        {
                            if (Type4 != "public")
                            {

                                if (Type1 != cn)
                                {
                                    Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                }

                            }
                        }
                    }
                    //CONC, PLL, RET, AMM, TYPE
                    j++;

                    
                    if (Func_5(var1,Name,Type1, Type, Type2, Type3, Type5) == true)
                    {
                        return true;
                    }



                }
            }
            
            return false;
        }
        public bool Func_3(string var1, string Name, string Name1)
        {
            if (cp[j] == "=")
            {
                var1 += "=";
                j++;
                if (Func_4(var1, Name, Name1) == true)
                {
                    return true;
                }
            }
            else if (List_Func(var1, Name,Name1,1,scope, Type, cn) == true)
            {
                return true;
            }
            return false;
        }
        public bool Func_4(string var1, string Name, string Name1)
        {
            if (Initialization_Func1(var1, Type) == true)
            {
                string type = q.Lookup_CT(Name, Name, line[j], ref Pa);


                if (type != "con")
                {
                    Console.WriteLine("Error: Constructor does not exist on line " + line[j]);
                }
                if (type == "con")
                {
                    if (q.LookupFT(Name1, line[j], cn, ref Type3, ref Type5) == true)
                    {
                        Console.WriteLine("Error: Redeclaration on line " + line[j]);
                    }
                }

                q.insertFT(Name1, cn, Name, scope, line[j], conc);
                if (List_Func(var1,Name, "",1, scope, Type, cn) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "new")
            {
                string type = q.Lookup_CT(Name, Name, line[j], ref Pa);

                var1 += " new ";
                if (type != "con" && Pa == String.Empty)
                {
                    Console.WriteLine("Error: Constructor does not exist on line " + line[j]);
                }
                if (type == "con" || Pa != String.Empty)
                {
                    if (q.LookupFT(Name1, line[j], cn, ref Type3, ref Type5) == true)
                    {
                        Console.WriteLine("Error: Redeclaration on line " + line[j]);
                    }
                }
                j++;
                if (cp[j] == "Identifier")
                {
                    string l = vp[j];
                    var1 += l;
                    if (type == "con" || Pa != String.Empty)
                    {
                        if (q.LookupFT(Name1, line[j], cn, ref Type3, ref Type5) == false)
                        {
                            if (Name != vp[j])
                            {
                                q.Lookup_Obj(Name, ref Type2, ref Type3);
                                if (vp[j] != Type2)
                                {

                                    Console.WriteLine("Error: Object incorrect on line " + line[j]);
                                }
                            }
                        }
                    }
                    
                    j++;
                    if (cp[j] == "(")
                    {
                        var1 += "(";
                        j++;
                       
                        var1 += vp[j];
                        Stack fun = new Stack();
                        if (PL(ref Type1, a, ref fun) == true)
                        {
                            
                           
                            w.IC(var1+" )");
                            var1 = "";
                            string azx = Type1;
                            if (type == "con" || Pa != String.Empty)
                            {
                                if (q.LookupFT(Name1, line[j], cn, ref Type3, ref Type5) == false)
                                {
                                    if (Name != vp[j])
                                    {
                                        q.Lookup_Obj(Name, ref Type2, ref Type3);
                                        if (vp[j] == Type2)
                                        {

                                            q.Lookup_Obj(l, ref Type2, ref Type3);
                                            if (azx != Type3)
                                            {
                                                Console.WriteLine("Error: Incorrect Parameters on line " + azx + Type3 + line[j]);
                                            }
                                        }
                                    }
                                    if (Name == vp[j])
                                    {
                                        q.Lookup_Obj(l, ref Type2, ref Type3);
                                        if (azx != Type3)
                                        {
                                            Console.WriteLine("Error: Incorrect Parameters on line " + azx + Type3 + line[j]);
                                        }
                                    }
                                }
                            }
                            
                            if (cp[j] == ")")
                            {
                                j++;

                                if (cp[j] == ";")
                                {
                                    j++;
                                    q.insertFT(Name1, cn, Name, scope, line[j], "obj");
                                    return true;
                                }

                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Func_5(string var1, string o, string oo, string Conc, string Parr, string Ret, string Tipe)
        {
            if (cp[j] == "(")
            {
                if (Conc != "method")
                {
                    Console.WriteLine("Error: Method doesn't exist on line " +Conc+ line[j]);
                }
                j++;
                Stack fun = new Stack();
                if (PL(ref Type1, a, ref fun) == true)
                {
                    if (Conc == "method")
                    {
                        if (Parr != Type1)
                        {
                            Console.WriteLine("Error: Incorrect Parameters on line " + line[j]);
                        }
                    }
                    int i = fun.Count;
                    while (fun.Count != 0)
                    {
                        w.IC("Param " + fun.Pop());
                    }
                    string var3 = w.CreateTemp();
                    w.IC(var3 + " = Call " + o + "," + i);
                    if (cp[j] == ")")
                    {
                        j++;
                        if (Func_9(var1,Ret) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == ".")
            {

                if (Conc != "obj")
                {


                    Console.WriteLine("Error: Must use an instance on line " + line[j]);

                }
                //CONC, PLL, RET, AMM, TYPE
                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += "." + Name;
                    if (Conc == "obj")
                    {
                        if (q.CT(Name, Tipe, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable "+Name+" on line "+line[j]);
                        }
                    }
                    if (Conc == "obj")
                    {
                        if (q.CT(Name, Tipe, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == true)
                        {
                            if (Type4 != "public")
                            {

                                if (cn != Tipe)
                                {
                                    Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                }

                            }
                        }
                    }
                   
                   
                    //CONC, PLL, RET, AMM, TYPE
                    j++;


                    if (Func_5(var1, Name, Tipe, Type, Type2, Type3, Type5) == true)
                    {
                        return true;
                    }



                }
            }
            else if (cp[j] == "[")
            {

                if (Conc != "array" && Conc == "obj_arr" && Conc == "marray" && Conc == "obj_marr")
                {
                    Console.WriteLine("Error: Incorrect use of array on line " + line[j]);
                }
                var1 = "[";
                j++;
                if (Func_6(var1, Conc, Ret, Tipe) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                if (op.Contains("+"))
                {
                    w.IC(o + " = " + o + " + 1");
                }
                else if (op.Contains("-"))
                {
                    w.IC(o + " = " + o + " - 1");
                }
                if (q.LookupCT(o, oo, line[j], ref Type_AMM, ref Type_Conc) == true)
                {
                    if (Type_AMM != "int" && Type_AMM != "char")
                    {

                        Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                    }
                }
                j++;
                if (cp[j] == ";")
                {
                    j++;
                    return true;
                }
            }
            else if (cp[j] == "=")
            {
                op = "=";
                j++;
                string n = "";
                if (Id_Constant(ref Type, ref n) == true)
                {
                    if (q.Comp(Tipe, Type, "=") == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " +Type+ line[j]);
                    }
                    w.IC(var1 + op + n);
                    var1 = "";

                    if (cp[j] == ";")
                    {
                        j++;
                        return true;
                    }
                }
            }

            return false;
        }
        public bool Func_6(string var1, string Conc, string Ret, string Tipe)
        {
            if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
            {
                var1 += Name_2;
                if (Conc == "marray" || Conc == "obj_marr" || Conc == "array" || Conc == "obj_arr")
                {
                    if (Type != "int" && Type != "char")
                    {
                        Console.WriteLine("Error: Incorrect types on line " + line[j]);
                    }
                }
                if (Func_7(var1, Conc, Ret, Tipe) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Func_7(string var1, string Conc, string Ret, string Tipe)
        {
            if (g == 0)
            {
                if (Conc == "marray" || Conc == "obj_marr")
                {
                    if (cp[j] != ",")
                    {
                        Console.WriteLine("Error: [] missing on line " + line[j]);
                    }

                }
            }

            if (cp[j] == "]")
            {
                j++;
                var1 = "]";
                if (Func_8(var1, Conc, Ret, Tipe) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == ",")
            {
                var1 += ",";
                j++;
                if (Expression(ref Name_2, scope, ref Type, ref Type5, cn, a, g) == true)
                {
                    var1 += Name_2;
                    if (Conc == "marray" || Conc == "obj_marr")
                    {
                        if (Type != "int" && Type != "char")
                        {
                            Console.WriteLine("Error: Incorrect types on line " + line[j]);
                        }
                    }
                    if (cp[j] == "]")
                    {
                        var1 += "]";
                        j++;
                        if (Func_8(var1, Conc, Ret, Tipe) == true)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }
        public bool Func_8(string var1, string Conc, string Ret, string Tipe)
        {
            if (cp[j] == ".")
            {

                j++;
                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += ".";
                    var1 += Name;
                    if (Conc != "obj_arr" && Conc != "obj_marr")
                    {
                        Console.WriteLine("Error: Must use an instance on line " + line[j]);
                    }
                    if (q.RT(Tipe) == false)
                    {


                        Console.WriteLine("Error: Class doesn't exist on line " + Tipe + line[j]);
                    }
                    if (q.RT(Tipe) == true)
                    {
                        if (q.CT(Name, Tipe, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable " + Name + " on line " + line[j]);
                        }
                        else if (q.CT(Name, Tipe, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == true)
                        {
                            
                            if (Type4 != "public")
                            {

                                if (Tipe != cn)
                                {
                                    Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                }

                            }
                        }
                    }
                    //CONC, PLL, RET, AMM, TYPE

                    j++;
                    if (Func_5(var1, Name,Tipe, Type, Type2, Type3, Type5) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "=")
            {
                j++;
                string n = "";
                if (Id_Constant(ref Type, ref n) == true)
                {
                    if (q.Comp(Tipe, Type, "=") == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    w.IC(var1 + op + n);
                    var1 = "";
                    if (cp[j] == ";")
                    {
                        j++;
                        return true;
                    }
                }

            }
            else if (cp[j] == "Increment Decrement")
            {
                op = vp[j];
                if (op.Contains("+"))
                {
                    w.IC(var1 + " = " + var1 + " + 1");
                }
                else if (op.Contains("-"))
                {
                    w.IC(var1 + " = " + var1 + " - 1");
                }
                var1 = "";
                if (Conc == "array" || Conc == "marray")
                {
                    if (Tipe != "int" && Tipe != "char")
                    {

                        Console.WriteLine("Error: Cannot be Incremented on line " + line[j]);
                    }
                }
                j++;
                if (cp[j] == ";")
                {
                    j++;
                    return true;
                }
            }

            return false;
        }

        public bool Func_9(string var1, string Ret)
        {
            if (cp[j] == ";")
            {
                j++;
                return true;
            }
            if (cp[j] == ".")
            {
                j++;

                if (cp[j] == "Identifier")
                {
                    Name = vp[j];
                    var1 += ".";
                    var1 += Name;
                    if (q.RT(Ret) == false)
                    {
                        Console.WriteLine("Error: Class is not existing on line " + line[j]);
                    }
                    if (q.RT(Ret) == true)
                    {
                        if (q.CT(Name, Ret, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == false)
                        {
                            Console.WriteLine("Error: Undeclared Variable " + Name + " on line " + line[j]);
                        }
                        else if (q.CT(Name, Ret, line[j], ref Type, ref Type2, ref Type3, ref Type4, ref Type5) == true)
                        {
                            if (Type4 != "public")
                            {

                                if (Ret != cn)
                                {
                                    Console.WriteLine("Error: Inaccessible due to protection level on line " + line[j]);
                                }

                            }
                        }
                        
                    }
                    //CONC, PLL, RET, AMM, TYPE
                    j++;
                    if (Func_10(var1, Type, Type2, Type3, Type5) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Func_10(string var1, string Conc, string Parr, string Ret, string Tipe)
        {
            if (cp[j] == "(")
            {
                if (Conc != "method")
                {
                    Console.WriteLine("Error: Method doesn't exist on line " + line[j]);
                }
                j++;
                Stack fun = new Stack();
                if (PL(ref Type1, a, ref fun) == true)
                {
                    if (Conc == "method")
                    {
                        if (Parr != Type1)
                        {
                            Console.WriteLine("Error: Incorrect Parameters on line " + line[j]);
                        }
                    }
                    int i = fun.Count;
                    while (fun.Count != 0)
                    {
                        w.IC("Param " + fun.Pop());
                    }
                    string var3 = w.CreateTemp();
                    w.IC(var3 + " = Call " + var1 + "," + i);
                    var1 = "";
                    if (cp[j] == ")")
                    {
                        j++;
                        if (Func_9(var1, Ret) == true)
                        {
                            return true;
                        }
                    }
                }
            }
            else if (cp[j] == "=")
            {
                op =vp[j];
                j++;
                string n = "";
                if (Id_Constant(ref Type, ref n) == true)
                {
                    if (q.Comp(Tipe, Type, "=") == "")
                    {
                        Console.WriteLine("Error: Types Mismatch on line " + line[j]);
                    }
                    w.IC(var1 + op + n);
                    var1 = "";
                    if (cp[j] == ";")
                    {
                        j++;
                        return true;
                    }
                }

            }
            return false;
        }
       
        public bool Class_St(string cn)
        {
            if (Class_St1(cn) == true)
            {
                if (Class_St(cn) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "}")
            {
                return true;
            }
            return false;
        }
        public bool Class_St1(string cn)
        {
            if (cp[j] == "Access Modifiers")
            {


                AMM = vp[j];
                j++;
                if (Static_St(ref TM) == true)
                {

                    if (Class_St2(cn, AMM, TM) == true)
                    {
                        return true;
                    }
                }
            }
            else if (cp[j] == "static")
            {
                AMM = "private";
                TM = cp[j];
                j++;
                if (Class_St2(cn, AMM, TM) == true)
                {
                    return true;
                }
            }
            else if (Class_St2(cn, "private", "") == true)
            {



                return true;
            }
            return false;
        }
        public bool Class_St2(string cn, string AMM, string TM)
        {

            if (cp[j] == "Datatype")
            {

                Type = vp[j];


                j++;
                if (Class_St3(cn, AMM, TM, Type) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "Identifier")
            {
                Name = vp[j];

                Type = vp[j];


                j++;
                if (Class_St4(Name, cn, AMM, TM, Type) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "void")
            {
                Type = cp[j];

                j++;
                if (Class_St5(cn, AMM, TM, Type) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "abstract")
            {
                TM = cp[j];
                j++;
                if (Method_Dt(ref Type, ref Type6) == true)
                {
                    string f = Type;
                    if (cp[j] == "Identifier")
                    {
                        Name1 = vp[j];
                        q.CreateScope(ref scope);
                        j++;
                        if (cp[j] == "(")
                        {
                            j++;
                            if (Method_Dec(scope, ref Type6) == true)
                            {
                                if (cp[j] == ")")
                                {
                                    j++;
                                    if (cp[j] == ";")
                                    {
                                        q.DestroyScope(ref scope);
                                        q.insertCT(Name1, Type6 + "->" + f, AMM, TM, cn, line[j], Type6, conc, Pa, ret);
                                        j++;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }
        public bool Class_St3(string cn, string AMM, string TM, string Type)
        {
            if (cp[j] == "Identifier")
            {
                Name = vp[j];
                j++;

                if (Class_St3_1(cn, AMM, TM, Type, Name) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "[")
            {
                j++;
                if (Class_St3_2("", cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }

            }
            else if (cp[j] == "main")
            {
                Name = cp[j];
                j++;

                if (cp[j] == "(")
                {
                    q.CreateScope(ref scope);

                    j++;
                    if (Main_Par(ref PLL) == true)
                    {
                        if (cp[j] == ")")
                        {
                            j++;

                            q.insertCT(Name, PLL + "->" + Type, AMM, TM, cn, line[j], P, conc, Pa, ret);
                            if (cp[j] == "{")
                            {
                                j++;
                                if (Body(ref Type1, ref Type5, scope, b, Type, "") == true)
                                {
                                    if (cp[j] == "}")
                                    {

                                        j++;
                                        q.DestroyScope(ref scope);
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Class_St3_1(string cn, string AMM, string TM, string Type, string Name1)
        {

            if (cp[j] == "(")
            {

                q.CreateScope(ref scope);

                j++;

                if (Method_Dec(scope, ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {


                        q.insertCT(Name1, PLL + "->" + Type, AMM, TM, cn, line[j], PLL, "method", Pa, Type);


                        j++;
                        if (cp[j] == "{")
                        {
                            j++;

                            if (Body(ref Type4, ref Type5, scope, 0, Type, "Datatype") == true)
                            {

                                if (Type4 != Type)
                                {

                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);


                                }
                                Type4 = "";

                                if (cp[j] == "}")
                                {
                                    q.DestroyScope(ref scope);
                                    j++;
                                    return true;
                                }

                            }
                        }
                    }
                }
            }
            else
            {
                q.insertCT(Name1, Type, AMM, TM, cn, line[j], P, conc, Pa, ret);

                if (Initialization_Class(Type) == true)
                {

                    if (List(Name,"", c, AMM, TM, Type, cn) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Class_St3_2(string N, string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == "]")
            {
                j++;
                if (Class_St3_3(N, cn, AMM, TM, Type, a) == true)
                {
                    return true;
                }
            }

            else if (cp[j] == ",")
            {
                j++;
                if (cp[j] == "]")
                {
                    j++;
                    if (Class_St3_4(N, cn, AMM, TM, Type, a) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Class_St3_3(string N, string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == "Identifier")
            {
                Name = vp[j];
                if (q.Lookup_Obj(Name, ref Type2, ref Type3) == "obj")
                {
                    Console.WriteLine("Error: Object redeclared on line " + line[j]);
                }

                j++;
                if (Class_St3_5(N, cn, AMM, TM, Type, Name, a) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "main")

                Name = cp[j];

            j++;
            if (cp[j] == "(")
            {
                q.CreateScope(ref scope);
                j++;
                if (Main_Par(ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {
                        j++;
                        q.insertCT(Name, PLL + "->" + Type, AMM, TM, cn, line[j], P, conc, Pa, ret);
                        if (cp[j] == "{")
                        {
                            j++;
                            if (Body(ref Type1, ref Type5, scope, b, Type, "") == true)
                            {
                                if (cp[j] == "}")
                                {
                                    q.DestroyScope(ref scope);
                                    j++;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }
        public bool Class_St3_4(string N, string cn, string AMM, string TM, string Type, int a)
        {
            if (cp[j] == "Identifier")
            {
                Name = vp[j];
                if (q.Lookup_Obj(Name, ref Type2, ref Type3) == "obj")
                {
                    Console.WriteLine("Error: Object redeclared on line " + line[j]);
                }
                j++;
                if (Class_St3_6(N, cn, AMM, TM, Type, Name, a) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "main")
            {
                Name = cp[j];
                j++;

                if (cp[j] == "(")
                {
                    q.CreateScope(ref scope);
                    j++;
                    if (Main_Par(ref PLL) == true)
                    {
                        if (cp[j] == ")")
                        {
                            q.insertCT(Name, PLL + "->" + Type, AMM, TM, cn, line[j], P, conc, Pa, ret);
                            j++;
                            if (cp[j] == "{")
                            {
                                j++;
                                if (Body(ref Type1, ref Type5, scope, b, Type, "") == true)
                                {
                                    if (cp[j] == "}")
                                    {
                                        q.DestroyScope(ref scope);
                                        j++;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Class_St3_5(string N, string cn, string AMM, string TM, string Type, string Name1, int a)
        {

            if (SArray_B(N, cn, AMM, TM, Type, a) == true)
            {

                return true;
            }
            else if (cp[j] == "(")
            {
                q.CreateScope(ref scope);

                j++;
                if (Method_Dec(scope, ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {

                        q.insertCT(Name1, PLL + "->" + Type, AMM, TM, cn, line[j], PLL, "method", Pa, Type);
                        j++;
                        if (cp[j] == "{")
                        {
                            j++;

                            if (Body(ref Type4, ref Type5, scope, 0, Type, "array") == true)
                            {
                                if (q.RT(Type) == false)
                                {

                                    if (Type != "int" && Type != "string" && Type != "char" && Type != "float")
                                    {
                                        Console.WriteLine("Error: Class doesn't exist on line " + line[j]);
                                    }
                                    if (Type5 != "array")
                                    {
                                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                                    }
                                    else if (Type5 == "array")
                                    {

                                        if (Type4 != Type)
                                        {
                                            Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                        }
                                    }

                                }
                                else if (q.RT(Type) == true)
                                {

                                    if (Type5 != "obj_arr")
                                    {
                                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                                    }
                                    else if (Type5 == "obj_arr")
                                    {
                                        if (Type4 != Type)
                                        {
                                            Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                        }
                                    }
                                }


                                Type4 = "";
                                Type = "";
                                if (cp[j] == "}")
                                {
                                    q.DestroyScope(ref scope);
                                    j++;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Class_St3_6(string N, string cn, string AMM, string TM, string Type, string Name1, int a)
        {

            if (MArray_B(N, cn, AMM, TM, Type, a) == true)
            {

                return true;
            }
            else if (cp[j] == "(")
            {
                q.CreateScope(ref scope);
                j++;


                if (Method_Dec(scope, ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {
                        q.insertCT(Name1, PLL + "->" + Type, AMM, TM, cn, line[j], PLL, "method", Pa, Type);

                        j++;
                        if (cp[j] == "{")
                        {

                            j++;
                            if (Body(ref Type4, ref Type5, scope, 0, Type, "marray") == true)
                            {
                                if (q.RT(Type) == false)
                                {

                                    if (Type != "int" && Type != "string" && Type != "char" && Type != "float")
                                    {
                                        Console.WriteLine("Error: Class doesn't exist on line " + line[j]);
                                    }
                                    if (Type5 != "marray")
                                    {
                                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                                    }
                                    else if (Type5 == "marray")
                                    {

                                        if (Type4 != Type)
                                        {
                                            Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                        }
                                    }

                                }
                                else if (q.RT(Type) == true)
                                {

                                    if (Type5 != "obj_marr")
                                    {
                                        Console.WriteLine("Error: Incorrect Return type on line " + line[j]);
                                    }
                                    else if (Type5 == "obj_marr")
                                    {
                                        if (Type4 != Type)
                                        {
                                            Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                        }
                                    }
                                }


                                Type4 = "";
                                Type = "";
                                if (cp[j] == "}")
                                {
                                    j++;
                                    q.DestroyScope(ref scope);

                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Class_St4(string cnn, string cn, string AMM, string TM, string Type)
        {

            if (cp[j] == "Identifier")
            {

                Name1 = vp[j];


                j++;
                if (Class_St4_1(Name1, cnn, cn, AMM, TM, Type) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "[")
            {
                string type = q.Lookup_CT(cnn, cnn, line[j], ref Pa);


                if (type != "con" && Pa == String.Empty)
                {
                    Console.WriteLine("Error: Constructor does not exist on line " + line[j]);
                }
                j++;
                if (Class_St3_2(cnn, cn, AMM, TM, Type, 1) == true)
                {
                    return true;
                }

            }

            else if (cp[j] == "(")
            {

                q.CreateScope(ref scope);
                j++;


                if (Method_Dec(scope, ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {
                        j++;
                        string ty = q.Lookup_CT(cnn, cnn, line[j], ref Pa);
                        

                        if (Pa != String.Empty)
                        {
                            string asss = q.Lookup_Obj(Pa, ref Type2, ref Type3);
                            
                            if (asss == "con")
                            {
                                
                                if (Type3 == "void")
                                { 
                                    
                                    if (ty == "con")
                                    {
                                        
                                        q.insertCT(cnn, PLL + "->" + Type, AMM, TM, cn, -1, PLL, "con", Pa, ret);

                                    }
                                    else if (ty != "con")
                                    {

                                        Console.WriteLine("Constructor cannot be created at line " + line[j]);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error: Parent Class " + Pa + " has a constructor");
                                }
                            }
                            else if (q.Lookup_R(Pa, "abstract") == true)
                            {
                                if (ty == "con")
                                {

                                    q.insertCT(cnn, PLL + "->" + Type, AMM, TM, cn, -1, PLL, "con", Pa, ret);

                                }
                                else if (ty != "con")
                                {

                                    Console.WriteLine("Constructor cannot be created at line " + line[j]);
                                }
                            }
                        }
                        else if (Pa == String.Empty)
                        {
                            if (ty == "con")
                            {
                                q.insertCT(cnn, PLL + "->" + Type, AMM, TM, cn, -1, PLL, "con", Pa, ret);

                            }
                            else if (ty != "con")
                            {

                                Console.WriteLine("Constructor cannot be created at line " + line[j]);
                            }
                        }











                        if (cp[j] == "{")
                        {
                            j++;
                            if (Body(ref Type4, ref Type5, scope, 0, "void", "void") == true)
                            {
                                if (Type4 != String.Empty)
                                {

                                    Console.WriteLine("Error: Incorrect Return type");

                                }
                                Type4 = "";
                                if (cp[j] == "}")
                                {
                                    j++;
                                    q.DestroyScope(ref scope);
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }
        public bool Class_St4_1(string Name1, string cnn, string cn, string AMM, string TM, string Type)
        {
            if (cp[j] == "=")
            {
                op = "=";
                j++;
                if (Class_St4_2(Name1, cnn, cn, AMM, TM, Type, op) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "(")
            {
                q.CreateScope(ref scope);
                j++;

                if (q.RT(cnn) == false)
                {
                    Console.WriteLine("Error: Class doesn't exist on line " + line[j]);
                }
                if (Method_Dec(scope, ref PLL) == true)
                {
                    if (cp[j] == ")")
                    {
                        j++;
                        q.insertCT(Name1, PLL + "->" + cnn, AMM, TM, cn, line[j], PLL, "method", Pa, cnn);
                        if (cp[j] == "{")
                        {
                            j++;
                            if (Body(ref Type4, ref Type5, scope, 0, cnn, "obj") == true)
                            {

                                if (Type4 != cnn)
                                {

                                    Console.WriteLine("Error: Incorrect Return type on line " + line[j]);

                                }
                                Type4 = "";
                                if (cp[j] == "}")
                                {
                                    j++;
                                    q.DestroyScope(ref scope);
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            else if (List(Name1, cnn, 1, AMM, TM, Type, cn) == true)
            {

                return true;
            }
            return false;
        }
        public bool Class_St4_2(string Name1, string cl, string cn, string AMM, string TM, string Type, string op)
        {
            if (Initialization_Class1(cl) == true)
            {
                string type = q.Lookup_CT(cl, cl, line[j], ref Pa);


                if (type != "con")
                {
                    Console.WriteLine("Error: Constructor does not exist on line "  + line[j]);
                }
                if (q.Lookup_Obj(Name1, ref Type2, ref Type3) == "obj")
                {
                    Console.WriteLine("Error: Object redeclared on line " + line[j]);
                }
                q.insertCT(Name1, cl, AMM, TM, cn, line[j], P, "obj", Pa, ret);


                if (List(Name, "",c, AMM, TM, Type, cn) == true)
                {
                    return true;
                }
            }
            else if (cp[j] == "new")
            {

                string type = q.Lookup_CT(cl, cl, line[j], ref Pa);
                if (type != "con" && Pa == String.Empty)
                {
                    Console.WriteLine("Error: Constructor does not exist on line " + line[j]);
                }
                j++;
                if (cp[j] == "Identifier")
                {
                    if (type == "con" || Pa != String.Empty)
                    {
                        if (q.Lookup_Obj(Name1, ref Type2, ref Type3) == "obj")
                        {
                            Console.WriteLine("Error: Object redeclared on line " + line[j]);
                        }
                    }
                    Name = vp[j];
                    if (Name != cl)
                    {
                        q.Lookup_Obj(Name, ref Type2, ref Type3);

                        if (type == "con" || Pa != String.Empty)
                        {
                            if (q.Lookup_Obj(Name1, ref Type2, ref Type3) != "obj")
                            {
                                if (Name != Type2)
                                {

                                    Console.WriteLine("Error: Object incorrect on line " + line[j]);
                                }
                            }
                        }
                    }
                    j++;

                    if (cp[j] == "(")
                    {
                        
                        j++;
                        Stack fun = new Stack();
                        if (PL(ref Type1, 1, ref fun) == true)
                        {

                            if (Name != cl)
                            {
                                q.Lookup_Obj(Name, ref Type2, ref Type3);

                                if (type == "con" || Pa != String.Empty)
                                {
                                    if (q.Lookup_Obj(Name1, ref Type2, ref Type3) != "obj")
                                    {
                                        if (Name == Type2)
                                        {

                                            if (Type1 != Type3)
                                            {
                                                Console.WriteLine("Error: Incorrect Parameters on line " + line[j]);
                                            }
                                        }
                                    }
                                }
                            }
                            q.insertCT(Name1, cl, AMM, TM, cn, line[j], P, "obj", Pa, ret);
                            if (cp[j] == ")")
                            {
                                j++;
                                if (cp[j] == ";")
                                {
                                    j++;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool Class_St5(string cn, string AMM, string TM, string Type)
        {
            if (cp[j] == "Identifier")
            {
                Name1 = vp[j];
                j++;

                q.CreateScope(ref scope);
                if (cp[j] == "(")
                {


                    j++;

                    if (Method_Dec(scope, ref PLL) == true)
                    {

                        if (cp[j] == ")")
                        {

                            q.insertCT(Name1, PLL + "->" + Type, AMM, TM, cn, line[j], PLL, "method", Pa, Type);
                            j++;


                            if (cp[j] == "{")
                            {

                                j++;
                                if (Body(ref Type11, ref Type5, scope, 0, Type, "void") == true)
                                {
                                    if (Type11 != "")
                                    {

                                        Console.WriteLine("Error: Incorrect Return type on line " + Type11 + line[j]);

                                    }
                                    Type11 = "";
                                    if (cp[j] == "}")
                                    {

                                        q.DestroyScope(ref scope);

                                        j++;

                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (cp[j] == "main")
            {
                Name = cp[j];

                j++;
                if (cp[j] == "(")
                {
                    q.CreateScope(ref scope);
                    j++;
                    if (Main_Par(ref PLL) == true)
                    {
                        if (cp[j] == ")")
                        {
                            j++;
                            q.insertCT(Name, PLL + "->" + Type, AMM, TM, cn, line[j], PLL, conc, Pa, ret);
                            if (cp[j] == "{")
                            {
                                j++;
                                if (Body(ref Type1, ref Type5, scope, b, Type, "") == true)
                                {
                                    if (cp[j] == "}")
                                    {
                                        j++;
                                        q.DestroyScope(ref scope);
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        


    }
    class Node
    {

        public string data;
        public Node next;
        public static Queue<string> c_part = new Queue<string>();
        public static Queue<string> v_part = new Queue<string>();
        public static Queue<int> lin = new Queue<int>();


        public Node(string cp, string vp, int line)
        {
            if (cp == "Operator")
            {
                if (vp == "-" || vp == "+")
                {
                    cp = "Plus Minus";
                }
                else if (vp == "*" || vp == "/" || vp == "%")
                {
                    cp = "MDM";
                }
                else if (vp == "<" || vp == ">" || vp == "<=" || vp == ">=" || vp == "==" || vp == "!=")
                {
                    cp = "Comparisional Operators";
                }
                else if (vp == "++" || vp == "--")
                {
                    cp = "Increment Decrement";
                }
                else if (vp == "~" || vp == "!")
                {
                    cp = "Not";
                }
                else if (vp == "*=" || vp == "/=" || vp == "%=" || vp == "+=" || vp == "-=")
                {
                    cp = "Assignment Operators";
                }
                else
                {
                    cp = vp;
                    vp = "";
                }
            }
            else if (cp == "Keyword")
            {
                if (vp == "int" || vp == "char" || vp == "string" || vp == "float")
                {
                    cp = "Datatype";
                }
                else if (vp == "public" || vp == "private")
                {
                    cp = "Access Modifiers";
                }
                else
                {
                    cp = vp;
                    vp = "";
                }
            }
            else if (cp == "Punctuator")
            {
                cp = vp;
                vp = "";

            }
            c_part.Enqueue(cp);
            v_part.Enqueue(vp);
            lin.Enqueue(line);
            data = "(" + cp + ", " + vp + ", " + line + ")";
            next = null;
        }

    }
    class List
    {
        public Node Head;
        public Node Tail;

        public int size;
        public List()
        {
            Head = null;
            Tail = null;
            size = 0;
        }

        public void Print()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        public void Write()
        {
            StreamWriter wr = new StreamWriter("E:\\FF.txt");
            Node temp = Head;
            while (temp != null)
            {
                wr.WriteLine(temp.data);
                temp = temp.next;

            }
            wr.Dispose();

        }
        public void Add_atEnd(string cp, string vp, int line)
        {
            Node temp = new Node(cp, vp, line);
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                size++;
            }
            else
            {
                Tail.next = temp;
                Tail = Tail.next;
                size++;
            }
        }

        public void Break(string temp, int line)
        {
            string[] Keywords = { "exception", "class", "args", "static", "void", "main", "return", "new", "seal", "int", "float", "char", "string", "char", "loop", "public", "private", "if", "else", "switch", "case", "def", "break", "abstract", "inherit", "array", "try", "catch" };
            string id = @"^[a-zA-Z_][0-9a-zA-Z_]*$";
            string flt = @"^[-+]?[0-9]*[.][0-9]+$";
            string integer = @"^[\-|+]?[0-9]+$";
            string wh = @"[\r|\n]";
            string[] Punctuators = new string[] { "{", "}", "[", "]", "(", ")", ",", ";", ":" };
            string[] Operators = new string[] { "+", "-", "*", "/", "%", "!", "=", ".", "<", ">", "&", "|", "&&", "||", "+=", "-=", "*=", "/=", "<=", ">=", "!=", "==", "++", "--" };

            if (Check_arr(Punctuators, temp) == true)
            {
                this.Add_atEnd("Punctuator", temp, line);
                temp = String.Empty;
            }
            else if (Check_arr(Operators, temp) == true)
            {
                this.Add_atEnd("Operator", temp, line);
                temp = String.Empty;
            }

            else if (Check(temp, id) == true)
            {
                if (Check_arr(Keywords, temp) == true)
                {
                    this.Add_atEnd("Keyword", temp, line);
                }
                else
                {
                    this.Add_atEnd("Identifier", temp, line);
                }
            }

            else if (Check(temp, integer) == true)
            {

                this.Add_atEnd("int", temp, line);
            }
            else if (Check(temp, flt) == true)
            {
                this.Add_atEnd("float", temp, line);
            }
            else if (Check(temp, flt) == false && Check(temp, integer) == false && Check(temp, id) == false && Check_arr(Punctuators, temp) == false && Check_arr(Operators, temp) == false && Check(temp, wh) == false && temp != "")
            {
                this.Add_atEnd("Invalid Lexeme", '"' + temp + '"', line);

            }

        }
        public bool Check_arr(string[] array, string temp)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (temp == array[k])
                {
                    return true;
                }
            }
            return false;
        }

        public bool Check(string temps, string pattern)
        {
            bool Ch = Regex.IsMatch(temps, pattern);
            if (Ch == true)
            {
                return true;
            }
            else
                return false;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            string temp = "";
            StreamReader sr = new StreamReader("C:\\FF.txt");
            List ob = new List();
            string[] Punctuators = new string[] { "{", "}", "[", "]", "(", ")", ",", ";", ":" };
            string[] Operators = new string[] { "+", "-", "*", "/", "%", "!", "=", ".", "<", ">", "&", "|", "&&", "||", "+=", "-=", "*=", "/=", "<=", ">=", "!=", "==", "++", "--" };
            Regex str = new Regex("^\"([a-zA-Z0-9 ]|(\\\\\\\\)|[~`!@#$%^&*()-=+{}|:;<>,.?/']|\\[|\\]|_|\\\\[abnrtv0f]|\\\\\"|\\\\')*\"$|^\"(\")\"$");
            int lock_string = 0;
            int lock_cm = 0;
            int lock_double_cm = 0;
            int line = 1;
            string flt = @"^[-+]?[0-9]*[.][0-9]+$";
            int char_lock = 0;
            int dot_lock = 0;
            string a = @"\";

            Regex chr_constant = new Regex("'[a-zA-Z0-9 ]'|'(\\\\\\\\)'|'[~`!@#$%^&*()-=+{}|:;<>,.?/]'|'\\['|'\\]'|'_'|'\\\\[abnrtv0f]'|'\"'|'\\\\\"'|'\\\\''");
            char current, ahead;

            do
            {
                current = (char)sr.Read();
                ahead = (char)sr.Peek();
                if ((current.ToString() == "'") && (lock_cm == 0) && (lock_double_cm == 0) && lock_string == 0 || (char_lock != 0))
                {
                    temp += current.ToString();
                    char_lock++;
                    if (current.ToString() == "'" && ahead.ToString() != a)
                    {
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp = temp + current.ToString();
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp = temp + current.ToString();
                        Match mc = chr_constant.Match(temp);

                        if (mc.Success)
                        {
                            temp = temp.Remove(0, 1);
                            temp = temp.Remove(temp.Length - 1);
                            ob.Add_atEnd("char", temp, line);
                            temp = String.Empty;
                        }
                        else
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }
                        char_lock = 0;
                    }

                    else if (current.ToString() == "'" && ahead.ToString() == a)
                    {
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp += current.ToString();
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp += current.ToString();
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp += current.ToString();
                        Match mc = chr_constant.Match(temp);

                        if (mc.Success)
                        {
                            temp = temp.Remove(0, 1);
                            temp = temp.Remove(temp.Length - 1);
                            ob.Add_atEnd("char", temp, line);
                            temp = String.Empty;
                        }
                        else
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }
                        char_lock = 0;
                    }
                }
                else if (current != ' ' && current != '\n' && lock_string == 0 && current != '"' && lock_cm == 0 && current != '#' && lock_double_cm == 0 && char_lock == 0 && current.ToString() != "'")
                {
                    temp += current.ToString();

                    if (current == '.' && dot_lock == 0)
                    {
                        if (char.IsNumber(ahead) == true)
                        {
                            dot_lock++;
                            temp += ahead.ToString();
                            ahead = (char)sr.Read();
                            current = ahead;
                            ahead = (char)sr.Peek();
                            while (char.IsLetterOrDigit(ahead) == true)
                            {
                                temp += ahead.ToString();
                                ahead = (char)sr.Read();
                                current = ahead;
                                ahead = (char)sr.Peek();
                            }
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }
                        else if (char.IsLetter(ahead) == true && dot_lock == 0)
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }
                    }


                    else if (ahead == '.' && dot_lock == 0)
                    {
                        if (char.IsNumber(current) == true)
                        {
                            dot_lock++;
                            if (char.IsNumber(current) == true && ahead == '.')
                            {
                                ahead = (char)sr.Read();
                                current = ahead;
                                ahead = (char)sr.Peek();
                                if (char.IsDigit(ahead) == true)
                                {
                                    temp = temp + current.ToString() + ahead.ToString();
                                    ahead = (char)sr.Read();
                                    current = ahead;
                                    ahead = (char)sr.Peek();
                                    while (char.IsLetterOrDigit(ahead) == true)
                                    {
                                        temp += ahead.ToString();
                                        ahead = (char)sr.Read();
                                        current = ahead;
                                        ahead = (char)sr.Peek();
                                    }
                                    ob.Break(temp, line);
                                    temp = String.Empty;
                                }
                                else if (char.IsNumber(ahead) == false)
                                {
                                    ob.Break(temp, line);
                                    ob.Break(current.ToString(), line);
                                    temp = String.Empty;
                                }
                                else if (ob.Check_arr(Punctuators, temp) == true)
                                {
                                    ob.Break(temp, line);
                                    temp = String.Empty;
                                }
                            }
                        }
                        else if (dot_lock == 0)
                        {

                            if (char.IsLetter(current) == true)
                            {
                                ob.Break(temp, line);
                                temp = String.Empty;
                            }
                            else if (ob.Check_arr(Operators, temp) == true)
                            {
                                ob.Break(temp, line);
                                temp = String.Empty;
                            }
                            else if (ob.Check_arr(Punctuators, current.ToString()) == true)
                            {
                                ob.Break(temp, line);
                                temp = String.Empty;
                            }
                        }
                    }
                    else if (current == '.' && char.IsDigit(ahead) == true)
                    {
                        ahead = (char)sr.Read();
                        current = ahead;
                        ahead = (char)sr.Peek();
                        temp = temp + current.ToString();
                        while (char.IsLetterOrDigit(ahead))
                        {
                            temp += ahead.ToString();
                            ahead = (char)sr.Read();
                            current = ahead;
                            ahead = (char)sr.Peek();
                        }
                        ob.Break(temp, line);
                        temp = String.Empty;
                    }

                    else if (current == '=' && (ahead == '+' || ahead == '-'))
                    {
                        ob.Add_atEnd("Operator", temp, line);
                        temp = String.Empty;
                        {
                            temp = temp + ahead.ToString();
                            ahead = (char)sr.Read();
                            current = ahead;
                            ahead = (char)sr.Peek();
                            if (char.IsNumber(current) == true)
                            {
                                temp = temp + current.ToString() + ahead.ToString();
                                ahead = (char)sr.Read();
                                current = ahead;
                                ahead = (char)sr.Peek();

                                if (char.IsNumber(ahead) == true)
                                {
                                    temp = temp + current.ToString() + ahead.ToString();
                                    ahead = (char)sr.Read();
                                    current = ahead;
                                    ahead = (char)sr.Peek();
                                    while (char.IsNumber(ahead) == true)
                                    {
                                        temp += ahead;
                                        current = (char)sr.Read();
                                        ahead = (char)sr.Peek();
                                    }

                                }
                                ob.Break(temp, line);
                                temp = String.Empty;
                            }
                        }
                    }
                    else if (dot_lock != 0 && ahead == '.' || current == '.')
                    {
                        if (ob.Check(temp, flt) == false)
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }
                    }
                    else if ((char)sr.Peek() == '\r')
                    {

                        ob.Break(temp, line);
                        temp = String.Empty;

                    }

                    else if (sr.Peek() == -1)
                    {
                        ob.Break(temp, line);
                        line++;
                        temp = String.Empty;
                    }
                    else if ((char)sr.Peek() == '\n')
                    {

                        ob.Break(temp, line);
                        temp = String.Empty;
                        line++;
                    }

                    else if (ob.Check_arr(Punctuators, ahead.ToString()) == true || ob.Check_arr(Punctuators, current.ToString()) == true)
                    {

                        ob.Break(temp, line);
                        temp = String.Empty;
                    }


                    else if (ob.Check_arr(Operators, ahead.ToString()) == true && ob.Check_arr(Operators, current.ToString()) == false)
                    {
                        ob.Break(temp, line);
                        temp = String.Empty;
                    }
                    else if (ob.Check_arr(Operators, current.ToString()) == true)
                    {
                        if (ob.Check_arr(Operators, ahead.ToString()) == false && ob.Check_arr(Operators, current.ToString()) == true)
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }

                        else if ((current == '+' && ahead == '+') || (current == '-' && ahead == '-') || (current == '|' && ahead == '|') || (current == '&' && ahead == '&') || (current == '=' && ahead == '='))
                        {
                            temp = current.ToString() + ahead.ToString();
                            ob.Add_atEnd("Operator", temp, line);
                            temp = String.Empty;
                            ahead = (char)sr.Read();
                            current = ahead;
                            ahead = (char)sr.Peek();

                        }
                        else if (ahead == '=')
                        {
                            temp = current.ToString() + ahead.ToString();
                            ob.Break(temp, line);
                            temp = String.Empty;
                            ahead = (char)sr.Read();
                            current = ahead;
                            ahead = (char)sr.Peek();

                        }

                        else if (ob.Check_arr(Operators, current.ToString()) == true && ob.Check_arr(Operators, ahead.ToString()) == true)
                        {
                            ob.Break(temp, line);
                            temp = String.Empty;
                        }


                    }
                }
                else if (current == ' ' && lock_string == 0 && lock_cm == 0 && lock_double_cm == 0 && char_lock == 0 && current.ToString() != "'")
                {
                    ob.Break(temp, line);
                    temp = String.Empty;
                    dot_lock = 0;
                }
                else if ((current == '"') && (lock_cm == 0) && (lock_double_cm == 0) && char_lock == 0 || (lock_string != 0) && (lock_cm == 0) && (lock_double_cm == 0) && char_lock == 0)
                {
                    lock_string++;
                    temp += current.ToString();
                    if (current != '"' && current != '\n')
                    {
                        if (ahead == '\n')
                        {
                            ob.Add_atEnd("Invalid Lexeme", '"' + temp + '"', line);
                            temp = String.Empty;
                            lock_string = 0;
                            line++;
                        }
                        else if (ahead == '\r')
                        {
                            ob.Add_atEnd("Invalid Lexeme", '"' + temp + '"', line);
                            temp = String.Empty;
                            lock_string = 0;
                        }
                        else if (sr.Peek() == -1)
                        {
                            ob.Add_atEnd("Invalid Lexeme", '"' + temp + '"', line);
                            temp = String.Empty;
                            lock_string = 0;
                        }

                    }
                    else if (lock_string > 1)
                    {
                        Match mc = str.Match(temp);
                        if (mc.Success)
                        {
                            temp = temp.Remove(0, 1);
                            temp = temp.Remove(temp.Length - 1);
                            ob.Add_atEnd("string", temp, line);
                            temp = String.Empty;
                            lock_string = 0;
                        }

                    }
                }

                else if (current == '#' || lock_cm != 0 && lock_string == 0 && char_lock == 0)
                {
                    ob.Break(temp, line);
                    temp = String.Empty;
                    lock_cm++;
                    if (current == '\n' && lock_double_cm == 0)
                    {
                        line++;
                        lock_cm = 0;
                    }
                    else if (ahead == '#')
                    {
                        lock_double_cm++;
                        lock_cm = 0;
                        line++;
                    }

                    else if (current == '#' && lock_double_cm > 1 && sr.Peek() == -1)
                    {
                        break;
                    }

                }
            }
            while (!sr.EndOfStream);
            ob.Add_atEnd("$", "", line);
            ob.Print();
            ob.Write();
            Syntax C = new Syntax();
            C.Struce();

            int value = 6;





            Console.ReadKey();

        }
    }
}
