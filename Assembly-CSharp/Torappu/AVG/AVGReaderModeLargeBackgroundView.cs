using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F2C RID: 7980
	[Token(Token = "0x2001F2C")]
	public class AVGReaderModeLargeBackgroundView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModePerformanceViewModel>, IHotfixable
	{
		// Token: 0x0600C657 RID: 50775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C657")]
		[Address(RVA = "0x346CD20", Offset = "0x346B920", VA = "0x18346CD20", Slot = "4")]
		public void OnValueChanged(AVGReaderModePerformanceViewModel viewModel)
		{
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C658")]
		[Address(RVA = "0x346D120", Offset = "0x346BD20", VA = "0x18346D120")]
		public void RenderView(Command command)
		{
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C659")]
		[Address(RVA = "0x346E1C0", Offset = "0x346CDC0", VA = "0x18346E1C0")]
		private void _ExecuteImage(AVGReaderModeLargeBackgroundView.LargeBGParam param)
		{
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65A")]
		[Address(RVA = "0x346E680", Offset = "0x346D280", VA = "0x18346E680")]
		private void _ExecuteLargeBG(AVGReaderModeLargeBackgroundView.LargeBGParam param)
		{
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65B")]
		[Address(RVA = "0x346F040", Offset = "0x346DC40", VA = "0x18346F040")]
		private void _ExecuteVerticalBG(AVGReaderModeLargeBackgroundView.LargeBGParam param)
		{
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65C")]
		[Address(RVA = "0x346D430", Offset = "0x346C030", VA = "0x18346D430")]
		private void _ExecuteGridBG(AVGReaderModeLargeBackgroundView.LargeBGParam param)
		{
		}

		// Token: 0x0600C65D RID: 50781 RVA: 0x000487C8 File Offset: 0x000469C8
		[Token(Token = "0x600C65D")]
		[Address(RVA = "0x34706B0", Offset = "0x346F2B0", VA = "0x1834706B0")]
		private bool _LoadImage(Image image, string imageName, float width, float height, int idx, bool useCG)
		{
			return default(bool);
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x000487E0 File Offset: 0x000469E0
		[Token(Token = "0x600C65E")]
		[Address(RVA = "0x346F9F0", Offset = "0x346E5F0", VA = "0x18346F9F0")]
		private AVGReaderModeLargeBackgroundView.LargeBGParam _GenParamWithCommand(Command command)
		{
			return default(AVGReaderModeLargeBackgroundView.LargeBGParam);
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x000487F8 File Offset: 0x000469F8
		[Token(Token = "0x600C65F")]
		[Address(RVA = "0x3470E40", Offset = "0x346FA40", VA = "0x183470E40")]
		private static bool _TryExtractCGParam(Command command, ref string image)
		{
			return default(bool);
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x00048810 File Offset: 0x00046A10
		[Token(Token = "0x600C660")]
		[Address(RVA = "0x3470590", Offset = "0x346F190", VA = "0x183470590")]
		private static bool _IsSameParam(AVGReaderModeLargeBackgroundView.LargeBGParam left, AVGReaderModeLargeBackgroundView.LargeBGParam right)
		{
			return default(bool);
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C661")]
		[Address(RVA = "0x3470D90", Offset = "0x346F990", VA = "0x183470D90")]
		private void _ResetPanel()
		{
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C662")]
		[Address(RVA = "0x3470A90", Offset = "0x346F690", VA = "0x183470A90")]
		private void _ResetImages()
		{
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C663")]
		[Address(RVA = "0x3470920", Offset = "0x346F520", VA = "0x183470920")]
		private static void _ResetImage(Image img)
		{
		}

		// Token: 0x0600C664 RID: 50788 RVA: 0x00048828 File Offset: 0x00046A28
		[Token(Token = "0x600C664")]
		[Address(RVA = "0x3470430", Offset = "0x346F030", VA = "0x183470430")]
		private static Vector2 _InitPositionUpperLeft(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x00048840 File Offset: 0x00046A40
		[Token(Token = "0x600C665")]
		[Address(RVA = "0x3470180", Offset = "0x346ED80", VA = "0x183470180")]
		private static Vector2 _InitPositionCenter(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x00048858 File Offset: 0x00046A58
		[Token(Token = "0x600C666")]
		[Address(RVA = "0x3470340", Offset = "0x346EF40", VA = "0x183470340")]
		private static Vector2 _InitPositionLowerCenter(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x00048870 File Offset: 0x00046A70
		[Token(Token = "0x600C667")]
		[Address(RVA = "0x3470240", Offset = "0x346EE40", VA = "0x183470240")]
		private static Vector2 _InitPositionDefault(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C668")]
		[Address(RVA = "0x34712A0", Offset = "0x346FEA0", VA = "0x1834712A0")]
		public AVGReaderModeLargeBackgroundView()
		{
		}

		// Token: 0x0400CB86 RID: 52102
		[Token(Token = "0x400CB86")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> SUPPORTED_COMMANDS;

		// Token: 0x0400CB87 RID: 52103
		[Token(Token = "0x400CB87")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Func<List<float>, List<float>, Vector2>> POSITION_INIT_FUNCTION;

		// Token: 0x0400CB88 RID: 52104
		[Token(Token = "0x400CB88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Image> _images;

		// Token: 0x0400CB89 RID: 52105
		[Token(Token = "0x400CB89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _initOffset;

		// Token: 0x0400CB8A RID: 52106
		[Token(Token = "0x400CB8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _offset;

		// Token: 0x0400CB8B RID: 52107
		[Token(Token = "0x400CB8B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Ease _fadeEase;

		// Token: 0x0400CB8C RID: 52108
		[Token(Token = "0x400CB8C")]
		private const int MAX_IMAGE_COUNT = 4;

		// Token: 0x0400CB8D RID: 52109
		[Token(Token = "0x400CB8D")]
		private const float IMAGE_FADE_TIME = 0.1f;

		// Token: 0x0400CB8E RID: 52110
		[Token(Token = "0x400CB8E")]
		[FieldOffset(Offset = "0x34")]
		private bool m_hasLastParam;

		// Token: 0x0400CB8F RID: 52111
		[Token(Token = "0x400CB8F")]
		[FieldOffset(Offset = "0x38")]
		private AVGReaderModeLargeBackgroundView.LargeBGParam m_lastParam;

		// Token: 0x0400CB90 RID: 52112
		[Token(Token = "0x400CB90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CB91 RID: 52113
		[Token(Token = "0x400CB91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400CB92 RID: 52114
		[Token(Token = "0x400CB92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteImage;

		// Token: 0x0400CB93 RID: 52115
		[Token(Token = "0x400CB93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteLargeBG;

		// Token: 0x0400CB94 RID: 52116
		[Token(Token = "0x400CB94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteVerticalBG;

		// Token: 0x0400CB95 RID: 52117
		[Token(Token = "0x400CB95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteGridBG;

		// Token: 0x0400CB96 RID: 52118
		[Token(Token = "0x400CB96")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400CB97 RID: 52119
		[Token(Token = "0x400CB97")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenParamWithCommand;

		// Token: 0x0400CB98 RID: 52120
		[Token(Token = "0x400CB98")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryExtractCGParam;

		// Token: 0x0400CB99 RID: 52121
		[Token(Token = "0x400CB99")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsSameParam;

		// Token: 0x0400CB9A RID: 52122
		[Token(Token = "0x400CB9A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetPanel;

		// Token: 0x0400CB9B RID: 52123
		[Token(Token = "0x400CB9B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetImages;

		// Token: 0x0400CB9C RID: 52124
		[Token(Token = "0x400CB9C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetImage;

		// Token: 0x0400CB9D RID: 52125
		[Token(Token = "0x400CB9D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitPositionUpperLeft;

		// Token: 0x0400CB9E RID: 52126
		[Token(Token = "0x400CB9E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitPositionCenter;

		// Token: 0x0400CB9F RID: 52127
		[Token(Token = "0x400CB9F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitPositionLowerCenter;

		// Token: 0x0400CBA0 RID: 52128
		[Token(Token = "0x400CBA0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitPositionDefault;

		// Token: 0x0400CBA1 RID: 52129
		[Token(Token = "0x400CBA1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F2D RID: 7981
		[Token(Token = "0x2001F2D")]
		public struct LargeBGParam
		{
			// Token: 0x0400CBA2 RID: 52130
			[Token(Token = "0x400CBA2")]
			[FieldOffset(Offset = "0x0")]
			public AVGReaderModeLargeBackgroundView.LargeBGParam.BGType type;

			// Token: 0x0400CBA3 RID: 52131
			[Token(Token = "0x400CBA3")]
			[FieldOffset(Offset = "0x8")]
			public string imageGroup;

			// Token: 0x0400CBA4 RID: 52132
			[Token(Token = "0x400CBA4")]
			[FieldOffset(Offset = "0x10")]
			public string solidWidthStr;

			// Token: 0x0400CBA5 RID: 52133
			[Token(Token = "0x400CBA5")]
			[FieldOffset(Offset = "0x18")]
			public float solidWidthFloat;

			// Token: 0x0400CBA6 RID: 52134
			[Token(Token = "0x400CBA6")]
			[FieldOffset(Offset = "0x20")]
			public string solidHeightStr;

			// Token: 0x0400CBA7 RID: 52135
			[Token(Token = "0x400CBA7")]
			[FieldOffset(Offset = "0x28")]
			public float solidHeightFloat;

			// Token: 0x0400CBA8 RID: 52136
			[Token(Token = "0x400CBA8")]
			[FieldOffset(Offset = "0x2C")]
			public float x;

			// Token: 0x0400CBA9 RID: 52137
			[Token(Token = "0x400CBA9")]
			[FieldOffset(Offset = "0x30")]
			public float y;

			// Token: 0x0400CBAA RID: 52138
			[Token(Token = "0x400CBAA")]
			[FieldOffset(Offset = "0x34")]
			public float xScale;

			// Token: 0x0400CBAB RID: 52139
			[Token(Token = "0x400CBAB")]
			[FieldOffset(Offset = "0x38")]
			public float yScale;

			// Token: 0x0400CBAC RID: 52140
			[Token(Token = "0x400CBAC")]
			[FieldOffset(Offset = "0x40")]
			public string initPosMode;

			// Token: 0x0400CBAD RID: 52141
			[Token(Token = "0x400CBAD")]
			[FieldOffset(Offset = "0x48")]
			public bool useCG;

			// Token: 0x0400CBAE RID: 52142
			[Token(Token = "0x400CBAE")]
			[FieldOffset(Offset = "0x4C")]
			public float fadetime;

			// Token: 0x02001F2E RID: 7982
			[Token(Token = "0x2001F2E")]
			public enum BGType
			{
				// Token: 0x0400CBB0 RID: 52144
				[Token(Token = "0x400CBB0")]
				LargeBG,
				// Token: 0x0400CBB1 RID: 52145
				[Token(Token = "0x400CBB1")]
				VerticalBG,
				// Token: 0x0400CBB2 RID: 52146
				[Token(Token = "0x400CBB2")]
				GridBG
			}
		}
	}
}
