using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE6 RID: 15334
	[Token(Token = "0x2003BE6")]
	public class UniEquipArchiveCharacterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x06017FEA RID: 98282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003940")]
		public UIWrappedScrollRect scrollRect
		{
			[Token(Token = "0x6017FEA")]
			[Address(RVA = "0x1060D00", Offset = "0x105F900", VA = "0x181060D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017FEB RID: 98283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FEB")]
		[Address(RVA = "0x1060BC0", Offset = "0x105F7C0", VA = "0x181060BC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017FEC RID: 98284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FEC")]
		[Address(RVA = "0x10607A0", Offset = "0x105F3A0", VA = "0x1810607A0")]
		public void Render(UniEquipArchiveCharacterItemViewModel data)
		{
		}

		// Token: 0x06017FED RID: 98285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FED")]
		[Address(RVA = "0x1060670", Offset = "0x105F270", VA = "0x181060670")]
		public void OnUniEquipClick()
		{
		}

		// Token: 0x06017FEE RID: 98286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FEE")]
		[Address(RVA = "0x1060540", Offset = "0x105F140", VA = "0x181060540")]
		public void OnUniEquipCharClick()
		{
		}

		// Token: 0x06017FEF RID: 98287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FEF")]
		[Address(RVA = "0x1060CA0", Offset = "0x105F8A0", VA = "0x181060CA0")]
		public UniEquipArchiveCharacterItemView()
		{
		}

		// Token: 0x0401D0E8 RID: 119016
		[Token(Token = "0x401D0E8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0401D0E9 RID: 119017
		[Token(Token = "0x401D0E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _prof;

		// Token: 0x0401D0EA RID: 119018
		[Token(Token = "0x401D0EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _elite;

		// Token: 0x0401D0EB RID: 119019
		[Token(Token = "0x401D0EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401D0EC RID: 119020
		[Token(Token = "0x401D0EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401D0ED RID: 119021
		[Token(Token = "0x401D0ED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rarity;

		// Token: 0x0401D0EE RID: 119022
		[Token(Token = "0x401D0EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelEquip;

		// Token: 0x0401D0EF RID: 119023
		[Token(Token = "0x401D0EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelEquipDisable;

		// Token: 0x0401D0F0 RID: 119024
		[Token(Token = "0x401D0F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelStarMark;

		// Token: 0x0401D0F1 RID: 119025
		[Token(Token = "0x401D0F1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackpoint;

		// Token: 0x0401D0F2 RID: 119026
		[Token(Token = "0x401D0F2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _equipContent;

		// Token: 0x0401D0F3 RID: 119027
		[Token(Token = "0x401D0F3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0401D0F4 RID: 119028
		[Token(Token = "0x401D0F4")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401D0F5 RID: 119029
		[Token(Token = "0x401D0F5")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipArchiveCharacterItemView.Adapter m_adapter;

		// Token: 0x0401D0F6 RID: 119030
		[Token(Token = "0x401D0F6")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D0F7 RID: 119031
		[Token(Token = "0x401D0F7")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D0F8 RID: 119032
		[Token(Token = "0x401D0F8")]
		[FieldOffset(Offset = "0xA8")]
		private UniEquipArchiveCharacterItemViewModel m_cachedViewModel;

		// Token: 0x0401D0F9 RID: 119033
		[Token(Token = "0x401D0F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scrollRect;

		// Token: 0x0401D0FA RID: 119034
		[Token(Token = "0x401D0FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D0FB RID: 119035
		[Token(Token = "0x401D0FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D0FC RID: 119036
		[Token(Token = "0x401D0FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUniEquipClick;

		// Token: 0x0401D0FD RID: 119037
		[Token(Token = "0x401D0FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUniEquipCharClick;

		// Token: 0x0401D0FE RID: 119038
		[Token(Token = "0x401D0FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BE7 RID: 15335
		[Token(Token = "0x2003BE7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06017FF0 RID: 98288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FF0")]
			[Address(RVA = "0x1076F90", Offset = "0x1075B90", VA = "0x181076F90")]
			public Adapter(UniEquipArchiveCharacterItemView closure)
			{
			}

			// Token: 0x17003941 RID: 14657
			// (get) Token: 0x06017FF1 RID: 98289 RVA: 0x00098E98 File Offset: 0x00097098
			[Token(Token = "0x17003941")]
			public override int count
			{
				[Token(Token = "0x6017FF1")]
				[Address(RVA = "0x1077010", Offset = "0x1075C10", VA = "0x181077010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06017FF2 RID: 98290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017FF2")]
			[Address(RVA = "0x1076D70", Offset = "0x1075970", VA = "0x181076D70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D0FF RID: 119039
			[Token(Token = "0x401D0FF")]
			[FieldOffset(Offset = "0x20")]
			private UniEquipArchiveCharacterItemView m_closure;

			// Token: 0x0401D100 RID: 119040
			[Token(Token = "0x401D100")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D101 RID: 119041
			[Token(Token = "0x401D101")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D102 RID: 119042
			[Token(Token = "0x401D102")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
