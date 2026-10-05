using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Examples
{
	// Token: 0x02000565 RID: 1381
	[Token(Token = "0x2000565")]
	public sealed class LargeFileDownloadSample : MonoBehaviour
	{
		// Token: 0x06002DB7 RID: 11703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x53ECEC0", Offset = "0x53EBAC0", VA = "0x1853ECEC0")]
		private void Awake()
		{
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x53ECF50", Offset = "0x53EBB50", VA = "0x1853ECF50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x53ECFC0", Offset = "0x53EBBC0", VA = "0x1853ECFC0")]
		private void OnGUI()
		{
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x53ED250", Offset = "0x53EBE50", VA = "0x1853ED250")]
		private void StreamLargeFileTest()
		{
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x53ED130", Offset = "0x53EBD30", VA = "0x1853ED130")]
		private void ProcessFragments(List<byte[]> fragments)
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x53EDC50", Offset = "0x53EC850", VA = "0x1853EDC50")]
		public LargeFileDownloadSample()
		{
		}

		// Token: 0x040019AC RID: 6572
		[Token(Token = "0x40019AC")]
		private const string URL = "http://uk3.testmy.net/dl-102400";

		// Token: 0x040019AD RID: 6573
		[Token(Token = "0x40019AD")]
		[FieldOffset(Offset = "0x18")]
		private HTTPRequest request;

		// Token: 0x040019AE RID: 6574
		[Token(Token = "0x40019AE")]
		[FieldOffset(Offset = "0x20")]
		private string status;

		// Token: 0x040019AF RID: 6575
		[Token(Token = "0x40019AF")]
		[FieldOffset(Offset = "0x28")]
		private float progress;

		// Token: 0x040019B0 RID: 6576
		[Token(Token = "0x40019B0")]
		[FieldOffset(Offset = "0x2C")]
		private int fragmentSize;
	}
}
