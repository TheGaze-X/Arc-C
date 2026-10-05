using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200216F RID: 8559
	[Token(Token = "0x200216F")]
	public class CachePointData : IReusable
	{
		// Token: 0x0600D2D2 RID: 53970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D2")]
		[Address(RVA = "0x3533670", Offset = "0x3532270", VA = "0x183533670", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D3")]
		[Address(RVA = "0x3533740", Offset = "0x3532340", VA = "0x183533740", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2D4")]
		[Address(RVA = "0x3533620", Offset = "0x3532220", VA = "0x183533620")]
		public static CachePointData Create()
		{
			return null;
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CachePointData()
		{
		}

		// Token: 0x0400E1D6 RID: 57814
		[Token(Token = "0x400E1D6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject cachePoint;
	}
}
