using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.StoryReview;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D94 RID: 28052
	[Token(Token = "0x2006D94")]
	public class ActCommonMiniStoryAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x06027F51 RID: 163665 RVA: 0x000D02A8 File Offset: 0x000CE4A8
		[Token(Token = "0x17005E74")]
		public override int count
		{
			[Token(Token = "0x6027F51")]
			[Address(RVA = "0x232DC10", Offset = "0x232C810", VA = "0x18232DC10", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027F52 RID: 163666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F52")]
		[Address(RVA = "0x232DB00", Offset = "0x232C700", VA = "0x18232DB00")]
		public ActCommonMiniStoryAdapter(GameObject customInfoPrefab, GameObject customLockPrefab)
		{
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F53")]
		[Address(RVA = "0x232D900", Offset = "0x232C500", VA = "0x18232D900", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x04038A0D RID: 231949
		[Token(Token = "0x4038A0D")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<StoryReviewViewModel> m_storyModels;

		// Token: 0x04038A0E RID: 231950
		[Token(Token = "0x4038A0E")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Color m_storyColor;

		// Token: 0x04038A0F RID: 231951
		[Token(Token = "0x4038A0F")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<string> onReviewStoryClicked;

		// Token: 0x04038A10 RID: 231952
		[Token(Token = "0x4038A10")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onUnlockStoryClicked;

		// Token: 0x04038A11 RID: 231953
		[Token(Token = "0x4038A11")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04038A12 RID: 231954
		[Token(Token = "0x4038A12")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_customPrefab;

		// Token: 0x04038A13 RID: 231955
		[Token(Token = "0x4038A13")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_customLockPrefab;

		// Token: 0x04038A14 RID: 231956
		[Token(Token = "0x4038A14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04038A15 RID: 231957
		[Token(Token = "0x4038A15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038A16 RID: 231958
		[Token(Token = "0x4038A16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;
	}
}
