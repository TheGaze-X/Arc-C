using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040F1 RID: 16625
	[Token(Token = "0x20040F1")]
	public class SandboxV2WorkbenchItemView : SandboxV2AdminMainListItemViewBase
	{
		// Token: 0x06019B67 RID: 105319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B67")]
		[Address(RVA = "0x1299150", Offset = "0x1297D50", VA = "0x181299150")]
		public void Render(int position, SandboxV2WorkbenchItemModel model)
		{
		}

		// Token: 0x06019B68 RID: 105320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B68")]
		[Address(RVA = "0x12992C0", Offset = "0x1297EC0", VA = "0x1812992C0")]
		public SandboxV2WorkbenchItemView()
		{
		}

		// Token: 0x040202B3 RID: 131763
		[Token(Token = "0x40202B3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _notAlchemyPanel;

		// Token: 0x040202B4 RID: 131764
		[Token(Token = "0x40202B4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x040202B5 RID: 131765
		[Token(Token = "0x40202B5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _unlockDescText;

		// Token: 0x040202B6 RID: 131766
		[Token(Token = "0x40202B6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _multipleItemScale;

		// Token: 0x040202B7 RID: 131767
		[Token(Token = "0x40202B7")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_hasRenderedBefore;

		// Token: 0x040202B8 RID: 131768
		[Token(Token = "0x40202B8")]
		[FieldOffset(Offset = "0xAD")]
		private bool m_cachedMultiple;

		// Token: 0x040202B9 RID: 131769
		[Token(Token = "0x40202B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040202BA RID: 131770
		[Token(Token = "0x40202BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
