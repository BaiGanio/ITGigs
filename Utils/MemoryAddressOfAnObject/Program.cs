using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace MemoryAddressOfAnObject
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            obj = "This is an object";
            object car2 = new Car();
            GCHandle gch = GCHandle.Alloc(car2, GCHandleType.Pinned);
            IntPtr pObj = gch.AddrOfPinnedObject();
            Console.WriteLine(pObj.ToString());


            //object car1 = new Car()/* { Color= "Grey" }*/;
            ////Car car2 = new Car("Silver");
            //Console.WriteLine(MemoryAddress.Get((object)car1));
            //Console.WriteLine(MemoryAddress.Get(car2));
            //car1.Color = "Blue";
            //Console.WriteLine(MemoryAddress.Get(car1));
        }
    }
    public class Car
    {
        //public string Color { get; set; }
    }
    public static class MemoryAddress
    {
        public static string Get(object obj)
        {
            GCHandle gch = GCHandle.Alloc(obj, GCHandleType.Pinned);
            IntPtr pObj = gch.AddrOfPinnedObject();
            return pObj.ToString();
        }
    }


    public static class ReferenceHelpers
    {
        public static readonly Action<object, Action<IntPtr>> GetPinnedPtr;

        static ReferenceHelpers()
        {
            var dyn = new DynamicMethod("GetPinnedPtr", typeof(void), new[] { typeof(object), typeof(Action<IntPtr>) }, typeof(ReferenceHelpers).Module);
            var il = dyn.GetILGenerator();
            il.DeclareLocal(typeof(object), true);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Stloc_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Ldloc_0);
            il.Emit(OpCodes.Conv_I);
            il.Emit(OpCodes.Call, typeof(Action<IntPtr>).GetMethod("Invoke"));
            il.Emit(OpCodes.Ret);
            GetPinnedPtr = (Action<object, Action<IntPtr>>)dyn.CreateDelegate(typeof(Action<object, Action<IntPtr>>));
        }
    }
}
