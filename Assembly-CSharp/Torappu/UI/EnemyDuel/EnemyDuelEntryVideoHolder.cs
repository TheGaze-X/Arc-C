using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F9B RID: 20379
	[Token(Token = "0x2004F9B")]
	public class EnemyDuelEntryVideoHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E4B1 RID: 124081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B1")]
		[Address(RVA = "0x1802630", Offset = "0x1801230", VA = "0x181802630")]
		private void _LoadViewIfNot(string actId)
		{
		}

		// Token: 0x0601E4B2 RID: 124082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B2")]
		[Address(RVA = "0x1802540", Offset = "0x1801140", VA = "0x181802540")]
		public void Render(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E4B3 RID: 124083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B3")]
		[Address(RVA = "0x1802450", Offset = "0x1801050", VA = "0x181802450")]
		public void OnDestroy()
		{
		}

		// Token: 0x0601E4B4 RID: 124084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B4")]
		[Address(RVA = "0x18028A0", Offset = "0x18014A0", VA = "0x1818028A0")]
		public EnemyDuelEntryVideoHolder()
		{
		}

		// Token: 0x040286FA RID: 165626
		[Token(Token = "0x40286FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelOnAct;

		// Token: 0x040286FB RID: 165627
		[Token(Token = "0x40286FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelOnEnd;

		// Token: 0x040286FC RID: 165628
		[Token(Token = "0x40286FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _videoContainer;

		// Token: 0x040286FD RID: 165629
		[Token(Token = "0x40286FD")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040286FE RID: 165630
		[Token(Token = "0x40286FE")]
		[FieldOffset(Offset = "0x40")]
		private EnemyDuelEntryVideoView m_videoView;

		// Token: 0x040286FF RID: 165631
		[Token(Token = "0x40286FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadViewIfNot;

		// Token: 0x04028700 RID: 165632
		[Token(Token = "0x4028700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028701 RID: 165633
		[Token(Token = "0x4028701")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04028702 RID: 165634
		[Token(Token = "0x4028702")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
