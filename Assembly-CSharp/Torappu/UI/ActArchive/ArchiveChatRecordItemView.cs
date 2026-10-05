using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B4C RID: 27468
	[Token(Token = "0x2006B4C")]
	public class ArchiveChatRecordItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027419 RID: 160793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027419")]
		[Address(RVA = "0x226DFA0", Offset = "0x226CBA0", VA = "0x18226DFA0")]
		public void Render(ArchiveChatRecordItemViewStruct viewModel)
		{
		}

		// Token: 0x0602741A RID: 160794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602741A")]
		[Address(RVA = "0x226E290", Offset = "0x226CE90", VA = "0x18226E290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602741B RID: 160795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602741B")]
		[Address(RVA = "0x226E340", Offset = "0x226CF40", VA = "0x18226E340")]
		public ArchiveChatRecordItemView()
		{
		}

		// Token: 0x040378EE RID: 227566
		[Token(Token = "0x40378EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x040378EF RID: 227567
		[Token(Token = "0x40378EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x040378F0 RID: 227568
		[Token(Token = "0x40378F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x040378F1 RID: 227569
		[Token(Token = "0x40378F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _lockContent;

		// Token: 0x040378F2 RID: 227570
		[Token(Token = "0x40378F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x040378F3 RID: 227571
		[Token(Token = "0x40378F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _titleImages;

		// Token: 0x040378F4 RID: 227572
		[Token(Token = "0x40378F4")]
		[FieldOffset(Offset = "0x48")]
		private TextGenerator m_textGenerator;

		// Token: 0x040378F5 RID: 227573
		[Token(Token = "0x40378F5")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x040378F6 RID: 227574
		[Token(Token = "0x40378F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040378F7 RID: 227575
		[Token(Token = "0x40378F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040378F8 RID: 227576
		[Token(Token = "0x40378F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
