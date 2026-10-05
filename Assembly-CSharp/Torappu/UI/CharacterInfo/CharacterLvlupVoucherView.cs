using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F68 RID: 24424
	[Token(Token = "0x2005F68")]
	public class CharacterLvlupVoucherView : DataBinder<CharacterLvlupVoucherViewProperty>
	{
		// Token: 0x060235C5 RID: 144837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C5")]
		[Address(RVA = "0x1E0D380", Offset = "0x1E0BF80", VA = "0x181E0D380", Slot = "7")]
		public override void OnValueChanged(CharacterLvlupVoucherViewProperty property)
		{
		}

		// Token: 0x060235C6 RID: 144838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C6")]
		[Address(RVA = "0x1E0D750", Offset = "0x1E0C350", VA = "0x181E0D750")]
		public CharacterLvlupVoucherView()
		{
		}

		// Token: 0x04030D2B RID: 199979
		[Token(Token = "0x4030D2B")]
		private const string TEXT_CURR_LEVEL_PREFIX = "LV.{0}";

		// Token: 0x04030D2C RID: 199980
		[Token(Token = "0x4030D2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCampLogo;

		// Token: 0x04030D2D RID: 199981
		[Token(Token = "0x4030D2D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterLvlupVoucherView.CharacterLvlupAttrInfoView _attrAndExpInfoView;

		// Token: 0x04030D2E RID: 199982
		[Token(Token = "0x4030D2E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCurrLvl;

		// Token: 0x04030D2F RID: 199983
		[Token(Token = "0x4030D2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMaxLvl;

		// Token: 0x04030D30 RID: 199984
		[Token(Token = "0x4030D30")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _raritySprite;

		// Token: 0x04030D31 RID: 199985
		[Token(Token = "0x4030D31")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textNickname;

		// Token: 0x04030D32 RID: 199986
		[Token(Token = "0x4030D32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030D33 RID: 199987
		[Token(Token = "0x4030D33")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoSkillRequireItemView _requireItemView;

		// Token: 0x04030D34 RID: 199988
		[Token(Token = "0x4030D34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030D35 RID: 199989
		[Token(Token = "0x4030D35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F69 RID: 24425
		[Token(Token = "0x2005F69")]
		[Serializable]
		public class CharacterLvlupAttrInfoView : IHotfixable
		{
			// Token: 0x060235C7 RID: 144839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235C7")]
			[Address(RVA = "0x1E0B310", Offset = "0x1E09F10", VA = "0x181E0B310")]
			public void Render(CharacterLvlupVoucherViewModel viewModel)
			{
			}

			// Token: 0x060235C8 RID: 144840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235C8")]
			[Address(RVA = "0x1E0B6F0", Offset = "0x1E0A2F0", VA = "0x181E0B6F0")]
			private string _ParseTargetValueDesc(int target, int current)
			{
				return null;
			}

			// Token: 0x060235C9 RID: 144841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235C9")]
			[Address(RVA = "0x1E0B7D0", Offset = "0x1E0A3D0", VA = "0x181E0B7D0")]
			private string _ParseTargetValueDesc(float target, float current)
			{
				return null;
			}

			// Token: 0x060235CA RID: 144842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235CA")]
			[Address(RVA = "0x1E0B8C0", Offset = "0x1E0A4C0", VA = "0x181E0B8C0")]
			public CharacterLvlupAttrInfoView()
			{
			}

			// Token: 0x04030D36 RID: 199990
			[Token(Token = "0x4030D36")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _txtCurMaxHp;

			// Token: 0x04030D37 RID: 199991
			[Token(Token = "0x4030D37")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _txtTarMaxHp;

			// Token: 0x04030D38 RID: 199992
			[Token(Token = "0x4030D38")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _txtCurAtk;

			// Token: 0x04030D39 RID: 199993
			[Token(Token = "0x4030D39")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _txtTarAtk;

			// Token: 0x04030D3A RID: 199994
			[Token(Token = "0x4030D3A")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _txtCurDef;

			// Token: 0x04030D3B RID: 199995
			[Token(Token = "0x4030D3B")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _txtTarDef;

			// Token: 0x04030D3C RID: 199996
			[Token(Token = "0x4030D3C")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Text _txtCurRes;

			// Token: 0x04030D3D RID: 199997
			[Token(Token = "0x4030D3D")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Text _txtTarRes;

			// Token: 0x04030D3E RID: 199998
			[Token(Token = "0x4030D3E")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private Color _highlightAttrColor;

			// Token: 0x04030D3F RID: 199999
			[Token(Token = "0x4030D3F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04030D40 RID: 200000
			[Token(Token = "0x4030D40")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__ParseTargetValueDesc;

			// Token: 0x04030D41 RID: 200001
			[Token(Token = "0x4030D41")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix1__ParseTargetValueDesc;

			// Token: 0x04030D42 RID: 200002
			[Token(Token = "0x4030D42")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
