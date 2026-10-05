using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003552 RID: 13650
	[Token(Token = "0x2003552")]
	[RequireComponent(typeof(ThreeStateToggle))]
	public class UICharacterSortTypeItem : UICharacterSortCommonItem
	{
		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x06015C00 RID: 89088 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015C01 RID: 89089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A9")]
		public Action<CharacterSortType> onSortTypeChanged
		{
			[Token(Token = "0x6015C00")]
			[Address(RVA = "0xE56BC0", Offset = "0xE557C0", VA = "0x180E56BC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6015C01")]
			[Address(RVA = "0xE56C20", Offset = "0xE55820", VA = "0x180E56C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06015C02 RID: 89090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C02")]
		[Address(RVA = "0xE568C0", Offset = "0xE554C0", VA = "0x180E568C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C03 RID: 89091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C03")]
		[Address(RVA = "0xE569E0", Offset = "0xE555E0", VA = "0x180E569E0")]
		private void _OnToggleClick(ThreeStateToggle.State state)
		{
		}

		// Token: 0x06015C04 RID: 89092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C04")]
		[Address(RVA = "0xE56650", Offset = "0xE55250", VA = "0x180E56650", Slot = "4")]
		public override void RenderSortItem(CharacterSortTypePair sortPair, bool lightMode)
		{
		}

		// Token: 0x06015C05 RID: 89093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C05")]
		[Address(RVA = "0xE564A0", Offset = "0xE550A0", VA = "0x180E564A0", Slot = "5")]
		public override void NotifySortTypeChanged(CharacterSortType sortType)
		{
		}

		// Token: 0x06015C06 RID: 89094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C06")]
		[Address(RVA = "0xE56AF0", Offset = "0xE556F0", VA = "0x180E56AF0")]
		public UICharacterSortTypeItem()
		{
		}

		// Token: 0x0401A252 RID: 107090
		[Token(Token = "0x401A252")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("sort type when first clicked")]
		private CharacterSortType _firstSortType;

		// Token: 0x0401A253 RID: 107091
		[Token(Token = "0x401A253")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("sort type when clicked again")]
		private CharacterSortType _secondSortType;

		// Token: 0x0401A254 RID: 107092
		[Token(Token = "0x401A254")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _sortTitles;

		// Token: 0x0401A255 RID: 107093
		[Token(Token = "0x401A255")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("note there're 3 icons")]
		private Image[] _sortIcons;

		// Token: 0x0401A256 RID: 107094
		[Token(Token = "0x401A256")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lightMask;

		// Token: 0x0401A257 RID: 107095
		[Token(Token = "0x401A257")]
		[FieldOffset(Offset = "0x38")]
		private string m_pageName;

		// Token: 0x0401A258 RID: 107096
		[Token(Token = "0x401A258")]
		[FieldOffset(Offset = "0x40")]
		private ThreeStateToggle m_toggle;

		// Token: 0x0401A259 RID: 107097
		[Token(Token = "0x401A259")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401A25B RID: 107099
		[Token(Token = "0x401A25B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSortTypeChanged;

		// Token: 0x0401A25C RID: 107100
		[Token(Token = "0x401A25C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSortTypeChanged;

		// Token: 0x0401A25D RID: 107101
		[Token(Token = "0x401A25D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A25E RID: 107102
		[Token(Token = "0x401A25E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggleClick;

		// Token: 0x0401A25F RID: 107103
		[Token(Token = "0x401A25F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderSortItem;

		// Token: 0x0401A260 RID: 107104
		[Token(Token = "0x401A260")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifySortTypeChanged;

		// Token: 0x0401A261 RID: 107105
		[Token(Token = "0x401A261")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
