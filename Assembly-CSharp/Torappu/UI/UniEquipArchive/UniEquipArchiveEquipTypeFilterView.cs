using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BC9 RID: 15305
	[Token(Token = "0x2003BC9")]
	public class UniEquipArchiveEquipTypeFilterView : DataBinder<UniEquipArchiveModuleTypeFilterViewProperty>
	{
		// Token: 0x06017F64 RID: 98148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F64")]
		[Address(RVA = "0x1063D80", Offset = "0x1062980", VA = "0x181063D80", Slot = "7")]
		public override void OnValueChanged(UniEquipArchiveModuleTypeFilterViewProperty property)
		{
		}

		// Token: 0x06017F65 RID: 98149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F65")]
		[Address(RVA = "0x1064020", Offset = "0x1062C20", VA = "0x181064020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017F66 RID: 98150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F66")]
		[Address(RVA = "0x1063D10", Offset = "0x1062910", VA = "0x181063D10")]
		public void OnFilterViewBgClick()
		{
		}

		// Token: 0x06017F67 RID: 98151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F67")]
		[Address(RVA = "0x10641A0", Offset = "0x1062DA0", VA = "0x1810641A0")]
		public UniEquipArchiveEquipTypeFilterView()
		{
		}

		// Token: 0x0401CFF7 RID: 118775
		[Token(Token = "0x401CFF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401CFF8 RID: 118776
		[Token(Token = "0x401CFF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasFilterItemListView;

		// Token: 0x0401CFF9 RID: 118777
		[Token(Token = "0x401CFF9")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<string> onTypeItemClick;

		// Token: 0x0401CFFA RID: 118778
		[Token(Token = "0x401CFFA")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action onTypeFilterBgClick;

		// Token: 0x0401CFFB RID: 118779
		[Token(Token = "0x401CFFB")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401CFFC RID: 118780
		[Token(Token = "0x401CFFC")]
		[FieldOffset(Offset = "0x48")]
		private UniEquipArchiveEquipTypeFilterView.Adapter m_adapter;

		// Token: 0x0401CFFD RID: 118781
		[Token(Token = "0x401CFFD")]
		[FieldOffset(Offset = "0x50")]
		private UniEquipArchiveModuleTypeFilterViewModel m_cachedModel;

		// Token: 0x0401CFFE RID: 118782
		[Token(Token = "0x401CFFE")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_tweenFilterItemList;

		// Token: 0x0401CFFF RID: 118783
		[Token(Token = "0x401CFFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D000 RID: 118784
		[Token(Token = "0x401D000")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D001 RID: 118785
		[Token(Token = "0x401D001")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFilterViewBgClick;

		// Token: 0x0401D002 RID: 118786
		[Token(Token = "0x401D002")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BCA RID: 15306
		[Token(Token = "0x2003BCA")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06017F68 RID: 98152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F68")]
			[Address(RVA = "0x105E160", Offset = "0x105CD60", VA = "0x18105E160")]
			public Adapter(UniEquipArchiveEquipTypeFilterView closure)
			{
			}

			// Token: 0x1700393B RID: 14651
			// (get) Token: 0x06017F69 RID: 98153 RVA: 0x00098C40 File Offset: 0x00096E40
			[Token(Token = "0x1700393B")]
			public override int count
			{
				[Token(Token = "0x6017F69")]
				[Address(RVA = "0x105E260", Offset = "0x105CE60", VA = "0x18105E260", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06017F6A RID: 98154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F6A")]
			[Address(RVA = "0x105DE10", Offset = "0x105CA10", VA = "0x18105DE10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D003 RID: 118787
			[Token(Token = "0x401D003")]
			[FieldOffset(Offset = "0x20")]
			private UniEquipArchiveEquipTypeFilterView m_closure;

			// Token: 0x0401D004 RID: 118788
			[Token(Token = "0x401D004")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D005 RID: 118789
			[Token(Token = "0x401D005")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D006 RID: 118790
			[Token(Token = "0x401D006")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
