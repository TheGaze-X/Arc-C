using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E14 RID: 24084
	[Token(Token = "0x2005E14")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class CharSelectAttrTabItem : DataBinder<CharAttrViewProperty>
	{
		// Token: 0x06022E80 RID: 142976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E80")]
		[Address(RVA = "0x1D640A0", Offset = "0x1D62CA0", VA = "0x181D640A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022E81 RID: 142977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E81")]
		[Address(RVA = "0x1D63F10", Offset = "0x1D62B10", VA = "0x181D63F10", Slot = "7")]
		public override void OnValueChanged(CharAttrViewProperty property)
		{
		}

		// Token: 0x06022E82 RID: 142978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E82")]
		[Address(RVA = "0x1D641A0", Offset = "0x1D62DA0", VA = "0x181D641A0")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06022E83 RID: 142979 RVA: 0x000BF700 File Offset: 0x000BD900
		[Token(Token = "0x170052C0")]
		public CharAttrTabType attrTabType
		{
			[Token(Token = "0x6022E83")]
			[Address(RVA = "0x1D642A0", Offset = "0x1D62EA0", VA = "0x181D642A0")]
			get
			{
				return CharAttrTabType.SKILL;
			}
		}

		// Token: 0x06022E84 RID: 142980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E84")]
		[Address(RVA = "0x1D64230", Offset = "0x1D62E30", VA = "0x181D64230")]
		public CharSelectAttrTabItem()
		{
		}

		// Token: 0x0403011C RID: 196892
		[Token(Token = "0x403011C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharAttrTabType _tabType;

		// Token: 0x0403011D RID: 196893
		[Token(Token = "0x403011D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharSelectAttrTabItem.CharAttrTabTypeMessage onSortTypeChanged;

		// Token: 0x0403011E RID: 196894
		[Token(Token = "0x403011E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403011F RID: 196895
		[Token(Token = "0x403011F")]
		[FieldOffset(Offset = "0x38")]
		private TwoStateToggle m_twoStateToggle;

		// Token: 0x04030120 RID: 196896
		[Token(Token = "0x4030120")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030121 RID: 196897
		[Token(Token = "0x4030121")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030122 RID: 196898
		[Token(Token = "0x4030122")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x04030123 RID: 196899
		[Token(Token = "0x4030123")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_attrTabType;

		// Token: 0x04030124 RID: 196900
		[Token(Token = "0x4030124")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E15 RID: 24085
		[Token(Token = "0x2005E15")]
		[Serializable]
		public class CharAttrTabTypeMessage : UnityEvent<CharAttrTabType>
		{
			// Token: 0x06022E85 RID: 142981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E85")]
			[Address(RVA = "0x1D60570", Offset = "0x1D5F170", VA = "0x181D60570")]
			public CharAttrTabTypeMessage()
			{
			}
		}
	}
}
