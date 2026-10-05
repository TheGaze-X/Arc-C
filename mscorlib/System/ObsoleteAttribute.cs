using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Delegate, Inherited = false)]
	[System.Serializable]
	public sealed class ObsoleteAttribute : System.Attribute
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x4CEC680", Offset = "0x4CEB280", VA = "0x184CEC680")]
		public ObsoleteAttribute()
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x4CEC700", Offset = "0x4CEB300", VA = "0x184CEC700")]
		public ObsoleteAttribute(string message)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x4CEC6B0", Offset = "0x4CEB2B0", VA = "0x184CEC6B0")]
		public ObsoleteAttribute(string message, bool error)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000A5")]
		public string Message
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x10")]
		private string _message;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x18")]
		private bool _error;
	}
}
