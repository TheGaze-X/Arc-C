using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016B4 RID: 5812
	[Token(Token = "0x20016B4")]
	public class SimpleKVTable<TValue, TSingleton> : AbstractKVTable<TValue, TSingleton> where TSingleton : ScriptableObject
	{
		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x00039390 File Offset: 0x00037590
		[Token(Token = "0x17000FA7")]
		public override bool inited
		{
			[Token(Token = "0x600931A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x000393A8 File Offset: 0x000375A8
		[Token(Token = "0x600931B")]
		public override bool Validate()
		{
			return default(bool);
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x0600931C RID: 37660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA8")]
		protected Dictionary<string, TValue> data
		{
			[Token(Token = "0x600931C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x000393C0 File Offset: 0x000375C0
		[Token(Token = "0x600931D")]
		public override bool Init(Stream reader, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x000393D8 File Offset: 0x000375D8
		[Token(Token = "0x600931E")]
		public override bool Init(TextAsset rawData, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600931F")]
		public override AbstractTable.IAsyncLoadRequest InitAsync(IConverter converter)
		{
			return null;
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009320")]
		private void _InitWithData(Dictionary<string, TValue> data, IConverter converter)
		{
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009321")]
		private void _InitDataFailed()
		{
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009322")]
		public override string SerializeToString(bool intended)
		{
			return null;
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009323")]
		public override string GetDebugString()
		{
			return null;
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06009324 RID: 37668 RVA: 0x000393F0 File Offset: 0x000375F0
		[Token(Token = "0x17000FA9")]
		public int Count
		{
			[Token(Token = "0x6009324")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009325")]
		public override IEnumerator<KeyValuePair<string, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x00039408 File Offset: 0x00037608
		[Token(Token = "0x6009326")]
		public override bool TryGetValue(string key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009327")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009328")]
		protected SimpleKVTable()
		{
		}

		// Token: 0x040088BC RID: 35004
		[Token(Token = "0x40088BC")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private bool m_inited;

		// Token: 0x040088BD RID: 35005
		[Token(Token = "0x40088BD")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		protected Dictionary<string, TValue> m_dataMap;

		// Token: 0x040088BE RID: 35006
		[Token(Token = "0x40088BE")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isValid;

		// Token: 0x040088BF RID: 35007
		[Token(Token = "0x40088BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x040088C0 RID: 35008
		[Token(Token = "0x40088C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x040088C1 RID: 35009
		[Token(Token = "0x40088C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x040088C2 RID: 35010
		[Token(Token = "0x40088C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040088C3 RID: 35011
		[Token(Token = "0x40088C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x040088C4 RID: 35012
		[Token(Token = "0x40088C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAsync;

		// Token: 0x040088C5 RID: 35013
		[Token(Token = "0x40088C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitWithData;

		// Token: 0x040088C6 RID: 35014
		[Token(Token = "0x40088C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitDataFailed;

		// Token: 0x040088C7 RID: 35015
		[Token(Token = "0x40088C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SerializeToString;

		// Token: 0x040088C8 RID: 35016
		[Token(Token = "0x40088C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDebugString;

		// Token: 0x040088C9 RID: 35017
		[Token(Token = "0x40088C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Count;

		// Token: 0x040088CA RID: 35018
		[Token(Token = "0x40088CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEnumerator;

		// Token: 0x040088CB RID: 35019
		[Token(Token = "0x40088CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetValue;

		// Token: 0x040088CC RID: 35020
		[Token(Token = "0x40088CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040088CD RID: 35021
		[Token(Token = "0x40088CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
