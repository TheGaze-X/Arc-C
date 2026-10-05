using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Examples
{
	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x2000567")]
	public sealed class CacheMaintenanceSample : MonoBehaviour
	{
		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x53E21E0", Offset = "0x53E0DE0", VA = "0x1853E21E0")]
		private void OnGUI()
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x53E2A70", Offset = "0x53E1670", VA = "0x1853E2A70")]
		public CacheMaintenanceSample()
		{
		}

		// Token: 0x040019B7 RID: 6583
		[Token(Token = "0x40019B7")]
		[FieldOffset(Offset = "0x18")]
		private CacheMaintenanceSample.DeleteOlderTypes deleteOlderType;

		// Token: 0x040019B8 RID: 6584
		[Token(Token = "0x40019B8")]
		[FieldOffset(Offset = "0x1C")]
		private int value;

		// Token: 0x040019B9 RID: 6585
		[Token(Token = "0x40019B9")]
		[FieldOffset(Offset = "0x20")]
		private int maxCacheSize;

		// Token: 0x02000568 RID: 1384
		[Token(Token = "0x2000568")]
		private enum DeleteOlderTypes
		{
			// Token: 0x040019BB RID: 6587
			[Token(Token = "0x40019BB")]
			Days,
			// Token: 0x040019BC RID: 6588
			[Token(Token = "0x40019BC")]
			Hours,
			// Token: 0x040019BD RID: 6589
			[Token(Token = "0x40019BD")]
			Mins,
			// Token: 0x040019BE RID: 6590
			[Token(Token = "0x40019BE")]
			Secs
		}
	}
}
