using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x020069BF RID: 27071
	[Token(Token = "0x20069BF")]
	public class StageZoneTabSeasonPlugin : StageZoneTabView.IPlugin
	{
		// Token: 0x06026BCE RID: 158670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BCE")]
		[Address(RVA = "0x21D8C60", Offset = "0x21D7860", VA = "0x1821D8C60", Slot = "4")]
		public override void RefreshTargetImg(StageZoneTabViewModel viewModel, bool isBlack, ref Image pic, out bool needFadeColor)
		{
		}

		// Token: 0x06026BCF RID: 158671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BCF")]
		[Address(RVA = "0x21D8F40", Offset = "0x21D7B40", VA = "0x1821D8F40")]
		private void _ShowCrisisIconIfNeed(StageSeasonTabViewModel seasonViewModel)
		{
		}

		// Token: 0x06026BD0 RID: 158672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD0")]
		[Address(RVA = "0x21D90E0", Offset = "0x21D7CE0", VA = "0x1821D90E0")]
		private void _ShowVecBreakIconIfNeed(ActivityTable.BasicData vecBreakInfo)
		{
		}

		// Token: 0x06026BD1 RID: 158673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageZoneTabSeasonPlugin()
		{
		}

		// Token: 0x04036B34 RID: 224052
		[Token(Token = "0x4036B34")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgCrisisIcon;

		// Token: 0x04036B35 RID: 224053
		[Token(Token = "0x4036B35")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgVecBreakIcon;

		// Token: 0x04036B36 RID: 224054
		[Token(Token = "0x4036B36")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;
	}
}
