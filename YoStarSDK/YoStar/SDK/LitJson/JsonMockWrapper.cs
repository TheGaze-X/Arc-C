using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x170001F6")]
		public bool IsArray
		{
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x170001F7")]
		public bool IsBoolean
		{
			[Token(Token = "0x6001158")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x170001F8")]
		public bool IsDouble
		{
			[Token(Token = "0x6001159")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x170001F9")]
		public bool IsInt
		{
			[Token(Token = "0x600115A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x170001FA")]
		public bool IsLong
		{
			[Token(Token = "0x600115B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x170001FB")]
		public bool IsObject
		{
			[Token(Token = "0x600115C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x170001FC")]
		public bool IsString
		{
			[Token(Token = "0x600115D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "12")]
		public double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x5CDDA30", Offset = "0x5CDC630", VA = "0x185CDDA30", Slot = "16")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void SetBoolean(bool val)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public void SetDouble(double val)
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public void SetInt(int val)
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public void SetLong(long val)
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public void SetString(string val)
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x5CDDA60", Offset = "0x5CDC660", VA = "0x185CDDA60", Slot = "23")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x170001FD")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600116C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x170001FE")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600116D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001FF")]
		private object Item
		{
			[Token(Token = "0x600116E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x600116F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		private void Insert(int i, object v)
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x17000200")]
		private int Count
		{
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x17000201")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		private object SyncRoot
		{
			[Token(Token = "0x6001179")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x17000203")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600117C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x17000204")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		private ICollection Keys
		{
			[Token(Token = "0x600117E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000206")]
		private ICollection Values
		{
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000207")]
		private object Item
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "51")]
		private void Add(object k, object v)
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000208")]
		private object Item
		{
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001188")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "44")]
		private void Insert(int i, object k, object v)
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "45")]
		private void RemoveAt(int i)
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMockWrapper()
		{
		}
	}
}
