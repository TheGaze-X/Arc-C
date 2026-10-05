using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[Preserve]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public JToken CurrentToken
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x4DC64D0", Offset = "0x4DC50D0", VA = "0x184DC64D0")]
		public JTokenReader(JToken token)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x4DC6540", Offset = "0x4DC5140", VA = "0x184DC6540")]
		internal JTokenReader(JToken token, string initialPath)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x4DC4A60", Offset = "0x4DC3660", VA = "0x184DC4A60", Slot = "12")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x4DC3A50", Offset = "0x4DC2650", VA = "0x184DC3A50")]
		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x4DC4A20", Offset = "0x4DC3620", VA = "0x184DC4A20")]
		private bool ReadToEnd()
		{
			return default(bool);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x4DC3700", Offset = "0x4DC2300", VA = "0x184DC3700")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x4DC39A0", Offset = "0x4DC25A0", VA = "0x184DC39A0")]
		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x4DC5D20", Offset = "0x4DC4920", VA = "0x184DC5D20")]
		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x4DC5F20", Offset = "0x4DC4B20", VA = "0x184DC5F20")]
		private void SetToken(JToken token)
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x4DC5CD0", Offset = "0x4DC48D0", VA = "0x184DC5CD0")]
		private string SafeToString(object value)
		{
			return null;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x4DC3880", Offset = "0x4DC2480", VA = "0x184DC3880", Slot = "23")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x17000186")]
		private int LineNumber
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x4DC38E0", Offset = "0x4DC24E0", VA = "0x184DC38E0", Slot = "24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x17000187")]
		private int LinePosition
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x4DC3940", Offset = "0x4DC2540", VA = "0x184DC3940", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public override string Path
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x4DC65C0", Offset = "0x4DC51C0", VA = "0x184DC65C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x80")]
		private string _initialPath;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x88")]
		private JToken _parent;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x90")]
		private JToken _current;
	}
}
