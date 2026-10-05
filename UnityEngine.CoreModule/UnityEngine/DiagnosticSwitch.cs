using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[NativeAsStruct]
	[NativeClass("DiagnosticSwitch", "struct DiagnosticSwitch;")]
	[NativeHeader("Runtime/Utilities/DiagnosticSwitch.h")]
	[StructLayout(0)]
	internal class DiagnosticSwitch
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DiagnosticSwitch()
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000204 RID: 516
		[Token(Token = "0x17000081")]
		public extern string name { [Token(Token = "0x6000204")] [Address(RVA = "0x5928330", Offset = "0x5926F30", VA = "0x185928330")] [MethodImpl(4096)] get; }

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_Ptr;
	}
}
