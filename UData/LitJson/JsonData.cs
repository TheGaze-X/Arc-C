using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000013")]
		public int Count
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x55B2810", Offset = "0x55B1410", VA = "0x1855B2810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000014")]
		public bool IsArray
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x5365C20", Offset = "0x5364820", VA = "0x185365C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x17000015")]
		public bool IsBoolean
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x5365C30", Offset = "0x5364830", VA = "0x185365C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000016")]
		public bool IsDouble
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x5365C40", Offset = "0x5364840", VA = "0x185365C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000017")]
		public bool IsInt
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x5365C50", Offset = "0x5364850", VA = "0x185365C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000018")]
		public bool IsLong
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5365C60", Offset = "0x5364860", VA = "0x185365C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x17000019")]
		public bool IsObject
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x5365C70", Offset = "0x5364870", VA = "0x185365C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x1700001A")]
		public bool IsString
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x5365C80", Offset = "0x5364880", VA = "0x185365C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700001B")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x55B5070", Offset = "0x55B3C70", VA = "0x1855B5070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x55B1A20", Offset = "0x55B0620", VA = "0x1855B1A20")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x1700001C")]
		private int Count
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x55B2810", Offset = "0x55B1410", VA = "0x1855B2810", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x1700001D")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x55B2870", Offset = "0x55B1470", VA = "0x1855B2870", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700001E")]
		private object SyncRoot
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x55B28D0", Offset = "0x55B14D0", VA = "0x1855B28D0", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700001F")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x55B2D10", Offset = "0x55B1910", VA = "0x1855B2D10", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000020")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x55B2D70", Offset = "0x55B1970", VA = "0x1855B2D70", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000021")]
		private ICollection Keys
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x55B2EC0", Offset = "0x55B1AC0", VA = "0x1855B2EC0", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000022")]
		private ICollection Values
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x55B31D0", Offset = "0x55B1DD0", VA = "0x1855B31D0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000023")]
		private bool IsArray
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x5365C20", Offset = "0x5364820", VA = "0x185365C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000024")]
		private bool IsBoolean
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x5365C30", Offset = "0x5364830", VA = "0x185365C30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x17000025")]
		private bool IsDouble
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x5365C40", Offset = "0x5364840", VA = "0x185365C40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x17000026")]
		private bool IsInt
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x5365C50", Offset = "0x5364850", VA = "0x185365C50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x17000027")]
		private bool IsLong
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x5365C60", Offset = "0x5364860", VA = "0x185365C60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000028")]
		private bool IsObject
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x5365C70", Offset = "0x5364870", VA = "0x185365C70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000029")]
		private bool IsString
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x5365C80", Offset = "0x5364880", VA = "0x185365C80", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x1700002A")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x55B3910", Offset = "0x55B2510", VA = "0x1855B3910", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x1700002B")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x55B3970", Offset = "0x55B2570", VA = "0x1855B3970", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public bool IsNull
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x36D4FA0", Offset = "0x36D3BA0", VA = "0x1836D4FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		private object Item
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x55B2DD0", Offset = "0x55B19D0", VA = "0x1855B2DD0", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x55B34E0", Offset = "0x55B20E0", VA = "0x1855B34E0", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		private object Item
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x55B3D10", Offset = "0x55B2910", VA = "0x1855B3D10", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x55B3D90", Offset = "0x55B2990", VA = "0x1855B3D90", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		private object Item
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x55B39D0", Offset = "0x55B25D0", VA = "0x1855B39D0", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x55B3A30", Offset = "0x55B2630", VA = "0x1855B3A30", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		[Token(Token = "0x17000030")]
		public JsonData this[string prop_name]
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x55B4F80", Offset = "0x55B3B80", VA = "0x1855B4F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x55B55B0", Offset = "0x55B41B0", VA = "0x1855B55B0")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		[Token(Token = "0x17000031")]
		public JsonData this[int index]
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x55B4E30", Offset = "0x55B3A30", VA = "0x1855B4E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x55B5790", Offset = "0x55B4390", VA = "0x1855B5790")]
			set
			{
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonData()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5368120", Offset = "0x5366D20", VA = "0x185368120")]
		public JsonData(bool boolean)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x53680C0", Offset = "0x5366CC0", VA = "0x1853680C0")]
		public JsonData(double number)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x53680F0", Offset = "0x5366CF0", VA = "0x1853680F0")]
		public JsonData(int number)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x53683E0", Offset = "0x5366FE0", VA = "0x1853683E0")]
		public JsonData(long number)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x55B4BA0", Offset = "0x55B37A0", VA = "0x1855B4BA0")]
		public JsonData(object obj)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5368080", Offset = "0x5366C80", VA = "0x185368080")]
		public JsonData(string str)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x55B54C0", Offset = "0x55B40C0", VA = "0x1855B54C0")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x55B5450", Offset = "0x55B4050", VA = "0x1855B5450")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x55B5370", Offset = "0x55B3F70", VA = "0x1855B5370")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x55B53E0", Offset = "0x55B3FE0", VA = "0x1855B53E0")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x55B5530", Offset = "0x55B4130", VA = "0x1855B5530")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x55B5260", Offset = "0x55B3E60", VA = "0x1855B5260")]
		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x55B5160", Offset = "0x55B3D60", VA = "0x1855B5160")]
		public static explicit operator double(JsonData data)
		{
			return 0.0;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x55B50D0", Offset = "0x55B3CD0", VA = "0x1855B50D0")]
		public static explicit operator int(JsonData data)
		{
			return 0;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x55B52E0", Offset = "0x55B3EE0", VA = "0x1855B52E0")]
		public static explicit operator long(JsonData data)
		{
			return 0L;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x55B51E0", Offset = "0x55B3DE0", VA = "0x1855B51E0")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x55B2710", Offset = "0x55B1310", VA = "0x1855B2710", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x55B2930", Offset = "0x55B1530", VA = "0x1855B2930", Slot = "51")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x55B2A60", Offset = "0x55B1660", VA = "0x1855B2A60", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x55B2AF0", Offset = "0x55B16F0", VA = "0x1855B2AF0", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x55B2B60", Offset = "0x55B1760", VA = "0x1855B2B60", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x55B2BA0", Offset = "0x55B17A0", VA = "0x1855B2BA0", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x55B35E0", Offset = "0x55B21E0", VA = "0x1855B35E0", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x55B4270", Offset = "0x55B2E70", VA = "0x1855B4270", Slot = "11")]
		private bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x55B42E0", Offset = "0x55B2EE0", VA = "0x1855B42E0", Slot = "12")]
		private double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x55B4350", Offset = "0x55B2F50", VA = "0x1855B4350", Slot = "13")]
		private int GetInt()
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x55B43C0", Offset = "0x55B2FC0", VA = "0x1855B43C0", Slot = "15")]
		private long GetLong()
		{
			return 0L;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x55B4430", Offset = "0x55B3030", VA = "0x1855B4430", Slot = "16")]
		private string GetString()
		{
			return null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x5365A20", Offset = "0x5364620", VA = "0x185365A20", Slot = "17")]
		private void SetBoolean(bool val)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5365A40", Offset = "0x5364640", VA = "0x185365A40", Slot = "18")]
		private void SetDouble(double val)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x5365A60", Offset = "0x5364660", VA = "0x185365A60", Slot = "19")]
		private void SetInt(int val)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x5365A80", Offset = "0x5364680", VA = "0x185365A80", Slot = "21")]
		private void SetLong(long val)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5365AA0", Offset = "0x53646A0", VA = "0x185365AA0", Slot = "22")]
		private void SetString(string val)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x55B44A0", Offset = "0x55B30A0", VA = "0x1855B44A0", Slot = "23")]
		private string ToJson()
		{
			return null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x55B4000", Offset = "0x55B2C00", VA = "0x1855B4000", Slot = "24")]
		private void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x55B1910", Offset = "0x55B0510", VA = "0x1855B1910", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x55B3630", Offset = "0x55B2230", VA = "0x1855B3630", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x55B36A0", Offset = "0x55B22A0", VA = "0x1855B36A0", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x55B3710", Offset = "0x55B2310", VA = "0x1855B3710", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x55B3780", Offset = "0x55B2380", VA = "0x1855B3780", Slot = "33")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x55B3890", Offset = "0x55B2490", VA = "0x1855B3890", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x55B3810", Offset = "0x55B2410", VA = "0x1855B3810", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x55B3A80", Offset = "0x55B2680", VA = "0x1855B3A80", Slot = "43")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x55B3B20", Offset = "0x55B2720", VA = "0x1855B3B20", Slot = "44")]
		private void Insert(int idx, object key, object value)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x55B3C40", Offset = "0x55B2840", VA = "0x1855B3C40", Slot = "45")]
		private void RemoveAt(int idx)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x55B1AB0", Offset = "0x55B06B0", VA = "0x1855B1AB0")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x55B1BA0", Offset = "0x55B07A0", VA = "0x1855B1BA0")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x55B1D60", Offset = "0x55B0960", VA = "0x1855B1D60")]
		private IList EnsureList()
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x55B3ED0", Offset = "0x55B2AD0", VA = "0x1855B3ED0")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x55B44B0", Offset = "0x55B30B0", VA = "0x1855B44B0")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x55B1910", Offset = "0x55B0510", VA = "0x1855B1910")]
		public int Add(object value)
		{
			return 0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x55B20C0", Offset = "0x55B0CC0", VA = "0x1855B20C0")]
		public bool Remove(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x55B19A0", Offset = "0x55B05A0", VA = "0x1855B19A0")]
		public void Clear()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x55B1EB0", Offset = "0x55B0AB0", VA = "0x1855B1EB0", Slot = "57")]
		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x55B2500", Offset = "0x55B1100", VA = "0x1855B2500", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x55B4040", Offset = "0x55B2C40", VA = "0x1855B4040")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x55B4000", Offset = "0x55B2C00", VA = "0x1855B4000")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x55B4160", Offset = "0x55B2D60", VA = "0x1855B4160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		private double inst_double;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x28")]
		private int inst_int;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x30")]
		private long inst_long;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x38")]
		private IDictionary<string, JsonData> inst_object;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x40")]
		private string inst_string;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x48")]
		private string json;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x50")]
		private JsonType type;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x58")]
		private IList<KeyValuePair<string, JsonData>> object_list;
	}
}
