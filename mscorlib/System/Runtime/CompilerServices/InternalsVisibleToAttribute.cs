using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	[System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class InternalsVisibleToAttribute : System.Attribute
	{
		// Token: 0x0600234F RID: 9039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x4BD5760", Offset = "0x4BD4360", VA = "0x184BD5760")]
		public InternalsVisibleToAttribute(string assemblyName)
		{
		}

		// Token: 0x1700048C RID: 1164
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		public bool AllInternalsVisible
		{
			[Token(Token = "0x6002350")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x10")]
		private string _assemblyName;

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x18")]
		private bool _allInternalsVisible;
	}
}
