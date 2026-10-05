using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FAF RID: 28591
	[Token(Token = "0x2006FAF")]
	public class ActMultiV3CharSelectCharItemView : TemplateCharSelectCardView
	{
		// Token: 0x060289B2 RID: 166322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B2")]
		[Address(RVA = "0x23EC450", Offset = "0x23EB050", VA = "0x1823EC450", Slot = "6")]
		protected override void DoRender(TemplateCharSelectCardViewModel baseModel)
		{
		}

		// Token: 0x060289B3 RID: 166323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B3")]
		[Address(RVA = "0x23EC850", Offset = "0x23EB450", VA = "0x1823EC850")]
		public ActMultiV3CharSelectCharItemView()
		{
		}

		// Token: 0x04039D75 RID: 236917
		[Token(Token = "0x4039D75")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _charCardRoot;

		// Token: 0x04039D76 RID: 236918
		[Token(Token = "0x4039D76")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3CharCardView _charCardPrefab;

		// Token: 0x04039D77 RID: 236919
		[Token(Token = "0x4039D77")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04039D78 RID: 236920
		[Token(Token = "0x4039D78")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _selectPartGO;

		// Token: 0x04039D79 RID: 236921
		[Token(Token = "0x4039D79")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _highPriSelectGO;

		// Token: 0x04039D7A RID: 236922
		[Token(Token = "0x4039D7A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lowPriSelectGO;

		// Token: 0x04039D7B RID: 236923
		[Token(Token = "0x4039D7B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textSelectIdx;

		// Token: 0x04039D7C RID: 236924
		[Token(Token = "0x4039D7C")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3CharCardView m_charCardView;

		// Token: 0x04039D7D RID: 236925
		[Token(Token = "0x4039D7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04039D7E RID: 236926
		[Token(Token = "0x4039D7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
