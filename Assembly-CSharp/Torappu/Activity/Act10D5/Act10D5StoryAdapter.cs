using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.StoryReview;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B21 RID: 31521
	[Token(Token = "0x2007B21")]
	public class Act10D5StoryAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17006765 RID: 26469
		// (get) Token: 0x0602C216 RID: 180758 RVA: 0x000DE318 File Offset: 0x000DC518
		[Token(Token = "0x17006765")]
		public override int count
		{
			[Token(Token = "0x602C216")]
			[Address(RVA = "0x280A4B0", Offset = "0x28090B0", VA = "0x18280A4B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602C217 RID: 180759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C217")]
		[Address(RVA = "0x280A210", Offset = "0x2808E10", VA = "0x18280A210", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602C218 RID: 180760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C218")]
		[Address(RVA = "0x280A3F0", Offset = "0x2808FF0", VA = "0x18280A3F0")]
		public Act10D5StoryAdapter()
		{
		}

		// Token: 0x0403FF90 RID: 262032
		[Token(Token = "0x403FF90")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<StoryReviewViewModel> m_storyModels;

		// Token: 0x0403FF91 RID: 262033
		[Token(Token = "0x403FF91")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Color m_storyColor;

		// Token: 0x0403FF92 RID: 262034
		[Token(Token = "0x403FF92")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<string> onReviewStoryClicked;

		// Token: 0x0403FF93 RID: 262035
		[Token(Token = "0x403FF93")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onUnlockStoryClicked;

		// Token: 0x0403FF94 RID: 262036
		[Token(Token = "0x403FF94")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x0403FF95 RID: 262037
		[Token(Token = "0x403FF95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403FF96 RID: 262038
		[Token(Token = "0x403FF96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403FF97 RID: 262039
		[Token(Token = "0x403FF97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
