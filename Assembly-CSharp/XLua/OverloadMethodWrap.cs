using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	public class OverloadMethodWrap
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x000165D8 File Offset: 0x000147D8
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000155")]
		public bool HasDefalutValue
		{
			[Token(Token = "0x600372A")]
			[Address(RVA = "0x1B5F4F0", Offset = "0x1B5E0F0", VA = "0x181B5F4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x332AEF0", Offset = "0x3329AF0", VA = "0x18332AEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x332AE70", Offset = "0x3329A70", VA = "0x18332AE70")]
		public OverloadMethodWrap(ObjectTranslator translator, Type targetType, MethodBase method)
		{
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x332A0E0", Offset = "0x3328CE0", VA = "0x18332A0E0")]
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x3329F00", Offset = "0x3328B00", VA = "0x183329F00")]
		public bool Check(IntPtr L)
		{
			return default(bool);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x3329550", Offset = "0x3328150", VA = "0x183329550")]
		public int Call(IntPtr L)
		{
			return 0;
		}

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x10")]
		private ObjectTranslator translator;

		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x18")]
		private Type targetType;

		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x20")]
		private MethodBase method;

		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x28")]
		private ObjectCheck[] checkArray;

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x30")]
		private ObjectCast[] castArray;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x38")]
		private int[] inPosArray;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x40")]
		private int[] outPosArray;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x48")]
		private bool[] isOptionalArray;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x50")]
		private object[] defaultValueArray;

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x58")]
		private bool isVoid;

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x5C")]
		private int luaStackPosStart;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x60")]
		private bool targetNeeded;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x68")]
		private object[] args;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x70")]
		private int[] refPos;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x78")]
		private Type paramsType;
	}
}
