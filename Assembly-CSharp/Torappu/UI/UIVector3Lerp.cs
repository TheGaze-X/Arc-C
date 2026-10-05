using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020037C5 RID: 14277
	[Token(Token = "0x20037C5")]
	[RequireComponent(typeof(RectTransform))]
	public class UIVector3Lerp : MonoBehaviour
	{
		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x06016A22 RID: 92706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003626")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6016A22")]
			[Address(RVA = "0xF1D7F0", Offset = "0xF1C3F0", VA = "0x180F1D7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016A23 RID: 92707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A23")]
		[Address(RVA = "0xF1D710", Offset = "0xF1C310", VA = "0x180F1D710")]
		[Inspect]
		public void RecordFrom()
		{
		}

		// Token: 0x06016A24 RID: 92708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A24")]
		[Address(RVA = "0xF1D410", Offset = "0xF1C010", VA = "0x180F1D410")]
		[Inspect]
		public void ApplyFrom()
		{
		}

		// Token: 0x06016A25 RID: 92709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A25")]
		[Address(RVA = "0xF1D780", Offset = "0xF1C380", VA = "0x180F1D780")]
		[Inspect]
		public void RecordTo()
		{
		}

		// Token: 0x06016A26 RID: 92710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A26")]
		[Address(RVA = "0xF1D4A0", Offset = "0xF1C0A0", VA = "0x180F1D4A0")]
		[Inspect]
		public void ApplyTo()
		{
		}

		// Token: 0x06016A27 RID: 92711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A27")]
		[Address(RVA = "0xF1D530", Offset = "0xF1C130", VA = "0x180F1D530")]
		public void Lerp(float value)
		{
		}

		// Token: 0x06016A28 RID: 92712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A28")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIVector3Lerp()
		{
		}

		// Token: 0x0401B48E RID: 111758
		[Token(Token = "0x401B48E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIVector3Lerp.Mode _mode;

		// Token: 0x0401B48F RID: 111759
		[Token(Token = "0x401B48F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 _from;

		// Token: 0x0401B490 RID: 111760
		[Token(Token = "0x401B490")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _to;

		// Token: 0x0401B491 RID: 111761
		[Token(Token = "0x401B491")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private RectTransform _target;

		// Token: 0x020037C6 RID: 14278
		[Token(Token = "0x20037C6")]
		private enum Mode
		{
			// Token: 0x0401B493 RID: 111763
			[Token(Token = "0x401B493")]
			ANCHORED_POSITION_3D,
			// Token: 0x0401B494 RID: 111764
			[Token(Token = "0x401B494")]
			LOCAL_SCALE
		}
	}
}
