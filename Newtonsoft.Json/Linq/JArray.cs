using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[Preserve]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x17000181")]
		public override JTokenType Type
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "13")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x4DB9040", Offset = "0x4DB7C40", VA = "0x184DB9040")]
		public JArray()
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x4DB91F0", Offset = "0x4DB7DF0", VA = "0x184DB91F0")]
		public JArray(JArray other)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x4DB9100", Offset = "0x4DB7D00", VA = "0x184DB9100")]
		public JArray(params object[] content)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x4DB9100", Offset = "0x4DB7D00", VA = "0x184DB9100")]
		public JArray(object content)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x4DB83B0", Offset = "0x4DB6FB0", VA = "0x184DB83B0", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x4DB8230", Offset = "0x4DB6E30", VA = "0x184DB8230", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x4DB8B60", Offset = "0x4DB7760", VA = "0x184DB8B60")]
		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x4DB8950", Offset = "0x4DB7550", VA = "0x184DB8950")]
		public new static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x4DB8E60", Offset = "0x4DB7A60", VA = "0x184DB8E60")]
		public new static JArray Parse(string json)
		{
			return null;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x4DB8C70", Offset = "0x4DB7870", VA = "0x184DB8C70")]
		public new static JArray Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x4DB85C0", Offset = "0x4DB71C0", VA = "0x184DB85C0")]
		public new static JArray FromObject(object o)
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x4DB85F0", Offset = "0x4DB71F0", VA = "0x184DB85F0")]
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x4DB8F00", Offset = "0x4DB7B00", VA = "0x184DB8F00", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x17000182 RID: 386
		[Token(Token = "0x17000182")]
		public override JToken this[object key]
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x4DB9290", Offset = "0x4DB7E90", VA = "0x184DB9290", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x4DB9480", Offset = "0x4DB8080", VA = "0x184DB9480", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		[Token(Token = "0x17000183")]
		public JToken this[int index]
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x4DB93E0", Offset = "0x4DB7FE0", VA = "0x184DB93E0", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x4DB9430", Offset = "0x4DB8030", VA = "0x184DB9430", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x4DB8850", Offset = "0x4DB7450", VA = "0x184DB8850", Slot = "74")]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x4DB8B70", Offset = "0x4DB7770", VA = "0x184DB8B70", Slot = "86")]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4DB88A0", Offset = "0x4DB74A0", VA = "0x184DB88A0", Slot = "26")]
		public int IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x4DB88F0", Offset = "0x4DB74F0", VA = "0x184DB88F0", Slot = "27")]
		public void Insert(int index, JToken item)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x4DB8E70", Offset = "0x4DB7A70", VA = "0x184DB8E70", Slot = "28")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x4DB87C0", Offset = "0x4DB73C0", VA = "0x184DB87C0", Slot = "5")]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x4DB81A0", Offset = "0x4DB6DA0", VA = "0x184DB81A0", Slot = "31")]
		public void Add(JToken item)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x4DB81F0", Offset = "0x4DB6DF0", VA = "0x184DB81F0", Slot = "32")]
		public void Clear()
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x4DB8300", Offset = "0x4DB6F00", VA = "0x184DB8300", Slot = "33")]
		public bool Contains(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x4DB8350", Offset = "0x4DB6F50", VA = "0x184DB8350", Slot = "34")]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x17000184")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4DB8EB0", Offset = "0x4DB7AB0", VA = "0x184DB8EB0", Slot = "35")]
		public bool Remove(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4DB87B0", Offset = "0x4DB73B0", VA = "0x184DB87B0", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<JToken> _values;
	}
}
