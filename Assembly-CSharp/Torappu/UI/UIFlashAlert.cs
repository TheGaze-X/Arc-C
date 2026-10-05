using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Notification;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039FE RID: 14846
	[Token(Token = "0x20039FE")]
	public class UIFlashAlert : NotifyView, IFloatNotifyView
	{
		// Token: 0x060176EF RID: 95983 RVA: 0x00096708 File Offset: 0x00094908
		[Token(Token = "0x60176EF")]
		[Address(RVA = "0xFC4190", Offset = "0xFC2D90", VA = "0x180FC4190")]
		private bool _CheckAbleToAlert()
		{
			return default(bool);
		}

		// Token: 0x060176F0 RID: 95984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176F0")]
		[Address(RVA = "0xFC3BD0", Offset = "0xFC27D0", VA = "0x180FC3BD0")]
		public void HandleFlashAlert(UIFlashAlert.InputParam option)
		{
		}

		// Token: 0x060176F1 RID: 95985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176F1")]
		[Address(RVA = "0xFC4220", Offset = "0xFC2E20", VA = "0x180FC4220")]
		private Tweener _InstTweener(float preferedWeight, float duration)
		{
			return null;
		}

		// Token: 0x060176F2 RID: 95986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176F2")]
		[Address(RVA = "0xFC4050", Offset = "0xFC2C50", VA = "0x180FC4050", Slot = "4")]
		public override void TriggerRender(NotifyViewParam rawParam)
		{
		}

		// Token: 0x060176F3 RID: 95987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176F3")]
		[Address(RVA = "0xFC3B10", Offset = "0xFC2710", VA = "0x180FC3B10", Slot = "5")]
		public UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x060176F4 RID: 95988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176F4")]
		[Address(RVA = "0xFC4370", Offset = "0xFC2F70", VA = "0x180FC4370")]
		public UIFlashAlert()
		{
		}

		// Token: 0x0401C4F0 RID: 115952
		[Token(Token = "0x401C4F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _canvas;

		// Token: 0x0401C4F1 RID: 115953
		[Token(Token = "0x401C4F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _resText;

		// Token: 0x0401C4F2 RID: 115954
		[Token(Token = "0x401C4F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _hideTime;

		// Token: 0x0401C4F3 RID: 115955
		[Token(Token = "0x401C4F3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _lengthPerSec;

		// Token: 0x0401C4F4 RID: 115956
		[Token(Token = "0x401C4F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _widthBar;

		// Token: 0x0401C4F5 RID: 115957
		[Token(Token = "0x401C4F5")]
		[FieldOffset(Offset = "0x44")]
		private int m_loopTimes;

		// Token: 0x0401C4F6 RID: 115958
		[Token(Token = "0x401C4F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401C4F7 RID: 115959
		[Token(Token = "0x401C4F7")]
		[FieldOffset(Offset = "0x50")]
		private Sequence m_animSequence;

		// Token: 0x0401C4F8 RID: 115960
		[Token(Token = "0x401C4F8")]
		[FieldOffset(Offset = "0x58")]
		private TextGenerator m_textGenerator;

		// Token: 0x0401C4F9 RID: 115961
		[Token(Token = "0x401C4F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckAbleToAlert;

		// Token: 0x0401C4FA RID: 115962
		[Token(Token = "0x401C4FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleFlashAlert;

		// Token: 0x0401C4FB RID: 115963
		[Token(Token = "0x401C4FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InstTweener;

		// Token: 0x0401C4FC RID: 115964
		[Token(Token = "0x401C4FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerRender;

		// Token: 0x0401C4FD RID: 115965
		[Token(Token = "0x401C4FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0401C4FE RID: 115966
		[Token(Token = "0x401C4FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039FF RID: 14847
		[Token(Token = "0x20039FF")]
		public class InputParam : NotifyViewParam
		{
			// Token: 0x060176F6 RID: 95990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60176F6")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InputParam()
			{
			}

			// Token: 0x0401C4FF RID: 115967
			[Token(Token = "0x401C4FF")]
			[FieldOffset(Offset = "0x10")]
			public string alertText;

			// Token: 0x0401C500 RID: 115968
			[Token(Token = "0x401C500")]
			[FieldOffset(Offset = "0x18")]
			public int times;

			// Token: 0x0401C501 RID: 115969
			[Token(Token = "0x401C501")]
			[FieldOffset(Offset = "0x20")]
			public Action onAlertEnd;
		}
	}
}
