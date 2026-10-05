using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E1A RID: 24090
	[Token(Token = "0x2005E1A")]
	public class CharSelectCardGroup : DataBinder<CardGroupViewProperty>
	{
		// Token: 0x06022E93 RID: 142995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E93")]
		[Address(RVA = "0x1D652D0", Offset = "0x1D63ED0", VA = "0x181D652D0")]
		public void InjectPlugin(UICharacterSelectState.IPlugin statePlugin)
		{
		}

		// Token: 0x06022E94 RID: 142996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E94")]
		[Address(RVA = "0x1D65350", Offset = "0x1D63F50", VA = "0x181D65350", Slot = "7")]
		public override void OnValueChanged(CardGroupViewProperty property)
		{
		}

		// Token: 0x06022E95 RID: 142997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E95")]
		[Address(RVA = "0x1D655E0", Offset = "0x1D641E0", VA = "0x181D655E0")]
		public CharSelectCardGroup()
		{
		}

		// Token: 0x04030153 RID: 196947
		[Token(Token = "0x4030153")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharSelectCardListAdapter _dataTargetAdapter;

		// Token: 0x04030154 RID: 196948
		[Token(Token = "0x4030154")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNoCard;

		// Token: 0x04030155 RID: 196949
		[Token(Token = "0x4030155")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNoCard;

		// Token: 0x04030156 RID: 196950
		[Token(Token = "0x4030156")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public string pageName;

		// Token: 0x04030157 RID: 196951
		[Token(Token = "0x4030157")]
		[FieldOffset(Offset = "0x40")]
		private UICharacterSelectState.IPlugin m_statePlugin;

		// Token: 0x04030158 RID: 196952
		[Token(Token = "0x4030158")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x04030159 RID: 196953
		[Token(Token = "0x4030159")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403015A RID: 196954
		[Token(Token = "0x403015A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
