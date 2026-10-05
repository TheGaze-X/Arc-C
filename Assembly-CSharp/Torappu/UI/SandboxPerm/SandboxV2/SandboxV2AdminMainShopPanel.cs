using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E1 RID: 16609
	[Token(Token = "0x20040E1")]
	public class SandboxV2AdminMainShopPanel : SandboxV2AdminMainTabPanel, IHotfixable
	{
		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x06019B0A RID: 105226 RVA: 0x0009F120 File Offset: 0x0009D320
		[Token(Token = "0x17003D49")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x6019B0A")]
			[Address(RVA = "0x12852B0", Offset = "0x1283EB0", VA = "0x1812852B0", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x06019B0B RID: 105227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D4A")]
		public override string topTitle
		{
			[Token(Token = "0x6019B0B")]
			[Address(RVA = "0x1285310", Offset = "0x1283F10", VA = "0x181285310", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019B0C RID: 105228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B0C")]
		[Address(RVA = "0x1284820", Offset = "0x1283420", VA = "0x181284820", Slot = "11")]
		protected override Func<string, bool> OnGetActiveCheckFunc()
		{
			return null;
		}

		// Token: 0x06019B0D RID: 105229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B0D")]
		[Address(RVA = "0x12848C0", Offset = "0x12834C0", VA = "0x1812848C0", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x06019B0E RID: 105230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B0E")]
		[Address(RVA = "0x1284770", Offset = "0x1283370", VA = "0x181284770", Slot = "12")]
		public override IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetToDataListener()
		{
			return null;
		}

		// Token: 0x06019B0F RID: 105231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B0F")]
		[Address(RVA = "0x12846C0", Offset = "0x12832C0", VA = "0x1812846C0", Slot = "13")]
		public override IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetFromDataListener()
		{
			return null;
		}

		// Token: 0x06019B10 RID: 105232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B10")]
		[Address(RVA = "0x12849B0", Offset = "0x12835B0", VA = "0x1812849B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019B11 RID: 105233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B11")]
		[Address(RVA = "0x1284CD0", Offset = "0x12838D0", VA = "0x181284CD0")]
		private void _OnGoodItemClicked(int index)
		{
		}

		// Token: 0x06019B12 RID: 105234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B12")]
		[Address(RVA = "0x12850E0", Offset = "0x1283CE0", VA = "0x1812850E0")]
		private void _OnJumpToDetailState(IStateBean sb)
		{
		}

		// Token: 0x06019B13 RID: 105235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B13")]
		[Address(RVA = "0x1284F80", Offset = "0x1283B80", VA = "0x181284F80")]
		private void _OnJumpFromDetailState(IStateBean sb)
		{
		}

		// Token: 0x06019B14 RID: 105236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B14")]
		[Address(RVA = "0x1285210", Offset = "0x1283E10", VA = "0x181285210")]
		public SandboxV2AdminMainShopPanel()
		{
		}

		// Token: 0x06019B15 RID: 105237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B15")]
		[Address(RVA = "0x12849A0", Offset = "0x12835A0", VA = "0x1812849A0")]
		private Func<string, bool> <>xLuaBaseProxy_OnGetActiveCheckFunc()
		{
			return null;
		}

		// Token: 0x06019B16 RID: 105238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B16")]
		[Address(RVA = "0x124BEC0", Offset = "0x124AAC0", VA = "0x18124BEC0")]
		private IEnumerable<KeyValuePair<Type, Action<IStateBean>>> <>xLuaBaseProxy_GetToDataListener()
		{
			return null;
		}

		// Token: 0x06019B17 RID: 105239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B17")]
		[Address(RVA = "0x1284990", Offset = "0x1283590", VA = "0x181284990")]
		private IEnumerable<KeyValuePair<Type, Action<IStateBean>>> <>xLuaBaseProxy_GetFromDataListener()
		{
			return null;
		}

		// Token: 0x04020225 RID: 131621
		[Token(Token = "0x4020225")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminMainShopTopBarView _topBarView;

		// Token: 0x04020226 RID: 131622
		[Token(Token = "0x4020226")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2AdminMainShopTraderView _traderView;

		// Token: 0x04020227 RID: 131623
		[Token(Token = "0x4020227")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminMainShopItemGroupView _itemGroupView;

		// Token: 0x04020228 RID: 131624
		[Token(Token = "0x4020228")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminMainShopProperty m_property;

		// Token: 0x04020229 RID: 131625
		[Token(Token = "0x4020229")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedSelectedIndex;

		// Token: 0x0402022A RID: 131626
		[Token(Token = "0x402022A")]
		[FieldOffset(Offset = "0x84")]
		private bool m_hasInited;

		// Token: 0x0402022B RID: 131627
		[Token(Token = "0x402022B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402022C RID: 131628
		[Token(Token = "0x402022C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x0402022D RID: 131629
		[Token(Token = "0x402022D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGetActiveCheckFunc;

		// Token: 0x0402022E RID: 131630
		[Token(Token = "0x402022E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0402022F RID: 131631
		[Token(Token = "0x402022F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetToDataListener;

		// Token: 0x04020230 RID: 131632
		[Token(Token = "0x4020230")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFromDataListener;

		// Token: 0x04020231 RID: 131633
		[Token(Token = "0x4020231")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020232 RID: 131634
		[Token(Token = "0x4020232")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnGoodItemClicked;

		// Token: 0x04020233 RID: 131635
		[Token(Token = "0x4020233")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToDetailState;

		// Token: 0x04020234 RID: 131636
		[Token(Token = "0x4020234")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpFromDetailState;

		// Token: 0x04020235 RID: 131637
		[Token(Token = "0x4020235")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
