using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FE")]
		public object Current
		{
			[Token(Token = "0x60024F4")]
			[Address(RVA = "0x539D670", Offset = "0x539C270", VA = "0x18539D670", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x170004FF")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x60024F5")]
			[Address(RVA = "0x539D740", Offset = "0x539C340", VA = "0x18539D740", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000500")]
		public object Key
		{
			[Token(Token = "0x60024F6")]
			[Address(RVA = "0x539D7E0", Offset = "0x539C3E0", VA = "0x18539D7E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000501")]
		public object Value
		{
			[Token(Token = "0x60024F7")]
			[Address(RVA = "0x539D840", Offset = "0x539C440", VA = "0x18539D840", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x539D5D0", Offset = "0x539C1D0", VA = "0x18539D5D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x539D620", Offset = "0x539C220", VA = "0x18539D620", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
