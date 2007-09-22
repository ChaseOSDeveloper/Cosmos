using System;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;
using CPU = Indy.IL2CPU.Assembler.X86;

namespace Indy.IL2CPU.IL.X86 {
	[OpCode(Code.Bge_Un_S)]
	public class Bge_Un_S: Op {
		public Bge_Un_S(Mono.Cecil.Cil.Instruction aInstruction, MethodInformation aMethodInfo)
			: base(aInstruction, aMethodInfo) {
		}
		public override void DoAssemble() {
			throw new NotImplementedException("This file has been autogenerated and not been changed afterwards!");
		}
	}
}