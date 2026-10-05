using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717B RID: 29051
	[Token(Token = "0x200717B")]
	public class Act9D0RetroPassRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293DB RID: 168923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293DB")]
		[Address(RVA = "0x24A1A90", Offset = "0x24A0690", VA = "0x1824A1A90")]
		public void UpdateRewardBtn()
		{
		}

		// Token: 0x060293DC RID: 168924 RVA: 0x000D4D00 File Offset: 0x000D2F00
		[Token(Token = "0x60293DC")]
		[Address(RVA = "0x24A1B00", Offset = "0x24A0700", VA = "0x1824A1B00")]
		private bool _CheckHasRewardToClaim()
		{
			return default(bool);
		}

		// Token: 0x060293DD RID: 168925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293DD")]
		[Address(RVA = "0x24A1710", Offset = "0x24A0310", VA = "0x1824A1710")]
		public void EventOnClickRetroPassReward()
		{
		}

		// Token: 0x060293DE RID: 168926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293DE")]
		[Address(RVA = "0x24A1E20", Offset = "0x24A0A20", VA = "0x1824A1E20")]
		public Act9D0RetroPassRewardView()
		{
		}

		// Token: 0x0403AE5E RID: 241246
		[Token(Token = "0x403AE5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnReward;

		// Token: 0x0403AE5F RID: 241247
		[Token(Token = "0x403AE5F")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedActId;

		// Token: 0x0403AE60 RID: 241248
		[Token(Token = "0x403AE60")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedRetroId;

		// Token: 0x0403AE61 RID: 241249
		[Token(Token = "0x403AE61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateRewardBtn;

		// Token: 0x0403AE62 RID: 241250
		[Token(Token = "0x403AE62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckHasRewardToClaim;

		// Token: 0x0403AE63 RID: 241251
		[Token(Token = "0x403AE63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickRetroPassReward;

		// Token: 0x0403AE64 RID: 241252
		[Token(Token = "0x403AE64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
