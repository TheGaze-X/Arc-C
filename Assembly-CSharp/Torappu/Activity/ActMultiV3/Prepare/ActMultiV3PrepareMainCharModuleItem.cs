using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200703E RID: 28734
	[Token(Token = "0x200703E")]
	public class ActMultiV3PrepareMainCharModuleItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x06028CA6 RID: 167078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CA7 RID: 167079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006064")]
		public Action<int, string> onEquipSelect
		{
			[Token(Token = "0x6028CA6")]
			[Address(RVA = "0x2432CD0", Offset = "0x24318D0", VA = "0x182432CD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028CA7")]
			[Address(RVA = "0x2432D30", Offset = "0x2431930", VA = "0x182432D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028CA8 RID: 167080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CA8")]
		[Address(RVA = "0x2432980", Offset = "0x2431580", VA = "0x182432980")]
		public void Render(int cardId, bool isSelect, ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel equipItemModel)
		{
		}

		// Token: 0x06028CA9 RID: 167081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CA9")]
		[Address(RVA = "0x2432880", Offset = "0x2431480", VA = "0x182432880")]
		public void OnEquipSelect()
		{
		}

		// Token: 0x06028CAA RID: 167082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CAA")]
		[Address(RVA = "0x2432C60", Offset = "0x2431860", VA = "0x182432C60")]
		public ActMultiV3PrepareMainCharModuleItem()
		{
		}

		// Token: 0x0403A284 RID: 238212
		[Token(Token = "0x403A284")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x0403A285 RID: 238213
		[Token(Token = "0x403A285")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403A286 RID: 238214
		[Token(Token = "0x403A286")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403A287 RID: 238215
		[Token(Token = "0x403A287")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403A288 RID: 238216
		[Token(Token = "0x403A288")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _levelGo;

		// Token: 0x0403A289 RID: 238217
		[Token(Token = "0x403A289")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x0403A28A RID: 238218
		[Token(Token = "0x403A28A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textEquipName;

		// Token: 0x0403A28B RID: 238219
		[Token(Token = "0x403A28B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x0403A28C RID: 238220
		[Token(Token = "0x403A28C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgEquipType;

		// Token: 0x0403A28D RID: 238221
		[Token(Token = "0x403A28D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403A28E RID: 238222
		[Token(Token = "0x403A28E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0403A28F RID: 238223
		[Token(Token = "0x403A28F")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cardId;

		// Token: 0x0403A290 RID: 238224
		[Token(Token = "0x403A290")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSelect;

		// Token: 0x0403A291 RID: 238225
		[Token(Token = "0x403A291")]
		[FieldOffset(Offset = "0x78")]
		private ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel m_equipModel;

		// Token: 0x0403A292 RID: 238226
		[Token(Token = "0x403A292")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A294 RID: 238228
		[Token(Token = "0x403A294")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x0403A295 RID: 238229
		[Token(Token = "0x403A295")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x0403A296 RID: 238230
		[Token(Token = "0x403A296")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A297 RID: 238231
		[Token(Token = "0x403A297")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEquipSelect;

		// Token: 0x0403A298 RID: 238232
		[Token(Token = "0x403A298")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
