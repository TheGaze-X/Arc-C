using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public static class DOTweenCYInstruction
	{
		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x060000DA RID: 218 RVA: 0x000024C0 File Offset: 0x000006C0
			[Token(Token = "0x17000001")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000DA")]
				[Address(RVA = "0x3744280", Offset = "0x3742E80", VA = "0x183744280", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public WaitForCompletion(Tween tween)
			{
			}

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public class WaitForRewind : CustomYieldInstruction
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x060000DC RID: 220 RVA: 0x000024D8 File Offset: 0x000006D8
			[Token(Token = "0x17000002")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0x3744420", Offset = "0x3743020", VA = "0x183744420", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public WaitForRewind(Tween tween)
			{
			}

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public class WaitForKill : CustomYieldInstruction
		{
			// Token: 0x17000003 RID: 3
			// (get) Token: 0x060000DE RID: 222 RVA: 0x000024F0 File Offset: 0x000006F0
			[Token(Token = "0x17000003")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000DE")]
				[Address(RVA = "0x3744350", Offset = "0x3742F50", VA = "0x183744350", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public WaitForKill(Tween tween)
			{
			}

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			// Token: 0x17000004 RID: 4
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002508 File Offset: 0x00000708
			[Token(Token = "0x17000004")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000E0")]
				[Address(RVA = "0x3744310", Offset = "0x3742F10", VA = "0x183744310", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public class WaitForPosition : CustomYieldInstruction
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002520 File Offset: 0x00000720
			[Token(Token = "0x17000005")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x37443C0", Offset = "0x3742FC0", VA = "0x1837443C0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x3744370", Offset = "0x3742F70", VA = "0x183744370")]
			public WaitForPosition(Tween tween, float position)
			{
			}

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x18")]
			private readonly float position;
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public class WaitForStart : CustomYieldInstruction
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002538 File Offset: 0x00000738
			[Token(Token = "0x17000006")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x3744490", Offset = "0x3743090", VA = "0x183744490", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public WaitForStart(Tween tween)
			{
			}

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x10")]
			private readonly Tween t;
		}
	}
}
