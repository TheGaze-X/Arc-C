using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C2 RID: 18626
	[Token(Token = "0x20048C2")]
	public class MiniActReviewListAdapter : RecycleLoopScrollAdapter<MiniActReviewListItemHolder, StoryReviewChapterViewModel>
	{
		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0601C18D RID: 115085 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C18E RID: 115086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042AF")]
		public Action<string> onReviewChapterClick
		{
			[Token(Token = "0x601C18D")]
			[Address(RVA = "0x15963C0", Offset = "0x1594FC0", VA = "0x1815963C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C18E")]
			[Address(RVA = "0x15964A0", Offset = "0x15950A0", VA = "0x1815964A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x0601C18F RID: 115087 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C190 RID: 115088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B0")]
		public Action<string> onChapterRewardGain
		{
			[Token(Token = "0x601C18F")]
			[Address(RVA = "0x1596360", Offset = "0x1594F60", VA = "0x181596360")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C190")]
			[Address(RVA = "0x1596420", Offset = "0x1595020", VA = "0x181596420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C191 RID: 115089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C191")]
		[Address(RVA = "0x1596050", Offset = "0x1594C50", VA = "0x181596050", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MiniActReviewListItemHolder holder, StoryReviewChapterViewModel data)
		{
		}

		// Token: 0x0601C192 RID: 115090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C192")]
		[Address(RVA = "0x1596240", Offset = "0x1594E40", VA = "0x181596240", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601C193 RID: 115091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C193")]
		[Address(RVA = "0x15962F0", Offset = "0x1594EF0", VA = "0x1815962F0")]
		public MiniActReviewListAdapter()
		{
		}

		// Token: 0x04024B84 RID: 150404
		[Token(Token = "0x4024B84")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x04024B87 RID: 150407
		[Token(Token = "0x4024B87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onReviewChapterClick;

		// Token: 0x04024B88 RID: 150408
		[Token(Token = "0x4024B88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onReviewChapterClick;

		// Token: 0x04024B89 RID: 150409
		[Token(Token = "0x4024B89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onChapterRewardGain;

		// Token: 0x04024B8A RID: 150410
		[Token(Token = "0x4024B8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onChapterRewardGain;

		// Token: 0x04024B8B RID: 150411
		[Token(Token = "0x4024B8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04024B8C RID: 150412
		[Token(Token = "0x4024B8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04024B8D RID: 150413
		[Token(Token = "0x4024B8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
