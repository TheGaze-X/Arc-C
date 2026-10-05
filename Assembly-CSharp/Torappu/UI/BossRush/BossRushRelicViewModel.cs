using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006196 RID: 24982
	[Token(Token = "0x2006196")]
	public class BossRushRelicViewModel : IHotfixable
	{
		// Token: 0x0602408A RID: 147594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602408A")]
		[Address(RVA = "0x1EA9D80", Offset = "0x1EA8980", VA = "0x181EA9D80")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602408B RID: 147595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602408B")]
		[Address(RVA = "0x1EAA570", Offset = "0x1EA9170", VA = "0x181EAA570")]
		public void UpdateByPlayerData(bool refreshSelect)
		{
		}

		// Token: 0x0602408C RID: 147596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602408C")]
		[Address(RVA = "0x1EAA8C0", Offset = "0x1EA94C0", VA = "0x181EAA8C0")]
		private PlayerActivity.PlayerBossRushActivity.RelicInfo _GetPlayerRelicData()
		{
			return null;
		}

		// Token: 0x0602408D RID: 147597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602408D")]
		[Address(RVA = "0x1EAA350", Offset = "0x1EA8F50", VA = "0x181EAA350")]
		public void SetRelic(string sRelicId)
		{
		}

		// Token: 0x0602408E RID: 147598 RVA: 0x000C2CE8 File Offset: 0x000C0EE8
		[Token(Token = "0x602408E")]
		[Address(RVA = "0x1EA9AD0", Offset = "0x1EA86D0", VA = "0x181EA9AD0")]
		public bool CompletedRelicUpgrade()
		{
			return default(bool);
		}

		// Token: 0x0602408F RID: 147599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602408F")]
		[Address(RVA = "0x1EA9C60", Offset = "0x1EA8860", VA = "0x181EA9C60")]
		public BossRushRelicNodeModel GetRelicNodeModel(string relicId)
		{
			return null;
		}

		// Token: 0x06024090 RID: 147600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024090")]
		[Address(RVA = "0x1EAAA80", Offset = "0x1EA9680", VA = "0x181EAAA80")]
		public BossRushRelicViewModel()
		{
		}

		// Token: 0x04032121 RID: 205089
		[Token(Token = "0x4032121")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032122 RID: 205090
		[Token(Token = "0x4032122")]
		[FieldOffset(Offset = "0x18")]
		public int tokenCount;

		// Token: 0x04032123 RID: 205091
		[Token(Token = "0x4032123")]
		[FieldOffset(Offset = "0x20")]
		public string tokenName;

		// Token: 0x04032124 RID: 205092
		[Token(Token = "0x4032124")]
		[FieldOffset(Offset = "0x28")]
		public string selectingRelicId;

		// Token: 0x04032125 RID: 205093
		[Token(Token = "0x4032125")]
		[FieldOffset(Offset = "0x30")]
		public bool selectingChange;

		// Token: 0x04032126 RID: 205094
		[Token(Token = "0x4032126")]
		[FieldOffset(Offset = "0x38")]
		public ListDict<string, BossRushRelicNodeModel> nodeViewModelDic;

		// Token: 0x04032127 RID: 205095
		[Token(Token = "0x4032127")]
		[FieldOffset(Offset = "0x40")]
		public string relicUpgradeItemId;

		// Token: 0x04032128 RID: 205096
		[Token(Token = "0x4032128")]
		[FieldOffset(Offset = "0x48")]
		public int enterAnimTick;

		// Token: 0x04032129 RID: 205097
		[Token(Token = "0x4032129")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403212A RID: 205098
		[Token(Token = "0x403212A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateByPlayerData;

		// Token: 0x0403212B RID: 205099
		[Token(Token = "0x403212B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPlayerRelicData;

		// Token: 0x0403212C RID: 205100
		[Token(Token = "0x403212C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetRelic;

		// Token: 0x0403212D RID: 205101
		[Token(Token = "0x403212D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompletedRelicUpgrade;

		// Token: 0x0403212E RID: 205102
		[Token(Token = "0x403212E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRelicNodeModel;

		// Token: 0x0403212F RID: 205103
		[Token(Token = "0x403212F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
