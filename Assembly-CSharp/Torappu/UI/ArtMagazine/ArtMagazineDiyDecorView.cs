using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006568 RID: 25960
	[Token(Token = "0x2006568")]
	public class ArtMagazineDiyDecorView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x06025545 RID: 152901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025545")]
		[Address(RVA = "0x2046E40", Offset = "0x2045A40", VA = "0x182046E40", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x06025546 RID: 152902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025546")]
		[Address(RVA = "0x20470A0", Offset = "0x2045CA0", VA = "0x1820470A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025547 RID: 152903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025547")]
		[Address(RVA = "0x2046DB0", Offset = "0x20459B0", VA = "0x182046DB0")]
		public void EventOpenHomeState()
		{
		}

		// Token: 0x06025548 RID: 152904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025548")]
		[Address(RVA = "0x2047130", Offset = "0x2045D30", VA = "0x182047130")]
		public ArtMagazineDiyDecorView()
		{
		}

		// Token: 0x04034601 RID: 214529
		[Token(Token = "0x4034601")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineDiyDecorTabItem[] _tabs;

		// Token: 0x04034602 RID: 214530
		[Token(Token = "0x4034602")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _stickerTypeTrackPoint;

		// Token: 0x04034603 RID: 214531
		[Token(Token = "0x4034603")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034604 RID: 214532
		[Token(Token = "0x4034604")]
		[FieldOffset(Offset = "0x40")]
		private int m_enterSeqNum;

		// Token: 0x04034605 RID: 214533
		[Token(Token = "0x4034605")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_stickerTypeTrackPoint;

		// Token: 0x04034606 RID: 214534
		[Token(Token = "0x4034606")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04034607 RID: 214535
		[Token(Token = "0x4034607")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034608 RID: 214536
		[Token(Token = "0x4034608")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034609 RID: 214537
		[Token(Token = "0x4034609")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOpenHomeState;

		// Token: 0x0403460A RID: 214538
		[Token(Token = "0x403460A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006569 RID: 25961
		[Token(Token = "0x2006569")]
		private class StickerTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700581C RID: 22556
			// (get) Token: 0x06025549 RID: 152905 RVA: 0x000C7758 File Offset: 0x000C5958
			[Token(Token = "0x1700581C")]
			public bool isShow
			{
				[Token(Token = "0x6025549")]
				[Address(RVA = "0x2055DC0", Offset = "0x20549C0", VA = "0x182055DC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602554A RID: 152906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602554A")]
			[Address(RVA = "0x2055C90", Offset = "0x2054890", VA = "0x182055C90", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602554B RID: 152907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602554B")]
			[Address(RVA = "0x2055D00", Offset = "0x2054900", VA = "0x182055D00")]
			public StickerTrackPointModel()
			{
			}

			// Token: 0x0403460B RID: 214539
			[Token(Token = "0x403460B")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403460C RID: 214540
			[Token(Token = "0x403460C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403460D RID: 214541
			[Token(Token = "0x403460D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403460E RID: 214542
			[Token(Token = "0x403460E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
