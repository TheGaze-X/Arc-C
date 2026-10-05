using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.ObjectPool
{
	// Token: 0x02001471 RID: 5233
	[Token(Token = "0x2001471")]
	public class GameObjectPoolComponent : MonoBehaviour
	{
		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600790A RID: 30986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E75")]
		public GameObjectPool pool
		{
			[Token(Token = "0x600790A")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600790B")]
		[Address(RVA = "0x2637530", Offset = "0x2636130", VA = "0x182637530")]
		private GameObjectPool _ConstructPool(PoolManager.ObjectConfig config)
		{
			return null;
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790C")]
		[Address(RVA = "0x26374E0", Offset = "0x26360E0", VA = "0x1826374E0")]
		private void Start()
		{
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600790D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public GameObjectPoolComponent()
		{
		}

		// Token: 0x0400772F RID: 30511
		[Token(Token = "0x400772F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PoolManager.ObjectConfig _config;

		// Token: 0x04007730 RID: 30512
		[Token(Token = "0x4007730")]
		[FieldOffset(Offset = "0x50")]
		private GameObjectPool m_pool;
	}
}
