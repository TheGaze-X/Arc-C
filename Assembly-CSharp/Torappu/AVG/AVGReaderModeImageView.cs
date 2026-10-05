using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F29 RID: 7977
	[Token(Token = "0x2001F29")]
	public class AVGReaderModeImageView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModePerformanceViewModel>, IHotfixable
	{
		// Token: 0x0600C647 RID: 50759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C647")]
		[Address(RVA = "0x346ADA0", Offset = "0x34699A0", VA = "0x18346ADA0", Slot = "4")]
		public void OnValueChanged(AVGReaderModePerformanceViewModel viewModel)
		{
		}

		// Token: 0x0600C648 RID: 50760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C648")]
		[Address(RVA = "0x346B2A0", Offset = "0x3469EA0", VA = "0x18346B2A0")]
		public void RenderView(Command command)
		{
		}

		// Token: 0x0600C649 RID: 50761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C649")]
		[Address(RVA = "0x346B520", Offset = "0x346A120", VA = "0x18346B520")]
		private void _ExecuteIfChanged(AVGReaderModeImageView.ImageParam param)
		{
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64A")]
		[Address(RVA = "0x346B650", Offset = "0x346A250", VA = "0x18346B650")]
		public void _ExecuteImage(AVGReaderModeImageView.ImageParam param)
		{
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x00048738 File Offset: 0x00046938
		[Token(Token = "0x600C64B")]
		[Address(RVA = "0x346C0E0", Offset = "0x346ACE0", VA = "0x18346C0E0")]
		private bool _LoadImage(Image image, AVGReaderModeImageView.ImageParam param)
		{
			return default(bool);
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C64C")]
		[Address(RVA = "0x346C630", Offset = "0x346B230", VA = "0x18346C630")]
		private Sprite _LoadSprite(string key, AVGReaderModeImageView.ImageParam.ImageType type)
		{
			return null;
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C64D")]
		[Address(RVA = "0x346BF10", Offset = "0x346AB10", VA = "0x18346BF10")]
		private string _GetResPathByImageType(string imageName, AVGReaderModeImageView.ImageParam.ImageType type)
		{
			return null;
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x00048750 File Offset: 0x00046950
		[Token(Token = "0x600C64E")]
		[Address(RVA = "0x346BA80", Offset = "0x346A680", VA = "0x18346BA80")]
		private AVGReaderModeImageView.ImageParam _GenParamWithCommand(Command command)
		{
			return default(AVGReaderModeImageView.ImageParam);
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x00048768 File Offset: 0x00046968
		[Token(Token = "0x600C64F")]
		[Address(RVA = "0x346C850", Offset = "0x346B450", VA = "0x18346C850")]
		private bool _ShouldHandleAvgDisplayBackground()
		{
			return default(bool);
		}

		// Token: 0x0600C650 RID: 50768 RVA: 0x00048780 File Offset: 0x00046980
		[Token(Token = "0x600C650")]
		[Address(RVA = "0x346BFF0", Offset = "0x346ABF0", VA = "0x18346BFF0")]
		private bool _HasLargeBackgroundCommand(AVGReaderModePerformanceViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x00048798 File Offset: 0x00046998
		[Token(Token = "0x600C651")]
		[Address(RVA = "0x346B400", Offset = "0x346A000", VA = "0x18346B400")]
		private AVGReaderModeImageView.ImageParam _CreateEmptyBackgroundParam()
		{
			return default(AVGReaderModeImageView.ImageParam);
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x000487B0 File Offset: 0x000469B0
		[Token(Token = "0x600C652")]
		[Address(RVA = "0x346C9D0", Offset = "0x346B5D0", VA = "0x18346C9D0")]
		private bool _TryGetBackgroundParamFromAvgDisplay(Command command, out AVGReaderModeImageView.ImageParam param)
		{
			return default(bool);
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C653")]
		[Address(RVA = "0x346C8E0", Offset = "0x346B4E0", VA = "0x18346C8E0")]
		private static void _SwapImages(ref Image lhs, ref Image rhs)
		{
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C654")]
		[Address(RVA = "0x346C7A0", Offset = "0x346B3A0", VA = "0x18346C7A0")]
		private static void _ResetImage(Image img)
		{
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C655")]
		[Address(RVA = "0x346CC40", Offset = "0x346B840", VA = "0x18346CC40")]
		public AVGReaderModeImageView()
		{
		}

		// Token: 0x0400CB60 RID: 52064
		[Token(Token = "0x400CB60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _supportedCommands;

		// Token: 0x0400CB61 RID: 52065
		[Token(Token = "0x400CB61")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<string> m_supportedCommandsSet;

		// Token: 0x0400CB62 RID: 52066
		[Token(Token = "0x400CB62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Image _foreImage;

		// Token: 0x0400CB63 RID: 52067
		[Token(Token = "0x400CB63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Image _backImage;

		// Token: 0x0400CB64 RID: 52068
		[Token(Token = "0x400CB64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Ease _fadeEase;

		// Token: 0x0400CB65 RID: 52069
		[Token(Token = "0x400CB65")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Vector2 _screenAdaptReferenceResolution;

		// Token: 0x0400CB66 RID: 52070
		[Token(Token = "0x400CB66")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RectTransform _rectTransform;

		// Token: 0x0400CB67 RID: 52071
		[Token(Token = "0x400CB67")]
		private const float IMAGE_FADE_TIME = 0.1f;

		// Token: 0x0400CB68 RID: 52072
		[Token(Token = "0x400CB68")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasLastImageName;

		// Token: 0x0400CB69 RID: 52073
		[Token(Token = "0x400CB69")]
		[FieldOffset(Offset = "0x58")]
		private string m_lastImageName;

		// Token: 0x0400CB6A RID: 52074
		[Token(Token = "0x400CB6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CB6B RID: 52075
		[Token(Token = "0x400CB6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400CB6C RID: 52076
		[Token(Token = "0x400CB6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteIfChanged;

		// Token: 0x0400CB6D RID: 52077
		[Token(Token = "0x400CB6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteImage;

		// Token: 0x0400CB6E RID: 52078
		[Token(Token = "0x400CB6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400CB6F RID: 52079
		[Token(Token = "0x400CB6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400CB70 RID: 52080
		[Token(Token = "0x400CB70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetResPathByImageType;

		// Token: 0x0400CB71 RID: 52081
		[Token(Token = "0x400CB71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenParamWithCommand;

		// Token: 0x0400CB72 RID: 52082
		[Token(Token = "0x400CB72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShouldHandleAvgDisplayBackground;

		// Token: 0x0400CB73 RID: 52083
		[Token(Token = "0x400CB73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HasLargeBackgroundCommand;

		// Token: 0x0400CB74 RID: 52084
		[Token(Token = "0x400CB74")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateEmptyBackgroundParam;

		// Token: 0x0400CB75 RID: 52085
		[Token(Token = "0x400CB75")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetBackgroundParamFromAvgDisplay;

		// Token: 0x0400CB76 RID: 52086
		[Token(Token = "0x400CB76")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SwapImages;

		// Token: 0x0400CB77 RID: 52087
		[Token(Token = "0x400CB77")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetImage;

		// Token: 0x0400CB78 RID: 52088
		[Token(Token = "0x400CB78")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F2A RID: 7978
		[Token(Token = "0x2001F2A")]
		public struct ImageParam
		{
			// Token: 0x0400CB79 RID: 52089
			[Token(Token = "0x400CB79")]
			[FieldOffset(Offset = "0x0")]
			public string imageName;

			// Token: 0x0400CB7A RID: 52090
			[Token(Token = "0x400CB7A")]
			[FieldOffset(Offset = "0x8")]
			public AVGReaderModeImageView.ImageParam.ImageType type;

			// Token: 0x0400CB7B RID: 52091
			[Token(Token = "0x400CB7B")]
			[FieldOffset(Offset = "0xC")]
			public bool tiled;

			// Token: 0x0400CB7C RID: 52092
			[Token(Token = "0x400CB7C")]
			[FieldOffset(Offset = "0x10")]
			public float width;

			// Token: 0x0400CB7D RID: 52093
			[Token(Token = "0x400CB7D")]
			[FieldOffset(Offset = "0x14")]
			public float height;

			// Token: 0x0400CB7E RID: 52094
			[Token(Token = "0x400CB7E")]
			[FieldOffset(Offset = "0x18")]
			public string screenAdaptMode;

			// Token: 0x0400CB7F RID: 52095
			[Token(Token = "0x400CB7F")]
			[FieldOffset(Offset = "0x20")]
			public float posX;

			// Token: 0x0400CB80 RID: 52096
			[Token(Token = "0x400CB80")]
			[FieldOffset(Offset = "0x24")]
			public float posY;

			// Token: 0x0400CB81 RID: 52097
			[Token(Token = "0x400CB81")]
			[FieldOffset(Offset = "0x28")]
			public float scaleX;

			// Token: 0x0400CB82 RID: 52098
			[Token(Token = "0x400CB82")]
			[FieldOffset(Offset = "0x2C")]
			public float scaleY;

			// Token: 0x02001F2B RID: 7979
			[Token(Token = "0x2001F2B")]
			public enum ImageType
			{
				// Token: 0x0400CB84 RID: 52100
				[Token(Token = "0x400CB84")]
				Background,
				// Token: 0x0400CB85 RID: 52101
				[Token(Token = "0x400CB85")]
				Image
			}
		}
	}
}
