using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067FB RID: 26619
	[Token(Token = "0x20067FB")]
	public class PermModeZoneGroupViewModel : ZoneGroupViewModel, IHotfixable
	{
		// Token: 0x06026266 RID: 156262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026266")]
		[Address(RVA = "0x2131D20", Offset = "0x2130920", VA = "0x182131D20")]
		public void LoadData()
		{
		}

		// Token: 0x06026267 RID: 156263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026267")]
		[Address(RVA = "0x2131F10", Offset = "0x2130B10", VA = "0x182131F10")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06026268 RID: 156264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026268")]
		[Address(RVA = "0x21320C0", Offset = "0x2130CC0", VA = "0x1821320C0")]
		private void _LoadRogueData(long currTs)
		{
		}

		// Token: 0x06026269 RID: 156265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026269")]
		[Address(RVA = "0x2132310", Offset = "0x2130F10", VA = "0x182132310")]
		private void _LoadSandboxData(long currTs)
		{
		}

		// Token: 0x0602626A RID: 156266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602626A")]
		[Address(RVA = "0x2132440", Offset = "0x2131040", VA = "0x182132440")]
		public PermModeZoneGroupViewModel()
		{
		}

		// Token: 0x04035BAB RID: 220075
		[Token(Token = "0x4035BAB")]
		[FieldOffset(Offset = "0x28")]
		public string currRogueTopicId;

		// Token: 0x04035BAC RID: 220076
		[Token(Token = "0x4035BAC")]
		[FieldOffset(Offset = "0x30")]
		public bool isOnBattle;

		// Token: 0x04035BAD RID: 220077
		[Token(Token = "0x4035BAD")]
		[FieldOffset(Offset = "0x38")]
		public string onBattleTopicId;

		// Token: 0x04035BAE RID: 220078
		[Token(Token = "0x4035BAE")]
		[FieldOffset(Offset = "0x40")]
		public string onBattleTopicName;

		// Token: 0x04035BAF RID: 220079
		[Token(Token = "0x4035BAF")]
		[FieldOffset(Offset = "0x48")]
		public bool showRoguelikeDLCUpdateTag;

		// Token: 0x04035BB0 RID: 220080
		[Token(Token = "0x4035BB0")]
		[FieldOffset(Offset = "0x49")]
		public bool showRoguelikeReviewUpdateTag;

		// Token: 0x04035BB1 RID: 220081
		[Token(Token = "0x4035BB1")]
		[FieldOffset(Offset = "0x50")]
		public string currSandboxTopicId;

		// Token: 0x04035BB2 RID: 220082
		[Token(Token = "0x4035BB2")]
		[FieldOffset(Offset = "0x58")]
		public bool showSandboxUpdateTag;

		// Token: 0x04035BB3 RID: 220083
		[Token(Token = "0x4035BB3")]
		[FieldOffset(Offset = "0x59")]
		public bool isSandboxClosed;

		// Token: 0x04035BB4 RID: 220084
		[Token(Token = "0x4035BB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035BB5 RID: 220085
		[Token(Token = "0x4035BB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04035BB6 RID: 220086
		[Token(Token = "0x4035BB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadRogueData;

		// Token: 0x04035BB7 RID: 220087
		[Token(Token = "0x4035BB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSandboxData;

		// Token: 0x04035BB8 RID: 220088
		[Token(Token = "0x4035BB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
