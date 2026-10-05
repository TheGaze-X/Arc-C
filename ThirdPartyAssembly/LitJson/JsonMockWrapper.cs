using System;
using System.Collections;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x17000508")]
		public bool IsArray
		{
			[Token(Token = "0x600255E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x17000509")]
		public bool IsBoolean
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x1700050A")]
		public bool IsDouble
		{
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x1700050B")]
		public bool IsInt
		{
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x1700050C")]
		public bool IsLong
		{
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x1700050D")]
		public bool IsObject
		{
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x1700050E")]
		public bool IsString
		{
			[Token(Token = "0x6002564")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "12")]
		public double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x5397380", Offset = "0x5395F80", VA = "0x185397380", Slot = "16")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void SetBoolean(bool val)
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public void SetDouble(double val)
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public void SetInt(int val)
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public void SetLong(long val)
		{
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public void SetString(string val)
		{
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x53973B0", Offset = "0x5395FB0", VA = "0x1853973B0", Slot = "23")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x1700050F")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002573")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x17000510")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002574")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		private object Item
		{
			[Token(Token = "0x6002575")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002576")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		private void Insert(int i, object v)
		{
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x17000512")]
		private int Count
		{
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x17000513")]
		private bool IsSynchronized
		{
			[Token(Token = "0x600257F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000514")]
		private object SyncRoot
		{
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x17000515")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002583")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x17000516")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000517")]
		private ICollection Keys
		{
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000518")]
		private ICollection Values
		{
			[Token(Token = "0x6002586")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000519")]
		private object Item
		{
			[Token(Token = "0x6002587")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002588")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "51")]
		private void Add(object k, object v)
		{
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051A")]
		private object Item
		{
			[Token(Token = "0x600258E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600258F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "41")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "42")]
		private void Insert(int i, object k, object v)
		{
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		private void RemoveAt(int i)
		{
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMockWrapper()
		{
		}
	}
}
