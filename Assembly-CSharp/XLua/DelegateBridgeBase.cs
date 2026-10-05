using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	public abstract class DelegateBridgeBase : LuaBase
	{
		// Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x331CB80", Offset = "0x331B780", VA = "0x18331CB80")]
		public DelegateBridgeBase(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00016440 File Offset: 0x00014640
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x331CAB0", Offset = "0x331B6B0", VA = "0x18331CAB0")]
		public bool TryGetDelegate(Type key, out Delegate value)
		{
			return default(bool);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x331C890", Offset = "0x331B490", VA = "0x18331C890")]
		public void AddDelegate(Type key, Delegate value)
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public virtual Delegate GetDelegateByType(Type type)
		{
			return null;
		}

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x20")]
		private Type firstKey;

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x28")]
		private Delegate firstValue;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Type, Delegate> bindTo;

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x38")]
		protected int errorFuncRef;
	}
}
