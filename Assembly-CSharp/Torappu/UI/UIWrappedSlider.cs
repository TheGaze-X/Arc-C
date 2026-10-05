using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003927 RID: 14631
	[Token(Token = "0x2003927")]
	public class UIWrappedSlider : Slider
	{
		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x06017204 RID: 94724 RVA: 0x00094F20 File Offset: 0x00093120
		// (set) Token: 0x06017205 RID: 94725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700373B")]
		public bool isDragging
		{
			[Token(Token = "0x6017204")]
			[Address(RVA = "0xF9BA40", Offset = "0xF9A640", VA = "0x180F9BA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017205")]
			[Address(RVA = "0xF9BA50", Offset = "0xF9A650", VA = "0x180F9BA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06017206 RID: 94726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017206")]
		[Address(RVA = "0xF9B870", Offset = "0xF9A470", VA = "0x180F9B870", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06017207 RID: 94727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017207")]
		[Address(RVA = "0xF9B850", Offset = "0xF9A450", VA = "0x180F9B850", Slot = "60")]
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06017208 RID: 94728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017208")]
		[Address(RVA = "0xF9B820", Offset = "0xF9A420", VA = "0x180F9B820", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06017209 RID: 94729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017209")]
		[Address(RVA = "0xF9B800", Offset = "0xF9A400", VA = "0x180F9B800")]
		public void CancelCurrentDrag()
		{
		}

		// Token: 0x0601720A RID: 94730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601720A")]
		[Address(RVA = "0xF9B940", Offset = "0xF9A540", VA = "0x180F9B940", Slot = "58")]
		protected override void Update()
		{
		}

		// Token: 0x0601720B RID: 94731 RVA: 0x00094F38 File Offset: 0x00093138
		[Token(Token = "0x601720B")]
		[Address(RVA = "0xF9B980", Offset = "0xF9A580", VA = "0x180F9B980")]
		private bool _IsPointerDownValid(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x0601720C RID: 94732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601720C")]
		[Address(RVA = "0xF9B800", Offset = "0xF9A400", VA = "0x180F9B800")]
		private void _StopCurrentDragImpl()
		{
		}

		// Token: 0x0601720D RID: 94733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601720D")]
		[Address(RVA = "0xF9BA20", Offset = "0xF9A620", VA = "0x180F9BA20")]
		public UIWrappedSlider()
		{
		}

		// Token: 0x0401BEBF RID: 114367
		[Token(Token = "0x401BEBF")]
		[FieldOffset(Offset = "0x17C")]
		private int m_dragPointerId;
	}
}
