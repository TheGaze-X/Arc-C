using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E07 RID: 19975
	[Token(Token = "0x2004E07")]
	public class NameCardV2EditButtonView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DD9F RID: 122271 RVA: 0x000AC860 File Offset: 0x000AAA60
		[Token(Token = "0x601DD9F")]
		[Address(RVA = "0x1774B50", Offset = "0x1773750", VA = "0x181774B50")]
		private static bool _CheckSkinEditTrackPoint(NameCardMiscModel miscModel)
		{
			return default(bool);
		}

		// Token: 0x0601DDA0 RID: 122272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA0")]
		[Address(RVA = "0x1774910", Offset = "0x1773510", VA = "0x181774910", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DDA1 RID: 122273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA1")]
		[Address(RVA = "0x1774AC0", Offset = "0x17736C0", VA = "0x181774AC0")]
		public void OpenNameCardEditState()
		{
		}

		// Token: 0x0601DDA2 RID: 122274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA2")]
		[Address(RVA = "0x1774C10", Offset = "0x1773810", VA = "0x181774C10")]
		public NameCardV2EditButtonView()
		{
		}

		// Token: 0x04027901 RID: 162049
		[Token(Token = "0x4027901")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _editImage;

		// Token: 0x04027902 RID: 162050
		[Token(Token = "0x4027902")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _simpleVersionColor;

		// Token: 0x04027903 RID: 162051
		[Token(Token = "0x4027903")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _editNameCardTrackPoint;

		// Token: 0x04027904 RID: 162052
		[Token(Token = "0x4027904")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027905 RID: 162053
		[Token(Token = "0x4027905")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckSkinEditTrackPoint;

		// Token: 0x04027906 RID: 162054
		[Token(Token = "0x4027906")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027907 RID: 162055
		[Token(Token = "0x4027907")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenNameCardEditState;

		// Token: 0x04027908 RID: 162056
		[Token(Token = "0x4027908")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
