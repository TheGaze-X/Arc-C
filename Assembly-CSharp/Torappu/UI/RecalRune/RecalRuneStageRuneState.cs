using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200478C RID: 18316
	[Token(Token = "0x200478C")]
	public class RecalRuneStageRuneState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601BBA8 RID: 113576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA8")]
		[Address(RVA = "0x150F140", Offset = "0x150DD40", VA = "0x18150F140", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BBA9 RID: 113577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA9")]
		[Address(RVA = "0x15101F0", Offset = "0x150EDF0", VA = "0x1815101F0")]
		private void _OnSelectItemClicked(string runeId)
		{
		}

		// Token: 0x0601BBAA RID: 113578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAA")]
		[Address(RVA = "0x150FDE0", Offset = "0x150E9E0", VA = "0x18150FDE0")]
		private void _OnDeselectItemClicked(string runeId)
		{
		}

		// Token: 0x0601BBAB RID: 113579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAB")]
		[Address(RVA = "0x1510080", Offset = "0x150EC80", VA = "0x181510080")]
		private void _OnFocusItemFromTable(string runeId)
		{
		}

		// Token: 0x0601BBAC RID: 113580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAC")]
		[Address(RVA = "0x150EE30", Offset = "0x150DA30", VA = "0x18150EE30")]
		public void OnClearClick()
		{
		}

		// Token: 0x0601BBAD RID: 113581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAD")]
		[Address(RVA = "0x150F570", Offset = "0x150E170", VA = "0x18150F570")]
		public void OnStagePreviewClick()
		{
		}

		// Token: 0x0601BBAE RID: 113582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAE")]
		[Address(RVA = "0x150F620", Offset = "0x150E220", VA = "0x18150F620")]
		public void OnStartClick()
		{
		}

		// Token: 0x0601BBAF RID: 113583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBAF")]
		[Address(RVA = "0x150FCB0", Offset = "0x150E8B0", VA = "0x18150FCB0")]
		public void SaveSelectedRunesToLocalCache()
		{
		}

		// Token: 0x0601BBB0 RID: 113584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBB0")]
		[Address(RVA = "0x150EDD0", Offset = "0x150D9D0", VA = "0x18150EDD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BBB1 RID: 113585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB1")]
		[Address(RVA = "0x150EEE0", Offset = "0x150DAE0", VA = "0x18150EEE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BBB2 RID: 113586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB2")]
		[Address(RVA = "0x150F470", Offset = "0x150E070", VA = "0x18150F470", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601BBB3 RID: 113587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB3")]
		[Address(RVA = "0x150FD40", Offset = "0x150E940", VA = "0x18150FD40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BBB4 RID: 113588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB4")]
		[Address(RVA = "0x15102C0", Offset = "0x150EEC0", VA = "0x1815102C0")]
		private void _Tutorial_TriggerSignal()
		{
		}

		// Token: 0x0601BBB5 RID: 113589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB5")]
		[Address(RVA = "0x1510370", Offset = "0x150EF70", VA = "0x181510370")]
		public RecalRuneStageRuneState()
		{
		}

		// Token: 0x0601BBB6 RID: 113590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601BBB7 RID: 113591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBB7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402409F RID: 147615
		[Token(Token = "0x402409F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecalRuneStageRuneView _view;

		// Token: 0x040240A0 RID: 147616
		[Token(Token = "0x40240A0")]
		[FieldOffset(Offset = "0x78")]
		private RecalRuneStageRuneProperty m_property;

		// Token: 0x040240A1 RID: 147617
		[Token(Token = "0x40240A1")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040240A2 RID: 147618
		[Token(Token = "0x40240A2")]
		[NonSerialized]
		public const int MSG_SELECT_ITEM = 0;

		// Token: 0x040240A3 RID: 147619
		[Token(Token = "0x40240A3")]
		[NonSerialized]
		public const int MSG_DESELECT_ITEM = 1;

		// Token: 0x040240A4 RID: 147620
		[Token(Token = "0x40240A4")]
		[NonSerialized]
		public const int MSG_FOCUS_ITEM_FROM_TABLE = 2;

		// Token: 0x040240A5 RID: 147621
		[Token(Token = "0x40240A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040240A6 RID: 147622
		[Token(Token = "0x40240A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSelectItemClicked;

		// Token: 0x040240A7 RID: 147623
		[Token(Token = "0x40240A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnDeselectItemClicked;

		// Token: 0x040240A8 RID: 147624
		[Token(Token = "0x40240A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnFocusItemFromTable;

		// Token: 0x040240A9 RID: 147625
		[Token(Token = "0x40240A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClearClick;

		// Token: 0x040240AA RID: 147626
		[Token(Token = "0x40240AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStagePreviewClick;

		// Token: 0x040240AB RID: 147627
		[Token(Token = "0x40240AB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStartClick;

		// Token: 0x040240AC RID: 147628
		[Token(Token = "0x40240AC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveSelectedRunesToLocalCache;

		// Token: 0x040240AD RID: 147629
		[Token(Token = "0x40240AD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040240AE RID: 147630
		[Token(Token = "0x40240AE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040240AF RID: 147631
		[Token(Token = "0x40240AF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040240B0 RID: 147632
		[Token(Token = "0x40240B0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040240B1 RID: 147633
		[Token(Token = "0x40240B1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Tutorial_TriggerSignal;

		// Token: 0x040240B2 RID: 147634
		[Token(Token = "0x40240B2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
