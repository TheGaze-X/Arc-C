using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	[Serializable]
	public class WebProxy : IWebProxy, ISerializable
	{
		// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x5064B20", Offset = "0x5063720", VA = "0x185064B20")]
		public WebProxy()
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x5064B90", Offset = "0x5063790", VA = "0x185064B90")]
		public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
		{
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000473")]
		public ICredentials Credentials
		{
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00009D38 File Offset: 0x00007F38
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000474")]
		public bool UseDefaultCredentials
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x5065060", Offset = "0x5063C60", VA = "0x185065060")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x50650F0", Offset = "0x5063CF0", VA = "0x1850650F0")]
			set
			{
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x5063CD0", Offset = "0x50628D0", VA = "0x185063CD0", Slot = "4")]
		public Uri GetProxy(Uri destination)
		{
			return null;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x50648B0", Offset = "0x50634B0", VA = "0x1850648B0")]
		private void UpdateRegExList(bool canThrow)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x5064670", Offset = "0x5063270", VA = "0x185064670")]
		private bool IsMatchInBypassList(Uri input)
		{
			return default(bool);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x50644D0", Offset = "0x50630D0", VA = "0x1850644D0")]
		private bool IsLocal(Uri host)
		{
			return default(bool);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x50643A0", Offset = "0x5062FA0", VA = "0x1850643A0")]
		private bool IsLocalInProxyHash(Uri host)
		{
			return default(bool);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x5064250", Offset = "0x5062E50", VA = "0x185064250", Slot = "5")]
		public bool IsBypassed(Uri host)
		{
			return default(bool);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x5063F30", Offset = "0x5062B30", VA = "0x185063F30")]
		private bool IsBypassedManual(Uri host)
		{
			return default(bool);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x5064C60", Offset = "0x5063860", VA = "0x185064C60")]
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x5056890", Offset = "0x5055490", VA = "0x185056890", Slot = "7")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x5063960", Offset = "0x5062560", VA = "0x185063960", Slot = "8")]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000475")]
		internal AutoWebProxyScriptEngine ScriptEngine
		{
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x5063900", Offset = "0x5062500", VA = "0x185063900")]
		public static IWebProxy CreateDefaultProxy()
		{
			return null;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x5064AF0", Offset = "0x50636F0", VA = "0x185064AF0")]
		internal WebProxy(bool enableAutoproxy)
		{
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150E")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0")]
		internal void UnsafeUpdateFromRegistry()
		{
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x5063AD0", Offset = "0x50626D0", VA = "0x185063AD0")]
		private bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			return default(bool);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x5063E60", Offset = "0x5062A60", VA = "0x185063E60")]
		private bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			return default(bool);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x50636F0", Offset = "0x50622F0", VA = "0x1850636F0")]
		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			return default(bool);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x5064810", Offset = "0x5063410", VA = "0x185064810")]
		private static Uri ProxyUri(string proxyName)
		{
			return null;
		}

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x10")]
		private bool _UseRegistry;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x11")]
		private bool _BypassOnLocal;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x12")]
		private bool m_EnableAutoproxy;

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x18")]
		private Uri _ProxyAddress;

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList _BypassList;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x28")]
		private ICredentials _Credentials;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x30")]
		private Regex[] _RegExBypassList;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x38")]
		private Hashtable _ProxyHostAddresses;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x40")]
		private AutoWebProxyScriptEngine m_ScriptEngine;
	}
}
