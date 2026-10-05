using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE3 RID: 31459
	[Token(Token = "0x2007AE3")]
	public class Act12D6GameEndRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x0602C0F9 RID: 180473 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C0FA RID: 180474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700673D")]
		public FadeSwitchTween switchTween
		{
			[Token(Token = "0x602C0F9")]
			[Address(RVA = "0x27EE1D0", Offset = "0x27ECDD0", VA = "0x1827EE1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C0FA")]
			[Address(RVA = "0x27EE230", Offset = "0x27ECE30", VA = "0x1827EE230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602C0FB RID: 180475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0FB")]
		[Address(RVA = "0x27ED670", Offset = "0x27EC270", VA = "0x1827ED670")]
		public void Render(Act12D6GameEndViewModel viewModel)
		{
		}

		// Token: 0x0602C0FC RID: 180476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0FC")]
		[Address(RVA = "0x27EE020", Offset = "0x27ECC20", VA = "0x1827EE020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C0FD RID: 180477 RVA: 0x000DDFE8 File Offset: 0x000DC1E8
		[Token(Token = "0x602C0FD")]
		[Address(RVA = "0x27EDDA0", Offset = "0x27EC9A0", VA = "0x1827EDDA0")]
		private Color _GetModeBkgColor(string modeId)
		{
			return default(Color);
		}

		// Token: 0x0602C0FE RID: 180478 RVA: 0x000DE000 File Offset: 0x000DC200
		[Token(Token = "0x602C0FE")]
		[Address(RVA = "0x27EDEE0", Offset = "0x27ECAE0", VA = "0x1827EDEE0")]
		private Color _GetModeTextColor(string modeId)
		{
			return default(Color);
		}

		// Token: 0x0602C0FF RID: 180479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0FF")]
		[Address(RVA = "0x27EE170", Offset = "0x27ECD70", VA = "0x1827EE170")]
		public Act12D6GameEndRewardView()
		{
		}

		// Token: 0x0403FD57 RID: 261463
		[Token(Token = "0x403FD57")]
		private const string FACTOR_FORMAT = "x {0}";

		// Token: 0x0403FD58 RID: 261464
		[Token(Token = "0x403FD58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Act12D6GameEndRewardView.ModeColorData> _modeColorData;

		// Token: 0x0403FD59 RID: 261465
		[Token(Token = "0x403FD59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _passedZoneScoreView;

		// Token: 0x0403FD5A RID: 261466
		[Token(Token = "0x403FD5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _moveScoreView;

		// Token: 0x0403FD5B RID: 261467
		[Token(Token = "0x403FD5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _battleScoreView;

		// Token: 0x0403FD5C RID: 261468
		[Token(Token = "0x403FD5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _eliteScoreView;

		// Token: 0x0403FD5D RID: 261469
		[Token(Token = "0x403FD5D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _bossScoreView;

		// Token: 0x0403FD5E RID: 261470
		[Token(Token = "0x403FD5E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _relicScoreView;

		// Token: 0x0403FD5F RID: 261471
		[Token(Token = "0x403FD5F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _charScoreView;

		// Token: 0x0403FD60 RID: 261472
		[Token(Token = "0x403FD60")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imageModeBkg;

		// Token: 0x0403FD61 RID: 261473
		[Token(Token = "0x403FD61")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textMode;

		// Token: 0x0403FD62 RID: 261474
		[Token(Token = "0x403FD62")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textModeFactor;

		// Token: 0x0403FD63 RID: 261475
		[Token(Token = "0x403FD63")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _totoalScoreView;

		// Token: 0x0403FD64 RID: 261476
		[Token(Token = "0x403FD64")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textOutBuffTokenTotalScore;

		// Token: 0x0403FD65 RID: 261477
		[Token(Token = "0x403FD65")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textOutBuffTokenFactor;

		// Token: 0x0403FD66 RID: 261478
		[Token(Token = "0x403FD66")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _outBuffTokenCnt;

		// Token: 0x0403FD67 RID: 261479
		[Token(Token = "0x403FD67")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textOutBuffTokenName;

		// Token: 0x0403FD68 RID: 261480
		[Token(Token = "0x403FD68")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imageOutBuffTokenIcon;

		// Token: 0x0403FD69 RID: 261481
		[Token(Token = "0x403FD69")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textMilestoneTokenTotalScore;

		// Token: 0x0403FD6A RID: 261482
		[Token(Token = "0x403FD6A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textMilestoneTokenFactor;

		// Token: 0x0403FD6B RID: 261483
		[Token(Token = "0x403FD6B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _milestoneTokenCnt;

		// Token: 0x0403FD6C RID: 261484
		[Token(Token = "0x403FD6C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textMilestoneTokenName;

		// Token: 0x0403FD6D RID: 261485
		[Token(Token = "0x403FD6D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image _imageMilestoneTokenIcon;

		// Token: 0x0403FD6E RID: 261486
		[Token(Token = "0x403FD6E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0403FD70 RID: 261488
		[Token(Token = "0x403FD70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_switchTween;

		// Token: 0x0403FD71 RID: 261489
		[Token(Token = "0x403FD71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_switchTween;

		// Token: 0x0403FD72 RID: 261490
		[Token(Token = "0x403FD72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FD73 RID: 261491
		[Token(Token = "0x403FD73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FD74 RID: 261492
		[Token(Token = "0x403FD74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetModeBkgColor;

		// Token: 0x0403FD75 RID: 261493
		[Token(Token = "0x403FD75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetModeTextColor;

		// Token: 0x0403FD76 RID: 261494
		[Token(Token = "0x403FD76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AE4 RID: 31460
		[Token(Token = "0x2007AE4")]
		[Serializable]
		private class ModeColorData
		{
			// Token: 0x0602C100 RID: 180480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C100")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ModeColorData()
			{
			}

			// Token: 0x0403FD77 RID: 261495
			[Token(Token = "0x403FD77")]
			[FieldOffset(Offset = "0x10")]
			public string modeId;

			// Token: 0x0403FD78 RID: 261496
			[Token(Token = "0x403FD78")]
			[FieldOffset(Offset = "0x18")]
			public Color color;

			// Token: 0x0403FD79 RID: 261497
			[Token(Token = "0x403FD79")]
			[FieldOffset(Offset = "0x28")]
			public Color textColor;
		}
	}
}
