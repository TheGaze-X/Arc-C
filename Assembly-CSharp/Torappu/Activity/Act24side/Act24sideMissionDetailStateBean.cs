using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075D4 RID: 30164
	[Token(Token = "0x20075D4")]
	public class Act24sideMissionDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x0602A78D RID: 173965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170063E3")]
		public Act24sideMissionDetailProp prop
		{
			[Token(Token = "0x602A78D")]
			[Address(RVA = "0x2624570", Offset = "0x2623170", VA = "0x182624570")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A78E RID: 173966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A78E")]
		[Address(RVA = "0x2624340", Offset = "0x2622F40", VA = "0x182624340")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0602A78F RID: 173967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A78F")]
		[Address(RVA = "0x26243F0", Offset = "0x2622FF0", VA = "0x1826243F0")]
		public void UpdateData()
		{
		}

		// Token: 0x0602A790 RID: 173968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A790")]
		[Address(RVA = "0x2624480", Offset = "0x2623080", VA = "0x182624480")]
		public Act24sideMissionDetailStateBean()
		{
		}

		// Token: 0x0403D1F7 RID: 250359
		[Token(Token = "0x403D1F7")]
		[FieldOffset(Offset = "0x10")]
		private Act24sideMissionDetailProp m_prop;

		// Token: 0x0403D1F8 RID: 250360
		[Token(Token = "0x403D1F8")]
		[FieldOffset(Offset = "0x18")]
		public string clickMissionId;

		// Token: 0x0403D1F9 RID: 250361
		[Token(Token = "0x403D1F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0403D1FA RID: 250362
		[Token(Token = "0x403D1FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403D1FB RID: 250363
		[Token(Token = "0x403D1FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403D1FC RID: 250364
		[Token(Token = "0x403D1FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
