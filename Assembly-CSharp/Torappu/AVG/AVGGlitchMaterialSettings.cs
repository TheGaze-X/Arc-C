using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F0C RID: 7948
	[Token(Token = "0x2001F0C")]
	[CreateAssetMenu(fileName = "GlitchMaterialSettings", menuName = "Torappu/AVG/GlitchSettings")]
	public class AVGGlitchMaterialSettings : ScriptableObject
	{
		// Token: 0x0600C535 RID: 50485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C535")]
		[Address(RVA = "0x3422110", Offset = "0x3420D10", VA = "0x183422110")]
		public void ApplyToMaterial(Material mat)
		{
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C536")]
		[Address(RVA = "0x3422290", Offset = "0x3420E90", VA = "0x183422290")]
		public List<MaterialTweenParam> ConvertPreset2Params(float duration, bool ignoreTs = false, Ease ease = Ease.Linear)
		{
			return null;
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C537")]
		[Address(RVA = "0x3422670", Offset = "0x3421270", VA = "0x183422670")]
		public AVGGlitchMaterialSettings()
		{
		}

		// Token: 0x0400C9D2 RID: 51666
		[Token(Token = "0x400C9D2")]
		[FieldOffset(Offset = "0x18")]
		public float glichSpeed;

		// Token: 0x0400C9D3 RID: 51667
		[Token(Token = "0x400C9D3")]
		[FieldOffset(Offset = "0x1C")]
		public float glichThreshold;

		// Token: 0x0400C9D4 RID: 51668
		[Token(Token = "0x400C9D4")]
		[FieldOffset(Offset = "0x20")]
		public float glichIntensity;

		// Token: 0x0400C9D5 RID: 51669
		[Token(Token = "0x400C9D5")]
		[FieldOffset(Offset = "0x24")]
		public float glichLineNum;

		// Token: 0x0400C9D6 RID: 51670
		[Token(Token = "0x400C9D6")]
		[FieldOffset(Offset = "0x28")]
		public Color maskColor;

		// Token: 0x0400C9D7 RID: 51671
		[Token(Token = "0x400C9D7")]
		[FieldOffset(Offset = "0x38")]
		public Color filterColor;

		// Token: 0x0400C9D8 RID: 51672
		[Token(Token = "0x400C9D8")]
		[FieldOffset(Offset = "0x48")]
		public Color lineColor;
	}
}
