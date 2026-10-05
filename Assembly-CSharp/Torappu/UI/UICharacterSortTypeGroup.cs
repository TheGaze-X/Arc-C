using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200354F RID: 13647
	[Token(Token = "0x200354F")]
	public class UICharacterSortTypeGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BF1 RID: 89073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF1")]
		[Address(RVA = "0xE55F60", Offset = "0xE54B60", VA = "0x180E55F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170033A7 RID: 13223
		// (set) Token: 0x06015BF2 RID: 89074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A7")]
		public Action<CharacterSortType> sortTypeListener
		{
			[Token(Token = "0x6015BF2")]
			[Address(RVA = "0xE56420", Offset = "0xE55020", VA = "0x180E56420")]
			set
			{
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (set) Token: 0x06015BF3 RID: 89075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A8")]
		public Action btnFilterClickListener
		{
			[Token(Token = "0x6015BF3")]
			[Address(RVA = "0xE563A0", Offset = "0xE54FA0", VA = "0x180E563A0")]
			set
			{
			}
		}

		// Token: 0x06015BF4 RID: 89076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF4")]
		[Address(RVA = "0xE55D80", Offset = "0xE54980", VA = "0x180E55D80")]
		public void Render(CharacterSortType sortType)
		{
		}

		// Token: 0x06015BF5 RID: 89077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF5")]
		[Address(RVA = "0xE55E80", Offset = "0xE54A80", VA = "0x180E55E80")]
		public void Render(CharacterCardSortTypeViewModel viewModel)
		{
		}

		// Token: 0x06015BF6 RID: 89078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF6")]
		[Address(RVA = "0xE562C0", Offset = "0xE54EC0", VA = "0x180E562C0")]
		private void _OnSortTypeChange(CharacterSortType sortType)
		{
		}

		// Token: 0x06015BF7 RID: 89079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF7")]
		[Address(RVA = "0xE56250", Offset = "0xE54E50", VA = "0x180E56250")]
		private void _OnSortPanelShow()
		{
		}

		// Token: 0x06015BF8 RID: 89080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF8")]
		[Address(RVA = "0xE55CE0", Offset = "0xE548E0", VA = "0x180E55CE0")]
		public void EventOnBtnFilterClick()
		{
		}

		// Token: 0x06015BF9 RID: 89081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BF9")]
		[Address(RVA = "0xE56340", Offset = "0xE54F40", VA = "0x180E56340")]
		public UICharacterSortTypeGroup()
		{
		}

		// Token: 0x0401A23A RID: 107066
		[Token(Token = "0x401A23A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("sort type toggles controlled by this panel")]
		private UICharacterSortTypeItem[] _sortTypeItems;

		// Token: 0x0401A23B RID: 107067
		[Token(Token = "0x401A23B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable;Custom sort type toggle")]
		private UICharacterSortTypeCustomableItem _customSortTypeItem;

		// Token: 0x0401A23C RID: 107068
		[Token(Token = "0x401A23C")]
		[FieldOffset(Offset = "0x28")]
		private Action<CharacterSortType> m_sortTypeListener;

		// Token: 0x0401A23D RID: 107069
		[Token(Token = "0x401A23D")]
		[FieldOffset(Offset = "0x30")]
		private Action m_btnFilterClickListener;

		// Token: 0x0401A23E RID: 107070
		[Token(Token = "0x401A23E")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401A23F RID: 107071
		[Token(Token = "0x401A23F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A240 RID: 107072
		[Token(Token = "0x401A240")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sortTypeListener;

		// Token: 0x0401A241 RID: 107073
		[Token(Token = "0x401A241")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_btnFilterClickListener;

		// Token: 0x0401A242 RID: 107074
		[Token(Token = "0x401A242")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A243 RID: 107075
		[Token(Token = "0x401A243")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0401A244 RID: 107076
		[Token(Token = "0x401A244")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSortTypeChange;

		// Token: 0x0401A245 RID: 107077
		[Token(Token = "0x401A245")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSortPanelShow;

		// Token: 0x0401A246 RID: 107078
		[Token(Token = "0x401A246")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnFilterClick;

		// Token: 0x0401A247 RID: 107079
		[Token(Token = "0x401A247")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003550 RID: 13648
		[Token(Token = "0x2003550")]
		[Serializable]
		public class CharacterSortTypeMessage : UnityEvent<CharacterSortType>
		{
			// Token: 0x06015BFA RID: 89082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BFA")]
			[Address(RVA = "0xE43920", Offset = "0xE42520", VA = "0x180E43920")]
			public CharacterSortTypeMessage()
			{
			}
		}
	}
}
