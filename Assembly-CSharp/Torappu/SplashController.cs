using System;
using System.Diagnostics;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Grading;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public class SplashController : MonoBehaviour
	{
		// Token: 0x06005BC0 RID: 23488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x1AFC650", Offset = "0x1AFB250", VA = "0x181AFC650")]
		private void Start()
		{
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0x1AFCA40", Offset = "0x1AFB640", VA = "0x181AFCA40")]
		private void Update()
		{
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0x1AFCDB0", Offset = "0x1AFB9B0", VA = "0x181AFCDB0")]
		private void _ShowInitLicense()
		{
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0x1AFCC00", Offset = "0x1AFB800", VA = "0x181AFCC00")]
		private void _OnTweenFinished()
		{
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC4")]
		[Address(RVA = "0x1AFCF10", Offset = "0x1AFBB10", VA = "0x181AFCF10")]
		private void _SwitchToInitScene()
		{
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x0002EF50 File Offset: 0x0002D150
		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool _CheckIfResValid()
		{
			return default(bool);
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x1AFCB10", Offset = "0x1AFB710", VA = "0x181AFCB10")]
		private void _HandlePerformanceTest()
		{
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x1AFCE40", Offset = "0x1AFBA40", VA = "0x181AFCE40")]
		private void _ShowResourceLoadFail()
		{
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x1AFCE70", Offset = "0x1AFBA70", VA = "0x181AFCE70")]
		private void _ShowSplashImage(int index)
		{
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x1AFCC20", Offset = "0x1AFB820", VA = "0x181AFCC20")]
		private void _PerformanceTestFinish()
		{
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCA")]
		[Address(RVA = "0x1AFCCD0", Offset = "0x1AFB8D0", VA = "0x181AFCCD0")]
		private void _SDKSetGameVersionForCrashLog()
		{
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x1AFCBF0", Offset = "0x1AFB7F0", VA = "0x181AFCBF0")]
		[Conditional("DEVELOPMENT_BUILD")]
		private void _InitProfilerBuffer()
		{
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x1AFCB00", Offset = "0x1AFB700", VA = "0x181AFCB00")]
		public void _ExitGame()
		{
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x1AFCF70", Offset = "0x1AFBB70", VA = "0x181AFCF70")]
		public SplashController()
		{
		}

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GlobalOptions _globalOptions;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _initialFadeTime;

		// Token: 0x04002148 RID: 8520
		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _regularFadeTime;

		// Token: 0x04002149 RID: 8521
		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _showTime;

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _blackCoverImage;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _gameObjectSplashImages;

		// Token: 0x0400214C RID: 8524
		[Token(Token = "0x400214C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PerformanceTest _performanceTest;

		// Token: 0x0400214D RID: 8525
		[Token(Token = "0x400214D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _warningDialog;

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textResourceLoading;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textConnectUs;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textConfirm;

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x68")]
		private Sequence m_tween;

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x70")]
		private SplashController.SwitchSceneTrigger m_sceneTrigger;

		// Token: 0x0200057C RID: 1404
		[Token(Token = "0x200057C")]
		private class SwitchSceneTrigger
		{
			// Token: 0x06005BCE RID: 23502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BCE")]
			[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
			public SwitchSceneTrigger(Action switchToScene)
			{
			}

			// Token: 0x06005BCF RID: 23503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BCF")]
			[Address(RVA = "0x1CF9570", Offset = "0x1CF8170", VA = "0x181CF9570")]
			public void NotifyLicenseGranted()
			{
			}

			// Token: 0x06005BD0 RID: 23504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BD0")]
			[Address(RVA = "0x1CF95C0", Offset = "0x1CF81C0", VA = "0x181CF95C0")]
			public void NotifyTweenFinshed()
			{
			}

			// Token: 0x06005BD1 RID: 23505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BD1")]
			[Address(RVA = "0x1CF9610", Offset = "0x1CF8210", VA = "0x181CF9610")]
			private void _TryTriggerSwitchScene()
			{
			}

			// Token: 0x04002153 RID: 8531
			[Token(Token = "0x4002153")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isTweenFinished;

			// Token: 0x04002154 RID: 8532
			[Token(Token = "0x4002154")]
			[FieldOffset(Offset = "0x11")]
			private bool m_isLicenseGranted;

			// Token: 0x04002155 RID: 8533
			[Token(Token = "0x4002155")]
			[FieldOffset(Offset = "0x18")]
			private Action m_switchToScene;
		}
	}
}
