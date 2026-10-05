using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F0F RID: 28431
	[Token(Token = "0x2006F0F")]
	public class ActMultiV3EntryJoinRoomMask : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x06028611 RID: 165393 RVA: 0x000D1AC0 File Offset: 0x000CFCC0
		// (set) Token: 0x06028612 RID: 165394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F4D")]
		public double longTimeThreshold
		{
			[Token(Token = "0x6028611")]
			[Address(RVA = "0x23ABF70", Offset = "0x23AAB70", VA = "0x1823ABF70")]
			[CompilerGenerated]
			private get
			{
				return 0.0;
			}
			[Token(Token = "0x6028612")]
			[Address(RVA = "0x23ABFD0", Offset = "0x23AABD0", VA = "0x1823ABFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x06028613 RID: 165395 RVA: 0x000D1AD8 File Offset: 0x000CFCD8
		[Token(Token = "0x17005F4E")]
		public bool isStable
		{
			[Token(Token = "0x6028613")]
			[Address(RVA = "0x23ABF10", Offset = "0x23AAB10", VA = "0x1823ABF10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028614 RID: 165396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028614")]
		[Address(RVA = "0x23ABC20", Offset = "0x23AA820", VA = "0x1823ABC20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028615 RID: 165397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028615")]
		[Address(RVA = "0x23ABDA0", Offset = "0x23AA9A0", VA = "0x1823ABDA0")]
		private void _TriggerCallback()
		{
		}

		// Token: 0x06028616 RID: 165398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028616")]
		[Address(RVA = "0x23ABCF0", Offset = "0x23AA8F0", VA = "0x1823ABCF0")]
		private IEnumerator _ShowMaskCoroutine()
		{
			return null;
		}

		// Token: 0x06028617 RID: 165399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028617")]
		[Address(RVA = "0x23ABA90", Offset = "0x23AA690", VA = "0x1823ABA90")]
		public void ShowMask(Action callback)
		{
		}

		// Token: 0x06028618 RID: 165400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028618")]
		[Address(RVA = "0x23AB8B0", Offset = "0x23AA4B0", VA = "0x1823AB8B0")]
		public void HideMask(Action callback)
		{
		}

		// Token: 0x06028619 RID: 165401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028619")]
		[Address(RVA = "0x23AB9A0", Offset = "0x23AA5A0", VA = "0x1823AB9A0")]
		public void ResetMask()
		{
		}

		// Token: 0x0602861A RID: 165402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602861A")]
		[Address(RVA = "0x23AB940", Offset = "0x23AA540", VA = "0x1823AB940")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602861B RID: 165403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602861B")]
		[Address(RVA = "0x23ABEB0", Offset = "0x23AAAB0", VA = "0x1823ABEB0")]
		public ActMultiV3EntryJoinRoomMask()
		{
		}

		// Token: 0x040396B4 RID: 235188
		[Token(Token = "0x40396B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasMask;

		// Token: 0x040396B5 RID: 235189
		[Token(Token = "0x40396B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x040396B6 RID: 235190
		[Token(Token = "0x40396B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _waitTime;

		// Token: 0x040396B7 RID: 235191
		[Token(Token = "0x40396B7")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_inited;

		// Token: 0x040396B8 RID: 235192
		[Token(Token = "0x40396B8")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040396B9 RID: 235193
		[Token(Token = "0x40396B9")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_showCoroutine;

		// Token: 0x040396BA RID: 235194
		[Token(Token = "0x40396BA")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_showTween;

		// Token: 0x040396BB RID: 235195
		[Token(Token = "0x40396BB")]
		[FieldOffset(Offset = "0x50")]
		private ActMultiV3EntryJoinRoomMask.Status m_status;

		// Token: 0x040396BC RID: 235196
		[Token(Token = "0x40396BC")]
		[FieldOffset(Offset = "0x58")]
		private Action m_cachedCallback;

		// Token: 0x040396BE RID: 235198
		[Token(Token = "0x40396BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_longTimeThreshold;

		// Token: 0x040396BF RID: 235199
		[Token(Token = "0x40396BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_longTimeThreshold;

		// Token: 0x040396C0 RID: 235200
		[Token(Token = "0x40396C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x040396C1 RID: 235201
		[Token(Token = "0x40396C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040396C2 RID: 235202
		[Token(Token = "0x40396C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerCallback;

		// Token: 0x040396C3 RID: 235203
		[Token(Token = "0x40396C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowMaskCoroutine;

		// Token: 0x040396C4 RID: 235204
		[Token(Token = "0x40396C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowMask;

		// Token: 0x040396C5 RID: 235205
		[Token(Token = "0x40396C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideMask;

		// Token: 0x040396C6 RID: 235206
		[Token(Token = "0x40396C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetMask;

		// Token: 0x040396C7 RID: 235207
		[Token(Token = "0x40396C7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040396C8 RID: 235208
		[Token(Token = "0x40396C8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F10 RID: 28432
		[Token(Token = "0x2006F10")]
		private enum Status
		{
			// Token: 0x040396CA RID: 235210
			[Token(Token = "0x40396CA")]
			INACTIVE,
			// Token: 0x040396CB RID: 235211
			[Token(Token = "0x40396CB")]
			WAIT,
			// Token: 0x040396CC RID: 235212
			[Token(Token = "0x40396CC")]
			WAIT_END
		}
	}
}
