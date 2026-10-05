using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Action.TNodeAction
{
	// Token: 0x020031FF RID: 12799
	[Token(Token = "0x20031FF")]
	[Serializable]
	public class TNodeDataActionKV<TKey>
	{
		// Token: 0x060144C3 RID: 83139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144C3")]
		public TNodeDataActionKV()
		{
		}

		// Token: 0x060144C4 RID: 83140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144C4")]
		public TNodeDataActionKV(TKey key, SerializedTNodeDataAction value)
		{
		}

		// Token: 0x060144C5 RID: 83141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144C5")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060144C6 RID: 83142 RVA: 0x00086520 File Offset: 0x00084720
		[Token(Token = "0x60144C6")]
		public static implicit operator KeyValuePair<TKey, SerializedTNodeDataAction>(TNodeDataActionKV<TKey> actionKV)
		{
			return default(KeyValuePair<TKey, SerializedTNodeDataAction>);
		}

		// Token: 0x060144C7 RID: 83143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144C7")]
		public static implicit operator TNodeDataActionKV<TKey>(KeyValuePair<TKey, SerializedTNodeDataAction> kv)
		{
			return null;
		}

		// Token: 0x04017EEE RID: 98030
		[Token(Token = "0x4017EEE")]
		[FieldOffset(Offset = "0x0")]
		public TKey key;

		// Token: 0x04017EEF RID: 98031
		[Token(Token = "0x4017EEF")]
		[FieldOffset(Offset = "0x0")]
		public SerializedTNodeDataAction value;
	}
}
