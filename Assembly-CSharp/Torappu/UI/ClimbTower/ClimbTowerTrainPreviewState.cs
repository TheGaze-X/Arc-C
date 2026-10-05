using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D34 RID: 23860
	[Token(Token = "0x2005D34")]
	public class ClimbTowerTrainPreviewState : PopupFloatState, IHotfixable
	{
		// Token: 0x060228CE RID: 141518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228CE")]
		[Address(RVA = "0x1D2BEE0", Offset = "0x1D2AAE0", VA = "0x181D2BEE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228CF RID: 141519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228CF")]
		[Address(RVA = "0x1D2BDC0", Offset = "0x1D2A9C0", VA = "0x181D2BDC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228D0 RID: 141520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228D0")]
		[Address(RVA = "0x1D2BFC0", Offset = "0x1D2ABC0", VA = "0x181D2BFC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060228D1 RID: 141521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D1")]
		[Address(RVA = "0x1D2C3D0", Offset = "0x1D2AFD0", VA = "0x181D2C3D0")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x060228D2 RID: 141522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D2")]
		[Address(RVA = "0x1D2C6C0", Offset = "0x1D2B2C0", VA = "0x181D2C6C0")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x060228D3 RID: 141523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D3")]
		[Address(RVA = "0x1D2BE20", Offset = "0x1D2AA20", VA = "0x181D2BE20")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x060228D4 RID: 141524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D4")]
		[Address(RVA = "0x1D2C190", Offset = "0x1D2AD90", VA = "0x181D2C190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228D5 RID: 141525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D5")]
		[Address(RVA = "0x1D2C580", Offset = "0x1D2B180", VA = "0x181D2C580")]
		private void _OnJumpToEnemyHandbook(List<EnemyHandBookEverViewModel> enemyList, int enemyListIdx)
		{
		}

		// Token: 0x060228D6 RID: 141526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D6")]
		[Address(RVA = "0x1D2C7F0", Offset = "0x1D2B3F0", VA = "0x181D2C7F0")]
		private void _OnJumpToRewardDetailView()
		{
		}

		// Token: 0x060228D7 RID: 141527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D7")]
		[Address(RVA = "0x1D2C8C0", Offset = "0x1D2B4C0", VA = "0x181D2C8C0")]
		public ClimbTowerTrainPreviewState()
		{
		}

		// Token: 0x060228D8 RID: 141528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228D8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060228D9 RID: 141529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228D9")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F7E3 RID: 194531
		[Token(Token = "0x402F7E3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _previewContainer;

		// Token: 0x0402F7E4 RID: 194532
		[Token(Token = "0x402F7E4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerPanelPreviewLevel _prefabPreview;

		// Token: 0x0402F7E5 RID: 194533
		[Token(Token = "0x402F7E5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F7E6 RID: 194534
		[Token(Token = "0x402F7E6")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerTrainPreviewStateBean m_stateBean;

		// Token: 0x0402F7E7 RID: 194535
		[Token(Token = "0x402F7E7")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerPanelPreviewLevel m_previewPanel;

		// Token: 0x0402F7E8 RID: 194536
		[Token(Token = "0x402F7E8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402F7E9 RID: 194537
		[Token(Token = "0x402F7E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F7EA RID: 194538
		[Token(Token = "0x402F7EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F7EB RID: 194539
		[Token(Token = "0x402F7EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F7EC RID: 194540
		[Token(Token = "0x402F7EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0402F7ED RID: 194541
		[Token(Token = "0x402F7ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0402F7EE RID: 194542
		[Token(Token = "0x402F7EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x0402F7EF RID: 194543
		[Token(Token = "0x402F7EF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F7F0 RID: 194544
		[Token(Token = "0x402F7F0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandbook;

		// Token: 0x0402F7F1 RID: 194545
		[Token(Token = "0x402F7F1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1__OnJumpToRewardDetailView;

		// Token: 0x0402F7F2 RID: 194546
		[Token(Token = "0x402F7F2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
