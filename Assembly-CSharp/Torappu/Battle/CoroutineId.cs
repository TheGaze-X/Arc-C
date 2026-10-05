using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200215C RID: 8540
	[Token(Token = "0x200215C")]
	public struct CoroutineId
	{
		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600D23F RID: 53823 RVA: 0x0004BB70 File Offset: 0x00049D70
		[Token(Token = "0x17001939")]
		public bool isValid
		{
			[Token(Token = "0x600D23F")]
			[Address(RVA = "0x3535340", Offset = "0x3533F40", VA = "0x183535340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D240")]
		[Address(RVA = "0x3535220", Offset = "0x3533E20", VA = "0x183535220")]
		public void MarkInvalid()
		{
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x0004BB88 File Offset: 0x00049D88
		[Token(Token = "0x600D241")]
		[Address(RVA = "0x35353B0", Offset = "0x3533FB0", VA = "0x1835353B0")]
		public static explicit operator CoroutineId(Coroutine coroutine)
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D242 RID: 53826 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		[Token(Token = "0x600D242")]
		[Address(RVA = "0x35353A0", Offset = "0x3533FA0", VA = "0x1835353A0")]
		public static explicit operator CoroutineId(CoroutineSimulator.InternalId id)
		{
			return default(CoroutineId);
		}

		// Token: 0x0400E0B7 RID: 57527
		[Token(Token = "0x400E0B7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CoroutineId NULL;

		// Token: 0x0400E0B8 RID: 57528
		[Token(Token = "0x400E0B8")]
		[FieldOffset(Offset = "0x0")]
		public Coroutine coroutine;

		// Token: 0x0400E0B9 RID: 57529
		[Token(Token = "0x400E0B9")]
		[FieldOffset(Offset = "0x8")]
		public CoroutineSimulator.InternalId simulatorId;
	}
}
