using System;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SwitchLevelAttribute : Attribute
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x5118DB0", Offset = "0x51179B0", VA = "0x185118DB0")]
		public SwitchLevelAttribute(Type switchLevelType)
		{
		}

		// Token: 0x170000FE RID: 254
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FE")]
		public Type SwitchLevelType
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x5118E80", Offset = "0x5117A80", VA = "0x185118E80")]
			set
			{
			}
		}

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x10")]
		private Type type;
	}
}
