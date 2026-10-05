using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A6B RID: 23147
	[Token(Token = "0x2005A6B")]
	public class SkinShopBlindboxSkinListRowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021AE3 RID: 137955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE3")]
		[Address(RVA = "0x1C29A70", Offset = "0x1C28670", VA = "0x181C29A70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021AE4 RID: 137956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE4")]
		[Address(RVA = "0x1C29930", Offset = "0x1C28530", VA = "0x181C29930")]
		public void Render(SkinShopBlindboxSkinListInfoDialog.VirtualView data)
		{
		}

		// Token: 0x06021AE5 RID: 137957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE5")]
		[Address(RVA = "0x1C29C40", Offset = "0x1C28840", VA = "0x181C29C40")]
		public SkinShopBlindboxSkinListRowView()
		{
		}

		// Token: 0x0402E0D1 RID: 188625
		[Token(Token = "0x402E0D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _skinLayout;

		// Token: 0x0402E0D2 RID: 188626
		[Token(Token = "0x402E0D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlDescription;

		// Token: 0x0402E0D3 RID: 188627
		[Token(Token = "0x402E0D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _notAchievedDescriptionText;

		// Token: 0x0402E0D4 RID: 188628
		[Token(Token = "0x402E0D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _achievedDescriptionText;

		// Token: 0x0402E0D5 RID: 188629
		[Token(Token = "0x402E0D5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _notAchievedRowBkgImg;

		// Token: 0x0402E0D6 RID: 188630
		[Token(Token = "0x402E0D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _achievedRowBkgImg;

		// Token: 0x0402E0D7 RID: 188631
		[Token(Token = "0x402E0D7")]
		[FieldOffset(Offset = "0x48")]
		private SkinShopBlindboxSkinListInfoDialog.VirtualView m_cachedData;

		// Token: 0x0402E0D8 RID: 188632
		[Token(Token = "0x402E0D8")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402E0D9 RID: 188633
		[Token(Token = "0x402E0D9")]
		[FieldOffset(Offset = "0x58")]
		private SkinShopBlindboxSkinListRowView.RowAdapter m_rowAdapter;

		// Token: 0x0402E0DA RID: 188634
		[Token(Token = "0x402E0DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E0DB RID: 188635
		[Token(Token = "0x402E0DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E0DC RID: 188636
		[Token(Token = "0x402E0DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A6C RID: 23148
		[Token(Token = "0x2005A6C")]
		private class RowAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06021AE6 RID: 137958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AE6")]
			[Address(RVA = "0x1C1B400", Offset = "0x1C1A000", VA = "0x181C1B400")]
			public RowAdapter(SkinShopBlindboxSkinListRowView closure)
			{
			}

			// Token: 0x17004F03 RID: 20227
			// (get) Token: 0x06021AE7 RID: 137959 RVA: 0x000BB128 File Offset: 0x000B9328
			[Token(Token = "0x17004F03")]
			public override int count
			{
				[Token(Token = "0x6021AE7")]
				[Address(RVA = "0x1C1B480", Offset = "0x1C1A080", VA = "0x181C1B480", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021AE8 RID: 137960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021AE8")]
			[Address(RVA = "0x1C1B230", Offset = "0x1C19E30", VA = "0x181C1B230", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E0DD RID: 188637
			[Token(Token = "0x402E0DD")]
			[FieldOffset(Offset = "0x20")]
			private SkinShopBlindboxSkinListRowView m_closure;

			// Token: 0x0402E0DE RID: 188638
			[Token(Token = "0x402E0DE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E0DF RID: 188639
			[Token(Token = "0x402E0DF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E0E0 RID: 188640
			[Token(Token = "0x402E0E0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
