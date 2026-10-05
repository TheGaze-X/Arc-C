using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	[System.Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x4C77020", Offset = "0x4C75C20", VA = "0x184C77020")]
		public DirectoryInfo(string path)
		{
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003169")]
		[Address(RVA = "0x4C770B0", Offset = "0x4C75CB0", VA = "0x184C770B0")]
		internal DirectoryInfo(string originalPath, [System.Runtime.InteropServices.Optional] string fullPath, [System.Runtime.InteropServices.Optional] string fileName, bool isNormalized = false)
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316A")]
		[Address(RVA = "0x4C769B0", Offset = "0x4C755B0", VA = "0x184C769B0")]
		private void Init(string originalPath, [System.Runtime.InteropServices.Optional] string fullPath, [System.Runtime.InteropServices.Optional] string fileName, bool isNormalized = false)
		{
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007E4")]
		public DirectoryInfo Parent
		{
			[Token(Token = "0x600316B")]
			[Address(RVA = "0x4C77540", Offset = "0x4C76140", VA = "0x184C77540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x4C76780", Offset = "0x4C75380", VA = "0x184C76780")]
		public void Create()
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x4C767B0", Offset = "0x4C753B0", VA = "0x184C767B0")]
		public DirectoryInfo[] GetDirectories()
		{
			return null;
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600316E")]
		[Address(RVA = "0x4C768F0", Offset = "0x4C754F0", VA = "0x184C768F0")]
		public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600316F")]
		[Address(RVA = "0x4C76E20", Offset = "0x4C75A20", VA = "0x184C76E20")]
		internal static System.Collections.Generic.IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003170")]
		[Address(RVA = "0x4C77520", Offset = "0x4C76120", VA = "0x184C77520")]
		private DirectoryInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
