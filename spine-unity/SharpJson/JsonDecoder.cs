using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace SharpJson
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class JsonDecoder
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000004")]
		public string errorMessage
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000005")]
		public bool parseNumbersAsFloat
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4E47500", Offset = "0x4E46100", VA = "0x184E47500")]
		public JsonDecoder()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4E46A40", Offset = "0x4E45640", VA = "0x184E46A40")]
		public object Decode(string text)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4E468C0", Offset = "0x4E454C0", VA = "0x184E468C0")]
		public static object DecodeText(string text)
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4E46D00", Offset = "0x4E45900", VA = "0x184E46D00")]
		private IDictionary<string, object> ParseObject()
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4E46B60", Offset = "0x4E45760", VA = "0x184E46B60")]
		private IList<object> ParseArray()
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4E46F30", Offset = "0x4E45B30", VA = "0x184E46F30")]
		private object ParseValue()
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4E47470", Offset = "0x4E46070", VA = "0x184E47470")]
		private void TriggerError(string message)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600001C")]
		private T EvalLexer<T>(T value)
		{
			return null;
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private Lexer lexer;
	}
}
