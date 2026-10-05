using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public sealed class WaitForSeconds : YieldInstruction
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x485B2E0", Offset = "0x4859EE0", VA = "0x18485B2E0")]
		public WaitForSeconds(float seconds)
		{
		}

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float m_Seconds;
	}
}
