using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006878 RID: 26744
	[Token(Token = "0x2006878")]
	public class ActivityCustomZoneMapState : PopupFadeState, IValueMsgReceiver, IPopupCustomActive
	{
		// Token: 0x060264CE RID: 156878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264CE")]
		[Address(RVA = "0x215E610", Offset = "0x215D210", VA = "0x18215E610", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060264CF RID: 156879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264CF")]
		[Address(RVA = "0x215E670", Offset = "0x215D270", VA = "0x18215E670", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060264D0 RID: 156880 RVA: 0x000CA9C8 File Offset: 0x000C8BC8
		[Token(Token = "0x60264D0")]
		[Address(RVA = "0x215EF70", Offset = "0x215DB70", VA = "0x18215EF70")]
		private bool _TryLoadZoneMapHolder(string prefabPath)
		{
			return default(bool);
		}

		// Token: 0x060264D1 RID: 156881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D1")]
		[Address(RVA = "0x215EB50", Offset = "0x215D750", VA = "0x18215EB50")]
		private void _ClearLoadedZoneMapHolder()
		{
		}

		// Token: 0x060264D2 RID: 156882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D2")]
		[Address(RVA = "0x215E850", Offset = "0x215D450", VA = "0x18215E850", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060264D3 RID: 156883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D3")]
		[Address(RVA = "0x215EDE0", Offset = "0x215D9E0", VA = "0x18215EDE0")]
		private void _SelectStage(string stageId)
		{
		}

		// Token: 0x060264D4 RID: 156884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D4")]
		[Address(RVA = "0x215EC60", Offset = "0x215D860", VA = "0x18215EC60")]
		private void _ClickMapBg()
		{
		}

		// Token: 0x060264D5 RID: 156885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D5")]
		[Address(RVA = "0x215ED20", Offset = "0x215D920", VA = "0x18215ED20")]
		private void _OpenStagePreview()
		{
		}

		// Token: 0x060264D6 RID: 156886 RVA: 0x000CA9E0 File Offset: 0x000C8BE0
		[Token(Token = "0x60264D6")]
		[Address(RVA = "0x215E5A0", Offset = "0x215D1A0", VA = "0x18215E5A0", Slot = "32")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x060264D7 RID: 156887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D7")]
		[Address(RVA = "0x215F1B0", Offset = "0x215DDB0", VA = "0x18215F1B0")]
		public ActivityCustomZoneMapState()
		{
		}

		// Token: 0x060264D8 RID: 156888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264D8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04035F47 RID: 220999
		[Token(Token = "0x4035F47")]
		[NonSerialized]
		public const int ON_SELECT_STAGE = 0;

		// Token: 0x04035F48 RID: 221000
		[Token(Token = "0x4035F48")]
		[NonSerialized]
		public const int ON_MAP_BG_CLICK = 1;

		// Token: 0x04035F49 RID: 221001
		[Token(Token = "0x4035F49")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _mapHolderContainer;

		// Token: 0x04035F4A RID: 221002
		[Token(Token = "0x4035F4A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityCustomZoneStateBean _stateBean;

		// Token: 0x04035F4B RID: 221003
		[Token(Token = "0x4035F4B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent _onMapBgClicked;

		// Token: 0x04035F4C RID: 221004
		[Token(Token = "0x4035F4C")]
		[FieldOffset(Offset = "0x88")]
		private string m_zoneMapHolderPathCache;

		// Token: 0x04035F4D RID: 221005
		[Token(Token = "0x4035F4D")]
		[FieldOffset(Offset = "0x90")]
		private ActivityCustomZoneMapHolderBase m_mapHolder;

		// Token: 0x04035F4E RID: 221006
		[Token(Token = "0x4035F4E")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035F4F RID: 221007
		[Token(Token = "0x4035F4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035F50 RID: 221008
		[Token(Token = "0x4035F50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035F51 RID: 221009
		[Token(Token = "0x4035F51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadZoneMapHolder;

		// Token: 0x04035F52 RID: 221010
		[Token(Token = "0x4035F52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearLoadedZoneMapHolder;

		// Token: 0x04035F53 RID: 221011
		[Token(Token = "0x4035F53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035F54 RID: 221012
		[Token(Token = "0x4035F54")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SelectStage;

		// Token: 0x04035F55 RID: 221013
		[Token(Token = "0x4035F55")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClickMapBg;

		// Token: 0x04035F56 RID: 221014
		[Token(Token = "0x4035F56")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenStagePreview;

		// Token: 0x04035F57 RID: 221015
		[Token(Token = "0x4035F57")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04035F58 RID: 221016
		[Token(Token = "0x4035F58")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
