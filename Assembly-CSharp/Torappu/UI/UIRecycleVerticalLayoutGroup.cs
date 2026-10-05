using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003901 RID: 14593
	[Token(Token = "0x2003901")]
	public class UIRecycleVerticalLayoutGroup : UIRecycleLayoutGroup
	{
		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x06017124 RID: 94500 RVA: 0x00094BC0 File Offset: 0x00092DC0
		[Token(Token = "0x1700371A")]
		public override float preferredWidth
		{
			[Token(Token = "0x6017124")]
			[Address(RVA = "0xF7E800", Offset = "0xF7D400", VA = "0x180F7E800", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x06017125 RID: 94501 RVA: 0x00094BD8 File Offset: 0x00092DD8
		[Token(Token = "0x1700371B")]
		public override float preferredHeight
		{
			[Token(Token = "0x6017125")]
			[Address(RVA = "0xF7E770", Offset = "0xF7D370", VA = "0x180F7E770", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x06017126 RID: 94502 RVA: 0x00094BF0 File Offset: 0x00092DF0
		[Token(Token = "0x1700371C")]
		protected override float paddingFront
		{
			[Token(Token = "0x6017126")]
			[Address(RVA = "0xF7E700", Offset = "0xF7D300", VA = "0x180F7E700", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x06017127 RID: 94503 RVA: 0x00094C08 File Offset: 0x00092E08
		[Token(Token = "0x1700371D")]
		protected override float paddingBack
		{
			[Token(Token = "0x6017127")]
			[Address(RVA = "0xF7E690", Offset = "0xF7D290", VA = "0x180F7E690", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06017128 RID: 94504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017128")]
		[Address(RVA = "0xF7DEE0", Offset = "0xF7CAE0", VA = "0x180F7DEE0", Slot = "15")]
		protected override void ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, UIRecycleLayoutGroup.LayoutMeta meta)
		{
		}

		// Token: 0x06017129 RID: 94505 RVA: 0x00094C20 File Offset: 0x00092E20
		[Token(Token = "0x6017129")]
		[Address(RVA = "0xF7E560", Offset = "0xF7D160", VA = "0x180F7E560", Slot = "16")]
		protected override Vector2 GetVisibleRange(Bounds viewBound)
		{
			return default(Vector2);
		}

		// Token: 0x0601712A RID: 94506 RVA: 0x00094C38 File Offset: 0x00092E38
		[Token(Token = "0x601712A")]
		[Address(RVA = "0xF7E280", Offset = "0xF7CE80", VA = "0x180F7E280", Slot = "21")]
		protected override Bounds GetElementBoundsFromMeta(UIRecycleLayoutGroup.LayoutMeta meta)
		{
			return default(Bounds);
		}

		// Token: 0x0601712B RID: 94507 RVA: 0x00094C50 File Offset: 0x00092E50
		[Token(Token = "0x601712B")]
		[Address(RVA = "0xF7E4D0", Offset = "0xF7D0D0", VA = "0x180F7E4D0")]
		public float GetElementPosByIndex(int index)
		{
			return 0f;
		}

		// Token: 0x0601712C RID: 94508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601712C")]
		[Address(RVA = "0xF7E630", Offset = "0xF7D230", VA = "0x180F7E630")]
		public UIRecycleVerticalLayoutGroup()
		{
		}

		// Token: 0x0401BD7B RID: 114043
		[Token(Token = "0x401BD7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401BD7C RID: 114044
		[Token(Token = "0x401BD7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401BD7D RID: 114045
		[Token(Token = "0x401BD7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_paddingFront;

		// Token: 0x0401BD7E RID: 114046
		[Token(Token = "0x401BD7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_paddingBack;

		// Token: 0x0401BD7F RID: 114047
		[Token(Token = "0x401BD7F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyLayoutMeta;

		// Token: 0x0401BD80 RID: 114048
		[Token(Token = "0x401BD80")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetVisibleRange;

		// Token: 0x0401BD81 RID: 114049
		[Token(Token = "0x401BD81")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetElementBoundsFromMeta;

		// Token: 0x0401BD82 RID: 114050
		[Token(Token = "0x401BD82")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetElementPosByIndex;

		// Token: 0x0401BD83 RID: 114051
		[Token(Token = "0x401BD83")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
