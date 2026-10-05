using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023E5 RID: 9189
	[Token(Token = "0x20023E5")]
	public class PtrObjRef : SingletonWithMonoHost<PtrObjRef, BattleController>, IDisposable
	{
		// Token: 0x0600EA89 RID: 60041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA89")]
		[Address(RVA = "0x607E10", Offset = "0x606A10", VA = "0x180607E10")]
		private PtrObjRef()
		{
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x00055E18 File Offset: 0x00054018
		[Token(Token = "0x600EA8A")]
		public static PtrObjRef<T> Ref<T>(T obj) where T : class, IPtrObject
		{
			return default(PtrObjRef<T>);
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA8B")]
		public static void LinkRef<T>(PtrObjRef<T> ptrRef, T obj) where T : class, IPtrObject
		{
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA8C")]
		public static T Get<T>(PtrObjRef<T> ptrRef) where T : class, IPtrObject
		{
			return null;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA8D")]
		[Address(RVA = "0x607D90", Offset = "0x606990", VA = "0x180607D90", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040102F5 RID: 66293
		[Token(Token = "0x40102F5")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, object> m_typeDict;

		// Token: 0x040102F6 RID: 66294
		[Token(Token = "0x40102F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040102F7 RID: 66295
		[Token(Token = "0x40102F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Ref;

		// Token: 0x040102F8 RID: 66296
		[Token(Token = "0x40102F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LinkRef;

		// Token: 0x040102F9 RID: 66297
		[Token(Token = "0x40102F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Get;

		// Token: 0x040102FA RID: 66298
		[Token(Token = "0x40102FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
