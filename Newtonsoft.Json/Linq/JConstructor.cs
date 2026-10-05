using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[Preserve]
	public class JConstructor : JContainer
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x4DB9950", Offset = "0x4DB8550", VA = "0x184DB9950", Slot = "74")]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x4DB9C30", Offset = "0x4DB8830", VA = "0x184DB9C30", Slot = "86")]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015C")]
		public string Name
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x1700015D")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "13")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4DBA250", Offset = "0x4DB8E50", VA = "0x184DBA250")]
		public JConstructor()
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4DBA000", Offset = "0x4DB8C00", VA = "0x184DBA000")]
		public JConstructor(JConstructor other)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4DB9FB0", Offset = "0x4DB8BB0", VA = "0x184DB9FB0")]
		public JConstructor(string name, params object[] content)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4DB9FB0", Offset = "0x4DB8BB0", VA = "0x184DB9FB0")]
		public JConstructor(string name, object content)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4DBA0B0", Offset = "0x4DB8CB0", VA = "0x184DBA0B0")]
		public JConstructor(string name)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4DB96C0", Offset = "0x4DB82C0", VA = "0x184DB96C0", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4DB95E0", Offset = "0x4DB81E0", VA = "0x184DB95E0", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x4DB9D00", Offset = "0x4DB8900", VA = "0x184DB9D00", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x1700015E RID: 350
		[Token(Token = "0x1700015E")]
		public override JToken this[object key]
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x4DBA310", Offset = "0x4DB8F10", VA = "0x184DBA310", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x4DBA460", Offset = "0x4DB9060", VA = "0x184DBA460", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4DB98F0", Offset = "0x4DB84F0", VA = "0x184DB98F0", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4DB99A0", Offset = "0x4DB85A0", VA = "0x184DB99A0")]
		public new static JConstructor Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4DB99B0", Offset = "0x4DB85B0", VA = "0x184DB99B0")]
		public new static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x50")]
		private string _name;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<JToken> _values;
	}
}
