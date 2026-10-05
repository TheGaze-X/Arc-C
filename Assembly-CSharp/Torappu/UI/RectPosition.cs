using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036EE RID: 14062
	[Token(Token = "0x20036EE")]
	[Serializable]
	public class RectPosition
	{
		// Token: 0x06016547 RID: 91463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016547")]
		[Address(RVA = "0xECBDF0", Offset = "0xECA9F0", VA = "0x180ECBDF0")]
		public RectPosition()
		{
		}

		// Token: 0x06016548 RID: 91464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016548")]
		[Address(RVA = "0xECBE10", Offset = "0xECAA10", VA = "0x180ECBE10")]
		public RectPosition(RectPosition copy)
		{
		}

		// Token: 0x06016549 RID: 91465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016549")]
		[Address(RVA = "0xECBD90", Offset = "0xECA990", VA = "0x180ECBD90")]
		public void SetValue(RectPosition val)
		{
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0601654A RID: 91466 RVA: 0x00090960 File Offset: 0x0008EB60
		// (set) Token: 0x0601654B RID: 91467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A2")]
		public float x
		{
			[Token(Token = "0x601654A")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601654B")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0601654C RID: 91468 RVA: 0x00090978 File Offset: 0x0008EB78
		// (set) Token: 0x0601654D RID: 91469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A3")]
		public float y
		{
			[Token(Token = "0x601654C")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601654D")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			set
			{
			}
		}

		// Token: 0x0601654E RID: 91470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601654E")]
		[Address(RVA = "0xECBD40", Offset = "0xECA940", VA = "0x180ECBD40")]
		public void ReadPosition(RectTransform target)
		{
		}

		// Token: 0x0601654F RID: 91471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601654F")]
		[Address(RVA = "0xECBDB0", Offset = "0xECA9B0", VA = "0x180ECBDB0")]
		public void WritePosition(RectTransform target)
		{
		}

		// Token: 0x06016550 RID: 91472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016550")]
		[Address(RVA = "0xECBCB0", Offset = "0xECA8B0", VA = "0x180ECBCB0")]
		public void Interpolate(RectPosition from, RectPosition to, float percent)
		{
		}

		// Token: 0x0401ADBF RID: 110015
		[Token(Token = "0x401ADBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 _position;
	}
}
