using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B6F RID: 23407
	[Token(Token = "0x2005B6F")]
	public class ShopSocialView : MonoBehaviour
	{
		// Token: 0x06021FBE RID: 139198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBE")]
		[Address(RVA = "0x1C77DF0", Offset = "0x1C769F0", VA = "0x181C77DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021FBF RID: 139199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBF")]
		[Address(RVA = "0x1C77960", Offset = "0x1C76560", VA = "0x181C77960")]
		public void RenderView(List<ShopCreditViewModel> itemObjList, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021FC0 RID: 139200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FC0")]
		[Address(RVA = "0x1C77EE0", Offset = "0x1C76AE0", VA = "0x181C77EE0")]
		private void _RenderCountDownValue()
		{
		}

		// Token: 0x06021FC1 RID: 139201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FC1")]
		[Address(RVA = "0x1C77DD0", Offset = "0x1C769D0", VA = "0x181C77DD0")]
		private void Update()
		{
		}

		// Token: 0x06021FC2 RID: 139202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FC2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopSocialView()
		{
		}

		// Token: 0x0402E93F RID: 190783
		[Token(Token = "0x402E93F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopSocialItemObject _itemObj;

		// Token: 0x0402E940 RID: 190784
		[Token(Token = "0x402E940")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemContainer;

		// Token: 0x0402E941 RID: 190785
		[Token(Token = "0x402E941")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _backTime;

		// Token: 0x0402E942 RID: 190786
		[Token(Token = "0x402E942")]
		[FieldOffset(Offset = "0x30")]
		private CountDownTask m_countDownTask;

		// Token: 0x0402E943 RID: 190787
		[Token(Token = "0x402E943")]
		[FieldOffset(Offset = "0x38")]
		private DateTime m_timeLimit;

		// Token: 0x0402E944 RID: 190788
		[Token(Token = "0x402E944")]
		[FieldOffset(Offset = "0x40")]
		private List<ShopCreditViewModel> m_itemObjList;

		// Token: 0x0402E945 RID: 190789
		[Token(Token = "0x402E945")]
		[FieldOffset(Offset = "0x48")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E946 RID: 190790
		[Token(Token = "0x402E946")]
		[FieldOffset(Offset = "0x50")]
		private ShopSocialView.Adapter m_adapter;

		// Token: 0x0402E947 RID: 190791
		[Token(Token = "0x402E947")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x02005B70 RID: 23408
		[Token(Token = "0x2005B70")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06021FC4 RID: 139204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021FC4")]
			[Address(RVA = "0x1C6E800", Offset = "0x1C6D400", VA = "0x181C6E800")]
			public Adapter(ShopSocialView closure)
			{
			}

			// Token: 0x17004F9C RID: 20380
			// (get) Token: 0x06021FC5 RID: 139205 RVA: 0x000BC1D8 File Offset: 0x000BA3D8
			[Token(Token = "0x17004F9C")]
			public override int count
			{
				[Token(Token = "0x6021FC5")]
				[Address(RVA = "0x1C6E880", Offset = "0x1C6D480", VA = "0x181C6E880", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021FC6 RID: 139206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021FC6")]
			[Address(RVA = "0x1C6E620", Offset = "0x1C6D220", VA = "0x181C6E620", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E948 RID: 190792
			[Token(Token = "0x402E948")]
			[FieldOffset(Offset = "0x20")]
			private ShopSocialView m_closure;

			// Token: 0x0402E949 RID: 190793
			[Token(Token = "0x402E949")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E94A RID: 190794
			[Token(Token = "0x402E94A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E94B RID: 190795
			[Token(Token = "0x402E94B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
