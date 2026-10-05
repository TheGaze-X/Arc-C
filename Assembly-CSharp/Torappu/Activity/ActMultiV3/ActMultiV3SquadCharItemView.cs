using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FB4 RID: 28596
	[Token(Token = "0x2006FB4")]
	public class ActMultiV3SquadCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060289B8 RID: 166328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B8")]
		[Address(RVA = "0x23EE4C0", Offset = "0x23ED0C0", VA = "0x1823EE4C0")]
		public void Render(ActMultiV3IdentityType idType, ActMultiV3CharViewModel charModel)
		{
		}

		// Token: 0x060289B9 RID: 166329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B9")]
		[Address(RVA = "0x23EE360", Offset = "0x23ECF60", VA = "0x1823EE360")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060289BA RID: 166330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289BA")]
		[Address(RVA = "0x23EE7F0", Offset = "0x23ED3F0", VA = "0x1823EE7F0")]
		public ActMultiV3SquadCharItemView()
		{
		}

		// Token: 0x04039D88 RID: 236936
		[Token(Token = "0x4039D88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _charCardRoot;

		// Token: 0x04039D89 RID: 236937
		[Token(Token = "0x4039D89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActMultiV3CharCardView _charCardPrefab;

		// Token: 0x04039D8A RID: 236938
		[Token(Token = "0x4039D8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04039D8B RID: 236939
		[Token(Token = "0x4039D8B")]
		[FieldOffset(Offset = "0x30")]
		private ActMultiV3CharCardView m_charCardView;

		// Token: 0x04039D8C RID: 236940
		[Token(Token = "0x4039D8C")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3CharViewModel m_viewModel;

		// Token: 0x04039D8D RID: 236941
		[Token(Token = "0x4039D8D")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3IdentityType m_idType;

		// Token: 0x04039D8E RID: 236942
		[Token(Token = "0x4039D8E")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039D8F RID: 236943
		[Token(Token = "0x4039D8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039D90 RID: 236944
		[Token(Token = "0x4039D90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04039D91 RID: 236945
		[Token(Token = "0x4039D91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
