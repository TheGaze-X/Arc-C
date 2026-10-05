using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036EF RID: 14063
	[Token(Token = "0x20036EF")]
	[Serializable]
	public class RectSize
	{
		// Token: 0x06016551 RID: 91473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016551")]
		[Address(RVA = "0xECBDF0", Offset = "0xECA9F0", VA = "0x180ECBDF0")]
		public RectSize()
		{
		}

		// Token: 0x06016552 RID: 91474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016552")]
		[Address(RVA = "0xECBE10", Offset = "0xECAA10", VA = "0x180ECBE10")]
		public RectSize(RectSize copy)
		{
		}

		// Token: 0x06016553 RID: 91475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016553")]
		[Address(RVA = "0xECBD90", Offset = "0xECA990", VA = "0x180ECBD90")]
		public void SetValue(RectSize val)
		{
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x06016554 RID: 91476 RVA: 0x00090990 File Offset: 0x0008EB90
		// (set) Token: 0x06016555 RID: 91477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A4")]
		public float width
		{
			[Token(Token = "0x6016554")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6016555")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x06016556 RID: 91478 RVA: 0x000909A8 File Offset: 0x0008EBA8
		// (set) Token: 0x06016557 RID: 91479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A5")]
		public float height
		{
			[Token(Token = "0x6016556")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6016557")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			set
			{
			}
		}

		// Token: 0x06016558 RID: 91480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016558")]
		[Address(RVA = "0xECBE50", Offset = "0xECAA50", VA = "0x180ECBE50")]
		public void ReadSize(RectTransform target)
		{
		}

		// Token: 0x06016559 RID: 91481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016559")]
		[Address(RVA = "0xECBEA0", Offset = "0xECAAA0", VA = "0x180ECBEA0")]
		public void WriteSize(RectTransform target)
		{
		}

		// Token: 0x0601655A RID: 91482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601655A")]
		[Address(RVA = "0xECBCB0", Offset = "0xECA8B0", VA = "0x180ECBCB0")]
		public void Interpolate(RectSize from, RectSize to, float percent)
		{
		}

		// Token: 0x0401ADC0 RID: 110016
		[Token(Token = "0x401ADC0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 _size;
	}
}
