using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016A1 RID: 5793
	[Token(Token = "0x20016A1")]
	public abstract class AbstractKVTable<TValue, TSingleton> : SingletonAbstractTable<TSingleton>, IEnumerable, IEnumerable<KeyValuePair<string, TValue>> where TSingleton : ScriptableObject
	{
		// Token: 0x060092B8 RID: 37560
		[Token(Token = "0x60092B8")]
		public abstract bool TryGetValue(string key, out TValue value);

		// Token: 0x060092B9 RID: 37561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092B9")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060092BA RID: 37562
		[Token(Token = "0x60092BA")]
		public abstract IEnumerator<KeyValuePair<string, TValue>> GetEnumerator();

		// Token: 0x060092BB RID: 37563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092BB")]
		public TValue GetValue(string key)
		{
			return null;
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092BC")]
		public TValue GetValueOrDefault(string key)
		{
			return null;
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092BD")]
		public virtual IList<TValue> GetValues(IList<string> keys)
		{
			return null;
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x00039180 File Offset: 0x00037380
		[Token(Token = "0x60092BE")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092BF")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C0")]
		protected AbstractKVTable()
		{
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092C1")]
		public override Type GetDataType()
		{
			return null;
		}

		// Token: 0x0400885B RID: 34907
		[Token(Token = "0x400885B")]
		[FieldOffset(Offset = "0x0")]
		protected List<TValue> m_sharedList;

		// Token: 0x0400885C RID: 34908
		[Token(Token = "0x400885C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge GetEnumerator;

		// Token: 0x0400885D RID: 34909
		[Token(Token = "0x400885D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0400885E RID: 34910
		[Token(Token = "0x400885E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOrDefault;

		// Token: 0x0400885F RID: 34911
		[Token(Token = "0x400885F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValues;

		// Token: 0x04008860 RID: 34912
		[Token(Token = "0x4008860")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x04008861 RID: 34913
		[Token(Token = "0x4008861")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x04008862 RID: 34914
		[Token(Token = "0x4008862")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008863 RID: 34915
		[Token(Token = "0x4008863")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataType;
	}
}
