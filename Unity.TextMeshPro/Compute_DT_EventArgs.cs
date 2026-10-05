using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class Compute_DT_EventArgs
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x586A300", Offset = "0x5868F00", VA = "0x18586A300")]
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors)
		{
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x10")]
		public Compute_DistanceTransform_EventTypes EventType;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x14")]
		public float ProgressPercentage;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		public Color[] Colors;
	}
}
