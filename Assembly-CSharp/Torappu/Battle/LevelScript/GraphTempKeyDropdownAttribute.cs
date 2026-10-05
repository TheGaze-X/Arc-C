using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200282D RID: 10285
	[Token(Token = "0x200282D")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[ApplyToParam]
	public class GraphTempKeyDropdownAttribute : Attribute
	{
		// Token: 0x060111EC RID: 70124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111EC")]
		[Address(RVA = "0x90EF10", Offset = "0x90DB10", VA = "0x18090EF10")]
		public GraphTempKeyDropdownAttribute()
		{
		}

		// Token: 0x060111ED RID: 70125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111ED")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public GraphTempKeyDropdownAttribute(Type valueType)
		{
		}

		// Token: 0x060111EE RID: 70126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111EE")]
		[Address(RVA = "0x90EF40", Offset = "0x90DB40", VA = "0x18090EF40")]
		public GraphTempKeyDropdownAttribute(bool allowAny)
		{
		}

		// Token: 0x040132F6 RID: 78582
		[Token(Token = "0x40132F6")]
		[FieldOffset(Offset = "0x10")]
		public Type ValueType;

		// Token: 0x040132F7 RID: 78583
		[Token(Token = "0x40132F7")]
		[FieldOffset(Offset = "0x18")]
		public bool AllowAny;
	}
}
