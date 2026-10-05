using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DFC RID: 7676
	[Token(Token = "0x2001DFC")]
	public class BuildingFloatVisitAlertView : MonoBehaviour
	{
		// Token: 0x0600BD8D RID: 48525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8D")]
		[Address(RVA = "0x33AE590", Offset = "0x33AD190", VA = "0x1833AE590")]
		public void Show(VisitAlertViewModel viewModel)
		{
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8E")]
		[Address(RVA = "0x33AE890", Offset = "0x33AD490", VA = "0x1833AE890")]
		private void _RenderContent()
		{
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingFloatVisitAlertView()
		{
		}

		// Token: 0x0400BE11 RID: 48657
		[Token(Token = "0x400BE11")]
		private const float SHOW_CONTENT_TIME = 6f;

		// Token: 0x0400BE12 RID: 48658
		[Token(Token = "0x400BE12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400BE13 RID: 48659
		[Token(Token = "0x400BE13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x0400BE14 RID: 48660
		[Token(Token = "0x400BE14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSocialPtActive;

		// Token: 0x0400BE15 RID: 48661
		[Token(Token = "0x400BE15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400BE16 RID: 48662
		[Token(Token = "0x400BE16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0400BE17 RID: 48663
		[Token(Token = "0x400BE17")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animHide;

		// Token: 0x0400BE18 RID: 48664
		[Token(Token = "0x400BE18")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isShowing;

		// Token: 0x0400BE19 RID: 48665
		[Token(Token = "0x400BE19")]
		[FieldOffset(Offset = "0x60")]
		private VisitAlertViewModel m_viewModel;
	}
}
