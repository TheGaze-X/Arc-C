using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007946 RID: 31046
	[Token(Token = "0x2007946")]
	public class Act1ArcadeEntryGameEntryItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B8F6 RID: 178422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F6")]
		[Address(RVA = "0x2774330", Offset = "0x2772F30", VA = "0x182774330")]
		public void Render(Act1ArcadeEntryGameEntryItemViewModel viewModel)
		{
		}

		// Token: 0x0602B8F7 RID: 178423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F7")]
		[Address(RVA = "0x27740F0", Offset = "0x2772CF0", VA = "0x1827740F0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B8F8 RID: 178424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F8")]
		[Address(RVA = "0x27747C0", Offset = "0x27733C0", VA = "0x1827747C0")]
		public Act1ArcadeEntryGameEntryItemView()
		{
		}

		// Token: 0x0403F018 RID: 258072
		[Token(Token = "0x403F018")]
		private const int SCORE_NUM_DIGIT_CNT = 7;

		// Token: 0x0403F019 RID: 258073
		[Token(Token = "0x403F019")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _scoreTxt;

		// Token: 0x0403F01A RID: 258074
		[Token(Token = "0x403F01A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameTxt;

		// Token: 0x0403F01B RID: 258075
		[Token(Token = "0x403F01B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _lockHintText;

		// Token: 0x0403F01C RID: 258076
		[Token(Token = "0x403F01C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _endHintText;

		// Token: 0x0403F01D RID: 258077
		[Token(Token = "0x403F01D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normPanel;

		// Token: 0x0403F01E RID: 258078
		[Token(Token = "0x403F01E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x0403F01F RID: 258079
		[Token(Token = "0x403F01F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _actClosePanel;

		// Token: 0x0403F020 RID: 258080
		[Token(Token = "0x403F020")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _newObj;

		// Token: 0x0403F021 RID: 258081
		[Token(Token = "0x403F021")]
		[FieldOffset(Offset = "0x58")]
		private Act1ArcadeEntryGameEntryItemViewModel m_cachedViewModel;

		// Token: 0x0403F022 RID: 258082
		[Token(Token = "0x403F022")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403F023 RID: 258083
		[Token(Token = "0x403F023")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> notifyToastAction;

		// Token: 0x0403F024 RID: 258084
		[Token(Token = "0x403F024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F025 RID: 258085
		[Token(Token = "0x403F025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403F026 RID: 258086
		[Token(Token = "0x403F026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
