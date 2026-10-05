using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200370D RID: 14093
	[Token(Token = "0x200370D")]
	public class UIGuidebookPage : MonoBehaviour
	{
		// Token: 0x060165DE RID: 91614 RVA: 0x00090CC0 File Offset: 0x0008EEC0
		[Token(Token = "0x60165DE")]
		[Address(RVA = "0xECF630", Offset = "0xECE230", VA = "0x180ECF630")]
		public bool Load(string pageId, bool hasRightArrow, UIGuidebookPanel guidebook)
		{
			return default(bool);
		}

		// Token: 0x060165DF RID: 91615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165DF")]
		[Address(RVA = "0xECF7E0", Offset = "0xECE3E0", VA = "0x180ECF7E0")]
		public void OnRightArrowClicked()
		{
		}

		// Token: 0x060165E0 RID: 91616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165E0")]
		[Address(RVA = "0xECF910", Offset = "0xECE510", VA = "0x180ECF910")]
		public void Release()
		{
		}

		// Token: 0x060165E1 RID: 91617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165E1")]
		[Address(RVA = "0xECF7D0", Offset = "0xECE3D0", VA = "0x180ECF7D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060165E2 RID: 91618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165E2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIGuidebookPage()
		{
		}

		// Token: 0x0401AE7F RID: 110207
		[Token(Token = "0x401AE7F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _content;

		// Token: 0x0401AE80 RID: 110208
		[Token(Token = "0x401AE80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _rightArrow;

		// Token: 0x0401AE81 RID: 110209
		[Token(Token = "0x401AE81")]
		[FieldOffset(Offset = "0x28")]
		private UIGuidebookPanel m_guidebook;
	}
}
