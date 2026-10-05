using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B87 RID: 15239
	[Token(Token = "0x2003B87")]
	public class UICommonClickableEquipTypeIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x06017E26 RID: 97830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017E27 RID: 97831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700390A")]
		public Action<string> onEquipClicked
		{
			[Token(Token = "0x6017E26")]
			[Address(RVA = "0x10229A0", Offset = "0x10215A0", VA = "0x1810229A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6017E27")]
			[Address(RVA = "0x1022A00", Offset = "0x1021600", VA = "0x181022A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06017E28 RID: 97832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E28")]
		[Address(RVA = "0x1022310", Offset = "0x1020F10", VA = "0x181022310")]
		public void Render(UIClickableEquipItemModel equipModel, bool isSelected, UICommonClickableEquipTypeIcon.InputParam param)
		{
		}

		// Token: 0x06017E29 RID: 97833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E29")]
		[Address(RVA = "0x1022850", Offset = "0x1021450", VA = "0x181022850")]
		private void _SetEquipItemShowType(bool isEmpty, bool isUnlock, bool isSelected)
		{
		}

		// Token: 0x06017E2A RID: 97834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E2A")]
		[Address(RVA = "0x1022220", Offset = "0x1020E20", VA = "0x181022220")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06017E2B RID: 97835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E2B")]
		[Address(RVA = "0x1022930", Offset = "0x1021530", VA = "0x181022930")]
		public UICommonClickableEquipTypeIcon()
		{
		}

		// Token: 0x0401CDDF RID: 118239
		[Token(Token = "0x401CDDF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0401CDE0 RID: 118240
		[Token(Token = "0x401CDE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0401CDE1 RID: 118241
		[Token(Token = "0x401CDE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0401CDE2 RID: 118242
		[Token(Token = "0x401CDE2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedPartGo;

		// Token: 0x0401CDE3 RID: 118243
		[Token(Token = "0x401CDE3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x0401CDE4 RID: 118244
		[Token(Token = "0x401CDE4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgShining;

		// Token: 0x0401CDE5 RID: 118245
		[Token(Token = "0x401CDE5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSingleType;

		// Token: 0x0401CDE6 RID: 118246
		[Token(Token = "0x401CDE6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMultiType;

		// Token: 0x0401CDE7 RID: 118247
		[Token(Token = "0x401CDE7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textSingleTypeDesc;

		// Token: 0x0401CDE8 RID: 118248
		[Token(Token = "0x401CDE8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textMultiTypeDesc;

		// Token: 0x0401CDE9 RID: 118249
		[Token(Token = "0x401CDE9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgMultiType;

		// Token: 0x0401CDEA RID: 118250
		[Token(Token = "0x401CDEA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401CDEB RID: 118251
		[Token(Token = "0x401CDEB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _levelPanelGo;

		// Token: 0x0401CDEC RID: 118252
		[Token(Token = "0x401CDEC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0401CDED RID: 118253
		[Token(Token = "0x401CDED")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _imgBack;

		// Token: 0x0401CDEE RID: 118254
		[Token(Token = "0x401CDEE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401CDEF RID: 118255
		[Token(Token = "0x401CDEF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0401CDF0 RID: 118256
		[Token(Token = "0x401CDF0")]
		[FieldOffset(Offset = "0xA0")]
		private UIClickableEquipItemModel m_equipModel;

		// Token: 0x0401CDF2 RID: 118258
		[Token(Token = "0x401CDF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEquipClicked;

		// Token: 0x0401CDF3 RID: 118259
		[Token(Token = "0x401CDF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEquipClicked;

		// Token: 0x0401CDF4 RID: 118260
		[Token(Token = "0x401CDF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CDF5 RID: 118261
		[Token(Token = "0x401CDF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetEquipItemShowType;

		// Token: 0x0401CDF6 RID: 118262
		[Token(Token = "0x401CDF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0401CDF7 RID: 118263
		[Token(Token = "0x401CDF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B88 RID: 15240
		[Token(Token = "0x2003B88")]
		public struct InputParam
		{
			// Token: 0x0401CDF8 RID: 118264
			[Token(Token = "0x401CDF8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICommonClickableEquipTypeIcon.InputParam DEFAULT;

			// Token: 0x0401CDF9 RID: 118265
			[Token(Token = "0x401CDF9")]
			[FieldOffset(Offset = "0x0")]
			public bool showShinning;

			// Token: 0x0401CDFA RID: 118266
			[Token(Token = "0x401CDFA")]
			[FieldOffset(Offset = "0x1")]
			public bool showBack;

			// Token: 0x0401CDFB RID: 118267
			[Token(Token = "0x401CDFB")]
			[FieldOffset(Offset = "0x2")]
			public bool showLevel;
		}
	}
}
