using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016B1 RID: 5809
	[Token(Token = "0x20016B1")]
	public class LRUKVTable<TValue, TSingleton> : AbstractKVTable<TValue, TSingleton> where TSingleton : ScriptableObject
	{
		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x000392E8 File Offset: 0x000374E8
		[Token(Token = "0x17000FA4")]
		public override bool inited
		{
			[Token(Token = "0x6009306")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x00039300 File Offset: 0x00037500
		[Token(Token = "0x6009307")]
		public override bool Validate()
		{
			return default(bool);
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x00039318 File Offset: 0x00037518
		[Token(Token = "0x6009308")]
		public override bool Init(Stream reader, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x00039330 File Offset: 0x00037530
		[Token(Token = "0x6009309")]
		public override bool Init(TextAsset rawData, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600930A")]
		public override AbstractTable.IAsyncLoadRequest InitAsync(IConverter converter)
		{
			return null;
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930B")]
		private void _InitWithData(Dictionary<string, byte[]> data, IConverter converter)
		{
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600930C")]
		private void _InitDataFailed()
		{
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600930D")]
		public override string SerializeToString(bool intended)
		{
			return null;
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600930E")]
		public override string GetDebugString()
		{
			return null;
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x00039348 File Offset: 0x00037548
		[Token(Token = "0x600930F")]
		public override bool TryGetValue(string key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009310")]
		public override IEnumerator<KeyValuePair<string, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009311")]
		public LRUKVTable()
		{
		}

		// Token: 0x040088A6 RID: 34982
		[Token(Token = "0x40088A6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _lruCapacity;

		// Token: 0x040088A7 RID: 34983
		[Token(Token = "0x40088A7")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private bool m_inited;

		// Token: 0x040088A8 RID: 34984
		[Token(Token = "0x40088A8")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private Dictionary<string, byte[]> m_rawBytesMap;

		// Token: 0x040088A9 RID: 34985
		[Token(Token = "0x40088A9")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private LRUCache<string, TValue> m_lruCache;

		// Token: 0x040088AA RID: 34986
		[Token(Token = "0x40088AA")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private IConverter m_converter;

		// Token: 0x040088AB RID: 34987
		[Token(Token = "0x40088AB")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isValid;

		// Token: 0x040088AC RID: 34988
		[Token(Token = "0x40088AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x040088AD RID: 34989
		[Token(Token = "0x40088AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x040088AE RID: 34990
		[Token(Token = "0x40088AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040088AF RID: 34991
		[Token(Token = "0x40088AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x040088B0 RID: 34992
		[Token(Token = "0x40088B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAsync;

		// Token: 0x040088B1 RID: 34993
		[Token(Token = "0x40088B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitWithData;

		// Token: 0x040088B2 RID: 34994
		[Token(Token = "0x40088B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitDataFailed;

		// Token: 0x040088B3 RID: 34995
		[Token(Token = "0x40088B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SerializeToString;

		// Token: 0x040088B4 RID: 34996
		[Token(Token = "0x40088B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDebugString;

		// Token: 0x040088B5 RID: 34997
		[Token(Token = "0x40088B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetValue;

		// Token: 0x040088B6 RID: 34998
		[Token(Token = "0x40088B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEnumerator;

		// Token: 0x040088B7 RID: 34999
		[Token(Token = "0x40088B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016B2 RID: 5810
		[Token(Token = "0x20016B2")]
		public class Enumerator : IEnumerator<KeyValuePair<string, TValue>>, IEnumerator, IDisposable
		{
			// Token: 0x17000FA5 RID: 4005
			// (get) Token: 0x06009312 RID: 37650 RVA: 0x00039360 File Offset: 0x00037560
			[Token(Token = "0x17000FA5")]
			public KeyValuePair<string, TValue> Current
			{
				[Token(Token = "0x6009312")]
				get
				{
					return default(KeyValuePair<string, TValue>);
				}
			}

			// Token: 0x17000FA6 RID: 4006
			// (get) Token: 0x06009313 RID: 37651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000FA6")]
			private object Current
			{
				[Token(Token = "0x6009313")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009314 RID: 37652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009314")]
			public Enumerator(IEnumerator<KeyValuePair<string, byte[]>> enumerator, AbstractKVTable<TValue, TSingleton> table)
			{
			}

			// Token: 0x06009315 RID: 37653 RVA: 0x00039378 File Offset: 0x00037578
			[Token(Token = "0x6009315")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06009316 RID: 37654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009316")]
			public void Reset()
			{
			}

			// Token: 0x06009317 RID: 37655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009317")]
			public void Dispose()
			{
			}

			// Token: 0x040088B8 RID: 35000
			[Token(Token = "0x40088B8")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<KeyValuePair<string, byte[]>> m_enumerator;

			// Token: 0x040088B9 RID: 35001
			[Token(Token = "0x40088B9")]
			[FieldOffset(Offset = "0x0")]
			private AbstractKVTable<TValue, TSingleton> m_table;
		}
	}
}
