using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006AA0 RID: 27296
	[Token(Token = "0x2006AA0")]
	public abstract class StageMixStoryStorySetCommonIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060270C3 RID: 159939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270C3")]
		[Address(RVA = "0x22451C0", Offset = "0x2243DC0", VA = "0x1822451C0")]
		public void Render(StageStorylineStorySetViewModel storySet, ILoadAsset assets)
		{
		}

		// Token: 0x060270C4 RID: 159940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270C4")]
		[Address(RVA = "0x2245110", Offset = "0x2243D10", VA = "0x182245110")]
		public void ClearView()
		{
		}

		// Token: 0x060270C5 RID: 159941
		[Token(Token = "0x60270C5")]
		protected abstract string _GetIconId(StageStorylineStorySetViewModel storySet);

		// Token: 0x060270C6 RID: 159942
		[Token(Token = "0x60270C6")]
		protected abstract string _LoadSpritePath(ILoadAsset assets, string iconId);

		// Token: 0x060270C7 RID: 159943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270C7")]
		[Address(RVA = "0x22453E0", Offset = "0x2243FE0", VA = "0x1822453E0")]
		protected StageMixStoryStorySetCommonIconView()
		{
		}

		// Token: 0x04037429 RID: 226345
		[Token(Token = "0x4037429")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDynImage _iconImage;

		// Token: 0x0403742A RID: 226346
		[Token(Token = "0x403742A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<StorylineStorySetType> _validTypes;

		// Token: 0x0403742B RID: 226347
		[Token(Token = "0x403742B")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedIconId;

		// Token: 0x0403742C RID: 226348
		[Token(Token = "0x403742C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403742D RID: 226349
		[Token(Token = "0x403742D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearView;

		// Token: 0x0403742E RID: 226350
		[Token(Token = "0x403742E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
