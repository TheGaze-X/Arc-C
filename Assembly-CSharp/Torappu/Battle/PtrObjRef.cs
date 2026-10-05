using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023E4 RID: 9188
	[Token(Token = "0x20023E4")]
	public struct PtrObjRef<T> : IEquatable<PtrObjRef<T>>, IHotfixable where T : class, IPtrObject
	{
		// Token: 0x0600EA80 RID: 60032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA80")]
		public PtrObjRef(T obj)
		{
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA81")]
		public T Get()
		{
			return null;
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x00055D88 File Offset: 0x00053F88
		[Token(Token = "0x600EA82")]
		public bool CheckValid(IPtrObject currentObj)
		{
			return default(bool);
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x00055DA0 File Offset: 0x00053FA0
		[Token(Token = "0x600EA83")]
		public bool Equals(PtrObjRef<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x00055DB8 File Offset: 0x00053FB8
		[Token(Token = "0x600EA84")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x00055DD0 File Offset: 0x00053FD0
		[Token(Token = "0x600EA85")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x00055DE8 File Offset: 0x00053FE8
		[Token(Token = "0x600EA86")]
		public static bool operator ==(PtrObjRef<T> left, PtrObjRef<T> right)
		{
			return default(bool);
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x00055E00 File Offset: 0x00054000
		[Token(Token = "0x600EA87")]
		public static bool operator !=(PtrObjRef<T> left, PtrObjRef<T> right)
		{
			return default(bool);
		}

		// Token: 0x040102EB RID: 66283
		[Token(Token = "0x40102EB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PtrObjRef<T> NULL_REF;

		// Token: 0x040102EC RID: 66284
		[Token(Token = "0x40102EC")]
		[FieldOffset(Offset = "0x0")]
		private readonly uint instanceUid;

		// Token: 0x040102ED RID: 66285
		[Token(Token = "0x40102ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040102EE RID: 66286
		[Token(Token = "0x40102EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Get;

		// Token: 0x040102EF RID: 66287
		[Token(Token = "0x40102EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckValid;

		// Token: 0x040102F0 RID: 66288
		[Token(Token = "0x40102F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x040102F1 RID: 66289
		[Token(Token = "0x40102F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Equals;

		// Token: 0x040102F2 RID: 66290
		[Token(Token = "0x40102F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHashCode;

		// Token: 0x040102F3 RID: 66291
		[Token(Token = "0x40102F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_op_Equality;

		// Token: 0x040102F4 RID: 66292
		[Token(Token = "0x40102F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_op_Inequality;
	}
}
