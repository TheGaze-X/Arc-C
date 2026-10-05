using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public class LuaYieldInstruction : CustomYieldInstruction, IDisposable
	{
		// Token: 0x060061E6 RID: 25062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E6")]
		[Address(RVA = "0x1DEEF40", Offset = "0x1DEDB40", VA = "0x181DEEF40")]
		public LuaYieldInstruction(ILuaAsyncInstruction asyncInst)
		{
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x0002FF10 File Offset: 0x0002E110
		[Token(Token = "0x17000CCD")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60061E7")]
			[Address(RVA = "0x1DEF090", Offset = "0x1DEDC90", VA = "0x181DEF090", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E8")]
		[Address(RVA = "0x1DEED40", Offset = "0x1DED940", VA = "0x181DEED40", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E9")]
		[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0x10")]
		private ILuaAsyncInstruction m_asyncInst;

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0x18")]
		private int m_refIndex;
	}
}
