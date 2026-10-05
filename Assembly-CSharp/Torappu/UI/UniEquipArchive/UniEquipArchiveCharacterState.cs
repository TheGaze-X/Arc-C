using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BD7 RID: 15319
	[Token(Token = "0x2003BD7")]
	public class UniEquipArchiveCharacterState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06017F8D RID: 98189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F8D")]
		[Address(RVA = "0x10614A0", Offset = "0x10600A0", VA = "0x1810614A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017F8E RID: 98190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F8E")]
		[Address(RVA = "0x1060E60", Offset = "0x105FA60", VA = "0x181060E60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017F8F RID: 98191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F8F")]
		[Address(RVA = "0x1061400", Offset = "0x1060000", VA = "0x181061400", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06017F90 RID: 98192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F90")]
		[Address(RVA = "0x1060F40", Offset = "0x105FB40", VA = "0x181060F40", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06017F91 RID: 98193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F91")]
		[Address(RVA = "0x1061A60", Offset = "0x1060660", VA = "0x181061A60")]
		private void _OnEquipClick(int chrInstId)
		{
		}

		// Token: 0x06017F92 RID: 98194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F92")]
		[Address(RVA = "0x10618D0", Offset = "0x10604D0", VA = "0x1810618D0")]
		private void _OnCharClick(int chrInstId)
		{
		}

		// Token: 0x06017F93 RID: 98195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F93")]
		[Address(RVA = "0x1061B50", Offset = "0x1060750", VA = "0x181061B50")]
		private void _OnSortClick(int msg)
		{
		}

		// Token: 0x06017F94 RID: 98196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F94")]
		[Address(RVA = "0x1061C30", Offset = "0x1060830", VA = "0x181061C30")]
		private void _OnStarMarkClick(int msg)
		{
		}

		// Token: 0x06017F95 RID: 98197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F95")]
		[Address(RVA = "0x1061D10", Offset = "0x1060910", VA = "0x181061D10")]
		private void _UpdateData()
		{
		}

		// Token: 0x06017F96 RID: 98198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F96")]
		[Address(RVA = "0x1061860", Offset = "0x1060460", VA = "0x181061860")]
		private void _InitView()
		{
		}

		// Token: 0x06017F97 RID: 98199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017F97")]
		[Address(RVA = "0x1060E00", Offset = "0x105FA00", VA = "0x181060E00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017F98 RID: 98200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F98")]
		[Address(RVA = "0x1062010", Offset = "0x1060C10", VA = "0x181062010")]
		public UniEquipArchiveCharacterState()
		{
		}

		// Token: 0x06017F99 RID: 98201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F99")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06017F9A RID: 98202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F9A")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0401D04F RID: 118863
		[Token(Token = "0x401D04F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipArchiveCharacterView _view;

		// Token: 0x0401D050 RID: 118864
		[Token(Token = "0x401D050")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _filterContainer;

		// Token: 0x0401D051 RID: 118865
		[Token(Token = "0x401D051")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _equipFilterContainer;

		// Token: 0x0401D052 RID: 118866
		[Token(Token = "0x401D052")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UniEquipArchiveFilterHolder _equipFilterPrefab;

		// Token: 0x0401D053 RID: 118867
		[Token(Token = "0x401D053")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0401D054 RID: 118868
		[Token(Token = "0x401D054")]
		[FieldOffset(Offset = "0x98")]
		private UniEquipArchiveCharacterState.ProfessionFilterHandler m_profFilterHandler;

		// Token: 0x0401D055 RID: 118869
		[Token(Token = "0x401D055")]
		[FieldOffset(Offset = "0xA0")]
		private UniEquipArchiveCharacterState.EquipFilterHandler m_equipFilterHandler;

		// Token: 0x0401D056 RID: 118870
		[Token(Token = "0x401D056")]
		[FieldOffset(Offset = "0xA8")]
		private UICharacterProfessionFilterHolder m_profFilterHolder;

		// Token: 0x0401D057 RID: 118871
		[Token(Token = "0x401D057")]
		[FieldOffset(Offset = "0xB0")]
		private UniEquipArchiveFilterHolder m_equipFilterHolder;

		// Token: 0x0401D058 RID: 118872
		[Token(Token = "0x401D058")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<string> m_validSubProfs;

		// Token: 0x0401D059 RID: 118873
		[Token(Token = "0x401D059")]
		[FieldOffset(Offset = "0xC0")]
		private UniEquipArchiveCharacterStateBean m_stateBean;

		// Token: 0x0401D05A RID: 118874
		[Token(Token = "0x401D05A")]
		[NonSerialized]
		public const int ON_EQUIP_CLICK = 0;

		// Token: 0x0401D05B RID: 118875
		[Token(Token = "0x401D05B")]
		[NonSerialized]
		public const int ON_CHAR_CLICK = 1;

		// Token: 0x0401D05C RID: 118876
		[Token(Token = "0x401D05C")]
		[NonSerialized]
		public const int ON_SORT_CLICK = 2;

		// Token: 0x0401D05D RID: 118877
		[Token(Token = "0x401D05D")]
		[NonSerialized]
		public const int ON_STAR_MARK_CLICK = 3;

		// Token: 0x0401D05E RID: 118878
		[Token(Token = "0x401D05E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D05F RID: 118879
		[Token(Token = "0x401D05F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D060 RID: 118880
		[Token(Token = "0x401D060")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0401D061 RID: 118881
		[Token(Token = "0x401D061")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D062 RID: 118882
		[Token(Token = "0x401D062")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnEquipClick;

		// Token: 0x0401D063 RID: 118883
		[Token(Token = "0x401D063")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCharClick;

		// Token: 0x0401D064 RID: 118884
		[Token(Token = "0x401D064")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSortClick;

		// Token: 0x0401D065 RID: 118885
		[Token(Token = "0x401D065")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStarMarkClick;

		// Token: 0x0401D066 RID: 118886
		[Token(Token = "0x401D066")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0401D067 RID: 118887
		[Token(Token = "0x401D067")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x0401D068 RID: 118888
		[Token(Token = "0x401D068")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D069 RID: 118889
		[Token(Token = "0x401D069")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BD8 RID: 15320
		[Token(Token = "0x2003BD8")]
		private class ProfessionFilterHandler : UICharacterProfessionFilterHolder.IProfFilterHandler, UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06017F9B RID: 98203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F9B")]
			[Address(RVA = "0x105F2B0", Offset = "0x105DEB0", VA = "0x18105F2B0")]
			public ProfessionFilterHandler(UniEquipArchiveCharacterState closure)
			{
			}

			// Token: 0x06017F9C RID: 98204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F9C")]
			[Address(RVA = "0x105F0A0", Offset = "0x105DCA0", VA = "0x18105F0A0", Slot = "5")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x06017F9D RID: 98205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F9D")]
			[Address(RVA = "0x105F250", Offset = "0x105DE50", VA = "0x18105F250", Slot = "4")]
			public void OnProfPanelChanged(bool isShow)
			{
			}

			// Token: 0x0401D06A RID: 118890
			[Token(Token = "0x401D06A")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveCharacterState m_closure;

			// Token: 0x0401D06B RID: 118891
			[Token(Token = "0x401D06B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D06C RID: 118892
			[Token(Token = "0x401D06C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;

			// Token: 0x0401D06D RID: 118893
			[Token(Token = "0x401D06D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnProfPanelChanged;
		}

		// Token: 0x02003BD9 RID: 15321
		[Token(Token = "0x2003BD9")]
		private class EquipFilterHandler : UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06017F9E RID: 98206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F9E")]
			[Address(RVA = "0x105E930", Offset = "0x105D530", VA = "0x18105E930")]
			public EquipFilterHandler(UniEquipArchiveCharacterState closure)
			{
			}

			// Token: 0x06017F9F RID: 98207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F9F")]
			[Address(RVA = "0x105E780", Offset = "0x105D380", VA = "0x18105E780", Slot = "4")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x0401D06E RID: 118894
			[Token(Token = "0x401D06E")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveCharacterState m_closure;

			// Token: 0x0401D06F RID: 118895
			[Token(Token = "0x401D06F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D070 RID: 118896
			[Token(Token = "0x401D070")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;
		}
	}
}
