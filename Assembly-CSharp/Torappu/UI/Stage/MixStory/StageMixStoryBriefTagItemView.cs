using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A86 RID: 27270
	[Token(Token = "0x2006A86")]
	public class StageMixStoryBriefTagItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602704D RID: 159821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704D")]
		[Address(RVA = "0x223D8C0", Offset = "0x223C4C0", VA = "0x18223D8C0")]
		public void Render(StageStorylineTagViewModel model)
		{
		}

		// Token: 0x0602704E RID: 159822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602704E")]
		[Address(RVA = "0x223DA70", Offset = "0x223C670", VA = "0x18223DA70")]
		public StageMixStoryBriefTagItemView()
		{
		}

		// Token: 0x04037325 RID: 226085
		[Token(Token = "0x4037325")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _tagText;

		// Token: 0x04037326 RID: 226086
		[Token(Token = "0x4037326")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _tagBkg;

		// Token: 0x04037327 RID: 226087
		[Token(Token = "0x4037327")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037328 RID: 226088
		[Token(Token = "0x4037328")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
