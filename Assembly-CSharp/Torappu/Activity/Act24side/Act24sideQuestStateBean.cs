using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007606 RID: 30214
	[Token(Token = "0x2007606")]
	public class Act24sideQuestStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x0602A89D RID: 174237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006404")]
		public Act24sideQuestProp prop
		{
			[Token(Token = "0x602A89D")]
			[Address(RVA = "0x26601C0", Offset = "0x265EDC0", VA = "0x1826601C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A89E RID: 174238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A89E")]
		[Address(RVA = "0x26600D0", Offset = "0x265ECD0", VA = "0x1826600D0")]
		public Act24sideQuestStateBean()
		{
		}

		// Token: 0x0403D3CE RID: 250830
		[Token(Token = "0x403D3CE")]
		[FieldOffset(Offset = "0x10")]
		private Act24sideQuestProp m_prop;

		// Token: 0x0403D3CF RID: 250831
		[Token(Token = "0x403D3CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0403D3D0 RID: 250832
		[Token(Token = "0x403D3D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
