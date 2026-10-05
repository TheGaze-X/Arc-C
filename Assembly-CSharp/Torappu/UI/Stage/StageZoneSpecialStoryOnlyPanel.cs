using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200689B RID: 26779
	[Token(Token = "0x200689B")]
	public class StageZoneSpecialStoryOnlyPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026600 RID: 157184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026600")]
		[Address(RVA = "0x21714F0", Offset = "0x21700F0", VA = "0x1821714F0")]
		public void Show(StageZoneSpecialStoryOnlyPanel.Param param)
		{
		}

		// Token: 0x06026601 RID: 157185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026601")]
		[Address(RVA = "0x2171340", Offset = "0x216FF40", VA = "0x182171340")]
		public void Hide()
		{
		}

		// Token: 0x06026602 RID: 157186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026602")]
		[Address(RVA = "0x2171470", Offset = "0x2170070", VA = "0x182171470")]
		public void OnStartButtonPressed()
		{
		}

		// Token: 0x06026603 RID: 157187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026603")]
		[Address(RVA = "0x21713B0", Offset = "0x216FFB0", VA = "0x1821713B0")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x06026604 RID: 157188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026604")]
		[Address(RVA = "0x21717C0", Offset = "0x21703C0", VA = "0x1821717C0")]
		public StageZoneSpecialStoryOnlyPanel()
		{
		}

		// Token: 0x040360A5 RID: 221349
		[Token(Token = "0x40360A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x040360A6 RID: 221350
		[Token(Token = "0x40360A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgPanel;

		// Token: 0x040360A7 RID: 221351
		[Token(Token = "0x40360A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x040360A8 RID: 221352
		[Token(Token = "0x40360A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageTitleText;

		// Token: 0x040360A9 RID: 221353
		[Token(Token = "0x40360A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x040360AA RID: 221354
		[Token(Token = "0x40360AA")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040360AB RID: 221355
		[Token(Token = "0x40360AB")]
		[FieldOffset(Offset = "0x50")]
		private Action m_startHandler;

		// Token: 0x040360AC RID: 221356
		[Token(Token = "0x40360AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040360AD RID: 221357
		[Token(Token = "0x40360AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040360AE RID: 221358
		[Token(Token = "0x40360AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStartButtonPressed;

		// Token: 0x040360AF RID: 221359
		[Token(Token = "0x40360AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x040360B0 RID: 221360
		[Token(Token = "0x40360B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200689C RID: 26780
		[Token(Token = "0x200689C")]
		public struct Param
		{
			// Token: 0x040360B1 RID: 221361
			[Token(Token = "0x40360B1")]
			[FieldOffset(Offset = "0x0")]
			public string stageCode;

			// Token: 0x040360B2 RID: 221362
			[Token(Token = "0x40360B2")]
			[FieldOffset(Offset = "0x8")]
			public string stageTitle;

			// Token: 0x040360B3 RID: 221363
			[Token(Token = "0x40360B3")]
			[FieldOffset(Offset = "0x10")]
			public string stageDesc;

			// Token: 0x040360B4 RID: 221364
			[Token(Token = "0x40360B4")]
			[FieldOffset(Offset = "0x18")]
			public Action startHandler;

			// Token: 0x040360B5 RID: 221365
			[Token(Token = "0x40360B5")]
			[FieldOffset(Offset = "0x20")]
			public string spriteId;

			// Token: 0x040360B6 RID: 221366
			[Token(Token = "0x40360B6")]
			[FieldOffset(Offset = "0x0")]
			public static StageZoneSpecialStoryOnlyPanel.Param EMPTY;
		}
	}
}
