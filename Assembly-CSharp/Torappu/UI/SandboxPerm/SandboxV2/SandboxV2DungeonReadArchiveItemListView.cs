using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041AF RID: 16815
	[Token(Token = "0x20041AF")]
	public class SandboxV2DungeonReadArchiveItemListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019EEA RID: 106218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EEA")]
		[Address(RVA = "0x12DF6A0", Offset = "0x12DE2A0", VA = "0x1812DF6A0")]
		public void Render(List<SandboxV2DungeonReadArchiveItemModel> models)
		{
		}

		// Token: 0x06019EEB RID: 106219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EEB")]
		[Address(RVA = "0x12DF850", Offset = "0x12DE450", VA = "0x1812DF850")]
		public void SelectItemView(int index)
		{
		}

		// Token: 0x06019EEC RID: 106220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EEC")]
		[Address(RVA = "0x12DF9C0", Offset = "0x12DE5C0", VA = "0x1812DF9C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019EED RID: 106221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EED")]
		[Address(RVA = "0x12DFA30", Offset = "0x12DE630", VA = "0x1812DFA30")]
		public SandboxV2DungeonReadArchiveItemListView()
		{
		}

		// Token: 0x04020A56 RID: 133718
		[Token(Token = "0x4020A56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SandboxV2DungeonReadArchiveItemView> itemViews;

		// Token: 0x04020A57 RID: 133719
		[Token(Token = "0x4020A57")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x04020A58 RID: 133720
		[Token(Token = "0x4020A58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020A59 RID: 133721
		[Token(Token = "0x4020A59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectItemView;

		// Token: 0x04020A5A RID: 133722
		[Token(Token = "0x4020A5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020A5B RID: 133723
		[Token(Token = "0x4020A5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
