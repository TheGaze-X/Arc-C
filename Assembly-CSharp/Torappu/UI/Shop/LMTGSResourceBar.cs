using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF0 RID: 23280
	[Token(Token = "0x2005AF0")]
	public class LMTGSResourceBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D51 RID: 138577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D51")]
		[Address(RVA = "0x1C43F10", Offset = "0x1C42B10", VA = "0x181C43F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021D52 RID: 138578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D52")]
		[Address(RVA = "0x1C43E80", Offset = "0x1C42A80", VA = "0x181C43E80")]
		public void UpdateValue()
		{
		}

		// Token: 0x06021D53 RID: 138579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D53")]
		[Address(RVA = "0x1C43BC0", Offset = "0x1C427C0", VA = "0x181C43BC0")]
		public void RenderEmpty()
		{
		}

		// Token: 0x06021D54 RID: 138580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D54")]
		[Address(RVA = "0x1C439B0", Offset = "0x1C425B0", VA = "0x181C439B0")]
		public void RenderAll()
		{
		}

		// Token: 0x06021D55 RID: 138581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D55")]
		[Address(RVA = "0x1C43CC0", Offset = "0x1C428C0", VA = "0x181C43CC0")]
		public void RenderRes(string lmtgsId)
		{
		}

		// Token: 0x06021D56 RID: 138582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D56")]
		[Address(RVA = "0x1C44070", Offset = "0x1C42C70", VA = "0x181C44070")]
		public LMTGSResourceBar()
		{
		}

		// Token: 0x0402E536 RID: 189750
		[Token(Token = "0x402E536")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402E537 RID: 189751
		[Token(Token = "0x402E537")]
		[FieldOffset(Offset = "0x20")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E538 RID: 189752
		[Token(Token = "0x402E538")]
		[FieldOffset(Offset = "0x28")]
		private LMTGSResourceBar.Adapter m_adapter;

		// Token: 0x0402E539 RID: 189753
		[Token(Token = "0x402E539")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0402E53A RID: 189754
		[Token(Token = "0x402E53A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E53B RID: 189755
		[Token(Token = "0x402E53B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateValue;

		// Token: 0x0402E53C RID: 189756
		[Token(Token = "0x402E53C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderEmpty;

		// Token: 0x0402E53D RID: 189757
		[Token(Token = "0x402E53D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderAll;

		// Token: 0x0402E53E RID: 189758
		[Token(Token = "0x402E53E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderRes;

		// Token: 0x0402E53F RID: 189759
		[Token(Token = "0x402E53F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AF1 RID: 23281
		[Token(Token = "0x2005AF1")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004F2E RID: 20270
			// (get) Token: 0x06021D57 RID: 138583 RVA: 0x000BB608 File Offset: 0x000B9808
			[Token(Token = "0x17004F2E")]
			public override int count
			{
				[Token(Token = "0x6021D57")]
				[Address(RVA = "0x1C42EB0", Offset = "0x1C41AB0", VA = "0x181C42EB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021D58 RID: 138584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021D58")]
			[Address(RVA = "0x1C42B60", Offset = "0x1C41760", VA = "0x181C42B60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021D59 RID: 138585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021D59")]
			[Address(RVA = "0x1C42D80", Offset = "0x1C41980", VA = "0x181C42D80")]
			public Adapter()
			{
			}

			// Token: 0x0402E540 RID: 189760
			[Token(Token = "0x402E540")]
			[FieldOffset(Offset = "0x20")]
			public List<LMTGSShopSchedule> viewModelList;

			// Token: 0x0402E541 RID: 189761
			[Token(Token = "0x402E541")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E542 RID: 189762
			[Token(Token = "0x402E542")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402E543 RID: 189763
			[Token(Token = "0x402E543")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
