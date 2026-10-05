using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public MouseButton button
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return MouseButton.LeftMouse;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700003F")]
		public readonly EventModifiers modifiers
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			get
			{
				return EventModifiers.None;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x17000040")]
		public readonly int clickCount
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5A36F00", Offset = "0x5A35B00", VA = "0x185A36F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5A36FB0", Offset = "0x5A35BB0", VA = "0x185A36FB0", Slot = "4")]
		public bool Equals(ManipulatorActivationFilter other)
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5A36FD0", Offset = "0x5A35BD0", VA = "0x185A36FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5A37370", Offset = "0x5A35F70", VA = "0x185A37370")]
		public bool Matches(IMouseEvent e)
		{
			return default(bool);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5A37130", Offset = "0x5A35D30", VA = "0x185A37130")]
		private bool HasModifiers(IMouseEvent e)
		{
			return default(bool);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x5A372A0", Offset = "0x5A35EA0", VA = "0x185A372A0")]
		public bool Matches(IPointerEvent e)
		{
			return default(bool);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5A37040", Offset = "0x5A35C40", VA = "0x185A37040")]
		private bool HasModifiers(IPointerEvent e)
		{
			return default(bool);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5A37220", Offset = "0x5A35E20", VA = "0x185A37220")]
		private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command)
		{
			return default(bool);
		}
	}
}
