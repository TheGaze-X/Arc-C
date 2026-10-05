using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075F2 RID: 30194
	[Token(Token = "0x20075F2")]
	public class Act24sideMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x0602A83C RID: 174140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170063FE")]
		public Act24sideMissionProp prop
		{
			[Token(Token = "0x602A83C")]
			[Address(RVA = "0x262C6D0", Offset = "0x262B2D0", VA = "0x18262C6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A83D RID: 174141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A83D")]
		[Address(RVA = "0x262C4A0", Offset = "0x262B0A0", VA = "0x18262C4A0")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0602A83E RID: 174142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A83E")]
		[Address(RVA = "0x262C550", Offset = "0x262B150", VA = "0x18262C550")]
		public void UpdateData()
		{
		}

		// Token: 0x0602A83F RID: 174143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A83F")]
		[Address(RVA = "0x262C2B0", Offset = "0x262AEB0", VA = "0x18262C2B0")]
		public List<string> GetCanReceiveMission()
		{
			return null;
		}

		// Token: 0x0602A840 RID: 174144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A840")]
		[Address(RVA = "0x262C5E0", Offset = "0x262B1E0", VA = "0x18262C5E0")]
		public Act24sideMissionStateBean()
		{
		}

		// Token: 0x0403D317 RID: 250647
		[Token(Token = "0x403D317")]
		[FieldOffset(Offset = "0x10")]
		private Act24sideMissionProp m_prop;

		// Token: 0x0403D318 RID: 250648
		[Token(Token = "0x403D318")]
		[FieldOffset(Offset = "0x18")]
		public string clickMissionId;

		// Token: 0x0403D319 RID: 250649
		[Token(Token = "0x403D319")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0403D31A RID: 250650
		[Token(Token = "0x403D31A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403D31B RID: 250651
		[Token(Token = "0x403D31B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403D31C RID: 250652
		[Token(Token = "0x403D31C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCanReceiveMission;

		// Token: 0x0403D31D RID: 250653
		[Token(Token = "0x403D31D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
