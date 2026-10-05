using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B6B RID: 15211
	[Token(Token = "0x2003B6B")]
	public class SquadPage : StateEnginePage
	{
		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x06017DBC RID: 97724 RVA: 0x00098718 File Offset: 0x00096918
		[Token(Token = "0x170038F8")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x6017DBC")]
			[Address(RVA = "0x101CF70", Offset = "0x101BB70", VA = "0x18101CF70", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x06017DBD RID: 97725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DBD")]
		[Address(RVA = "0x101CC40", Offset = "0x101B840", VA = "0x18101CC40", Slot = "15")]
		protected override void OnRecycle()
		{
		}

		// Token: 0x06017DBE RID: 97726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DBE")]
		[Address(RVA = "0x101CF10", Offset = "0x101BB10", VA = "0x18101CF10")]
		public SquadPage()
		{
		}

		// Token: 0x06017DBF RID: 97727 RVA: 0x00098730 File Offset: 0x00096930
		[Token(Token = "0x6017DBF")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x06017DC0 RID: 97728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DC0")]
		[Address(RVA = "0xF93B70", Offset = "0xF92770", VA = "0x180F93B70")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0401CD33 RID: 118067
		[Token(Token = "0x401CD33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x0401CD34 RID: 118068
		[Token(Token = "0x401CD34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401CD35 RID: 118069
		[Token(Token = "0x401CD35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B6C RID: 15212
		[Token(Token = "0x2003B6C")]
		public struct Params
		{
			// Token: 0x0401CD36 RID: 118070
			[Token(Token = "0x401CD36")]
			[FieldOffset(Offset = "0x0")]
			public StageId stage;

			// Token: 0x0401CD37 RID: 118071
			[Token(Token = "0x401CD37")]
			[FieldOffset(Offset = "0x18")]
			public bool isPractice;

			// Token: 0x0401CD38 RID: 118072
			[Token(Token = "0x401CD38")]
			[FieldOffset(Offset = "0x19")]
			public bool isAutoBattle;

			// Token: 0x0401CD39 RID: 118073
			[Token(Token = "0x401CD39")]
			[FieldOffset(Offset = "0x1A")]
			public bool isRetro;

			// Token: 0x0401CD3A RID: 118074
			[Token(Token = "0x401CD3A")]
			[FieldOffset(Offset = "0x1B")]
			public bool blockPluginLoad;

			// Token: 0x0401CD3B RID: 118075
			[Token(Token = "0x401CD3B")]
			[FieldOffset(Offset = "0x1C")]
			public StageDiffGroup diffGroup;

			// Token: 0x0401CD3C RID: 118076
			[Token(Token = "0x401CD3C")]
			[FieldOffset(Offset = "0x20")]
			public int diffGroupPry;

			// Token: 0x0401CD3D RID: 118077
			[Token(Token = "0x401CD3D")]
			[FieldOffset(Offset = "0x28")]
			public string overrideDropId;

			// Token: 0x0401CD3E RID: 118078
			[Token(Token = "0x401CD3E")]
			[FieldOffset(Offset = "0x30")]
			public bool isMultipleBattle;

			// Token: 0x0401CD3F RID: 118079
			[Token(Token = "0x401CD3F")]
			[FieldOffset(Offset = "0x34")]
			public int multipleBattleTimes;

			// Token: 0x0401CD40 RID: 118080
			[Token(Token = "0x401CD40")]
			[FieldOffset(Offset = "0x38")]
			public BattleStageInfo battleStageInfo;

			// Token: 0x0401CD41 RID: 118081
			[Token(Token = "0x401CD41")]
			[FieldOffset(Offset = "0xA8")]
			public BattleActivityMeta actMeta;

			// Token: 0x0401CD42 RID: 118082
			[Token(Token = "0x401CD42")]
			[FieldOffset(Offset = "0xC8")]
			public BattleStageMeta stageMeta;

			// Token: 0x0401CD43 RID: 118083
			[Token(Token = "0x401CD43")]
			[FieldOffset(Offset = "0xD0")]
			public DataBundle battleBundleToJumpBack;

			// Token: 0x0401CD44 RID: 118084
			[Token(Token = "0x401CD44")]
			[FieldOffset(Offset = "0xD8")]
			public List<string> optionalRuneKeys;

			// Token: 0x0401CD45 RID: 118085
			[Token(Token = "0x401CD45")]
			[FieldOffset(Offset = "0xE0")]
			public List<string> sixStarRuneIds;
		}
	}
}
