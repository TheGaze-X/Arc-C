using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E3A RID: 20026
	[Token(Token = "0x2004E3A")]
	public class FireworkPlateSelectionElementView : MonoBehaviour, IFireworkPlateElementView, IHotfixable
	{
		// Token: 0x0601DE96 RID: 122518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE96")]
		[Address(RVA = "0x1770300", Offset = "0x176EF00", VA = "0x181770300")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x0601DE97 RID: 122519 RVA: 0x000ACD70 File Offset: 0x000AAF70
		// (set) Token: 0x0601DE98 RID: 122520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004639")]
		public GridPosition gridPos
		{
			[Token(Token = "0x601DE97")]
			[Address(RVA = "0x1770440", Offset = "0x176F040", VA = "0x181770440", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(GridPosition);
			}
			[Token(Token = "0x601DE98")]
			[Address(RVA = "0x17704A0", Offset = "0x176F0A0", VA = "0x1817704A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601DE99 RID: 122521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE99")]
		[Address(RVA = "0x176FE80", Offset = "0x176EA80", VA = "0x18176FE80")]
		public void Render(FireworkPlateGroupModel plateModel, FireworkPlateViewStyle style)
		{
		}

		// Token: 0x0601DE9A RID: 122522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE9A")]
		[Address(RVA = "0x17703E0", Offset = "0x176EFE0", VA = "0x1817703E0")]
		public FireworkPlateSelectionElementView()
		{
		}

		// Token: 0x04027B07 RID: 162567
		[Token(Token = "0x4027B07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgOutline;

		// Token: 0x04027B08 RID: 162568
		[Token(Token = "0x4027B08")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04027B09 RID: 162569
		[Token(Token = "0x4027B09")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _highlightDuration;

		// Token: 0x04027B0A RID: 162570
		[Token(Token = "0x4027B0A")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_inited;

		// Token: 0x04027B0B RID: 162571
		[Token(Token = "0x4027B0B")]
		[FieldOffset(Offset = "0x30")]
		private FireworkData.PlateSlotData m_cachedSelectedPlatePiece;

		// Token: 0x04027B0C RID: 162572
		[Token(Token = "0x4027B0C")]
		[FieldOffset(Offset = "0x38")]
		private FireworkData.PlateSlotData m_cachedLastFilledPlatePiece;

		// Token: 0x04027B0D RID: 162573
		[Token(Token = "0x4027B0D")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_showTween;

		// Token: 0x04027B0E RID: 162574
		[Token(Token = "0x4027B0E")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_highlightTween;

		// Token: 0x04027B10 RID: 162576
		[Token(Token = "0x4027B10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027B11 RID: 162577
		[Token(Token = "0x4027B11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gridPos;

		// Token: 0x04027B12 RID: 162578
		[Token(Token = "0x4027B12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_gridPos;

		// Token: 0x04027B13 RID: 162579
		[Token(Token = "0x4027B13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B14 RID: 162580
		[Token(Token = "0x4027B14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
