using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004909 RID: 18697
	[Token(Token = "0x2004909")]
	public class MiniReviewDetailAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x0601C32D RID: 115501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C32D")]
		[Address(RVA = "0x15B17C0", Offset = "0x15B03C0", VA = "0x1815B17C0")]
		public MiniReviewDetailAdapter(GameObject customInfo, GameObject customLock)
		{
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x0601C32E RID: 115502 RVA: 0x000A7898 File Offset: 0x000A5A98
		[Token(Token = "0x170042F0")]
		public override int count
		{
			[Token(Token = "0x601C32E")]
			[Address(RVA = "0x15B18D0", Offset = "0x15B04D0", VA = "0x1815B18D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C32F RID: 115503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C32F")]
		[Address(RVA = "0x15B15B0", Offset = "0x15B01B0", VA = "0x1815B15B0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x04024DB9 RID: 150969
		[Token(Token = "0x4024DB9")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<StoryReviewViewModel> m_storyModels;

		// Token: 0x04024DBA RID: 150970
		[Token(Token = "0x4024DBA")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Color m_storyColor;

		// Token: 0x04024DBB RID: 150971
		[Token(Token = "0x4024DBB")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public bool m_ActivityOutOfTime;

		// Token: 0x04024DBC RID: 150972
		[Token(Token = "0x4024DBC")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onReviewStoryClicked;

		// Token: 0x04024DBD RID: 150973
		[Token(Token = "0x4024DBD")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onUnlockStoryClicked;

		// Token: 0x04024DBE RID: 150974
		[Token(Token = "0x4024DBE")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04024DBF RID: 150975
		[Token(Token = "0x4024DBF")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_customInfoPrefab;

		// Token: 0x04024DC0 RID: 150976
		[Token(Token = "0x4024DC0")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_customLockPrefab;

		// Token: 0x04024DC1 RID: 150977
		[Token(Token = "0x4024DC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04024DC2 RID: 150978
		[Token(Token = "0x4024DC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04024DC3 RID: 150979
		[Token(Token = "0x4024DC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;
	}
}
