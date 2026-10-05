using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Fx;
using UnityEngine;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003201 RID: 12801
	[Token(Token = "0x2003201")]
	public class CameraEffect : BasicEffect
	{
		// Token: 0x060144DE RID: 83166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144DE")]
		[Address(RVA = "0xC86B30", Offset = "0xC85730", VA = "0x180C86B30")]
		public void Init(Camera camera)
		{
		}

		// Token: 0x060144DF RID: 83167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144DF")]
		[Address(RVA = "0xC86CF0", Offset = "0xC858F0", VA = "0x180C86CF0")]
		private IEnumerator _CheckIfAlive()
		{
			return null;
		}

		// Token: 0x060144E0 RID: 83168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144E0")]
		[Address(RVA = "0xC86D70", Offset = "0xC85970", VA = "0x180C86D70")]
		public CameraEffect()
		{
		}

		// Token: 0x04017EF1 RID: 98033
		[Token(Token = "0x4017EF1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _spawnOffset;

		// Token: 0x04017EF2 RID: 98034
		[Token(Token = "0x4017EF2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxLifeTime;
	}
}
