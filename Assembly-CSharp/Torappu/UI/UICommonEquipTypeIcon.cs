using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B7F RID: 15231
	[Token(Token = "0x2003B7F")]
	public class UICommonEquipTypeIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x06017E15 RID: 97813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003904")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x6017E15")]
			[Address(RVA = "0x1022E10", Offset = "0x1021A10", VA = "0x181022E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017E16 RID: 97814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E16")]
		[Address(RVA = "0x1022B20", Offset = "0x1021720", VA = "0x181022B20")]
		public void Render(UniEquipData data, bool haveFlag, bool showDesc = true, bool showShining = true, bool showBack = true)
		{
		}

		// Token: 0x06017E17 RID: 97815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E17")]
		[Address(RVA = "0x1022A80", Offset = "0x1021680", VA = "0x181022A80")]
		public void PlayAnim()
		{
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E18")]
		[Address(RVA = "0x1022D80", Offset = "0x1021980", VA = "0x181022D80")]
		public UICommonEquipTypeIcon()
		{
		}

		// Token: 0x0401CDB9 RID: 118201
		[Token(Token = "0x401CDB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon1;

		// Token: 0x0401CDBA RID: 118202
		[Token(Token = "0x401CDBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon2;

		// Token: 0x0401CDBB RID: 118203
		[Token(Token = "0x401CDBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _shiningImg;

		// Token: 0x0401CDBC RID: 118204
		[Token(Token = "0x401CDBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSingleType;

		// Token: 0x0401CDBD RID: 118205
		[Token(Token = "0x401CDBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelMultiType;

		// Token: 0x0401CDBE RID: 118206
		[Token(Token = "0x401CDBE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _uniEquipSingleTypeDesc;

		// Token: 0x0401CDBF RID: 118207
		[Token(Token = "0x401CDBF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _uniEquipMultiTypeDesc;

		// Token: 0x0401CDC0 RID: 118208
		[Token(Token = "0x401CDC0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _uniEquipMultiTypeDescImg;

		// Token: 0x0401CDC1 RID: 118209
		[Token(Token = "0x401CDC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _animHaveWrapper;

		// Token: 0x0401CDC2 RID: 118210
		[Token(Token = "0x401CDC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x0401CDC3 RID: 118211
		[Token(Token = "0x401CDC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401CDC4 RID: 118212
		[Token(Token = "0x401CDC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _haveIconPart;

		// Token: 0x0401CDC5 RID: 118213
		[Token(Token = "0x401CDC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _noIconPart;

		// Token: 0x0401CDC6 RID: 118214
		[Token(Token = "0x401CDC6")]
		[FieldOffset(Offset = "0x80")]
		private string ANIM_HAVE_PARAM;

		// Token: 0x0401CDC7 RID: 118215
		[Token(Token = "0x401CDC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0401CDC8 RID: 118216
		[Token(Token = "0x401CDC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CDC9 RID: 118217
		[Token(Token = "0x401CDC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0401CDCA RID: 118218
		[Token(Token = "0x401CDCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
