using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003748 RID: 14152
	[Token(Token = "0x2003748")]
	public class PCMouseHandler : PCMouseHandlerBase
	{
		// Token: 0x060167C5 RID: 92101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60167C5")]
		[Address(RVA = "0xEDBF70", Offset = "0xEDAB70", VA = "0x180EDBF70", Slot = "4")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x060167C6 RID: 92102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C6")]
		[Address(RVA = "0xEDBFD0", Offset = "0xEDABD0", VA = "0x180EDBFD0", Slot = "5")]
		public override void InjectCanvas(Canvas uiCanvas)
		{
		}

		// Token: 0x060167C7 RID: 92103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C7")]
		[Address(RVA = "0xEDC0C0", Offset = "0xEDACC0", VA = "0x180EDC0C0", Slot = "6")]
		public override void OnMouseMoveEvent()
		{
		}

		// Token: 0x060167C8 RID: 92104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C8")]
		[Address(RVA = "0xEDC050", Offset = "0xEDAC50", VA = "0x180EDC050", Slot = "8")]
		public override void OnMouseDownEvent()
		{
		}

		// Token: 0x060167C9 RID: 92105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C9")]
		[Address(RVA = "0xEDC120", Offset = "0xEDAD20", VA = "0x180EDC120", Slot = "7")]
		public override void OnMouseUpEvent()
		{
		}

		// Token: 0x060167CA RID: 92106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167CA")]
		[Address(RVA = "0xEDC310", Offset = "0xEDAF10", VA = "0x180EDC310")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060167CB RID: 92107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167CB")]
		[Address(RVA = "0xEDC3B0", Offset = "0xEDAFB0", VA = "0x180EDC3B0")]
		private void _MoveMouse()
		{
		}

		// Token: 0x060167CC RID: 92108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167CC")]
		[Address(RVA = "0xEDC580", Offset = "0xEDB180", VA = "0x180EDC580")]
		private void _PlayAnim(UIAnimationLocation animLocation)
		{
		}

		// Token: 0x060167CD RID: 92109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167CD")]
		[Address(RVA = "0xEDC190", Offset = "0xEDAD90", VA = "0x180EDC190", Slot = "9")]
		public override void SetScaler(float scaler)
		{
		}

		// Token: 0x060167CE RID: 92110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167CE")]
		[Address(RVA = "0xEDC6D0", Offset = "0xEDB2D0", VA = "0x180EDC6D0")]
		public PCMouseHandler()
		{
		}

		// Token: 0x0401B14B RID: 110923
		[Token(Token = "0x401B14B")]
		private const float MAX_SIZE = 1.25f;

		// Token: 0x0401B14C RID: 110924
		[Token(Token = "0x401B14C")]
		private const float MIN_SIZE = 0.75f;

		// Token: 0x0401B14D RID: 110925
		[Token(Token = "0x401B14D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _onBtnDownAnim;

		// Token: 0x0401B14E RID: 110926
		[Token(Token = "0x401B14E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _onBtnUpAnim;

		// Token: 0x0401B14F RID: 110927
		[Token(Token = "0x401B14F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _id;

		// Token: 0x0401B150 RID: 110928
		[Token(Token = "0x401B150")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0401B151 RID: 110929
		[Token(Token = "0x401B151")]
		[FieldOffset(Offset = "0x48")]
		private Canvas m_canvasUI;

		// Token: 0x0401B152 RID: 110930
		[Token(Token = "0x401B152")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_cacheScale;

		// Token: 0x0401B153 RID: 110931
		[Token(Token = "0x401B153")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_isInited;

		// Token: 0x0401B154 RID: 110932
		[Token(Token = "0x401B154")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x0401B155 RID: 110933
		[Token(Token = "0x401B155")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InjectCanvas;

		// Token: 0x0401B156 RID: 110934
		[Token(Token = "0x401B156")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMouseMoveEvent;

		// Token: 0x0401B157 RID: 110935
		[Token(Token = "0x401B157")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMouseDownEvent;

		// Token: 0x0401B158 RID: 110936
		[Token(Token = "0x401B158")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMouseUpEvent;

		// Token: 0x0401B159 RID: 110937
		[Token(Token = "0x401B159")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B15A RID: 110938
		[Token(Token = "0x401B15A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__MoveMouse;

		// Token: 0x0401B15B RID: 110939
		[Token(Token = "0x401B15B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0401B15C RID: 110940
		[Token(Token = "0x401B15C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x0401B15D RID: 110941
		[Token(Token = "0x401B15D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
