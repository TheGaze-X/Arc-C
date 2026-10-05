using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC7 RID: 20167
	[Token(Token = "0x2004EC7")]
	public class FifthAnnivExploreValueGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E17F RID: 123263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E17F")]
		[Address(RVA = "0x17DAE10", Offset = "0x17D9A10", VA = "0x1817DAE10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E180 RID: 123264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E180")]
		[Address(RVA = "0x17DAB60", Offset = "0x17D9760", VA = "0x1817DAB60")]
		public void Render(FifthAnnivExploreValueGroupViewModel viewModel)
		{
		}

		// Token: 0x0601E181 RID: 123265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E181")]
		[Address(RVA = "0x17DAE70", Offset = "0x17D9A70", VA = "0x1817DAE70")]
		public FifthAnnivExploreValueGroupView()
		{
		}

		// Token: 0x04028085 RID: 163973
		[Token(Token = "0x4028085")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FifthAnnivExploreValueViewConfig _config;

		// Token: 0x04028086 RID: 163974
		[Token(Token = "0x4028086")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<FifthAnnivExploreValueGroupView.ValueViewComponents> _valueViewComponents;

		// Token: 0x04028087 RID: 163975
		[Token(Token = "0x4028087")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _iconAtlas;

		// Token: 0x04028088 RID: 163976
		[Token(Token = "0x4028088")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04028089 RID: 163977
		[Token(Token = "0x4028089")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402808A RID: 163978
		[Token(Token = "0x402808A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402808B RID: 163979
		[Token(Token = "0x402808B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EC8 RID: 20168
		[Token(Token = "0x2004EC8")]
		[Serializable]
		private struct ValueViewComponents
		{
			// Token: 0x0402808C RID: 163980
			[Token(Token = "0x402808C")]
			[FieldOffset(Offset = "0x0")]
			public FifthAnnivExploreValueAbstractView valueView;

			// Token: 0x0402808D RID: 163981
			[Token(Token = "0x402808D")]
			[FieldOffset(Offset = "0x8")]
			public UIAtlasImage iconImg;
		}
	}
}
