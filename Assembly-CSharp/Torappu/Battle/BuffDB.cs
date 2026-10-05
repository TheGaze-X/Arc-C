using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200266E RID: 9838
	[Token(Token = "0x200266E")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/BuffTable")]
	[Serializable]
	public class BuffDB : SimpleKVTable<BuffData, BuffDB>
	{
		// Token: 0x0601016E RID: 65902 RVA: 0x00062370 File Offset: 0x00060570
		[Token(Token = "0x601016E")]
		[Address(RVA = "0x7C27A0", Offset = "0x7C13A0", VA = "0x1807C27A0")]
		public bool TryGetTemplate(string templateKey, out BuffTemplate template)
		{
			return default(bool);
		}

		// Token: 0x0601016F RID: 65903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601016F")]
		[Address(RVA = "0x7C2670", Offset = "0x7C1270", VA = "0x1807C2670")]
		public void LoadBuffTemplatesIfNot()
		{
		}

		// Token: 0x06010170 RID: 65904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010170")]
		[Address(RVA = "0x7C2730", Offset = "0x7C1330", VA = "0x1807C2730", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x06010171 RID: 65905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010171")]
		[Address(RVA = "0x7C2910", Offset = "0x7C1510", VA = "0x1807C2910")]
		public BuffDB()
		{
		}

		// Token: 0x04011E58 RID: 73304
		[Token(Token = "0x4011E58")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, BuffTemplate> m_buffTemplates;

		// Token: 0x04011E59 RID: 73305
		[Token(Token = "0x4011E59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetTemplate;

		// Token: 0x04011E5A RID: 73306
		[Token(Token = "0x4011E5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadBuffTemplatesIfNot;

		// Token: 0x04011E5B RID: 73307
		[Token(Token = "0x4011E5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011E5C RID: 73308
		[Token(Token = "0x4011E5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
