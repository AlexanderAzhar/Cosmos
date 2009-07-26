using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Ldind_I2)]
	public class Ldind_I2: ILOp
	{
		public Ldind_I2(Cosmos.IL2CPU.Assembler aAsmblr):base(aAsmblr)
		{
		}

    public override void Execute(uint aMethodUID, ILOpCode aOpCode) {
      throw new Exception("TODO:");
    }

    #region Old code
		// using System;
		// using System.IO;
		// 
		// 
		// using CPUx86 = Indy.IL2CPU.Assembler.X86;
		// using Indy.IL2CPU.Assembler;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[OpCode(OpCodeEnum.Ldind_I2)]
		// 	public class Ldind_I2: Op {
		// 		public Ldind_I2(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 		}
		// 		public override void DoAssemble() {
		//             new CPUx86.Pop { DestinationReg = CPUx86.Registers.EAX };
		//             new CPUx86.Move { DestinationReg = CPUx86.Registers.EDX, SourceValue = 0 };
		// 			new CPUx86.Move{DestinationReg = CPUx86.Registers.DX, SourceReg = CPUx86.Registers.EAX, SourceIsIndirect=true};
		//             new CPUx86.Push { DestinationReg = CPUx86.Registers.EDX };
		// 			Assembler.StackContents.Pop();
		// 			Assembler.StackContents.Push(new StackContent(2, typeof(short)));
		// 		}
		// 	}
		// }
		#endregion Old code
	}
}
