using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Method)]
	[System.Serializable]
	public class CompilationRelaxationsAttribute : System.Attribute
	{
		// Token: 0x0600234C RID: 9036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public CompilationRelaxationsAttribute(int relaxations)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x1700048B")]
		public int CompilationRelaxations
		{
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_relaxations;
	}
}
