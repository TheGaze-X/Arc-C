using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006831 RID: 26673
	[Token(Token = "0x2006831")]
	public class SixStarStagePreviewRankView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026333 RID: 156467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026333")]
		[Address(RVA = "0x214E2F0", Offset = "0x214CEF0", VA = "0x18214E2F0")]
		public void Render(StageViewModel sixStarStageModel)
		{
		}

		// Token: 0x06026334 RID: 156468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026334")]
		[Address(RVA = "0x214E410", Offset = "0x214D010", VA = "0x18214E410")]
		public SixStarStagePreviewRankView()
		{
		}

		// Token: 0x04035D47 RID: 220487
		[Token(Token = "0x4035D47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle[] _rankViews;

		// Token: 0x04035D48 RID: 220488
		[Token(Token = "0x4035D48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035D49 RID: 220489
		[Token(Token = "0x4035D49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
