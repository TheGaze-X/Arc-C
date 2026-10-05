using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004171 RID: 16753
	[Token(Token = "0x2004171")]
	public class SandboxV2DungeonCameraSlider : Slider
	{
		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x06019DBA RID: 105914 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		[Token(Token = "0x17003D99")]
		public bool isSliding
		{
			[Token(Token = "0x6019DBA")]
			[Address(RVA = "0x12BE710", Offset = "0x12BD310", VA = "0x1812BE710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x06019DBB RID: 105915 RVA: 0x0009F900 File Offset: 0x0009DB00
		// (set) Token: 0x06019DBC RID: 105916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D9A")]
		public float zoomValue
		{
			[Token(Token = "0x6019DBB")]
			[Address(RVA = "0x12BE730", Offset = "0x12BD330", VA = "0x1812BE730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6019DBC")]
			[Address(RVA = "0x12BE7B0", Offset = "0x12BD3B0", VA = "0x1812BE7B0")]
			set
			{
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (set) Token: 0x06019DBD RID: 105917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D9B")]
		public float maxZoomValue
		{
			[Token(Token = "0x6019DBD")]
			[Address(RVA = "0x12BE770", Offset = "0x12BD370", VA = "0x1812BE770")]
			set
			{
			}
		}

		// Token: 0x06019DBE RID: 105918 RVA: 0x0009F918 File Offset: 0x0009DB18
		[Token(Token = "0x6019DBE")]
		[Address(RVA = "0x12BE6D0", Offset = "0x12BD2D0", VA = "0x1812BE6D0")]
		private float _SliderValueToZoomValue(float sliderValue)
		{
			return 0f;
		}

		// Token: 0x06019DBF RID: 105919 RVA: 0x0009F930 File Offset: 0x0009DB30
		[Token(Token = "0x6019DBF")]
		[Address(RVA = "0x12BE6E0", Offset = "0x12BD2E0", VA = "0x1812BE6E0")]
		private float _ZoomValueToSliderValue(float zoomValue)
		{
			return 0f;
		}

		// Token: 0x06019DC0 RID: 105920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC0")]
		[Address(RVA = "0x12BE610", Offset = "0x12BD210", VA = "0x1812BE610", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06019DC1 RID: 105921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC1")]
		[Address(RVA = "0x12BE650", Offset = "0x12BD250", VA = "0x1812BE650", Slot = "35")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC2")]
		[Address(RVA = "0x12BE690", Offset = "0x12BD290", VA = "0x1812BE690")]
		public void SetLock(SandboxV2DungeonCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x06019DC3 RID: 105923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC3")]
		[Address(RVA = "0x12BE700", Offset = "0x12BD300", VA = "0x1812BE700")]
		public SandboxV2DungeonCameraSlider()
		{
		}

		// Token: 0x040207D2 RID: 133074
		[Token(Token = "0x40207D2")]
		[FieldOffset(Offset = "0x178")]
		private bool m_isSliding;

		// Token: 0x040207D3 RID: 133075
		[Token(Token = "0x40207D3")]
		[FieldOffset(Offset = "0x17C")]
		private int m_lock;
	}
}
