using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003536 RID: 13622
	[Token(Token = "0x2003536")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class UICharacterFilterItemOnFloat : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015B67 RID: 88935 RVA: 0x0008D9A8 File Offset: 0x0008BBA8
		[Token(Token = "0x6015B67")]
		[Address(RVA = "0xE4E6F0", Offset = "0xE4D2F0", VA = "0x180E4E6F0")]
		public bool NotifyFilterTypeChanged(List<CharacterFilterIdent> selectedFilters)
		{
			return default(bool);
		}

		// Token: 0x06015B68 RID: 88936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B68")]
		[Address(RVA = "0xE4E9A0", Offset = "0xE4D5A0", VA = "0x180E4E9A0")]
		private void _OnToggleClick(TwoStateToggle.State state)
		{
		}

		// Token: 0x06015B69 RID: 88937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B69")]
		[Address(RVA = "0xE4E8A0", Offset = "0xE4D4A0", VA = "0x180E4E8A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015B6A RID: 88938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B6A")]
		[Address(RVA = "0xE4EA30", Offset = "0xE4D630", VA = "0x180E4EA30")]
		public UICharacterFilterItemOnFloat()
		{
		}

		// Token: 0x0401A160 RID: 106848
		[Token(Token = "0x401A160")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("filter when selected")]
		private CharacterFilterElement _filter;

		// Token: 0x0401A161 RID: 106849
		[Token(Token = "0x401A161")]
		[FieldOffset(Offset = "0x20")]
		private TwoStateToggle m_toggle;

		// Token: 0x0401A162 RID: 106850
		[Token(Token = "0x401A162")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401A163 RID: 106851
		[Token(Token = "0x401A163")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<CharacterFilterElement, bool> onFilterChanged;

		// Token: 0x0401A164 RID: 106852
		[Token(Token = "0x401A164")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyFilterTypeChanged;

		// Token: 0x0401A165 RID: 106853
		[Token(Token = "0x401A165")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnToggleClick;

		// Token: 0x0401A166 RID: 106854
		[Token(Token = "0x401A166")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A167 RID: 106855
		[Token(Token = "0x401A167")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
