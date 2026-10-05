using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F4B RID: 24395
	[Token(Token = "0x2005F4B")]
	public class CharacterEvolveDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023532 RID: 144690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023532")]
		[Address(RVA = "0x1DD4B90", Offset = "0x1DD3790", VA = "0x181DD4B90")]
		public void OnBack()
		{
		}

		// Token: 0x06023533 RID: 144691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023533")]
		[Address(RVA = "0x1DD4CA0", Offset = "0x1DD38A0", VA = "0x181DD4CA0")]
		public void OnClick()
		{
		}

		// Token: 0x06023534 RID: 144692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023534")]
		[Address(RVA = "0x1DD5610", Offset = "0x1DD4210", VA = "0x181DD5610")]
		private IEnumerator _BackAnim()
		{
			return null;
		}

		// Token: 0x06023535 RID: 144693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023535")]
		[Address(RVA = "0x1DD56C0", Offset = "0x1DD42C0", VA = "0x181DD56C0")]
		private IEnumerator _EffectAnim()
		{
			return null;
		}

		// Token: 0x06023536 RID: 144694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023536")]
		[Address(RVA = "0x1DD4DB0", Offset = "0x1DD39B0", VA = "0x181DD4DB0")]
		public void Render(CharacterInfoEvolveInfoViewModel viewModel)
		{
		}

		// Token: 0x06023537 RID: 144695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023537")]
		[Address(RVA = "0x1DD5770", Offset = "0x1DD4370", VA = "0x181DD5770")]
		public CharacterEvolveDetailView()
		{
		}

		// Token: 0x04030BE1 RID: 199649
		[Token(Token = "0x4030BE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _detailButton;

		// Token: 0x04030BE2 RID: 199650
		[Token(Token = "0x4030BE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterEvolveDetailNewAttackRangeView _newAttackRange;

		// Token: 0x04030BE3 RID: 199651
		[Token(Token = "0x4030BE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterEvolveDetailNormalText _normalText;

		// Token: 0x04030BE4 RID: 199652
		[Token(Token = "0x4030BE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterEvolveDetailSingleLineText _singleLineText;

		// Token: 0x04030BE5 RID: 199653
		[Token(Token = "0x4030BE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterEvolveDetailNewSkillView _skillView;

		// Token: 0x04030BE6 RID: 199654
		[Token(Token = "0x4030BE6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _closeButton;

		// Token: 0x04030BE7 RID: 199655
		[Token(Token = "0x4030BE7")]
		[FieldOffset(Offset = "0x48")]
		private List<CharacterEvolveDetailCommon> m_detailList;

		// Token: 0x04030BE8 RID: 199656
		[Token(Token = "0x4030BE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBack;

		// Token: 0x04030BE9 RID: 199657
		[Token(Token = "0x4030BE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04030BEA RID: 199658
		[Token(Token = "0x4030BEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BackAnim;

		// Token: 0x04030BEB RID: 199659
		[Token(Token = "0x4030BEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EffectAnim;

		// Token: 0x04030BEC RID: 199660
		[Token(Token = "0x4030BEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BED RID: 199661
		[Token(Token = "0x4030BED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
