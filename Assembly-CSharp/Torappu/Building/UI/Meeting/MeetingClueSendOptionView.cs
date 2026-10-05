using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D6E RID: 7534
	[Token(Token = "0x2001D6E")]
	public class MeetingClueSendOptionView : MonoBehaviour
	{
		// Token: 0x0600BA1F RID: 47647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1F")]
		[Address(RVA = "0x337BD70", Offset = "0x337A970", VA = "0x18337BD70")]
		public void SetSelectedClue(IMeetingClue clue)
		{
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA20")]
		[Address(RVA = "0x337BE10", Offset = "0x337AA10", VA = "0x18337BE10")]
		public void Setup(IMeetingSession session, int category, [Optional] Action<int> clickFilterCallback, [Optional] Action<IMeetingClue, MeetingClueItemView> clickClueItemCallback)
		{
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x00045AE0 File Offset: 0x00043CE0
		[Token(Token = "0x600BA21")]
		[Address(RVA = "0x337C050", Offset = "0x337AC50", VA = "0x18337C050")]
		private bool _ClueFilterPredicate(IMeetingClue clue)
		{
			return default(bool);
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x00045AF8 File Offset: 0x00043CF8
		[Token(Token = "0x600BA22")]
		[Address(RVA = "0x337BB80", Offset = "0x337A780", VA = "0x18337BB80")]
		public bool CheckAbleToAutoSend()
		{
			return default(bool);
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA23")]
		[Address(RVA = "0x337BCF0", Offset = "0x337A8F0", VA = "0x18337BCF0")]
		public void RefreshClueList()
		{
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA24")]
		[Address(RVA = "0x337C170", Offset = "0x337AD70", VA = "0x18337C170")]
		private void _SetupClueList([Optional] Predicate<IMeetingClue> pred)
		{
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA25")]
		[Address(RVA = "0x337C100", Offset = "0x337AD00", VA = "0x18337C100")]
		private void _OnCategoryTogglePressed(int index)
		{
		}

		// Token: 0x0600BA26 RID: 47654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA26")]
		[Address(RVA = "0x337BBE0", Offset = "0x337A7E0", VA = "0x18337BBE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA27")]
		[Address(RVA = "0x337C150", Offset = "0x337AD50", VA = "0x18337C150")]
		private void _OnCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA28")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueSendOptionView()
		{
		}

		// Token: 0x0400B8FE RID: 47358
		[Token(Token = "0x400B8FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleButtonGroup _categoryToggleGroup;

		// Token: 0x0400B8FF RID: 47359
		[Token(Token = "0x400B8FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeetingClueAdapter _clueAdapter;

		// Token: 0x0400B900 RID: 47360
		[Token(Token = "0x400B900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyHint;

		// Token: 0x0400B901 RID: 47361
		[Token(Token = "0x400B901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textClueOwned;

		// Token: 0x0400B902 RID: 47362
		[Token(Token = "0x400B902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IMeetingSession m_session;

		// Token: 0x0400B903 RID: 47363
		[Token(Token = "0x400B903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<int> m_clickClueFilterCallback;

		// Token: 0x0400B904 RID: 47364
		[Token(Token = "0x400B904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<IMeetingClue, MeetingClueItemView> m_clickClueItemCallback;

		// Token: 0x0400B905 RID: 47365
		[Token(Token = "0x400B905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_categoryFilter;
	}
}
