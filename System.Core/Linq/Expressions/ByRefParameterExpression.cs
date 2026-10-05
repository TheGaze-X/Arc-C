using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	internal sealed class ByRefParameterExpression : TypedParameterExpression
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4F3DC50", Offset = "0x4F3C850", VA = "0x184F3DC50")]
		internal ByRefParameterExpression(Type type, string name)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		internal override bool GetIsByRef()
		{
			return default(bool);
		}
	}
}
