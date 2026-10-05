using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x5AE8F10", Offset = "0x5AE7B10", VA = "0x185AE8F10")]
		internal static NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
		{
			return NavigationMoveEvent.Direction.None;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000064C8 File Offset: 0x000046C8
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B9")]
		public NavigationMoveEvent.Direction direction
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x21E8010", Offset = "0x21E6C10", VA = "0x1821E8010")]
			[CompilerGenerated]
			get
			{
				return NavigationMoveEvent.Direction.None;
			}
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x21E8280", Offset = "0x21E6E80", VA = "0x1821E8280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002BA RID: 698
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		private Vector2 move
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x4212020", Offset = "0x4210C20", VA = "0x184212020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x5AE8F90", Offset = "0x5AE7B90", VA = "0x185AE8F90")]
		public static NavigationMoveEvent GetPooled(Vector2 moveVector)
		{
			return null;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x5AE9080", Offset = "0x5AE7C80", VA = "0x185AE9080", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x5AE9110", Offset = "0x5AE7D10", VA = "0x185AE9110")]
		public NavigationMoveEvent()
		{
		}

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		public enum Direction
		{
			// Token: 0x04000671 RID: 1649
			[Token(Token = "0x4000671")]
			None,
			// Token: 0x04000672 RID: 1650
			[Token(Token = "0x4000672")]
			Left,
			// Token: 0x04000673 RID: 1651
			[Token(Token = "0x4000673")]
			Up,
			// Token: 0x04000674 RID: 1652
			[Token(Token = "0x4000674")]
			Right,
			// Token: 0x04000675 RID: 1653
			[Token(Token = "0x4000675")]
			Down
		}
	}
}
