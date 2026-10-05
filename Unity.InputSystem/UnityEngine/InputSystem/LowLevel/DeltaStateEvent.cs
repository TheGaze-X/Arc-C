using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	[StructLayout(2)]
	public struct DeltaStateEvent : IInputEventTypeInfo
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x1700046E")]
		public uint deltaStateSizeInBytes
		{
			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x56CF480", Offset = "0x56CE080", VA = "0x1856CF480")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046F")]
		public unsafe void* deltaState
		{
			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0x56CF490", Offset = "0x56CE090", VA = "0x1856CF490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x17000470")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x56CF4A0", Offset = "0x56CE0A0", VA = "0x1856CF4A0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x56CF340", Offset = "0x56CDF40", VA = "0x1856CF340")]
		public unsafe static DeltaStateEvent* From(InputEventPtr ptr)
		{
			return null;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		internal unsafe static DeltaStateEvent* FromUnchecked(InputEventPtr ptr)
		{
			return null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x56CEFE0", Offset = "0x56CDBE0", VA = "0x1856CEFE0")]
		public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		public const int Type = 1145852993;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public FourCC stateFormat;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint stateOffset;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FixedBuffer(typeof(byte), 1)]
		internal DeltaStateEvent.<stateData>e__FixedBuffer stateData;

		// Token: 0x020001A4 RID: 420
		[Token(Token = "0x20001A4")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <stateData>e__FixedBuffer
		{
			// Token: 0x040009A0 RID: 2464
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
