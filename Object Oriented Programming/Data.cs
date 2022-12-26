namespace Object_Oriented_Programming
{
    // Tipul clasa Data este generalizata cu tipul T, el in urma lui fiind orice tip necesar in program fie int fie char fie string...
    internal class Data<T>
    {
        private T? data1;
        private T? data2;

        public T Data1
        { get { return data1; } set { data1 = value; } }

        public T Data2
        { get { return data2; } set { data2 = value; } }
    }
}