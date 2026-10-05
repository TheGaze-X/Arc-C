using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002064 RID: 8292
	[Token(Token = "0x2002064")]
	[Serializable]
	public class HighlightTileProfile : ScriptableObject
	{
		// Token: 0x0600CC34 RID: 52276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC34")]
		[Address(RVA = "0x34D55F0", Offset = "0x34D41F0", VA = "0x1834D55F0")]
		public HighlightTileProfile()
		{
		}

		// Token: 0x0400D6AD RID: 54957
		[Token(Token = "0x400D6AD")]
		[FieldOffset(Offset = "0x18")]
		public bool initState;

		// Token: 0x0400D6AE RID: 54958
		[Token(Token = "0x400D6AE")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve anmCurve;

		// Token: 0x0400D6AF RID: 54959
		[Token(Token = "0x400D6AF")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.01f, 5f)]
		public float anmDuration;
	}
}
