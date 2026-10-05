using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	[StructLayout(2)]
	internal struct ActionEvent : IInputEventTypeInfo
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x17000464")]
		public static FourCC Type
		{
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x56CEC70", Offset = "0x56CD870", VA = "0x1856CEC70")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00008130 File Offset: 0x00006330
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public double startTime
		{
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x56CECF0", Offset = "0x56CD8F0", VA = "0x1856CECF0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x56CEEE0", Offset = "0x56CDAE0", VA = "0x1856CEEE0")]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00008148 File Offset: 0x00006348
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public InputActionPhase phase
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x56CECE0", Offset = "0x56CD8E0", VA = "0x1856CECE0")]
			get
			{
				return InputActionPhase.Disabled;
			}
			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x56CEED0", Offset = "0x56CDAD0", VA = "0x1856CEED0")]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000467")]
		public unsafe byte* valueData
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x56CED40", Offset = "0x56CD940", VA = "0x1856CED40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x17000468")]
		public int valueSizeInBytes
		{
			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x56CED50", Offset = "0x56CD950", VA = "0x1856CED50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000469")]
		public int stateIndex
		{
			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x2205330", Offset = "0x2203F30", VA = "0x182205330")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x56CEEF0", Offset = "0x56CDAF0", VA = "0x1856CEEF0")]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046A")]
		public int controlIndex
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x41DFF70", Offset = "0x41DEB70", VA = "0x1841DFF70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x56CEDD0", Offset = "0x56CD9D0", VA = "0x1856CEDD0")]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000081A8 File Offset: 0x000063A8
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046B")]
		public int bindingIndex
		{
			[Token(Token = "0x6000FB6")]
			[Address(RVA = "0x56CECB0", Offset = "0x56CD8B0", VA = "0x1856CECB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FB7")]
			[Address(RVA = "0x56CED60", Offset = "0x56CD960", VA = "0x1856CED60")]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000081C0 File Offset: 0x000063C0
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046C")]
		public int interactionIndex
		{
			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x56CECC0", Offset = "0x56CD8C0", VA = "0x1856CECC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x56CEE40", Offset = "0x56CDA40", VA = "0x1856CEE40")]
			set
			{
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x1700046D")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x56CED00", Offset = "0x56CD900", VA = "0x1856CED00", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x56CEC60", Offset = "0x56CD860", VA = "0x1856CEC60")]
		public static int GetEventSizeWithValueSize(int valueSizeInBytes)
		{
			return 0;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x56CEB20", Offset = "0x56CD720", VA = "0x1856CEB20")]
		public unsafe static ActionEvent* From(InputEventPtr ptr)
		{
			return null;
		}

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ushort m_ControlIndex;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private ushort m_BindingIndex;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ushort m_InteractionIndex;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private byte m_StateIndex;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		private byte m_Phase;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private double m_StartTime;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[FixedBuffer(typeof(byte), 1)]
		public ActionEvent.<m_ValueData>e__FixedBuffer m_ValueData;

		// Token: 0x020001A2 RID: 418
		[Token(Token = "0x20001A2")]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct <m_ValueData>e__FixedBuffer
		{
			// Token: 0x0400099A RID: 2458
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
