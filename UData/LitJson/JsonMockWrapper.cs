using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x1700003C")]
		public bool IsArray
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700003D")]
		public bool IsBoolean
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700003E")]
		public bool IsDouble
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x1700003F")]
		public bool IsInt
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000040")]
		public bool IsLong
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000041")]
		public bool IsObject
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000042")]
		public bool IsString
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "12")]
		public double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x55BCA10", Offset = "0x55BB610", VA = "0x1855BCA10", Slot = "16")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void SetBoolean(bool val)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public void SetDouble(double val)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public void SetInt(int val)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public void SetLong(long val)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public void SetString(string val)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x55BCA40", Offset = "0x55BB640", VA = "0x1855BCA40", Slot = "23")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x17000043")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000044")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		private object Item
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		private void Insert(int i, object v)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000046")]
		private int Count
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000047")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000048")]
		private object SyncRoot
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x17000049")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x1700004A")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700004B")]
		private ICollection Keys
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700004C")]
		private ICollection Values
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		private object Item
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "51")]
		private void Add(object k, object v)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		private object Item
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "44")]
		private void Insert(int i, object k, object v)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "45")]
		private void RemoveAt(int i)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMockWrapper()
		{
		}
	}
}
