using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006010 RID: 24592
	[Token(Token = "0x2006010")]
	public class CGGalleryInspectImageViewScaleHandler : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005402 RID: 21506
		// (set) Token: 0x060238F9 RID: 145657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005402")]
		public float horizontalScale
		{
			[Token(Token = "0x60238F9")]
			[Address(RVA = "0x1E32DB0", Offset = "0x1E319B0", VA = "0x181E32DB0")]
			set
			{
			}
		}

		// Token: 0x17005403 RID: 21507
		// (set) Token: 0x060238FA RID: 145658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005403")]
		public float verticalScale
		{
			[Token(Token = "0x60238FA")]
			[Address(RVA = "0x1E32E30", Offset = "0x1E31A30", VA = "0x181E32E30")]
			set
			{
			}
		}

		// Token: 0x060238FB RID: 145659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238FB")]
		[Address(RVA = "0x1E32C20", Offset = "0x1E31820", VA = "0x181E32C20")]
		private void _ApplyScale()
		{
		}

		// Token: 0x060238FC RID: 145660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238FC")]
		[Address(RVA = "0x1E32B00", Offset = "0x1E31700", VA = "0x181E32B00")]
		public void BindImageView(CGGalleryImageView imageView)
		{
		}

		// Token: 0x060238FD RID: 145661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238FD")]
		[Address(RVA = "0x1E32D50", Offset = "0x1E31950", VA = "0x181E32D50")]
		public CGGalleryInspectImageViewScaleHandler()
		{
		}

		// Token: 0x0403134E RID: 201550
		[Token(Token = "0x403134E")]
		[FieldOffset(Offset = "0x18")]
		private CGGalleryInspectImageViewScaleHandler.ScaleApplyType m_scaleApplyType;

		// Token: 0x0403134F RID: 201551
		[Token(Token = "0x403134F")]
		[FieldOffset(Offset = "0x1C")]
		private float m_horizontalScale;

		// Token: 0x04031350 RID: 201552
		[Token(Token = "0x4031350")]
		[FieldOffset(Offset = "0x20")]
		private float m_verticalScale;

		// Token: 0x04031351 RID: 201553
		[Token(Token = "0x4031351")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_horizontalScale;

		// Token: 0x04031352 RID: 201554
		[Token(Token = "0x4031352")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_verticalScale;

		// Token: 0x04031353 RID: 201555
		[Token(Token = "0x4031353")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyScale;

		// Token: 0x04031354 RID: 201556
		[Token(Token = "0x4031354")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindImageView;

		// Token: 0x04031355 RID: 201557
		[Token(Token = "0x4031355")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006011 RID: 24593
		[Token(Token = "0x2006011")]
		public enum ScaleApplyType
		{
			// Token: 0x04031357 RID: 201559
			[Token(Token = "0x4031357")]
			USE_HORIZONTAL,
			// Token: 0x04031358 RID: 201560
			[Token(Token = "0x4031358")]
			USE_VERTICAL,
			// Token: 0x04031359 RID: 201561
			[Token(Token = "0x4031359")]
			USE_MIN
		}
	}
}
