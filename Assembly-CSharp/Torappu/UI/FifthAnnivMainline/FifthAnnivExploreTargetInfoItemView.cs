using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F14 RID: 20244
	[Token(Token = "0x2004F14")]
	public class FifthAnnivExploreTargetInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E2B6 RID: 123574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2B6")]
		[Address(RVA = "0x17D9AB0", Offset = "0x17D86B0", VA = "0x1817D9AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2B7 RID: 123575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2B7")]
		[Address(RVA = "0x17D95C0", Offset = "0x17D81C0", VA = "0x1817D95C0")]
		public void Render(FifthAnnivExploreTargetInfoItemView.Config config, FifthAnnivExploreTargetInfoItemViewModel viewModel)
		{
		}

		// Token: 0x0601E2B8 RID: 123576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2B8")]
		[Address(RVA = "0x17D9B10", Offset = "0x17D8710", VA = "0x1817D9B10")]
		public FifthAnnivExploreTargetInfoItemView()
		{
		}

		// Token: 0x040282C1 RID: 164545
		[Token(Token = "0x40282C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _iconImg;

		// Token: 0x040282C2 RID: 164546
		[Token(Token = "0x40282C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _targetNameText;

		// Token: 0x040282C3 RID: 164547
		[Token(Token = "0x40282C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _requireEventDescText;

		// Token: 0x040282C4 RID: 164548
		[Token(Token = "0x40282C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _completeObjToggle;

		// Token: 0x040282C5 RID: 164549
		[Token(Token = "0x40282C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<FifthAnnivExploreTargetInfoItemView.TeamValueTypeComp> _teamValueTypeComps;

		// Token: 0x040282C6 RID: 164550
		[Token(Token = "0x40282C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _iconAtlas;

		// Token: 0x040282C7 RID: 164551
		[Token(Token = "0x40282C7")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x040282C8 RID: 164552
		[Token(Token = "0x40282C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040282C9 RID: 164553
		[Token(Token = "0x40282C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040282CA RID: 164554
		[Token(Token = "0x40282CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F15 RID: 20245
		[Token(Token = "0x2004F15")]
		[Serializable]
		public struct Config
		{
			// Token: 0x040282CB RID: 164555
			[Token(Token = "0x40282CB")]
			[FieldOffset(Offset = "0x0")]
			public Color noRequireEventColor;

			// Token: 0x040282CC RID: 164556
			[Token(Token = "0x40282CC")]
			[FieldOffset(Offset = "0x10")]
			public Color completedColor;

			// Token: 0x040282CD RID: 164557
			[Token(Token = "0x40282CD")]
			[FieldOffset(Offset = "0x20")]
			public Color uncompletedColor;

			// Token: 0x040282CE RID: 164558
			[Token(Token = "0x40282CE")]
			[FieldOffset(Offset = "0x30")]
			public Color requireEventDescColor;
		}

		// Token: 0x02004F16 RID: 20246
		[Token(Token = "0x2004F16")]
		[Serializable]
		private struct TeamValueTypeComp
		{
			// Token: 0x040282CF RID: 164559
			[Token(Token = "0x40282CF")]
			[FieldOffset(Offset = "0x0")]
			public UIAtlasImage iconImg;

			// Token: 0x040282D0 RID: 164560
			[Token(Token = "0x40282D0")]
			[FieldOffset(Offset = "0x8")]
			public Text valueText;
		}
	}
}
