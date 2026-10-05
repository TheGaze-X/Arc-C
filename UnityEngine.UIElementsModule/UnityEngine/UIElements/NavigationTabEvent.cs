using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent>
	{
		// Token: 0x170002BB RID: 699
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		private NavigationTabEvent.Direction direction
		{
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x21E8280", Offset = "0x21E6E80", VA = "0x1821E8280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x5AE91B0", Offset = "0x5AE7DB0", VA = "0x185AE91B0")]
		internal static NavigationTabEvent.Direction DetermineMoveDirection(int moveValue)
		{
			return NavigationTabEvent.Direction.None;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x5AE91D0", Offset = "0x5AE7DD0", VA = "0x185AE91D0")]
		public static NavigationTabEvent GetPooled(int moveValue)
		{
			return null;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x5AE9250", Offset = "0x5AE7E50", VA = "0x185AE9250", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x5AE92A0", Offset = "0x5AE7EA0", VA = "0x185AE92A0")]
		public NavigationTabEvent()
		{
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		public enum Direction
		{
			// Token: 0x04000678 RID: 1656
			[Token(Token = "0x4000678")]
			None,
			// Token: 0x04000679 RID: 1657
			[Token(Token = "0x4000679")]
			Next,
			// Token: 0x0400067A RID: 1658
			[Token(Token = "0x400067A")]
			Previous
		}
	}
}
