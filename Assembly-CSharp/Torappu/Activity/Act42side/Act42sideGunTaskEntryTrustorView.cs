using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007324 RID: 29476
	[Token(Token = "0x2007324")]
	public class Act42sideGunTaskEntryTrustorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029AF0 RID: 170736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF0")]
		[Address(RVA = "0x2516E40", Offset = "0x2515A40", VA = "0x182516E40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029AF1 RID: 170737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF1")]
		[Address(RVA = "0x2516930", Offset = "0x2515530", VA = "0x182516930")]
		public void Render(Act42sideGunTaskEntryTrustorViewModel trustorViewModel, bool isActEnd)
		{
		}

		// Token: 0x06029AF2 RID: 170738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF2")]
		[Address(RVA = "0x2516820", Offset = "0x2515420", VA = "0x182516820")]
		public void EventOnClick()
		{
		}

		// Token: 0x06029AF3 RID: 170739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF3")]
		[Address(RVA = "0x2516EE0", Offset = "0x2515AE0", VA = "0x182516EE0")]
		public Act42sideGunTaskEntryTrustorView()
		{
		}

		// Token: 0x0403BA3D RID: 244285
		[Token(Token = "0x403BA3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0403BA3E RID: 244286
		[Token(Token = "0x403BA3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGunUncomplete;

		// Token: 0x0403BA3F RID: 244287
		[Token(Token = "0x403BA3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelGunComplete;

		// Token: 0x0403BA40 RID: 244288
		[Token(Token = "0x403BA40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403BA41 RID: 244289
		[Token(Token = "0x403BA41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRuning;

		// Token: 0x0403BA42 RID: 244290
		[Token(Token = "0x403BA42")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403BA43 RID: 244291
		[Token(Token = "0x403BA43")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403BA44 RID: 244292
		[Token(Token = "0x403BA44")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _panelTrack;

		// Token: 0x0403BA45 RID: 244293
		[Token(Token = "0x403BA45")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelRuningTag;

		// Token: 0x0403BA46 RID: 244294
		[Token(Token = "0x403BA46")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _names;

		// Token: 0x0403BA47 RID: 244295
		[Token(Token = "0x403BA47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _completeCount;

		// Token: 0x0403BA48 RID: 244296
		[Token(Token = "0x403BA48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _totalCount;

		// Token: 0x0403BA49 RID: 244297
		[Token(Token = "0x403BA49")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _weapon;

		// Token: 0x0403BA4A RID: 244298
		[Token(Token = "0x403BA4A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _weaponComplete;

		// Token: 0x0403BA4B RID: 244299
		[Token(Token = "0x403BA4B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0403BA4C RID: 244300
		[Token(Token = "0x403BA4C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403BA4D RID: 244301
		[Token(Token = "0x403BA4D")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BA4E RID: 244302
		[Token(Token = "0x403BA4E")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BA4F RID: 244303
		[Token(Token = "0x403BA4F")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTrustorId;

		// Token: 0x0403BA50 RID: 244304
		[Token(Token = "0x403BA50")]
		[FieldOffset(Offset = "0xC0")]
		private TrackPointViewProperty m_trackProp;

		// Token: 0x0403BA51 RID: 244305
		[Token(Token = "0x403BA51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BA52 RID: 244306
		[Token(Token = "0x403BA52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BA53 RID: 244307
		[Token(Token = "0x403BA53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403BA54 RID: 244308
		[Token(Token = "0x403BA54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007325 RID: 29477
		[Token(Token = "0x2007325")]
		private class TrackViewModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x06029AF4 RID: 170740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029AF4")]
			[Address(RVA = "0x251C4C0", Offset = "0x251B0C0", VA = "0x18251C4C0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x1700627D RID: 25213
			// (get) Token: 0x06029AF5 RID: 170741 RVA: 0x000D6398 File Offset: 0x000D4598
			[Token(Token = "0x1700627D")]
			public bool isShow
			{
				[Token(Token = "0x6029AF5")]
				[Address(RVA = "0x251C5F0", Offset = "0x251B1F0", VA = "0x18251C5F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06029AF6 RID: 170742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029AF6")]
			[Address(RVA = "0x251C590", Offset = "0x251B190", VA = "0x18251C590")]
			public TrackViewModel()
			{
			}

			// Token: 0x0403BA55 RID: 244309
			[Token(Token = "0x403BA55")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403BA56 RID: 244310
			[Token(Token = "0x403BA56")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403BA57 RID: 244311
			[Token(Token = "0x403BA57")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403BA58 RID: 244312
			[Token(Token = "0x403BA58")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02007326 RID: 29478
			[Token(Token = "0x2007326")]
			public class Input
			{
				// Token: 0x06029AF7 RID: 170743 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6029AF7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x0403BA59 RID: 244313
				[Token(Token = "0x403BA59")]
				[FieldOffset(Offset = "0x10")]
				public bool isShow;
			}
		}
	}
}
