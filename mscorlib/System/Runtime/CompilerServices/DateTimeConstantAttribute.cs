using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	[System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited = false)]
	[System.Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000476")]
		public override object Value
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x4BD3070", Offset = "0x4BD1C70", VA = "0x184BD3070", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x10")]
		private System.DateTime _date;
	}
}
