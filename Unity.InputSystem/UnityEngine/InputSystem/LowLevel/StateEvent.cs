using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[StructLayout(2)]
	public struct StateEvent : IInputEventTypeInfo
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x170004B2")]
		public uint stateSizeInBytes
		{
			[Token(Token = "0x600108F")]
			[Address(RVA = "0x56FA710", Offset = "0x56F9310", VA = "0x1856FA710")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B3")]
		public unsafe void* state
		{
			[Token(Token = "0x6001090")]
			[Address(RVA = "0x56FA730", Offset = "0x56F9330", VA = "0x1856FA730")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x6001091")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x170004B4")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6001092")]
			[Address(RVA = "0x56FA740", Offset = "0x56F9340", VA = "0x1856FA740", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001093")]
		public TState GetState<TState>() where TState : struct, IInputStateTypeInfo
		{
			return null;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001094")]
		public static TState GetState<TState>(InputEventPtr ptr) where TState : struct, IInputStateTypeInfo
		{
			return null;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x6001095")]
		public static int GetEventSizeWithPayload<TState>() where TState : struct
		{
			return 0;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x56FA5C0", Offset = "0x56F91C0", VA = "0x1856FA5C0")]
		public unsafe static StateEvent* From(InputEventPtr ptr)
		{
			return null;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001097")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		internal unsafe static StateEvent* FromUnchecked(InputEventPtr ptr)
		{
			return null;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x56FA590", Offset = "0x56F9190", VA = "0x1856FA590")]
		public static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x56FA230", Offset = "0x56F8E30", VA = "0x1856FA230")]
		public static NativeArray<byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x56FA260", Offset = "0x56F8E60", VA = "0x1856FA260")]
		private static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		public const int Type = 1398030676;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		internal const int kStateDataSizeToSubtract = 1;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public FourCC stateFormat;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FixedBuffer(typeof(byte), 1)]
		internal StateEvent.<stateData>e__FixedBuffer stateData;

		// Token: 0x020001BD RID: 445
		[Token(Token = "0x20001BD")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <stateData>e__FixedBuffer
		{
			// Token: 0x04000A03 RID: 2563
			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
