using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Method)]
	public class MethodAttribute : Attribute
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public MethodDisplay Display
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return MethodDisplay.Button;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public string UndoMessageOnClick
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public bool IsCoroutine
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4F1DC0", Offset = "0x4F09C0", VA = "0x1804F1DC0")]
		public MethodAttribute()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4F1C80", Offset = "0x4F0880", VA = "0x1804F1C80")]
		public MethodAttribute(MethodDisplay display)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4F1D70", Offset = "0x4F0970", VA = "0x1804F1D70")]
		public MethodAttribute(bool isCoroutine)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4F1E10", Offset = "0x4F0A10", VA = "0x1804F1E10")]
		public MethodAttribute(string undoMessageOnClick)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4F1CE0", Offset = "0x4F08E0", VA = "0x1804F1CE0")]
		public MethodAttribute(bool isCoroutine, string undoMessageOnClick)
		{
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		private MethodDisplay display;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		private string undoMessageOnClick;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		private bool isCoroutine;
	}
}
