using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EC")]
		public object Current
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x5CDF970", Offset = "0x5CDE570", VA = "0x185CDF970", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x170001ED")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x5CDFA40", Offset = "0x5CDE640", VA = "0x185CDFA40", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EE")]
		public object Key
		{
			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x5CDFAE0", Offset = "0x5CDE6E0", VA = "0x185CDFAE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EF")]
		public object Value
		{
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x5CDFB40", Offset = "0x5CDE740", VA = "0x185CDFB40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x5CDF8D0", Offset = "0x5CDE4D0", VA = "0x185CDF8D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x5CDF920", Offset = "0x5CDE520", VA = "0x185CDF920", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
