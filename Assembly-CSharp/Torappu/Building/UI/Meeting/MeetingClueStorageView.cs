using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D70 RID: 7536
	[Token(Token = "0x2001D70")]
	public class MeetingClueStorageView : MonoBehaviour
	{
		// Token: 0x0600BA2F RID: 47663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2F")]
		[Address(RVA = "0x337CF80", Offset = "0x337BB80", VA = "0x18337CF80")]
		public void Setup(IMeetingSession session, int category, [Optional] Action<IMeetingClue, MeetingClueItemView> clickCallback, [Optional] Action<IMeetingClue, MeetingClueItemView> removeClickCallback, [Optional] Action<IMeetingClue, MeetingClueItemView> unequipClickCallback)
		{
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x00045B28 File Offset: 0x00043D28
		[Token(Token = "0x600BA30")]
		[Address(RVA = "0x337D520", Offset = "0x337C120", VA = "0x18337D520")]
		private bool _ClueFilterPredicate(IMeetingClue clue)
		{
			return default(bool);
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA31")]
		[Address(RVA = "0x337CB30", Offset = "0x337B730", VA = "0x18337CB30")]
		public void RefreshClueCountLabel()
		{
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA32")]
		[Address(RVA = "0x337CEE0", Offset = "0x337BAE0", VA = "0x18337CEE0")]
		public void RefreshClueList(bool rebuild)
		{
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA33")]
		[Address(RVA = "0x337D750", Offset = "0x337C350", VA = "0x18337D750")]
		private void _SetupClueList([Optional] Predicate<IMeetingClue> pred)
		{
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA34")]
		[Address(RVA = "0x337D6B0", Offset = "0x337C2B0", VA = "0x18337D6B0")]
		private void _OnSourceTogglePressed(int index)
		{
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA35")]
		[Address(RVA = "0x337D5F0", Offset = "0x337C1F0", VA = "0x18337D5F0")]
		private void _OnCategoryTogglePressed(int index)
		{
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA36")]
		[Address(RVA = "0x337C910", Offset = "0x337B510", VA = "0x18337C910")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA37")]
		[Address(RVA = "0x337C150", Offset = "0x337AD50", VA = "0x18337C150")]
		private void _OnCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA38")]
		[Address(RVA = "0x337D690", Offset = "0x337C290", VA = "0x18337D690")]
		private void _OnClueRemovePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA39")]
		[Address(RVA = "0x337B230", Offset = "0x3379E30", VA = "0x18337B230")]
		private void _OnClueUnequipPressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueStorageView()
		{
		}

		// Token: 0x0400B912 RID: 47378
		[Token(Token = "0x400B912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleButtonGroup _sourceToggleGroup;

		// Token: 0x0400B913 RID: 47379
		[Token(Token = "0x400B913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ToggleButtonGroup _categoryToggleGroup;

		// Token: 0x0400B914 RID: 47380
		[Token(Token = "0x400B914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeetingClueAdapter _clueAdapter;

		// Token: 0x0400B915 RID: 47381
		[Token(Token = "0x400B915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _localClueCountLabels;

		// Token: 0x0400B916 RID: 47382
		[Token(Token = "0x400B916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _noClueHint;

		// Token: 0x0400B917 RID: 47383
		[Token(Token = "0x400B917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IMeetingSession m_session;

		// Token: 0x0400B918 RID: 47384
		[Token(Token = "0x400B918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<IMeetingClue, MeetingClueItemView> m_clickCallback;

		// Token: 0x0400B919 RID: 47385
		[Token(Token = "0x400B919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<IMeetingClue, MeetingClueItemView> m_removeClickCallback;

		// Token: 0x0400B91A RID: 47386
		[Token(Token = "0x400B91A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<IMeetingClue, MeetingClueItemView> m_unequipClickCallback;

		// Token: 0x0400B91B RID: 47387
		[Token(Token = "0x400B91B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeetingClueStorageView.SourceFilterState m_sourceFilterState;

		// Token: 0x0400B91C RID: 47388
		[Token(Token = "0x400B91C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_categoryFilter;

		// Token: 0x02001D71 RID: 7537
		[Token(Token = "0x2001D71")]
		private enum SourceFilterState
		{
			// Token: 0x0400B91E RID: 47390
			[Token(Token = "0x400B91E")]
			None,
			// Token: 0x0400B91F RID: 47391
			[Token(Token = "0x400B91F")]
			Internal,
			// Token: 0x0400B920 RID: 47392
			[Token(Token = "0x400B920")]
			External
		}
	}
}
