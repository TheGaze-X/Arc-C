using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	[DefaultMember("Item")]
	[Serializable]
	public class StringDictionary : IEnumerable
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x5177460", Offset = "0x5176060", VA = "0x185177460")]
		public StringDictionary()
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x5189410", Offset = "0x5188010", VA = "0x185189410", Slot = "5")]
		public virtual void Add(string key, string value)
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x4ADF130", Offset = "0x4ADDD30", VA = "0x184ADF130", Slot = "6")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x10")]
		internal Hashtable contents;
	}
}
