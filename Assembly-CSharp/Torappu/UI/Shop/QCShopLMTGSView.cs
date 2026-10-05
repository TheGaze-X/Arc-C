using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B0F RID: 23311
	[Token(Token = "0x2005B0F")]
	public class QCShopLMTGSView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DD0 RID: 138704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DD0")]
		[Address(RVA = "0x1C5B510", Offset = "0x1C5A110", VA = "0x181C5B510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021DD1 RID: 138705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DD1")]
		[Address(RVA = "0x1C5AB20", Offset = "0x1C59720", VA = "0x181C5AB20")]
		public void OnEnter(ShopPage page)
		{
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DD2")]
		[Address(RVA = "0x1C5B620", Offset = "0x1C5A220", VA = "0x181C5B620")]
		public QCShopLMTGSView()
		{
		}

		// Token: 0x0402E641 RID: 190017
		[Token(Token = "0x402E641")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402E642 RID: 190018
		[Token(Token = "0x402E642")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0402E643 RID: 190019
		[Token(Token = "0x402E643")]
		[FieldOffset(Offset = "0x28")]
		private QCShopLMTGSView.Adapter m_adapter;

		// Token: 0x0402E644 RID: 190020
		[Token(Token = "0x402E644")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0402E645 RID: 190021
		[Token(Token = "0x402E645")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E646 RID: 190022
		[Token(Token = "0x402E646")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E647 RID: 190023
		[Token(Token = "0x402E647")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B10 RID: 23312
		[Token(Token = "0x2005B10")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004F3B RID: 20283
			// (get) Token: 0x06021DD4 RID: 138708 RVA: 0x000BB758 File Offset: 0x000B9958
			[Token(Token = "0x17004F3B")]
			public override int count
			{
				[Token(Token = "0x6021DD4")]
				[Address(RVA = "0x1C58420", Offset = "0x1C57020", VA = "0x181C58420", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021DD5 RID: 138709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021DD5")]
			[Address(RVA = "0x1C57F10", Offset = "0x1C56B10", VA = "0x181C57F10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021DD6 RID: 138710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021DD6")]
			[Address(RVA = "0x1C57D80", Offset = "0x1C56980", VA = "0x181C57D80")]
			public void CheckNeedToOpen()
			{
			}

			// Token: 0x06021DD7 RID: 138711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021DD7")]
			[Address(RVA = "0x1C58330", Offset = "0x1C56F30", VA = "0x181C58330")]
			public Adapter()
			{
			}

			// Token: 0x0402E648 RID: 190024
			[Token(Token = "0x402E648")]
			[FieldOffset(Offset = "0x20")]
			public List<LMTGSViewModel> viewModelList;

			// Token: 0x0402E649 RID: 190025
			[Token(Token = "0x402E649")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E64A RID: 190026
			[Token(Token = "0x402E64A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402E64B RID: 190027
			[Token(Token = "0x402E64B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckNeedToOpen;

			// Token: 0x0402E64C RID: 190028
			[Token(Token = "0x402E64C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
