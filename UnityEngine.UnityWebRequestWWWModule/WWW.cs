using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
	public class WWW : CustomYieldInstruction, IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5B9FE30", Offset = "0x5B9EA30", VA = "0x185B9FE30")]
		public static string EscapeURL(string s)
		{
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5B9FE20", Offset = "0x5B9EA20", VA = "0x185B9FE20")]
		public static string EscapeURL(string s, Encoding e)
		{
			return null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5B9FE60", Offset = "0x5B9EA60", VA = "0x185B9FE60")]
		public static string UnEscapeURL(string s)
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5B9FE90", Offset = "0x5B9EA90", VA = "0x185B9FE90")]
		public static string UnEscapeURL(string s, Encoding e)
		{
			return null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5B9FF90", Offset = "0x5B9EB90", VA = "0x185B9FF90")]
		public WWW(string url)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5B9FFF0", Offset = "0x5B9EBF0", VA = "0x185B9FFF0")]
		public WWW(string url, byte[] postData, Dictionary<string, string> headers)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public byte[] bytes
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5BA02C0", Offset = "0x5B9EEC0", VA = "0x185BA02C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public string error
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5BA0350", Offset = "0x5B9EF50", VA = "0x185BA0350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000003")]
		public bool isDone
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x5BA0470", Offset = "0x5B9F070", VA = "0x185BA0470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public Dictionary<string, string> responseHeaders
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x5BA04C0", Offset = "0x5B9F0C0", VA = "0x185BA04C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public string text
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x5BA0690", Offset = "0x5B9F290", VA = "0x185BA0690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public string url
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5BA0710", Offset = "0x5B9F310", VA = "0x185BA0710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000007")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x5BA0490", Offset = "0x5B9F090", VA = "0x185BA0490", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5B9FDE0", Offset = "0x5B9E9E0", VA = "0x185B9FDE0", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5B9FEA0", Offset = "0x5B9EAA0", VA = "0x185B9FEA0")]
		private bool WaitUntilDoneIfPossible()
		{
			return default(bool);
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private UnityWebRequest _uwr;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> _responseHeaders;
	}
}
