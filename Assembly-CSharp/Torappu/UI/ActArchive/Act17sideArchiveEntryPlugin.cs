using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AA6 RID: 27302
	[Token(Token = "0x2006AA6")]
	public class Act17sideArchiveEntryPlugin : ArchiveActivityEntryPlugin
	{
		// Token: 0x060270E4 RID: 159972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270E4")]
		[Address(RVA = "0x22315C0", Offset = "0x22301C0", VA = "0x1822315C0", Slot = "4")]
		public override void OnEnter()
		{
		}

		// Token: 0x060270E5 RID: 159973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270E5")]
		[Address(RVA = "0x2231720", Offset = "0x2230320", VA = "0x182231720", Slot = "6")]
		public override void OnExit()
		{
		}

		// Token: 0x060270E6 RID: 159974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270E6")]
		[Address(RVA = "0x2230D20", Offset = "0x222F920", VA = "0x182230D20")]
		public Tween GenerateEnterTween()
		{
			return null;
		}

		// Token: 0x060270E7 RID: 159975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270E7")]
		[Address(RVA = "0x22310C0", Offset = "0x222FCC0", VA = "0x1822310C0")]
		public Tween GenerateLoopTween()
		{
			return null;
		}

		// Token: 0x060270E8 RID: 159976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270E8")]
		[Address(RVA = "0x22317C0", Offset = "0x22303C0", VA = "0x1822317C0")]
		public void ResetBtnStatus(bool isShow)
		{
		}

		// Token: 0x060270E9 RID: 159977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270E9")]
		[Address(RVA = "0x2231BB0", Offset = "0x22307B0", VA = "0x182231BB0")]
		public Act17sideArchiveEntryPlugin()
		{
		}

		// Token: 0x060270EB RID: 159979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270EB")]
		[Address(RVA = "0x2231B90", Offset = "0x2230790", VA = "0x182231B90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060270EC RID: 159980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270EC")]
		[Address(RVA = "0x2231BA0", Offset = "0x22307A0", VA = "0x182231BA0")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04037463 RID: 226403
		[Token(Token = "0x4037463")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _btnLandmark;

		// Token: 0x04037464 RID: 226404
		[Token(Token = "0x4037464")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _btnLog;

		// Token: 0x04037465 RID: 226405
		[Token(Token = "0x4037465")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _btnMusic;

		// Token: 0x04037466 RID: 226406
		[Token(Token = "0x4037466")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _btnPic;

		// Token: 0x04037467 RID: 226407
		[Token(Token = "0x4037467")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroupLandmark;

		// Token: 0x04037468 RID: 226408
		[Token(Token = "0x4037468")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupLog;

		// Token: 0x04037469 RID: 226409
		[Token(Token = "0x4037469")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroupMusic;

		// Token: 0x0403746A RID: 226410
		[Token(Token = "0x403746A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasGroupPic;

		// Token: 0x0403746B RID: 226411
		[Token(Token = "0x403746B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_entryAnimPlayed;

		// Token: 0x0403746C RID: 226412
		[Token(Token = "0x403746C")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cachedTween;

		// Token: 0x0403746D RID: 226413
		[Token(Token = "0x403746D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403746E RID: 226414
		[Token(Token = "0x403746E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403746F RID: 226415
		[Token(Token = "0x403746F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateEnterTween;

		// Token: 0x04037470 RID: 226416
		[Token(Token = "0x4037470")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateLoopTween;

		// Token: 0x04037471 RID: 226417
		[Token(Token = "0x4037471")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetBtnStatus;

		// Token: 0x04037472 RID: 226418
		[Token(Token = "0x4037472")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
