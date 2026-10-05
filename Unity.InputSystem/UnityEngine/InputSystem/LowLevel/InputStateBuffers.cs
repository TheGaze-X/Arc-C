using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	internal struct InputStateBuffers
	{
		// Token: 0x0600113A RID: 4410 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x56F18C0", Offset = "0x56F04C0", VA = "0x1856F18C0")]
		public InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType)
		{
			return default(InputStateBuffers.DoubleBuffers);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x56F19A0", Offset = "0x56F05A0", VA = "0x1856F19A0")]
		public unsafe static void* GetFrontBufferForDevice(int deviceIndex)
		{
			return null;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x56F1870", Offset = "0x56F0470", VA = "0x1856F1870")]
		public unsafe static void* GetBackBufferForDevice(int deviceIndex)
		{
			return null;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x56F23B0", Offset = "0x56F0FB0", VA = "0x1856F23B0")]
		public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update)
		{
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x56F14F0", Offset = "0x56F00F0", VA = "0x1856F14F0")]
		public void AllocateAll(InputDevice[] devices, int deviceCount)
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x56F2350", Offset = "0x56F0F50", VA = "0x1856F2350")]
		private unsafe static InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer)
		{
			return default(InputStateBuffers.DoubleBuffers);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x56F17A0", Offset = "0x56F03A0", VA = "0x1856F17A0")]
		public void FreeAll()
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x56F19F0", Offset = "0x56F05F0", VA = "0x1856F19F0")]
		public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x56F1F80", Offset = "0x56F0B80", VA = "0x1856F1F80")]
		private static void MigrateDoubleBuffer(InputStateBuffers.DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, InputStateBuffers.DoubleBuffers oldBuffer)
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x56F2120", Offset = "0x56F0D20", VA = "0x1856F2120")]
		private unsafe static void MigrateSingleBuffer(void* newBuffer, InputDevice[] devices, int deviceCount, void* oldBuffer)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x56F1620", Offset = "0x56F0220", VA = "0x1856F1620")]
		private static uint ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount)
		{
			return 0U;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x56F2230", Offset = "0x56F0E30", VA = "0x1856F2230")]
		private static uint NextDeviceOffset(uint currentOffset, InputDevice device)
		{
			return 0U;
		}

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x0")]
		public uint sizePerBuffer;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x4")]
		public uint totalSize;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x8")]
		public unsafe void* defaultStateBuffer;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x10")]
		public unsafe void* noiseMaskBuffer;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x18")]
		public unsafe void* resetMaskBuffer;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x20")]
		private unsafe void* m_AllBuffers;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x28")]
		internal InputStateBuffers.DoubleBuffers m_PlayerStateBuffers;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x0")]
		internal unsafe static void* s_DefaultStateBuffer;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x8")]
		internal unsafe static void* s_NoiseMaskBuffer;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x10")]
		internal unsafe static void* s_ResetMaskBuffer;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x18")]
		internal static InputStateBuffers.DoubleBuffers s_CurrentBuffers;

		// Token: 0x020001D3 RID: 467
		[Token(Token = "0x20001D3")]
		[Serializable]
		internal struct DoubleBuffers
		{
			// Token: 0x170004F0 RID: 1264
			// (get) Token: 0x06001146 RID: 4422 RVA: 0x00009018 File Offset: 0x00007218
			[Token(Token = "0x170004F0")]
			public bool valid
			{
				[Token(Token = "0x6001146")]
				[Address(RVA = "0x4226870", Offset = "0x4225470", VA = "0x184226870")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001147")]
			[Address(RVA = "0x56E9020", Offset = "0x56E7C20", VA = "0x1856E9020")]
			public unsafe void SetFrontBuffer(int deviceIndex, void* ptr)
			{
			}

			// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001148")]
			[Address(RVA = "0x56E9010", Offset = "0x56E7C10", VA = "0x1856E9010")]
			public unsafe void SetBackBuffer(int deviceIndex, void* ptr)
			{
			}

			// Token: 0x06001149 RID: 4425 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001149")]
			[Address(RVA = "0x56E9000", Offset = "0x56E7C00", VA = "0x1856E9000")]
			public unsafe void* GetFrontBuffer(int deviceIndex)
			{
				return null;
			}

			// Token: 0x0600114A RID: 4426 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600114A")]
			[Address(RVA = "0x56E8FF0", Offset = "0x56E7BF0", VA = "0x1856E8FF0")]
			public unsafe void* GetBackBuffer(int deviceIndex)
			{
				return null;
			}

			// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600114B")]
			[Address(RVA = "0x56E9030", Offset = "0x56E7C30", VA = "0x1856E9030")]
			public void SwapBuffers(int deviceIndex)
			{
			}

			// Token: 0x04000A68 RID: 2664
			[Token(Token = "0x4000A68")]
			[FieldOffset(Offset = "0x0")]
			public unsafe void** deviceToBufferMapping;
		}
	}
}
