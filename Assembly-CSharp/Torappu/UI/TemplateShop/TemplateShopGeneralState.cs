using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D3F RID: 15679
	[Token(Token = "0x2003D3F")]
	public class TemplateShopGeneralState : PopupFloatState
	{
		// Token: 0x060186CE RID: 100046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186CE")]
		[Address(RVA = "0x10F2710", Offset = "0x10F1310", VA = "0x1810F2710", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186CF RID: 100047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186CF")]
		[Address(RVA = "0x10F2930", Offset = "0x10F1530", VA = "0x1810F2930", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186D0 RID: 100048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D0")]
		[Address(RVA = "0x10F2860", Offset = "0x10F1460", VA = "0x1810F2860")]
		public void OnClick()
		{
		}

		// Token: 0x060186D1 RID: 100049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D1")]
		[Address(RVA = "0x10F2770", Offset = "0x10F1370", VA = "0x1810F2770")]
		public void OnClickComplex()
		{
		}

		// Token: 0x060186D2 RID: 100050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D2")]
		[Address(RVA = "0x10F2BB0", Offset = "0x10F17B0", VA = "0x1810F2BB0")]
		public void RefreshReplicate()
		{
		}

		// Token: 0x060186D3 RID: 100051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D3")]
		[Address(RVA = "0x10F2EC0", Offset = "0x10F1AC0", VA = "0x1810F2EC0")]
		public TemplateShopGeneralState()
		{
		}

		// Token: 0x060186D7 RID: 100055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE1D RID: 122397
		[Token(Token = "0x401DE1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0401DE1E RID: 122398
		[Token(Token = "0x401DE1E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateShopCommonLeftViewHolder _leftPart;

		// Token: 0x0401DE1F RID: 122399
		[Token(Token = "0x401DE1F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TemplateShopCommonRightViewHolder _rightParts;

		// Token: 0x0401DE20 RID: 122400
		[Token(Token = "0x401DE20")]
		[FieldOffset(Offset = "0x88")]
		private TemplateShopNormalDetailStateBean m_stateBean;

		// Token: 0x0401DE21 RID: 122401
		[Token(Token = "0x401DE21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE22 RID: 122402
		[Token(Token = "0x401DE22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE23 RID: 122403
		[Token(Token = "0x401DE23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401DE24 RID: 122404
		[Token(Token = "0x401DE24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickComplex;

		// Token: 0x0401DE25 RID: 122405
		[Token(Token = "0x401DE25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshReplicate;

		// Token: 0x0401DE26 RID: 122406
		[Token(Token = "0x401DE26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
