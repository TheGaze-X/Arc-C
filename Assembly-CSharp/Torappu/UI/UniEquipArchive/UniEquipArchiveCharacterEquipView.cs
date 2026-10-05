using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE5 RID: 15333
	[Token(Token = "0x2003BE5")]
	public class UniEquipArchiveCharacterEquipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017FE6 RID: 98278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE6")]
		[Address(RVA = "0x1060110", Offset = "0x105ED10", VA = "0x181060110")]
		public void Render(UniEquipArchiveEquipTypeViewModel viewModel)
		{
		}

		// Token: 0x06017FE7 RID: 98279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE7")]
		[Address(RVA = "0x1060420", Offset = "0x105F020", VA = "0x181060420")]
		private void _ActivateIcon(bool haveIcon, bool isLocked)
		{
		}

		// Token: 0x06017FE8 RID: 98280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE8")]
		[Address(RVA = "0x10600A0", Offset = "0x105ECA0", VA = "0x1810600A0")]
		public void OnEquipClick()
		{
		}

		// Token: 0x06017FE9 RID: 98281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE9")]
		[Address(RVA = "0x10604E0", Offset = "0x105F0E0", VA = "0x1810604E0")]
		public UniEquipArchiveCharacterEquipView()
		{
		}

		// Token: 0x0401D0D5 RID: 118997
		[Token(Token = "0x401D0D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401D0D6 RID: 118998
		[Token(Token = "0x401D0D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSingleType;

		// Token: 0x0401D0D7 RID: 118999
		[Token(Token = "0x401D0D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMultiType;

		// Token: 0x0401D0D8 RID: 119000
		[Token(Token = "0x401D0D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _uniEquipSingleTypeDesc;

		// Token: 0x0401D0D9 RID: 119001
		[Token(Token = "0x401D0D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _uniEquipMultiTypeDesc;

		// Token: 0x0401D0DA RID: 119002
		[Token(Token = "0x401D0DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _uniEquipMultiTypeDescImg;

		// Token: 0x0401D0DB RID: 119003
		[Token(Token = "0x401D0DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x0401D0DC RID: 119004
		[Token(Token = "0x401D0DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _haveIconPart;

		// Token: 0x0401D0DD RID: 119005
		[Token(Token = "0x401D0DD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _noIconPart;

		// Token: 0x0401D0DE RID: 119006
		[Token(Token = "0x401D0DE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _lockPart;

		// Token: 0x0401D0DF RID: 119007
		[Token(Token = "0x401D0DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLevel;

		// Token: 0x0401D0E0 RID: 119008
		[Token(Token = "0x401D0E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401D0E1 RID: 119009
		[Token(Token = "0x401D0E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _initialIconColor;

		// Token: 0x0401D0E2 RID: 119010
		[Token(Token = "0x401D0E2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _advancedIconColor;

		// Token: 0x0401D0E3 RID: 119011
		[Token(Token = "0x401D0E3")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action onEquipClick;

		// Token: 0x0401D0E4 RID: 119012
		[Token(Token = "0x401D0E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D0E5 RID: 119013
		[Token(Token = "0x401D0E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ActivateIcon;

		// Token: 0x0401D0E6 RID: 119014
		[Token(Token = "0x401D0E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEquipClick;

		// Token: 0x0401D0E7 RID: 119015
		[Token(Token = "0x401D0E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
