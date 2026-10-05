using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	internal static class InputUpdate
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x56F5200", Offset = "0x56F3E00", VA = "0x1856F5200")]
		internal static void OnBeforeUpdate(InputUpdateType type)
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x56F5270", Offset = "0x56F3E70", VA = "0x1856F5270")]
		internal static void OnUpdate(InputUpdateType type)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x56F5380", Offset = "0x56F3F80", VA = "0x1856F5380")]
		public static InputUpdate.SerializedState Save()
		{
			return default(InputUpdate.SerializedState);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x56F52F0", Offset = "0x56F3EF0", VA = "0x1856F52F0")]
		public static void Restore(InputUpdate.SerializedState state)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x56F51D0", Offset = "0x56F3DD0", VA = "0x1856F51D0")]
		public static InputUpdateType GetUpdateTypeForPlayer(this InputUpdateType mask)
		{
			return InputUpdateType.None;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x56F51F0", Offset = "0x56F3DF0", VA = "0x1856F51F0")]
		public static bool IsPlayerUpdate(this InputUpdateType updateType)
		{
			return default(bool);
		}

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x0")]
		public static uint s_UpdateStepCount;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x4")]
		public static InputUpdateType s_LatestUpdateType;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x8")]
		public static InputUpdate.UpdateStepCount s_PlayerUpdateStepCount;

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x20001C6")]
		[Serializable]
		public struct UpdateStepCount
		{
			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x060010DF RID: 4319 RVA: 0x00008CB8 File Offset: 0x00006EB8
			// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004D4")]
			public uint value
			{
				[Token(Token = "0x60010DF")]
				[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
				[CompilerGenerated]
				readonly get
				{
					return 0U;
				}
				[Token(Token = "0x60010E0")]
				[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x56FB350", Offset = "0x56F9F50", VA = "0x1856FB350")]
			public void OnBeforeUpdate()
			{
			}

			// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x56FB360", Offset = "0x56F9F60", VA = "0x1856FB360")]
			public void OnUpdate()
			{
			}

			// Token: 0x04000A1F RID: 2591
			[Token(Token = "0x4000A1F")]
			[FieldOffset(Offset = "0x0")]
			private bool m_WasUpdated;
		}

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x20001C7")]
		[Serializable]
		public struct SerializedState
		{
			// Token: 0x04000A21 RID: 2593
			[Token(Token = "0x4000A21")]
			[FieldOffset(Offset = "0x0")]
			public InputUpdateType lastUpdateType;

			// Token: 0x04000A22 RID: 2594
			[Token(Token = "0x4000A22")]
			[FieldOffset(Offset = "0x4")]
			public InputUpdate.UpdateStepCount playerUpdateStepCount;
		}
	}
}
