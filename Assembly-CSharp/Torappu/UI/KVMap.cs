using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200371A RID: 14106
	[Token(Token = "0x200371A")]
	public class KVMap : ScriptableObject, IEnumerable
	{
		// Token: 0x06016665 RID: 91749 RVA: 0x00091170 File Offset: 0x0008F370
		[Token(Token = "0x6016665")]
		[Address(RVA = "0xECB850", Offset = "0xECA450", VA = "0x180ECB850")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06016666 RID: 91750 RVA: 0x00091188 File Offset: 0x0008F388
		[Token(Token = "0x6016666")]
		[Address(RVA = "0xECB9F0", Offset = "0xECA5F0", VA = "0x180ECB9F0")]
		public bool TryGetValue(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x06016667 RID: 91751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016667")]
		[Address(RVA = "0xECB940", Offset = "0xECA540", VA = "0x180ECB940")]
		public void SetValue(string key, string value)
		{
		}

		// Token: 0x06016668 RID: 91752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016668")]
		[Address(RVA = "0xECBA60", Offset = "0xECA660", VA = "0x180ECBA60")]
		private void _Init()
		{
		}

		// Token: 0x06016669 RID: 91753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016669")]
		[Address(RVA = "0xECB8B0", Offset = "0xECA4B0", VA = "0x180ECB8B0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0601666A RID: 91754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601666A")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public KVMap()
		{
		}

		// Token: 0x0401AF13 RID: 110355
		[Token(Token = "0x401AF13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _keys;

		// Token: 0x0401AF14 RID: 110356
		[Token(Token = "0x401AF14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _values;

		// Token: 0x0401AF15 RID: 110357
		[Token(Token = "0x401AF15")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _map;
	}
}
