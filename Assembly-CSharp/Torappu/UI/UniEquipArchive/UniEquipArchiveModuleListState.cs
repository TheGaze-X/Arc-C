using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BDD RID: 15325
	[Token(Token = "0x2003BDD")]
	public class UniEquipArchiveModuleListState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06017FAF RID: 98223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FAF")]
		[Address(RVA = "0x10655E0", Offset = "0x10641E0", VA = "0x1810655E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017FB0 RID: 98224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB0")]
		[Address(RVA = "0x1065EF0", Offset = "0x1064AF0", VA = "0x181065EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017FB1 RID: 98225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB1")]
		[Address(RVA = "0x1065640", Offset = "0x1064240", VA = "0x181065640", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017FB2 RID: 98226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB2")]
		[Address(RVA = "0x1065E60", Offset = "0x1064A60", VA = "0x181065E60", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06017FB3 RID: 98227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB3")]
		[Address(RVA = "0x10662D0", Offset = "0x1064ED0", VA = "0x1810662D0")]
		private void _LoadData()
		{
		}

		// Token: 0x06017FB4 RID: 98228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB4")]
		[Address(RVA = "0x10669C0", Offset = "0x10655C0", VA = "0x1810669C0")]
		private void _UpdateData()
		{
		}

		// Token: 0x06017FB5 RID: 98229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB5")]
		[Address(RVA = "0x1066260", Offset = "0x1064E60", VA = "0x181066260")]
		private void _InitView()
		{
		}

		// Token: 0x06017FB6 RID: 98230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB6")]
		[Address(RVA = "0x10658C0", Offset = "0x10644C0", VA = "0x1810658C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06017FB7 RID: 98231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB7")]
		[Address(RVA = "0x10665C0", Offset = "0x10651C0", VA = "0x1810665C0")]
		private void _OnEquipItemClick(string msg)
		{
		}

		// Token: 0x06017FB8 RID: 98232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB8")]
		[Address(RVA = "0x10664A0", Offset = "0x10650A0", VA = "0x1810664A0")]
		private void _OnEquipCharPartClick(string msg)
		{
		}

		// Token: 0x06017FB9 RID: 98233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FB9")]
		[Address(RVA = "0x1066780", Offset = "0x1065380", VA = "0x181066780")]
		private void _OnSortClick(int msg)
		{
		}

		// Token: 0x06017FBA RID: 98234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FBA")]
		[Address(RVA = "0x1066850", Offset = "0x1065450", VA = "0x181066850")]
		private void _OnTypeFilterClick()
		{
		}

		// Token: 0x06017FBB RID: 98235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FBB")]
		[Address(RVA = "0x1066AA0", Offset = "0x10656A0", VA = "0x181066AA0")]
		public UniEquipArchiveModuleListState()
		{
		}

		// Token: 0x06017FBC RID: 98236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FBC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06017FBD RID: 98237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FBD")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0401D088 RID: 118920
		[Token(Token = "0x401D088")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionView _view;

		// Token: 0x0401D089 RID: 118921
		[Token(Token = "0x401D089")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _equipOwnFilterContainer;

		// Token: 0x0401D08A RID: 118922
		[Token(Token = "0x401D08A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UniEquipArchiveFilterHolder _equipOwnFilterPrefab;

		// Token: 0x0401D08B RID: 118923
		[Token(Token = "0x401D08B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _equipTypeFilterContainer;

		// Token: 0x0401D08C RID: 118924
		[Token(Token = "0x401D08C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UniEquipArchiveEquipTypeFilterHolder _equipTypeFilterPrefab;

		// Token: 0x0401D08D RID: 118925
		[Token(Token = "0x401D08D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401D08E RID: 118926
		[Token(Token = "0x401D08E")]
		[FieldOffset(Offset = "0xA0")]
		private UniEquipArchiveModuleListState.EquipOwnFilterHandler m_equipOwnFilterHandler;

		// Token: 0x0401D08F RID: 118927
		[Token(Token = "0x401D08F")]
		[FieldOffset(Offset = "0xA8")]
		private UniEquipArchiveFilterHolder m_equipOwnFilterHolder;

		// Token: 0x0401D090 RID: 118928
		[Token(Token = "0x401D090")]
		[FieldOffset(Offset = "0xB0")]
		private UniEquipArchiveModuleListState.EquipTypeFilterHandler m_equipTypeFilterHandler;

		// Token: 0x0401D091 RID: 118929
		[Token(Token = "0x401D091")]
		[FieldOffset(Offset = "0xB8")]
		private UniEquipArchiveEquipTypeFilterHolder m_equipTypeFilterHolder;

		// Token: 0x0401D092 RID: 118930
		[Token(Token = "0x401D092")]
		[FieldOffset(Offset = "0xC0")]
		private UniEquipArchiveModuleCollectionStateBean m_stateBean;

		// Token: 0x0401D093 RID: 118931
		[Token(Token = "0x401D093")]
		[NonSerialized]
		public const int ON_EQUIP_ITEM_CLICK = 0;

		// Token: 0x0401D094 RID: 118932
		[Token(Token = "0x401D094")]
		[NonSerialized]
		public const int ON_EQUIP_ITEM_CHAR_PART_CLICK = 1;

		// Token: 0x0401D095 RID: 118933
		[Token(Token = "0x401D095")]
		[NonSerialized]
		public const int ON_SORT_CLICK = 2;

		// Token: 0x0401D096 RID: 118934
		[Token(Token = "0x401D096")]
		[NonSerialized]
		public const int ON_TYPE_FILTER_CLICK = 3;

		// Token: 0x0401D097 RID: 118935
		[Token(Token = "0x401D097")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D098 RID: 118936
		[Token(Token = "0x401D098")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D099 RID: 118937
		[Token(Token = "0x401D099")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D09A RID: 118938
		[Token(Token = "0x401D09A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0401D09B RID: 118939
		[Token(Token = "0x401D09B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0401D09C RID: 118940
		[Token(Token = "0x401D09C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0401D09D RID: 118941
		[Token(Token = "0x401D09D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x0401D09E RID: 118942
		[Token(Token = "0x401D09E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D09F RID: 118943
		[Token(Token = "0x401D09F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEquipItemClick;

		// Token: 0x0401D0A0 RID: 118944
		[Token(Token = "0x401D0A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEquipCharPartClick;

		// Token: 0x0401D0A1 RID: 118945
		[Token(Token = "0x401D0A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSortClick;

		// Token: 0x0401D0A2 RID: 118946
		[Token(Token = "0x401D0A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTypeFilterClick;

		// Token: 0x0401D0A3 RID: 118947
		[Token(Token = "0x401D0A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BDE RID: 15326
		[Token(Token = "0x2003BDE")]
		private class EquipOwnFilterHandler : UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06017FBE RID: 98238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FBE")]
			[Address(RVA = "0x105EB60", Offset = "0x105D760", VA = "0x18105EB60")]
			public EquipOwnFilterHandler(UniEquipArchiveModuleListState closure)
			{
			}

			// Token: 0x06017FBF RID: 98239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FBF")]
			[Address(RVA = "0x105E9B0", Offset = "0x105D5B0", VA = "0x18105E9B0", Slot = "4")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x0401D0A4 RID: 118948
			[Token(Token = "0x401D0A4")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveModuleListState m_closure;

			// Token: 0x0401D0A5 RID: 118949
			[Token(Token = "0x401D0A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D0A6 RID: 118950
			[Token(Token = "0x401D0A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;
		}

		// Token: 0x02003BDF RID: 15327
		[Token(Token = "0x2003BDF")]
		private class EquipTypeFilterHandler : UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06017FC0 RID: 98240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FC0")]
			[Address(RVA = "0x105ED90", Offset = "0x105D990", VA = "0x18105ED90")]
			public EquipTypeFilterHandler(UniEquipArchiveModuleListState closure)
			{
			}

			// Token: 0x06017FC1 RID: 98241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FC1")]
			[Address(RVA = "0x105EBE0", Offset = "0x105D7E0", VA = "0x18105EBE0", Slot = "4")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x0401D0A7 RID: 118951
			[Token(Token = "0x401D0A7")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveModuleListState m_closure;

			// Token: 0x0401D0A8 RID: 118952
			[Token(Token = "0x401D0A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D0A9 RID: 118953
			[Token(Token = "0x401D0A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;
		}
	}
}
