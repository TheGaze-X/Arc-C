using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	internal static class PointerDeviceState
	{
		// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x5AE9CA0", Offset = "0x5AE88A0", VA = "0x185AE9CA0")]
		internal static void RemovePanelData(IPanel panel)
		{
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x5AE9ED0", Offset = "0x5AE8AD0", VA = "0x185AE9ED0")]
		public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType)
		{
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x5AE9A80", Offset = "0x5AE8680", VA = "0x185AE9A80")]
		public static void PressButton(int pointerId, int buttonId)
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x5AE9BD0", Offset = "0x5AE87D0", VA = "0x185AE9BD0")]
		public static void ReleaseButton(int pointerId, int buttonId)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x5AE9B50", Offset = "0x5AE8750", VA = "0x185AE9B50")]
		public static void ReleaseAllButtons(int pointerId)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x5AE9850", Offset = "0x5AE8450", VA = "0x185AE9850")]
		public static Vector2 GetPointerPosition(int pointerId, ContextType contextType)
		{
			return default(Vector2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x5AE9760", Offset = "0x5AE8360", VA = "0x185AE9760")]
		public static IPanel GetPanel(int pointerId, ContextType contextType)
		{
			return null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x5AE99E0", Offset = "0x5AE85E0", VA = "0x185AE99E0")]
		private static bool HasFlagFast(PointerDeviceState.LocationFlag flagSet, PointerDeviceState.LocationFlag flag)
		{
			return default(bool);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x5AE99F0", Offset = "0x5AE85F0", VA = "0x185AE99F0")]
		public static bool HasLocationFlag(int pointerId, ContextType contextType, PointerDeviceState.LocationFlag flag)
		{
			return default(bool);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x5AE98E0", Offset = "0x5AE84E0", VA = "0x185AE98E0")]
		public static int GetPressedButtons(int pointerId)
		{
			return 0;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x5AE9950", Offset = "0x5AE8550", VA = "0x185AE9950")]
		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
		{
			return default(bool);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x5AE9F80", Offset = "0x5AE8B80", VA = "0x185AE9F80")]
		internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x5AE97E0", Offset = "0x5AE83E0", VA = "0x185AE97E0")]
		internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
		{
			return null;
		}

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x0")]
		private static PointerDeviceState.PointerLocation[] s_PlayerPointerLocations;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x8")]
		private static int[] s_PressedButtons;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture;

		// Token: 0x020001D4 RID: 468
		[Token(Token = "0x20001D4")]
		[Flags]
		internal enum LocationFlag
		{
			// Token: 0x04000681 RID: 1665
			[Token(Token = "0x4000681")]
			None = 0,
			// Token: 0x04000682 RID: 1666
			[Token(Token = "0x4000682")]
			OutsidePanel = 1
		}

		// Token: 0x020001D5 RID: 469
		[Token(Token = "0x20001D5")]
		private struct PointerLocation
		{
			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00006588 File Offset: 0x00004788
			// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BE")]
			internal Vector2 Position
			{
				[Token(Token = "0x6000C73")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000C74")]
				[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002BF")]
			internal IPanel Panel
			{
				[Token(Token = "0x6000C75")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000C76")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000065A0 File Offset: 0x000047A0
			// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002C0")]
			internal PointerDeviceState.LocationFlag Flags
			{
				[Token(Token = "0x6000C77")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				readonly get
				{
					return PointerDeviceState.LocationFlag.None;
				}
				[Token(Token = "0x6000C78")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x5AEAC70", Offset = "0x5AE9870", VA = "0x185AEAC70")]
			internal void SetLocation(Vector2 position, IPanel panel)
			{
			}
		}
	}
}
