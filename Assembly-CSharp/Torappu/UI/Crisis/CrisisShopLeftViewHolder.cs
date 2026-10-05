using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A0F RID: 23055
	[Token(Token = "0x2005A0F")]
	public class CrisisShopLeftViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602196D RID: 137581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196D")]
		[Address(RVA = "0x1C09BF0", Offset = "0x1C087F0", VA = "0x181C09BF0")]
		private void _InitedIfNot()
		{
		}

		// Token: 0x0602196E RID: 137582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196E")]
		[Address(RVA = "0x1C09A80", Offset = "0x1C08680", VA = "0x181C09A80")]
		public void Render(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x0602196F RID: 137583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602196F")]
		[Address(RVA = "0x1C09360", Offset = "0x1C07F60", VA = "0x181C09360")]
		public void RenderNormalObj(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021970 RID: 137584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021970")]
		[Address(RVA = "0x1C09150", Offset = "0x1C07D50", VA = "0x181C09150")]
		public void RenderCommonObj(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021971 RID: 137585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021971")]
		[Address(RVA = "0x1C09070", Offset = "0x1C07C70", VA = "0x181C09070")]
		public void RenderCharAndSkin(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021972 RID: 137586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021972")]
		[Address(RVA = "0x1C09280", Offset = "0x1C07E80", VA = "0x181C09280")]
		public void RenderFurn(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021973 RID: 137587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021973")]
		[Address(RVA = "0x1C09840", Offset = "0x1C08440", VA = "0x181C09840")]
		public void RenderProgressObj(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021974 RID: 137588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021974")]
		[Address(RVA = "0x1C09CC0", Offset = "0x1C088C0", VA = "0x181C09CC0")]
		public CrisisShopLeftViewHolder()
		{
		}

		// Token: 0x0402DE85 RID: 188037
		[Token(Token = "0x402DE85")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402DE86 RID: 188038
		[Token(Token = "0x402DE86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402DE87 RID: 188039
		[Token(Token = "0x402DE87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _usage;

		// Token: 0x0402DE88 RID: 188040
		[Token(Token = "0x402DE88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrisisShopLeftCharView _charView;

		// Token: 0x0402DE89 RID: 188041
		[Token(Token = "0x402DE89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrisisShopLeftProgressView _progressView;

		// Token: 0x0402DE8A RID: 188042
		[Token(Token = "0x402DE8A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalView;

		// Token: 0x0402DE8B RID: 188043
		[Token(Token = "0x402DE8B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CrisisShopLeftFurnView _furnView;

		// Token: 0x0402DE8C RID: 188044
		[Token(Token = "0x402DE8C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0402DE8D RID: 188045
		[Token(Token = "0x402DE8D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _pileViewContainer;

		// Token: 0x0402DE8E RID: 188046
		[Token(Token = "0x402DE8E")]
		[FieldOffset(Offset = "0x60")]
		private ShopDetailItemPileView m_pileView;

		// Token: 0x0402DE8F RID: 188047
		[Token(Token = "0x402DE8F")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0402DE90 RID: 188048
		[Token(Token = "0x402DE90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitedIfNot;

		// Token: 0x0402DE91 RID: 188049
		[Token(Token = "0x402DE91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DE92 RID: 188050
		[Token(Token = "0x402DE92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderNormalObj;

		// Token: 0x0402DE93 RID: 188051
		[Token(Token = "0x402DE93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCommonObj;

		// Token: 0x0402DE94 RID: 188052
		[Token(Token = "0x402DE94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCharAndSkin;

		// Token: 0x0402DE95 RID: 188053
		[Token(Token = "0x402DE95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderFurn;

		// Token: 0x0402DE96 RID: 188054
		[Token(Token = "0x402DE96")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderProgressObj;

		// Token: 0x0402DE97 RID: 188055
		[Token(Token = "0x402DE97")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
