using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006377 RID: 25463
	[Token(Token = "0x2006377")]
	public class AutoChessCharCardModuleSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x06024BC5 RID: 150469 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024BC6 RID: 150470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056BB")]
		public Action<string, int, string> onEquipSelect
		{
			[Token(Token = "0x6024BC5")]
			[Address(RVA = "0x1F975B0", Offset = "0x1F961B0", VA = "0x181F975B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024BC6")]
			[Address(RVA = "0x1F97610", Offset = "0x1F96210", VA = "0x181F97610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024BC7 RID: 150471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BC7")]
		[Address(RVA = "0x1F97230", Offset = "0x1F95E30", VA = "0x181F97230")]
		public void Render(string chessId, int chessLv, bool isSelect, AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel equipItemModel)
		{
		}

		// Token: 0x06024BC8 RID: 150472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BC8")]
		[Address(RVA = "0x1F97120", Offset = "0x1F95D20", VA = "0x181F97120")]
		public void OnEquipSelect()
		{
		}

		// Token: 0x06024BC9 RID: 150473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BC9")]
		[Address(RVA = "0x1F97540", Offset = "0x1F96140", VA = "0x181F97540")]
		public AutoChessCharCardModuleSelectItem()
		{
		}

		// Token: 0x040334E1 RID: 210145
		[Token(Token = "0x40334E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x040334E2 RID: 210146
		[Token(Token = "0x40334E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconSelectGo;

		// Token: 0x040334E3 RID: 210147
		[Token(Token = "0x40334E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x040334E4 RID: 210148
		[Token(Token = "0x40334E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x040334E5 RID: 210149
		[Token(Token = "0x40334E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x040334E6 RID: 210150
		[Token(Token = "0x40334E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _levelGo;

		// Token: 0x040334E7 RID: 210151
		[Token(Token = "0x40334E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x040334E8 RID: 210152
		[Token(Token = "0x40334E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textEquipName;

		// Token: 0x040334E9 RID: 210153
		[Token(Token = "0x40334E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x040334EA RID: 210154
		[Token(Token = "0x40334EA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgEquipType;

		// Token: 0x040334EB RID: 210155
		[Token(Token = "0x40334EB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040334EC RID: 210156
		[Token(Token = "0x40334EC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x040334ED RID: 210157
		[Token(Token = "0x40334ED")]
		[FieldOffset(Offset = "0x78")]
		private string m_chessId;

		// Token: 0x040334EE RID: 210158
		[Token(Token = "0x40334EE")]
		[FieldOffset(Offset = "0x80")]
		private int m_chessLv;

		// Token: 0x040334EF RID: 210159
		[Token(Token = "0x40334EF")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessMultiCharSkillEquipEditItemViewModel.EquipItemViewModel m_equipModel;

		// Token: 0x040334F0 RID: 210160
		[Token(Token = "0x40334F0")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040334F2 RID: 210162
		[Token(Token = "0x40334F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x040334F3 RID: 210163
		[Token(Token = "0x40334F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x040334F4 RID: 210164
		[Token(Token = "0x40334F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040334F5 RID: 210165
		[Token(Token = "0x40334F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEquipSelect;

		// Token: 0x040334F6 RID: 210166
		[Token(Token = "0x40334F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
