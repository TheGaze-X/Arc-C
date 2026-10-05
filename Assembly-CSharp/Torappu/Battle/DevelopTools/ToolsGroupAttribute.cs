using System;
using AdvancedInspector;
using Il2CppDummyDll;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200289F RID: 10399
	[Token(Token = "0x200289F")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class ToolsGroupAttribute : GroupAttribute
	{
		// Token: 0x060114DF RID: 70879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114DF")]
		[Address(RVA = "0x932E00", Offset = "0x931A00", VA = "0x180932E00")]
		public ToolsGroupAttribute()
		{
		}

		// Token: 0x060114E0 RID: 70880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114E0")]
		[Address(RVA = "0x932D70", Offset = "0x931970", VA = "0x180932D70")]
		public ToolsGroupAttribute(string name)
		{
		}
	}
}
