using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x170001CE")]
		public int Count
		{
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x5CD39D0", Offset = "0x5CD25D0", VA = "0x185CD39D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x170001CF")]
		public bool IsArray
		{
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x5365C20", Offset = "0x5364820", VA = "0x185365C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x170001D0")]
		public bool IsBoolean
		{
			[Token(Token = "0x600108E")]
			[Address(RVA = "0x5365C30", Offset = "0x5364830", VA = "0x185365C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x170001D1")]
		public bool IsDouble
		{
			[Token(Token = "0x600108F")]
			[Address(RVA = "0x5365C40", Offset = "0x5364840", VA = "0x185365C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x170001D2")]
		public bool IsInt
		{
			[Token(Token = "0x6001090")]
			[Address(RVA = "0x5365C50", Offset = "0x5364850", VA = "0x185365C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x170001D3")]
		public bool IsLong
		{
			[Token(Token = "0x6001091")]
			[Address(RVA = "0x5365C60", Offset = "0x5364860", VA = "0x185365C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x170001D4")]
		public bool IsObject
		{
			[Token(Token = "0x6001092")]
			[Address(RVA = "0x5365C70", Offset = "0x5364870", VA = "0x185365C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x170001D5")]
		public bool IsString
		{
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x5365C80", Offset = "0x5364880", VA = "0x185365C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6001094")]
			[Address(RVA = "0x5CD6210", Offset = "0x5CD4E10", VA = "0x185CD6210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x5CD2BE0", Offset = "0x5CD17E0", VA = "0x185CD2BE0")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x170001D7")]
		private int Count
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x5CD39D0", Offset = "0x5CD25D0", VA = "0x185CD39D0", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x170001D8")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6001097")]
			[Address(RVA = "0x5CD3A30", Offset = "0x5CD2630", VA = "0x185CD3A30", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		private object SyncRoot
		{
			[Token(Token = "0x6001098")]
			[Address(RVA = "0x5CD3A90", Offset = "0x5CD2690", VA = "0x185CD3A90", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x170001DA")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6001099")]
			[Address(RVA = "0x5CD3ED0", Offset = "0x5CD2AD0", VA = "0x185CD3ED0", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x170001DB")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600109A")]
			[Address(RVA = "0x5CD3F30", Offset = "0x5CD2B30", VA = "0x185CD3F30", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DC")]
		private ICollection Keys
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x5CD4080", Offset = "0x5CD2C80", VA = "0x185CD4080", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DD")]
		private ICollection Values
		{
			[Token(Token = "0x600109C")]
			[Address(RVA = "0x5CD4390", Offset = "0x5CD2F90", VA = "0x185CD4390", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170001DE")]
		private bool IsArray
		{
			[Token(Token = "0x600109D")]
			[Address(RVA = "0x5365C20", Offset = "0x5364820", VA = "0x185365C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x170001DF")]
		private bool IsBoolean
		{
			[Token(Token = "0x600109E")]
			[Address(RVA = "0x5365C30", Offset = "0x5364830", VA = "0x185365C30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x170001E0")]
		private bool IsDouble
		{
			[Token(Token = "0x600109F")]
			[Address(RVA = "0x5365C40", Offset = "0x5364840", VA = "0x185365C40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x170001E1")]
		private bool IsInt
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x5365C50", Offset = "0x5364850", VA = "0x185365C50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x170001E2")]
		private bool IsLong
		{
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0x5365C60", Offset = "0x5364860", VA = "0x185365C60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x170001E3")]
		private bool IsObject
		{
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0x5365C70", Offset = "0x5364870", VA = "0x185365C70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x170001E4")]
		private bool IsString
		{
			[Token(Token = "0x60010A3")]
			[Address(RVA = "0x5365C80", Offset = "0x5364880", VA = "0x185365C80", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x170001E5")]
		private bool IsFixedSize
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x5CD4AD0", Offset = "0x5CD36D0", VA = "0x185CD4AD0", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x170001E6")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x5CD4B30", Offset = "0x5CD3730", VA = "0x185CD4B30", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001E7")]
		private object Item
		{
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x5CD3F90", Offset = "0x5CD2B90", VA = "0x185CD3F90", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x5CD46A0", Offset = "0x5CD32A0", VA = "0x185CD46A0", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001E8")]
		private object Item
		{
			[Token(Token = "0x60010A8")]
			[Address(RVA = "0x5CD4ED0", Offset = "0x5CD3AD0", VA = "0x185CD4ED0", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A9")]
			[Address(RVA = "0x5CD4F50", Offset = "0x5CD3B50", VA = "0x185CD4F50", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001E9")]
		private object Item
		{
			[Token(Token = "0x60010AA")]
			[Address(RVA = "0x5CD4B90", Offset = "0x5CD3790", VA = "0x185CD4B90", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0x5CD4BF0", Offset = "0x5CD37F0", VA = "0x185CD4BF0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x170001EA RID: 490
		[Token(Token = "0x170001EA")]
		public JsonData this[string prop_name]
		{
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0x5CD5FD0", Offset = "0x5CD4BD0", VA = "0x185CD5FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0x5CD6750", Offset = "0x5CD5350", VA = "0x185CD6750")]
			set
			{
			}
		}

		// Token: 0x170001EB RID: 491
		[Token(Token = "0x170001EB")]
		public JsonData this[int index]
		{
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x5CD60C0", Offset = "0x5CD4CC0", VA = "0x185CD60C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x5CD6930", Offset = "0x5CD5530", VA = "0x185CD6930")]
			set
			{
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonData()
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x5368120", Offset = "0x5366D20", VA = "0x185368120")]
		public JsonData(bool boolean)
		{
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x53680C0", Offset = "0x5366CC0", VA = "0x1853680C0")]
		public JsonData(double number)
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x53680F0", Offset = "0x5366CF0", VA = "0x1853680F0")]
		public JsonData(int number)
		{
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x53683E0", Offset = "0x5366FE0", VA = "0x1853683E0")]
		public JsonData(long number)
		{
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x5CD5D40", Offset = "0x5CD4940", VA = "0x185CD5D40")]
		public JsonData(object obj)
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x5368080", Offset = "0x5366C80", VA = "0x185368080")]
		public JsonData(string str)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x5CD6510", Offset = "0x5CD5110", VA = "0x185CD6510")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x5CD65F0", Offset = "0x5CD51F0", VA = "0x185CD65F0")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x5CD6580", Offset = "0x5CD5180", VA = "0x185CD6580")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x5CD66E0", Offset = "0x5CD52E0", VA = "0x185CD66E0")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x5CD6660", Offset = "0x5CD5260", VA = "0x185CD6660")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x5CD6490", Offset = "0x5CD5090", VA = "0x185CD6490")]
		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x5CD6270", Offset = "0x5CD4E70", VA = "0x185CD6270")]
		public static explicit operator double(JsonData data)
		{
			return 0.0;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x5CD62F0", Offset = "0x5CD4EF0", VA = "0x185CD62F0")]
		public static explicit operator int(JsonData data)
		{
			return 0;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x5CD6400", Offset = "0x5CD5000", VA = "0x185CD6400")]
		public static explicit operator long(JsonData data)
		{
			return 0L;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x5CD6380", Offset = "0x5CD4F80", VA = "0x185CD6380")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x5CD38D0", Offset = "0x5CD24D0", VA = "0x185CD38D0", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x5CD3AF0", Offset = "0x5CD26F0", VA = "0x185CD3AF0", Slot = "51")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x5CD3C20", Offset = "0x5CD2820", VA = "0x185CD3C20", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x5CD3CB0", Offset = "0x5CD28B0", VA = "0x185CD3CB0", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x5CD3D20", Offset = "0x5CD2920", VA = "0x185CD3D20", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x5CD3D60", Offset = "0x5CD2960", VA = "0x185CD3D60", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x5CD47A0", Offset = "0x5CD33A0", VA = "0x185CD47A0", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x5CD5B00", Offset = "0x5CD4700", VA = "0x185CD5B00", Slot = "11")]
		private bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x5CD5B70", Offset = "0x5CD4770", VA = "0x185CD5B70", Slot = "12")]
		private double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x5CD5BE0", Offset = "0x5CD47E0", VA = "0x185CD5BE0", Slot = "13")]
		private int GetInt()
		{
			return 0;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x5CD5C50", Offset = "0x5CD4850", VA = "0x185CD5C50", Slot = "15")]
		private long GetLong()
		{
			return 0L;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x5CD5CC0", Offset = "0x5CD48C0", VA = "0x185CD5CC0", Slot = "16")]
		private string GetString()
		{
			return null;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x5365A20", Offset = "0x5364620", VA = "0x185365A20", Slot = "17")]
		private void SetBoolean(bool val)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x5365A40", Offset = "0x5364640", VA = "0x185365A40", Slot = "18")]
		private void SetDouble(double val)
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x5365A60", Offset = "0x5364660", VA = "0x185365A60", Slot = "19")]
		private void SetInt(int val)
		{
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x5365A80", Offset = "0x5364680", VA = "0x185365A80", Slot = "21")]
		private void SetLong(long val)
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x5365AA0", Offset = "0x53646A0", VA = "0x185365AA0", Slot = "22")]
		private void SetString(string val)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x5CD5D30", Offset = "0x5CD4930", VA = "0x185CD5D30", Slot = "23")]
		private string ToJson()
		{
			return null;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x5CD52C0", Offset = "0x5CD3EC0", VA = "0x185CD52C0", Slot = "24")]
		private void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x5CD2AD0", Offset = "0x5CD16D0", VA = "0x185CD2AD0", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x5CD47F0", Offset = "0x5CD33F0", VA = "0x185CD47F0", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x5CD4860", Offset = "0x5CD3460", VA = "0x185CD4860", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x5CD48D0", Offset = "0x5CD34D0", VA = "0x185CD48D0", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x5CD4940", Offset = "0x5CD3540", VA = "0x185CD4940", Slot = "33")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x5CD4A50", Offset = "0x5CD3650", VA = "0x185CD4A50", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x5CD49D0", Offset = "0x5CD35D0", VA = "0x185CD49D0", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x5CD4C40", Offset = "0x5CD3840", VA = "0x185CD4C40", Slot = "43")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x5CD4CE0", Offset = "0x5CD38E0", VA = "0x185CD4CE0", Slot = "44")]
		private void Insert(int idx, object key, object value)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x5CD4E00", Offset = "0x5CD3A00", VA = "0x185CD4E00", Slot = "45")]
		private void RemoveAt(int idx)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x5CD2C70", Offset = "0x5CD1870", VA = "0x185CD2C70")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x5CD2D60", Offset = "0x5CD1960", VA = "0x185CD2D60")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x5CD2F20", Offset = "0x5CD1B20", VA = "0x185CD2F20")]
		private IList EnsureList()
		{
			return null;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x5CD5090", Offset = "0x5CD3C90", VA = "0x185CD5090")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x5CD5410", Offset = "0x5CD4010", VA = "0x185CD5410")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x5CD2AD0", Offset = "0x5CD16D0", VA = "0x185CD2AD0")]
		public int Add(object value)
		{
			return 0;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x5CD3280", Offset = "0x5CD1E80", VA = "0x185CD3280")]
		public bool Remove(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x5CD2B60", Offset = "0x5CD1760", VA = "0x185CD2B60")]
		public void Clear()
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x5CD3070", Offset = "0x5CD1C70", VA = "0x185CD3070", Slot = "57")]
		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x5CD36C0", Offset = "0x5CD22C0", VA = "0x185CD36C0", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x5CD51C0", Offset = "0x5CD3DC0", VA = "0x185CD51C0")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x5CD52C0", Offset = "0x5CD3EC0", VA = "0x185CD52C0")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x5CD5300", Offset = "0x5CD3F00", VA = "0x185CD5300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x20")]
		private double inst_double;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x28")]
		private int inst_int;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x30")]
		private long inst_long;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x38")]
		private IDictionary<string, JsonData> inst_object;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x40")]
		private string inst_string;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x48")]
		private string json;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x50")]
		private JsonType type;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x58")]
		private IList<KeyValuePair<string, JsonData>> object_list;
	}
}
