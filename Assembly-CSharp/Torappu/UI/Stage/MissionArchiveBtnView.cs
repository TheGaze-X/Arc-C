using System;
using Il2CppDummyDll;
using Torappu.UI.MissionArchive;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F3 RID: 26867
	[Token(Token = "0x20068F3")]
	public class MissionArchiveBtnView : StageAdditionalBtnView
	{
		// Token: 0x060267CE RID: 157646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267CE")]
		[Address(RVA = "0x2193FF0", Offset = "0x2192BF0", VA = "0x182193FF0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x060267CF RID: 157647 RVA: 0x000CB538 File Offset: 0x000C9738
		[Token(Token = "0x60267CF")]
		[Address(RVA = "0x2194160", Offset = "0x2192D60", VA = "0x182194160", Slot = "4")]
		public override bool OnUpdate(ZoneViewModel model)
		{
			return default(bool);
		}

		// Token: 0x060267D0 RID: 157648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D0")]
		[Address(RVA = "0x2194390", Offset = "0x2192F90", VA = "0x182194390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060267D1 RID: 157649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D1")]
		[Address(RVA = "0x2194470", Offset = "0x2193070", VA = "0x182194470")]
		public MissionArchiveBtnView()
		{
		}

		// Token: 0x04036392 RID: 222098
		[Token(Token = "0x4036392")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04036393 RID: 222099
		[Token(Token = "0x4036393")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04036394 RID: 222100
		[Token(Token = "0x4036394")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x04036395 RID: 222101
		[Token(Token = "0x4036395")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MissionArchiveDataServiceProxy _proxy;

		// Token: 0x04036396 RID: 222102
		[Token(Token = "0x4036396")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _topicId;

		// Token: 0x04036397 RID: 222103
		[Token(Token = "0x4036397")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_hasRewardTrackProperty;

		// Token: 0x04036398 RID: 222104
		[Token(Token = "0x4036398")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04036399 RID: 222105
		[Token(Token = "0x4036399")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403639A RID: 222106
		[Token(Token = "0x403639A")]
		[FieldOffset(Offset = "0x60")]
		private MissionArchiveData m_cachedRecordData;

		// Token: 0x0403639B RID: 222107
		[Token(Token = "0x403639B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_cachedEntryOpen;

		// Token: 0x0403639C RID: 222108
		[Token(Token = "0x403639C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0403639D RID: 222109
		[Token(Token = "0x403639D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403639E RID: 222110
		[Token(Token = "0x403639E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403639F RID: 222111
		[Token(Token = "0x403639F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
