using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A2 RID: 1442
	[Token(Token = "0x20005A2")]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Module, AllowMultiple = false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class DebuggableAttribute : System.Attribute
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
		}

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		// Token: 0x020005A3 RID: 1443
		[Token(Token = "0x20005A3")]
		[System.Runtime.InteropServices.ComVisible(true)]
		[System.Flags]
		public enum DebuggingModes
		{
			// Token: 0x04001927 RID: 6439
			[Token(Token = "0x4001927")]
			None = 0,
			// Token: 0x04001928 RID: 6440
			[Token(Token = "0x4001928")]
			Default = 1,
			// Token: 0x04001929 RID: 6441
			[Token(Token = "0x4001929")]
			DisableOptimizations = 256,
			// Token: 0x0400192A RID: 6442
			[Token(Token = "0x400192A")]
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x0400192B RID: 6443
			[Token(Token = "0x400192B")]
			EnableEditAndContinue = 4
		}
	}
}
