using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage.MixStory;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007161 RID: 29025
	[Token(Token = "0x2007161")]
	public class Act9D0EntryCgBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602936B RID: 168811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936B")]
		[Address(RVA = "0x2493270", Offset = "0x2491E70", VA = "0x182493270")]
		public void Init(Act9D0StageController controller)
		{
		}

		// Token: 0x0602936C RID: 168812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936C")]
		[Address(RVA = "0x2493090", Offset = "0x2491C90", VA = "0x182493090")]
		public void EventOnCgClicked()
		{
		}

		// Token: 0x0602936D RID: 168813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936D")]
		[Address(RVA = "0x2493720", Offset = "0x2492320", VA = "0x182493720")]
		public Act9D0EntryCgBtnView()
		{
		}

		// Token: 0x0403AD6F RID: 241007
		[Token(Token = "0x403AD6F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Btn")]
		private UIButton _btn;

		// Token: 0x0403AD70 RID: 241008
		[Token(Token = "0x403AD70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Btn")]
		private Color _btnUnlockedNormalCol;

		// Token: 0x0403AD71 RID: 241009
		[Token(Token = "0x403AD71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Btn")]
		private Color _btnUnlockedHighLightCol;

		// Token: 0x0403AD72 RID: 241010
		[Token(Token = "0x403AD72")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Btn")]
		private Color _btnUnlockedPressCol;

		// Token: 0x0403AD73 RID: 241011
		[Token(Token = "0x403AD73")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Btn")]
		private Color _btnLockCol;

		// Token: 0x0403AD74 RID: 241012
		[Token(Token = "0x403AD74")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Text")]
		private Text _txtBtnName;

		// Token: 0x0403AD75 RID: 241013
		[Token(Token = "0x403AD75")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Text")]
		private Color _unlockTextCol;

		// Token: 0x0403AD76 RID: 241014
		[Token(Token = "0x403AD76")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Text")]
		private Color _lockTextCol;

		// Token: 0x0403AD77 RID: 241015
		[Token(Token = "0x403AD77")]
		[FieldOffset(Offset = "0x88")]
		private StageStorylineStorySetViewModel m_storySetViewModel;

		// Token: 0x0403AD78 RID: 241016
		[Token(Token = "0x403AD78")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isCgUnlocked;

		// Token: 0x0403AD79 RID: 241017
		[Token(Token = "0x403AD79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403AD7A RID: 241018
		[Token(Token = "0x403AD7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCgClicked;

		// Token: 0x0403AD7B RID: 241019
		[Token(Token = "0x403AD7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
