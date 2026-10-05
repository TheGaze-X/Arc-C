using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000032")]
		public object Current
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x55C1D40", Offset = "0x55C0940", VA = "0x1855C1D40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x17000033")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x55C1E10", Offset = "0x55C0A10", VA = "0x1855C1E10", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000034")]
		public object Key
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x55C1EB0", Offset = "0x55C0AB0", VA = "0x1855C1EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000035")]
		public object Value
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x55C1F10", Offset = "0x55C0B10", VA = "0x1855C1F10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x55C1CA0", Offset = "0x55C08A0", VA = "0x1855C1CA0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x55C1CF0", Offset = "0x55C08F0", VA = "0x1855C1CF0", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
