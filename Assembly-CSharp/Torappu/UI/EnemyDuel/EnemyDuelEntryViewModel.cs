using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FA3 RID: 20387
	[Token(Token = "0x2004FA3")]
	public class EnemyDuelEntryViewModel : IHotfixable
	{
		// Token: 0x0601E4D1 RID: 124113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4D1")]
		[Address(RVA = "0x1802CB0", Offset = "0x18018B0", VA = "0x181802CB0")]
		public void LoadData(string actId, TemplateActivityLifeCycleViewModel actModel)
		{
		}

		// Token: 0x0601E4D2 RID: 124114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4D2")]
		[Address(RVA = "0x18031C0", Offset = "0x1801DC0", VA = "0x1818031C0")]
		private ActivityEnemyDuelAnnounceData _LoadValidAnnounce(List<ActivityEnemyDuelAnnounceData> announceData)
		{
			return null;
		}

		// Token: 0x0601E4D3 RID: 124115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4D3")]
		[Address(RVA = "0x18032F0", Offset = "0x1801EF0", VA = "0x1818032F0")]
		public EnemyDuelEntryViewModel()
		{
		}

		// Token: 0x04028741 RID: 165697
		[Token(Token = "0x4028741")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028742 RID: 165698
		[Token(Token = "0x4028742")]
		[FieldOffset(Offset = "0x18")]
		public bool showMainWnd;

		// Token: 0x04028743 RID: 165699
		[Token(Token = "0x4028743")]
		[FieldOffset(Offset = "0x19")]
		public bool showMusicWnd;

		// Token: 0x04028744 RID: 165700
		[Token(Token = "0x4028744")]
		[FieldOffset(Offset = "0x1C")]
		public int enterSeq;

		// Token: 0x04028745 RID: 165701
		[Token(Token = "0x4028745")]
		[FieldOffset(Offset = "0x20")]
		public string videoResPath;

		// Token: 0x04028746 RID: 165702
		[Token(Token = "0x4028746")]
		[FieldOffset(Offset = "0x28")]
		public string titleMainWnd;

		// Token: 0x04028747 RID: 165703
		[Token(Token = "0x4028747")]
		[FieldOffset(Offset = "0x30")]
		public string musicName;

		// Token: 0x04028748 RID: 165704
		[Token(Token = "0x4028748")]
		[FieldOffset(Offset = "0x38")]
		public TemplateActivityLifeCycleViewModel.ActState actState;

		// Token: 0x04028749 RID: 165705
		[Token(Token = "0x4028749")]
		[FieldOffset(Offset = "0x3C")]
		public bool isMultiPreposedPassed;

		// Token: 0x0402874A RID: 165706
		[Token(Token = "0x402874A")]
		[FieldOffset(Offset = "0x3D")]
		public bool announceShowNew;

		// Token: 0x0402874B RID: 165707
		[Token(Token = "0x402874B")]
		[FieldOffset(Offset = "0x40")]
		public string announceText;

		// Token: 0x0402874C RID: 165708
		[Token(Token = "0x402874C")]
		[FieldOffset(Offset = "0x48")]
		public int dailyProcess;

		// Token: 0x0402874D RID: 165709
		[Token(Token = "0x402874D")]
		[FieldOffset(Offset = "0x4C")]
		public int dailyTarget;

		// Token: 0x0402874E RID: 165710
		[Token(Token = "0x402874E")]
		[FieldOffset(Offset = "0x50")]
		public bool haveMatchTrack;

		// Token: 0x0402874F RID: 165711
		[Token(Token = "0x402874F")]
		[FieldOffset(Offset = "0x58")]
		public string playerName;

		// Token: 0x04028750 RID: 165712
		[Token(Token = "0x4028750")]
		[FieldOffset(Offset = "0x60")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028751 RID: 165713
		[Token(Token = "0x4028751")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028752 RID: 165714
		[Token(Token = "0x4028752")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadValidAnnounce;

		// Token: 0x04028753 RID: 165715
		[Token(Token = "0x4028753")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
