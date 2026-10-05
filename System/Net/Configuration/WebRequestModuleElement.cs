using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public sealed class WebRequestModuleElement : ConfigurationElement
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x50C8FB0", Offset = "0x50C7BB0", VA = "0x1850C8FB0")]
		public WebRequestModuleElement()
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x50C8F80", Offset = "0x50C7B80", VA = "0x1850C8F80")]
		public WebRequestModuleElement(string prefix, string type)
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x50C8FE0", Offset = "0x50C7BE0", VA = "0x1850C8FE0")]
		public WebRequestModuleElement(string prefix, Type type)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066C")]
		public string Prefix
		{
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x50C9010", Offset = "0x50C7C10", VA = "0x1850C9010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x50C90A0", Offset = "0x50C7CA0", VA = "0x1850C90A0")]
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066D")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x50C9040", Offset = "0x50C7C40", VA = "0x1850C9040", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066E")]
		public Type Type
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x50C9070", Offset = "0x50C7C70", VA = "0x1850C9070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x50C90D0", Offset = "0x50C7CD0", VA = "0x1850C90D0")]
			set
			{
			}
		}
	}
}
