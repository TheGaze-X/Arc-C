using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Effects.Data
{
	// Token: 0x02003286 RID: 12934
	[Token(Token = "0x2003286")]
	public class EffectData_Advanced : SourceData
	{
		// Token: 0x0601487C RID: 84092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601487C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public EffectData_Advanced()
		{
		}

		// Token: 0x0401845A RID: 99418
		[Token(Token = "0x401845A")]
		[FieldOffset(Offset = "0x18")]
		public bool overrideHeight;

		// Token: 0x0401845B RID: 99419
		[Token(Token = "0x401845B")]
		[FieldOffset(Offset = "0x1C")]
		public float heightOffset;

		// Token: 0x0401845C RID: 99420
		[Token(Token = "0x401845C")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] inactiveOnFinish;
	}
}
