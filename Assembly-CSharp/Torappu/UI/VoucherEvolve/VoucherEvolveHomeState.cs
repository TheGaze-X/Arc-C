using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoucherEvolve
{
	// Token: 0x02003B98 RID: 15256
	[Token(Token = "0x2003B98")]
	public class VoucherEvolveHomeState : State
	{
		// Token: 0x06017E61 RID: 97889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E61")]
		[Address(RVA = "0x1022FB0", Offset = "0x1021BB0", VA = "0x181022FB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017E62 RID: 97890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E62")]
		[Address(RVA = "0x1023230", Offset = "0x1021E30", VA = "0x181023230", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017E63 RID: 97891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E63")]
		[Address(RVA = "0x10230A0", Offset = "0x1021CA0", VA = "0x1810230A0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06017E64 RID: 97892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E64")]
		[Address(RVA = "0x1023100", Offset = "0x1021D00", VA = "0x181023100")]
		public void OnDetailClick()
		{
		}

		// Token: 0x06017E65 RID: 97893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E65")]
		[Address(RVA = "0x1023430", Offset = "0x1022030", VA = "0x181023430")]
		public void OnUpgradeConfirmClick()
		{
		}

		// Token: 0x06017E66 RID: 97894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E66")]
		[Address(RVA = "0x1023010", Offset = "0x1021C10", VA = "0x181023010")]
		public void OnCancelClick()
		{
		}

		// Token: 0x06017E67 RID: 97895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E67")]
		[Address(RVA = "0x1023910", Offset = "0x1022510", VA = "0x181023910")]
		private void _ClearIllusts()
		{
		}

		// Token: 0x06017E68 RID: 97896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E68")]
		[Address(RVA = "0x1023A50", Offset = "0x1022650", VA = "0x181023A50")]
		private void _LoadAndSetIllusts()
		{
		}

		// Token: 0x06017E69 RID: 97897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E69")]
		[Address(RVA = "0x10243E0", Offset = "0x1022FE0", VA = "0x1810243E0")]
		private void _RefreshViews()
		{
		}

		// Token: 0x06017E6A RID: 97898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E6A")]
		[Address(RVA = "0x1023FF0", Offset = "0x1022BF0", VA = "0x181023FF0")]
		private void _RefreshItemCardView()
		{
		}

		// Token: 0x06017E6B RID: 97899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E6B")]
		[Address(RVA = "0x1023E10", Offset = "0x1022A10", VA = "0x181023E10")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x06017E6C RID: 97900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E6C")]
		[Address(RVA = "0x1023F10", Offset = "0x1022B10", VA = "0x181023F10")]
		private void _OpenItemRepoPage()
		{
		}

		// Token: 0x06017E6D RID: 97901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E6D")]
		[Address(RVA = "0x10245A0", Offset = "0x10231A0", VA = "0x1810245A0")]
		public VoucherEvolveHomeState()
		{
		}

		// Token: 0x06017E6F RID: 97903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E6F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401CE6C RID: 118380
		[Token(Token = "0x401CE6C")]
		private const int REQUIRE_ITEM_COUNT = 1;

		// Token: 0x0401CE6D RID: 118381
		[Token(Token = "0x401CE6D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VoucherEvolveStateBean _stateBean;

		// Token: 0x0401CE6E RID: 118382
		[Token(Token = "0x401CE6E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _panelIllustOld;

		// Token: 0x0401CE6F RID: 118383
		[Token(Token = "0x401CE6F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _panelIllustNew;

		// Token: 0x0401CE70 RID: 118384
		[Token(Token = "0x401CE70")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Range(0.1f, 2f)]
		private float _illustScaleFactor;

		// Token: 0x0401CE71 RID: 118385
		[Token(Token = "0x401CE71")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _illustNewColor;

		// Token: 0x0401CE72 RID: 118386
		[Token(Token = "0x401CE72")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0401CE73 RID: 118387
		[Token(Token = "0x401CE73")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _realNameText;

		// Token: 0x0401CE74 RID: 118388
		[Token(Token = "0x401CE74")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _nickNameText;

		// Token: 0x0401CE75 RID: 118389
		[Token(Token = "0x401CE75")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _evolvePhaseText;

		// Token: 0x0401CE76 RID: 118390
		[Token(Token = "0x401CE76")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _evolvePhaseImg;

		// Token: 0x0401CE77 RID: 118391
		[Token(Token = "0x401CE77")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0401CE78 RID: 118392
		[Token(Token = "0x401CE78")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Tooltip("The scale to show an item card")]
		private float _itemCardScale;

		// Token: 0x0401CE79 RID: 118393
		[Token(Token = "0x401CE79")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _itemCountText;

		// Token: 0x0401CE7A RID: 118394
		[Token(Token = "0x401CE7A")]
		[FieldOffset(Offset = "0xC0")]
		private UICharacterIllust m_illustOld;

		// Token: 0x0401CE7B RID: 118395
		[Token(Token = "0x401CE7B")]
		[FieldOffset(Offset = "0xC8")]
		private UICharacterIllust m_illustNew;

		// Token: 0x0401CE7C RID: 118396
		[Token(Token = "0x401CE7C")]
		[FieldOffset(Offset = "0xD0")]
		private UIItemCard m_itemCard;

		// Token: 0x0401CE7D RID: 118397
		[Token(Token = "0x401CE7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401CE7E RID: 118398
		[Token(Token = "0x401CE7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401CE7F RID: 118399
		[Token(Token = "0x401CE7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401CE80 RID: 118400
		[Token(Token = "0x401CE80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x0401CE81 RID: 118401
		[Token(Token = "0x401CE81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpgradeConfirmClick;

		// Token: 0x0401CE82 RID: 118402
		[Token(Token = "0x401CE82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0401CE83 RID: 118403
		[Token(Token = "0x401CE83")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearIllusts;

		// Token: 0x0401CE84 RID: 118404
		[Token(Token = "0x401CE84")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadAndSetIllusts;

		// Token: 0x0401CE85 RID: 118405
		[Token(Token = "0x401CE85")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshViews;

		// Token: 0x0401CE86 RID: 118406
		[Token(Token = "0x401CE86")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshItemCardView;

		// Token: 0x0401CE87 RID: 118407
		[Token(Token = "0x401CE87")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0401CE88 RID: 118408
		[Token(Token = "0x401CE88")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenItemRepoPage;

		// Token: 0x0401CE89 RID: 118409
		[Token(Token = "0x401CE89")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
