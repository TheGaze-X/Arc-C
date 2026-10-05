using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038F2 RID: 14578
	[Token(Token = "0x20038F2")]
	public class UIRecycleHorizonLayoutGroup : UIRecycleLayoutGroup
	{
		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x060170B0 RID: 94384 RVA: 0x00094878 File Offset: 0x00092A78
		[Token(Token = "0x170036FB")]
		public override float preferredWidth
		{
			[Token(Token = "0x60170B0")]
			[Address(RVA = "0xF7A1A0", Offset = "0xF78DA0", VA = "0x180F7A1A0", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x060170B1 RID: 94385 RVA: 0x00094890 File Offset: 0x00092A90
		[Token(Token = "0x170036FC")]
		public override float preferredHeight
		{
			[Token(Token = "0x60170B1")]
			[Address(RVA = "0xF7A140", Offset = "0xF78D40", VA = "0x180F7A140", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x060170B2 RID: 94386 RVA: 0x000948A8 File Offset: 0x00092AA8
		[Token(Token = "0x170036FD")]
		protected override float paddingFront
		{
			[Token(Token = "0x60170B2")]
			[Address(RVA = "0xF7A0D0", Offset = "0xF78CD0", VA = "0x180F7A0D0", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x060170B3 RID: 94387 RVA: 0x000948C0 File Offset: 0x00092AC0
		[Token(Token = "0x170036FE")]
		protected override float paddingBack
		{
			[Token(Token = "0x60170B3")]
			[Address(RVA = "0xF7A060", Offset = "0xF78C60", VA = "0x180F7A060", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060170B4 RID: 94388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170B4")]
		[Address(RVA = "0xF798C0", Offset = "0xF784C0", VA = "0x180F798C0", Slot = "15")]
		protected override void ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, UIRecycleLayoutGroup.LayoutMeta meta)
		{
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x000948D8 File Offset: 0x00092AD8
		[Token(Token = "0x60170B5")]
		[Address(RVA = "0xF79F40", Offset = "0xF78B40", VA = "0x180F79F40", Slot = "16")]
		protected override Vector2 GetVisibleRange(Bounds viewBound)
		{
			return default(Vector2);
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x000948F0 File Offset: 0x00092AF0
		[Token(Token = "0x60170B6")]
		[Address(RVA = "0xF79C60", Offset = "0xF78860", VA = "0x180F79C60", Slot = "21")]
		protected override Bounds GetElementBoundsFromMeta(UIRecycleLayoutGroup.LayoutMeta meta)
		{
			return default(Bounds);
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x00094908 File Offset: 0x00092B08
		[Token(Token = "0x60170B7")]
		[Address(RVA = "0xF79EB0", Offset = "0xF78AB0", VA = "0x180F79EB0")]
		public float GetElementPosByIndex(int index)
		{
			return 0f;
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170B8")]
		[Address(RVA = "0xF7A000", Offset = "0xF78C00", VA = "0x180F7A000")]
		public UIRecycleHorizonLayoutGroup()
		{
		}

		// Token: 0x0401BD0B RID: 113931
		[Token(Token = "0x401BD0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401BD0C RID: 113932
		[Token(Token = "0x401BD0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401BD0D RID: 113933
		[Token(Token = "0x401BD0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_paddingFront;

		// Token: 0x0401BD0E RID: 113934
		[Token(Token = "0x401BD0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_paddingBack;

		// Token: 0x0401BD0F RID: 113935
		[Token(Token = "0x401BD0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyLayoutMeta;

		// Token: 0x0401BD10 RID: 113936
		[Token(Token = "0x401BD10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetVisibleRange;

		// Token: 0x0401BD11 RID: 113937
		[Token(Token = "0x401BD11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetElementBoundsFromMeta;

		// Token: 0x0401BD12 RID: 113938
		[Token(Token = "0x401BD12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetElementPosByIndex;

		// Token: 0x0401BD13 RID: 113939
		[Token(Token = "0x401BD13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
