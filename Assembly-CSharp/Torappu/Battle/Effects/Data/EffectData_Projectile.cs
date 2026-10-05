using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Effects.Data
{
	// Token: 0x02003287 RID: 12935
	[Token(Token = "0x2003287")]
	public class EffectData_Projectile : SourceData
	{
		// Token: 0x0601487D RID: 84093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601487D")]
		[Address(RVA = "0xCB0110", Offset = "0xCAED10", VA = "0x180CB0110")]
		public EffectData_Projectile()
		{
		}

		// Token: 0x0401845D RID: 99421
		[Token(Token = "0x401845D")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] inactiveOnFinish;

		// Token: 0x0401845E RID: 99422
		[Token(Token = "0x401845E")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] inactiveOnHit;
	}
}
