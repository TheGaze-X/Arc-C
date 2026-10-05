using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200593D RID: 22845
	[Token(Token = "0x200593D")]
	public class CrisisV2AchievementHistoryState : PopupFadeState, IHotfixable
	{
		// Token: 0x0602146F RID: 136303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602146F")]
		[Address(RVA = "0x1B88110", Offset = "0x1B86D10", VA = "0x181B88110", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021470 RID: 136304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021470")]
		[Address(RVA = "0x1B88170", Offset = "0x1B86D70", VA = "0x181B88170", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021471 RID: 136305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021471")]
		[Address(RVA = "0x1B88250", Offset = "0x1B86E50", VA = "0x181B88250", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06021472 RID: 136306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021472")]
		[Address(RVA = "0x1B88470", Offset = "0x1B87070", VA = "0x181B88470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021473 RID: 136307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021473")]
		[Address(RVA = "0x1B8A3A0", Offset = "0x1B88FA0", VA = "0x181B8A3A0")]
		private void _OnCloseBtnClicked()
		{
		}

		// Token: 0x06021474 RID: 136308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021474")]
		[Address(RVA = "0x1B88E40", Offset = "0x1B87A40", VA = "0x181B88E40")]
		private void _LoadDataAndRender()
		{
		}

		// Token: 0x06021475 RID: 136309 RVA: 0x000B9388 File Offset: 0x000B7588
		[Token(Token = "0x6021475")]
		[Address(RVA = "0x1B8A280", Offset = "0x1B88E80", VA = "0x181B8A280")]
		private bool _LoadSnapshotDiffData(CrisisV2SettleViewModel.Param input, CrisisV2SnapShotBase snapshot)
		{
			return default(bool);
		}

		// Token: 0x06021476 RID: 136310 RVA: 0x000B93A0 File Offset: 0x000B75A0
		[Token(Token = "0x6021476")]
		[Address(RVA = "0x1B892E0", Offset = "0x1B87EE0", VA = "0x181B892E0")]
		private bool _LoadDataFromDetailSnapshot(CrisisV2SettleViewModel.Param input, CrisisV2DetailSnapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x06021477 RID: 136311 RVA: 0x000B93B8 File Offset: 0x000B75B8
		[Token(Token = "0x6021477")]
		[Address(RVA = "0x1B89620", Offset = "0x1B88220", VA = "0x181B89620")]
		private bool _LoadDataFromSimpleSnapshot(CrisisV2SettleViewModel.Param input, CrisisV2SimpleSnapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x06021478 RID: 136312 RVA: 0x000B93D0 File Offset: 0x000B75D0
		[Token(Token = "0x6021478")]
		[Address(RVA = "0x1B89BD0", Offset = "0x1B887D0", VA = "0x181B89BD0")]
		private bool _LoadRuneList(CrisisV2SettleViewModel.Param input, CrisisV2SnapShotBase snapshot, bool isCurrentSeason)
		{
			return default(bool);
		}

		// Token: 0x06021479 RID: 136313 RVA: 0x000B93E8 File Offset: 0x000B75E8
		[Token(Token = "0x6021479")]
		[Address(RVA = "0x1B886F0", Offset = "0x1B872F0", VA = "0x181B886F0")]
		private bool _LoadCommentList(CrisisV2SettleViewModel.Param input, CrisisV2SnapShotBase snapshot, bool isCurrentSeason)
		{
			return default(bool);
		}

		// Token: 0x0602147A RID: 136314 RVA: 0x000B9400 File Offset: 0x000B7600
		[Token(Token = "0x602147A")]
		[Address(RVA = "0x1B8A450", Offset = "0x1B89050", VA = "0x181B8A450")]
		private static CrisisV2SettleViewModel.SquadSkinInfo _PickRandomSkinInfo(List<CrisisV2SettleViewModel.SquadSkinInfo> skinInfoList)
		{
			return default(CrisisV2SettleViewModel.SquadSkinInfo);
		}

		// Token: 0x0602147B RID: 136315 RVA: 0x000B9418 File Offset: 0x000B7618
		[Token(Token = "0x602147B")]
		[Address(RVA = "0x1B88310", Offset = "0x1B86F10", VA = "0x181B88310")]
		private static SquadItemStruct _CreateSquadItemFromSharedChar(SharedCharData charData, bool withPotential)
		{
			return default(SquadItemStruct);
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602147C")]
		[Address(RVA = "0x1B8A750", Offset = "0x1B89350", VA = "0x181B8A750")]
		public CrisisV2AchievementHistoryState()
		{
		}

		// Token: 0x0602147D RID: 136317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602147D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602147E RID: 136318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602147E")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402D5E7 RID: 185831
		[Token(Token = "0x402D5E7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CrisisV2SettleView _settleViewPrefab;

		// Token: 0x0402D5E8 RID: 185832
		[Token(Token = "0x402D5E8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402D5E9 RID: 185833
		[Token(Token = "0x402D5E9")]
		[FieldOffset(Offset = "0x80")]
		private CrisisV2AchievementHistoryStateBean m_stateBean;

		// Token: 0x0402D5EA RID: 185834
		[Token(Token = "0x402D5EA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402D5EB RID: 185835
		[Token(Token = "0x402D5EB")]
		[FieldOffset(Offset = "0x90")]
		private CrisisV2SettleView m_settleView;

		// Token: 0x0402D5EC RID: 185836
		[Token(Token = "0x402D5EC")]
		[FieldOffset(Offset = "0x98")]
		private CrisisV2CacheServerData m_crisisV2ServerData;

		// Token: 0x0402D5ED RID: 185837
		[Token(Token = "0x402D5ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D5EE RID: 185838
		[Token(Token = "0x402D5EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D5EF RID: 185839
		[Token(Token = "0x402D5EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402D5F0 RID: 185840
		[Token(Token = "0x402D5F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D5F1 RID: 185841
		[Token(Token = "0x402D5F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCloseBtnClicked;

		// Token: 0x0402D5F2 RID: 185842
		[Token(Token = "0x402D5F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadDataAndRender;

		// Token: 0x0402D5F3 RID: 185843
		[Token(Token = "0x402D5F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadSnapshotDiffData;

		// Token: 0x0402D5F4 RID: 185844
		[Token(Token = "0x402D5F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadDataFromDetailSnapshot;

		// Token: 0x0402D5F5 RID: 185845
		[Token(Token = "0x402D5F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadDataFromSimpleSnapshot;

		// Token: 0x0402D5F6 RID: 185846
		[Token(Token = "0x402D5F6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadRuneList;

		// Token: 0x0402D5F7 RID: 185847
		[Token(Token = "0x402D5F7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadCommentList;

		// Token: 0x0402D5F8 RID: 185848
		[Token(Token = "0x402D5F8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PickRandomSkinInfo;

		// Token: 0x0402D5F9 RID: 185849
		[Token(Token = "0x402D5F9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateSquadItemFromSharedChar;

		// Token: 0x0402D5FA RID: 185850
		[Token(Token = "0x402D5FA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
