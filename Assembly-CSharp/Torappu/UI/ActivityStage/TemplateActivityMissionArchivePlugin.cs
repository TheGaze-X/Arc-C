using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C8B RID: 27787
	[Token(Token = "0x2006C8B")]
	public class TemplateActivityMissionArchivePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A51 RID: 162385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A51")]
		[Address(RVA = "0x22E46B0", Offset = "0x22E32B0", VA = "0x1822E46B0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06027A52 RID: 162386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A52")]
		[Address(RVA = "0x22E4750", Offset = "0x22E3350", VA = "0x1822E4750", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A53 RID: 162387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A53")]
		[Address(RVA = "0x22E49A0", Offset = "0x22E35A0", VA = "0x1822E49A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A54 RID: 162388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A54")]
		[Address(RVA = "0x22E4A70", Offset = "0x22E3670", VA = "0x1822E4A70")]
		public TemplateActivityMissionArchivePlugin()
		{
		}

		// Token: 0x040383B8 RID: 230328
		[Token(Token = "0x40383B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x040383B9 RID: 230329
		[Token(Token = "0x40383B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x040383BA RID: 230330
		[Token(Token = "0x40383BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _unlockDescText;

		// Token: 0x040383BB RID: 230331
		[Token(Token = "0x40383BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x040383BC RID: 230332
		[Token(Token = "0x40383BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x040383BD RID: 230333
		[Token(Token = "0x40383BD")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040383BE RID: 230334
		[Token(Token = "0x40383BE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040383BF RID: 230335
		[Token(Token = "0x40383BF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x040383C0 RID: 230336
		[Token(Token = "0x40383C0")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedTopicId;

		// Token: 0x040383C1 RID: 230337
		[Token(Token = "0x40383C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x040383C2 RID: 230338
		[Token(Token = "0x40383C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x040383C3 RID: 230339
		[Token(Token = "0x40383C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040383C4 RID: 230340
		[Token(Token = "0x40383C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
