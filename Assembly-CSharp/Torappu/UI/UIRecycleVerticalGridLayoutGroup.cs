using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003900 RID: 14592
	[Token(Token = "0x2003900")]
	public class UIRecycleVerticalGridLayoutGroup : UIRecycleGridLayoutGroup
	{
		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x06017119 RID: 94489 RVA: 0x00094B18 File Offset: 0x00092D18
		[Token(Token = "0x17003715")]
		public override float preferredWidth
		{
			[Token(Token = "0x6017119")]
			[Address(RVA = "0xF7DDE0", Offset = "0xF7C9E0", VA = "0x180F7DDE0", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0601711A RID: 94490 RVA: 0x00094B30 File Offset: 0x00092D30
		[Token(Token = "0x17003716")]
		public override float preferredHeight
		{
			[Token(Token = "0x601711A")]
			[Address(RVA = "0xF7DD50", Offset = "0xF7C950", VA = "0x180F7DD50", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0601711B RID: 94491 RVA: 0x00094B48 File Offset: 0x00092D48
		[Token(Token = "0x17003717")]
		protected override float paddingFront
		{
			[Token(Token = "0x601711B")]
			[Address(RVA = "0xF7DC80", Offset = "0xF7C880", VA = "0x180F7DC80", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0601711C RID: 94492 RVA: 0x00094B60 File Offset: 0x00092D60
		[Token(Token = "0x17003718")]
		protected override float paddingBack
		{
			[Token(Token = "0x601711C")]
			[Address(RVA = "0xF7DC10", Offset = "0xF7C810", VA = "0x180F7DC10", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0601711D RID: 94493 RVA: 0x00094B78 File Offset: 0x00092D78
		// (set) Token: 0x0601711E RID: 94494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003719")]
		private protected float perpendicularSize
		{
			[Token(Token = "0x601711D")]
			[Address(RVA = "0xF7DCF0", Offset = "0xF7C8F0", VA = "0x180F7DCF0")]
			[CompilerGenerated]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x601711E")]
			[Address(RVA = "0xF7DE70", Offset = "0xF7CA70", VA = "0x180F7DE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601711F RID: 94495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601711F")]
		[Address(RVA = "0xF7C860", Offset = "0xF7B460", VA = "0x180F7C860", Slot = "15")]
		protected override void ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, UIRecycleLayoutGroup.LayoutMeta meta)
		{
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x00094B90 File Offset: 0x00092D90
		[Token(Token = "0x6017120")]
		[Address(RVA = "0xF7DAA0", Offset = "0xF7C6A0", VA = "0x180F7DAA0", Slot = "16")]
		protected override Vector2 GetVisibleRange(Bounds viewBound)
		{
			return default(Vector2);
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017121")]
		[Address(RVA = "0xF7CD00", Offset = "0xF7B900", VA = "0x180F7CD00", Slot = "22")]
		protected override void CalculateViewMeta(int fromIndex)
		{
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x00094BA8 File Offset: 0x00092DA8
		[Token(Token = "0x6017122")]
		[Address(RVA = "0xF7D760", Offset = "0xF7C360", VA = "0x180F7D760", Slot = "21")]
		protected override Bounds GetElementBoundsFromMeta(UIRecycleLayoutGroup.LayoutMeta meta)
		{
			return default(Bounds);
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017123")]
		[Address(RVA = "0xF7DB70", Offset = "0xF7C770", VA = "0x180F7DB70")]
		public UIRecycleVerticalGridLayoutGroup()
		{
		}

		// Token: 0x0401BD70 RID: 114032
		[Token(Token = "0x401BD70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401BD71 RID: 114033
		[Token(Token = "0x401BD71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401BD72 RID: 114034
		[Token(Token = "0x401BD72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_paddingFront;

		// Token: 0x0401BD73 RID: 114035
		[Token(Token = "0x401BD73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_paddingBack;

		// Token: 0x0401BD74 RID: 114036
		[Token(Token = "0x401BD74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_perpendicularSize;

		// Token: 0x0401BD75 RID: 114037
		[Token(Token = "0x401BD75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_perpendicularSize;

		// Token: 0x0401BD76 RID: 114038
		[Token(Token = "0x401BD76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyLayoutMeta;

		// Token: 0x0401BD77 RID: 114039
		[Token(Token = "0x401BD77")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetVisibleRange;

		// Token: 0x0401BD78 RID: 114040
		[Token(Token = "0x401BD78")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalculateViewMeta;

		// Token: 0x0401BD79 RID: 114041
		[Token(Token = "0x401BD79")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetElementBoundsFromMeta;

		// Token: 0x0401BD7A RID: 114042
		[Token(Token = "0x401BD7A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
