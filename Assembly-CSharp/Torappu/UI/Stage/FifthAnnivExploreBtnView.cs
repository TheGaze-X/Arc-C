using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F2 RID: 26866
	[Token(Token = "0x20068F2")]
	public class FifthAnnivExploreBtnView : StageAdditionalBtnView
	{
		// Token: 0x060267CA RID: 157642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267CA")]
		[Address(RVA = "0x2191360", Offset = "0x218FF60", VA = "0x182191360")]
		public void OnClickEvent()
		{
		}

		// Token: 0x060267CB RID: 157643 RVA: 0x000CB520 File Offset: 0x000C9720
		[Token(Token = "0x60267CB")]
		[Address(RVA = "0x2191420", Offset = "0x2190020", VA = "0x182191420", Slot = "4")]
		public override bool OnUpdate(ZoneViewModel model)
		{
			return default(bool);
		}

		// Token: 0x060267CC RID: 157644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267CC")]
		[Address(RVA = "0x2191560", Offset = "0x2190160", VA = "0x182191560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060267CD RID: 157645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267CD")]
		[Address(RVA = "0x21915F0", Offset = "0x21901F0", VA = "0x1821915F0")]
		public FifthAnnivExploreBtnView()
		{
		}

		// Token: 0x04036387 RID: 222087
		[Token(Token = "0x4036387")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04036388 RID: 222088
		[Token(Token = "0x4036388")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04036389 RID: 222089
		[Token(Token = "0x4036389")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0403638A RID: 222090
		[Token(Token = "0x403638A")]
		[FieldOffset(Offset = "0x30")]
		private TrackPointViewProperty m_trackProperty;

		// Token: 0x0403638B RID: 222091
		[Token(Token = "0x403638B")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403638C RID: 222092
		[Token(Token = "0x403638C")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403638D RID: 222093
		[Token(Token = "0x403638D")]
		[FieldOffset(Offset = "0x49")]
		private bool m_cachedOpen;

		// Token: 0x0403638E RID: 222094
		[Token(Token = "0x403638E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0403638F RID: 222095
		[Token(Token = "0x403638F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04036390 RID: 222096
		[Token(Token = "0x4036390")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036391 RID: 222097
		[Token(Token = "0x4036391")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
