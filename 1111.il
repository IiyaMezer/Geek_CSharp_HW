
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Building
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 08 42 75 69 6C 64 69 6E 67 00 00 )          // ...Building..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 08 42 75 69 6C 64 69 6E 67 00 00 )          // ...Building..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 35 63 38 32 63 37 30 61 2D 64 35 62 30   // ..$5c82c70a-d5b0
                                                                                                  2D 34 37 64 64 2D 62 37 62 32 2D 63 66 65 61 65   // -47dd-b7b2-cfeae
                                                                                                  64 36 35 62 66 34 39 00 00 )                      // d65bf49..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Building.exe
// MVID: {D09ED730-A35A-425A-B9BF-E953C40C48E5}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x09060000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Building.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Task01(int32 X,
                                                int32 Y) cil managed
  {
    // Code size       195 (0xc3)
    .maxstack  4
    .locals init ([0] char[0...,0...] Matrix,
             [1] int32 dx,
             [2] int32 dy,
             [3] int32 err,
             [4] int32 y,
             [5] int32 derr,
             [6] int32 Ystep,
             [7] int32 i,
             [8] bool V_8,
             [9] int32 x,
             [10] bool V_10,
             [11] bool V_11)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldarg.0
    IL_0003:  newobj     instance void char[0...,0...]::.ctor(int32,
                                                              int32)
    IL_0008:  stloc.0
    IL_0009:  ldloc.0
    IL_000a:  ldc.i4.1
    IL_000b:  callvirt   instance int32 [mscorlib]System.Array::GetLength(int32)
    IL_0010:  stloc.1
    IL_0011:  ldloc.0
    IL_0012:  ldc.i4.0
    IL_0013:  callvirt   instance int32 [mscorlib]System.Array::GetLength(int32)
    IL_0018:  stloc.2
    IL_0019:  ldc.i4.0
    IL_001a:  stloc.3
    IL_001b:  ldc.i4.0
    IL_001c:  stloc.s    y
    IL_001e:  ldloc.2
    IL_001f:  stloc.s    derr
    IL_0021:  ldc.i4.0
    IL_0022:  ldloc.2
    IL_0023:  blt.s      IL_0028

    IL_0025:  ldc.i4.m1
    IL_0026:  br.s       IL_0029

    IL_0028:  ldc.i4.1
    IL_0029:  stloc.s    Ystep
    IL_002b:  ldc.i4.0
    IL_002c:  stloc.s    i
    IL_002e:  br.s       IL_00ae

    IL_0030:  nop
    IL_0031:  ldloc.0
    IL_0032:  ldloc.s    y
    IL_0034:  ldloc.s    i
    IL_0036:  ldc.i4.s   42
    IL_0038:  call       instance void char[0...,0...]::Set(int32,
                                                            int32,
                                                            char)
    IL_003d:  ldstr      "{0} "
    IL_0042:  ldloc.0
    IL_0043:  ldloc.s    y
    IL_0045:  ldloc.s    i
    IL_0047:  call       instance char char[0...,0...]::Get(int32,
                                                            int32)
    IL_004c:  box        [mscorlib]System.Char
    IL_0051:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0056:  call       void [mscorlib]System.Console::Write(string)
    IL_005b:  nop
    IL_005c:  ldloc.3
    IL_005d:  ldloc.s    derr
    IL_005f:  add
    IL_0060:  stloc.3
    IL_0061:  ldloc.3
    IL_0062:  ldloc.1
    IL_0063:  clt
    IL_0065:  ldc.i4.0
    IL_0066:  ceq
    IL_0068:  stloc.s    V_8
    IL_006a:  ldloc.s    V_8
    IL_006c:  brfalse.s  IL_00a7

    IL_006e:  nop
    IL_006f:  ldloc.s    y
    IL_0071:  ldloc.s    Ystep
    IL_0073:  add
    IL_0074:  stloc.s    y
    IL_0076:  ldloc.3
    IL_0077:  ldloc.1
    IL_0078:  sub
    IL_0079:  stloc.3
    IL_007a:  call       void [mscorlib]System.Console::WriteLine()
    IL_007f:  nop
    IL_0080:  ldc.i4.0
    IL_0081:  stloc.s    x
    IL_0083:  br.s       IL_0098

    IL_0085:  nop
    IL_0086:  ldstr      "  "
    IL_008b:  call       void [mscorlib]System.Console::Write(string)
    IL_0090:  nop
    IL_0091:  nop
    IL_0092:  ldloc.s    x
    IL_0094:  ldc.i4.1
    IL_0095:  add
    IL_0096:  stloc.s    x
    IL_0098:  ldloc.s    x
    IL_009a:  ldloc.s    i
    IL_009c:  ldc.i4.1
    IL_009d:  add
    IL_009e:  clt
    IL_00a0:  stloc.s    V_10
    IL_00a2:  ldloc.s    V_10
    IL_00a4:  brtrue.s   IL_0085

    IL_00a6:  nop
    IL_00a7:  nop
    IL_00a8:  ldloc.s    i
    IL_00aa:  ldc.i4.1
    IL_00ab:  add
    IL_00ac:  stloc.s    i
    IL_00ae:  ldloc.s    i
    IL_00b0:  ldloc.1
    IL_00b1:  clt
    IL_00b3:  stloc.s    V_11
    IL_00b5:  ldloc.s    V_11
    IL_00b7:  brtrue     IL_0030

    IL_00bc:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_00c1:  pop
    IL_00c2:  ret
  } // end of method Program::Task01

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       54 (0x36)
    .maxstack  2
    .locals init ([0] int32 x,
             [1] int32 y)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    34 04 3B 04 38 04 3D 04 43 04 20 00 3C 04 30 04   // 4.;.8.=.C. .<.0.
                                    41 04 41 04 38 04 32 04 30 04 3A 00 )             // A.A.8.2.0.:.
    IL_0006:  call       void [mscorlib]System.Console::Write(string)
    IL_000b:  nop
    IL_000c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0011:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_0016:  stloc.0
    IL_0017:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    32 04 4B 04 41 04 3E 04 42 04 43 04 20 00 3C 04   // 2.K.A.>.B.C. .<.
                                    30 04 41 04 41 04 38 04 32 04 30 04 20 00 3C 04   // 0.A.A.8.2.0. .<.
                                    35 04 3D 04 4C 04 48 04 43 04 4E 04 20 00 34 04   // 5.=.L.H.C.N. .4.
                                    3B 04 38 04 3D 04 35 04 3A 00 )                   // ;.8.=.5.:.
    IL_001c:  call       void [mscorlib]System.Console::ReadLine()
    IL_0027:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_002c:  stloc.1
    IL_002d:  ldloc.0
    IL_002e:  ldloc.1
    IL_002f:  call       void Building.Program::Task01(int32,
                                                       int32)
    IL_0034:  nop
    IL_0035:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Building.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file E:\Ñ#\repos\IiyaMezer\Geek_CSharp_HW\Building\1111.res
