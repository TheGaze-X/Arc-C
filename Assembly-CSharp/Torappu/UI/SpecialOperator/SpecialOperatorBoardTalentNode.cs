using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E4F RID: 15951
	[Token(Token = "0x2003E4F")]
	public class SpecialOperatorBoardTalentNode : SpecialOperatorBoardNodeBase
	{
		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x06018CD0 RID: 101584 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		[Token(Token = "0x17003B2C")]
		public override bool isUnlocked
		{
			[Token(Token = "0x6018CD0")]
			[Address(RVA = "0x1177530", Offset = "0x1176130", VA = "0x181177530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x06018CD1 RID: 101585 RVA: 0x0009BEF8 File Offset: 0x0009A0F8
		// (set) Token: 0x06018CD2 RID: 101586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B2D")]
		public override bool unlockTaskMeet
		{
			[Token(Token = "0x6018CD1")]
			[Address(RVA = "0x1177600", Offset = "0x1176200", VA = "0x181177600", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018CD2")]
			[Address(RVA = "0x11776D0", Offset = "0x11762D0", VA = "0x1811776D0", Slot = "8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x06018CD3 RID: 101587 RVA: 0x0009BF10 File Offset: 0x0009A110
		// (set) Token: 0x06018CD4 RID: 101588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B2E")]
		public override bool evolveLevelMeet
		{
			[Token(Token = "0x6018CD3")]
			[Address(RVA = "0x11774D0", Offset = "0x11760D0", VA = "0x1811774D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018CD4")]
			[Address(RVA = "0x1177660", Offset = "0x1176260", VA = "0x181177660", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x06018CD5 RID: 101589 RVA: 0x0009BF28 File Offset: 0x0009A128
		[Token(Token = "0x17003B2F")]
		public override SpecialOperatorSelectAnchorType selectAnchorType
		{
			[Token(Token = "0x6018CD5")]
			[Address(RVA = "0x1177590", Offset = "0x1176190", VA = "0x181177590", Slot = "11")]
			get
			{
				return SpecialOperatorSelectAnchorType.OFFSET;
			}
		}

		// Token: 0x06018CD6 RID: 101590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CD6")]
		[Address(RVA = "0x1177110", Offset = "0x1175D10", VA = "0x181177110", Slot = "10")]
		public override void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018CD7 RID: 101591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CD7")]
		[Address(RVA = "0x1176ED0", Offset = "0x1175AD0", VA = "0x181176ED0", Slot = "9")]
		protected override void OnInitData()
		{
		}

		// Token: 0x06018CD8 RID: 101592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CD8")]
		[Address(RVA = "0x1177430", Offset = "0x1176030", VA = "0x181177430")]
		public SpecialOperatorBoardTalentNode()
		{
		}

		// Token: 0x06018CD9 RID: 101593 RVA: 0x0009BF40 File Offset: 0x0009A140
		[Token(Token = "0x6018CD9")]
		[Address(RVA = "0x116F450", Offset = "0x116E050", VA = "0x18116F450")]
		private SpecialOperatorSelectAnchorType <>xLuaBaseProxy_get_selectAnchorType()
		{
			return SpecialOperatorSelectAnchorType.OFFSET;
		}

		// Token: 0x0401E7B3 RID: 124851
		[Token(Token = "0x401E7B3")]
		[FieldOffset(Offset = "0x40")]
		public int talentIndex;

		// Token: 0x0401E7B4 RID: 124852
		[Token(Token = "0x401E7B4")]
		[FieldOffset(Offset = "0x44")]
		public int level;

		// Token: 0x0401E7B5 RID: 124853
		[Token(Token = "0x401E7B5")]
		[FieldOffset(Offset = "0x48")]
		public EvolvePhase evolvePhase;

		// Token: 0x0401E7B6 RID: 124854
		[Token(Token = "0x401E7B6")]
		[FieldOffset(Offset = "0x4C")]
		public SpecialOperatorNodeStyleType nodeStyleType;

		// Token: 0x0401E7B7 RID: 124855
		[Token(Token = "0x401E7B7")]
		[FieldOffset(Offset = "0x50")]
		public string upgradeNoticeStr;

		// Token: 0x0401E7B8 RID: 124856
		[Token(Token = "0x401E7B8")]
		[FieldOffset(Offset = "0x58")]
		public string talentName;

		// Token: 0x0401E7B9 RID: 124857
		[Token(Token = "0x401E7B9")]
		[FieldOffset(Offset = "0x60")]
		public string description;

		// Token: 0x0401E7BA RID: 124858
		[Token(Token = "0x401E7BA")]
		[FieldOffset(Offset = "0x68")]
		public PlayerSpecialOperatorNode.State nodeState;

		// Token: 0x0401E7BB RID: 124859
		[Token(Token = "0x401E7BB")]
		[FieldOffset(Offset = "0x70")]
		public string conditionDesc;

		// Token: 0x0401E7BE RID: 124862
		[Token(Token = "0x401E7BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlocked;

		// Token: 0x0401E7BF RID: 124863
		[Token(Token = "0x401E7BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unlockTaskMeet;

		// Token: 0x0401E7C0 RID: 124864
		[Token(Token = "0x401E7C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_unlockTaskMeet;

		// Token: 0x0401E7C1 RID: 124865
		[Token(Token = "0x401E7C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_evolveLevelMeet;

		// Token: 0x0401E7C2 RID: 124866
		[Token(Token = "0x401E7C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_evolveLevelMeet;

		// Token: 0x0401E7C3 RID: 124867
		[Token(Token = "0x401E7C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectAnchorType;

		// Token: 0x0401E7C4 RID: 124868
		[Token(Token = "0x401E7C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E7C5 RID: 124869
		[Token(Token = "0x401E7C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInitData;

		// Token: 0x0401E7C6 RID: 124870
		[Token(Token = "0x401E7C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
