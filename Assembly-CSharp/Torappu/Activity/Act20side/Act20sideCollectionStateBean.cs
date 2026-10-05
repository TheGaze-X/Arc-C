using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007696 RID: 30358
	[Token(Token = "0x2007696")]
	public class Act20sideCollectionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AB23 RID: 174883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB23")]
		[Address(RVA = "0x2670570", Offset = "0x266F170", VA = "0x182670570")]
		public void LoadData()
		{
		}

		// Token: 0x0602AB24 RID: 174884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB24")]
		[Address(RVA = "0x2670600", Offset = "0x266F200", VA = "0x182670600")]
		public Act20sideCollectionStateBean()
		{
		}

		// Token: 0x0403D846 RID: 251974
		[Token(Token = "0x403D846")]
		[FieldOffset(Offset = "0x10")]
		public readonly Act20sideCollectionProperty property;

		// Token: 0x0403D847 RID: 251975
		[Token(Token = "0x403D847")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0403D848 RID: 251976
		[Token(Token = "0x403D848")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D849 RID: 251977
		[Token(Token = "0x403D849")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
