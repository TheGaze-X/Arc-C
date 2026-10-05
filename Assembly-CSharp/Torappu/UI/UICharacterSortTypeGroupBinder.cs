using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003551 RID: 13649
	[Token(Token = "0x2003551")]
	public class UICharacterSortTypeGroupBinder : DataBinder<CharacterCardSortTypeViewProperty>, IHotfixable
	{
		// Token: 0x06015BFB RID: 89083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BFB")]
		[Address(RVA = "0xE559F0", Offset = "0xE545F0", VA = "0x180E559F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BFC RID: 89084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BFC")]
		[Address(RVA = "0xE55770", Offset = "0xE54370", VA = "0x180E55770", Slot = "7")]
		public override void OnValueChanged(CharacterCardSortTypeViewProperty property)
		{
		}

		// Token: 0x06015BFD RID: 89085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BFD")]
		[Address(RVA = "0xE55C70", Offset = "0xE54870", VA = "0x180E55C70")]
		public UICharacterSortTypeGroupBinder()
		{
		}

		// Token: 0x0401A248 RID: 107080
		[Token(Token = "0x401A248")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _groupHolder;

		// Token: 0x0401A249 RID: 107081
		[Token(Token = "0x401A249")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterSortTypeGroup _sortGroupPrefab;

		// Token: 0x0401A24A RID: 107082
		[Token(Token = "0x401A24A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _eventBtnFilterClick;

		// Token: 0x0401A24B RID: 107083
		[Token(Token = "0x401A24B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSortTypeGroup.CharacterSortTypeMessage _eventSortTypeChange;

		// Token: 0x0401A24C RID: 107084
		[Token(Token = "0x401A24C")]
		[FieldOffset(Offset = "0x40")]
		private CharacterSortType? m_dataCache;

		// Token: 0x0401A24D RID: 107085
		[Token(Token = "0x401A24D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401A24E RID: 107086
		[Token(Token = "0x401A24E")]
		[FieldOffset(Offset = "0x50")]
		private UICharacterSortTypeGroup m_sortTypeGroup;

		// Token: 0x0401A24F RID: 107087
		[Token(Token = "0x401A24F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A250 RID: 107088
		[Token(Token = "0x401A250")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A251 RID: 107089
		[Token(Token = "0x401A251")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
