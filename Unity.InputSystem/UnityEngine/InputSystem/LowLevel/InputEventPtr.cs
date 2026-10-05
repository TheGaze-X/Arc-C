using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	public struct InputEventPtr : IEquatable<InputEventPtr>
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public unsafe InputEventPtr(InputEvent* eventPtr)
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x17000488")]
		public bool valid
		{
			[Token(Token = "0x600100E")]
			[Address(RVA = "0x4226870", Offset = "0x4225470", VA = "0x184226870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000085B0 File Offset: 0x000067B0
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000489")]
		public bool handled
		{
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x56DAE10", Offset = "0x56D9A10", VA = "0x1856DAE10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x56DB220", Offset = "0x56D9E20", VA = "0x1856DB220")]
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000085C8 File Offset: 0x000067C8
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		public int id
		{
			[Token(Token = "0x6001011")]
			[Address(RVA = "0x56DAE30", Offset = "0x56D9A30", VA = "0x1856DAE30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001012")]
			[Address(RVA = "0x56DB2B0", Offset = "0x56D9EB0", VA = "0x1856DB2B0")]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x1700048B")]
		public FourCC type
		{
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x56DB1A0", Offset = "0x56D9DA0", VA = "0x1856DB1A0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x1700048C")]
		public uint sizeInBytes
		{
			[Token(Token = "0x6001014")]
			[Address(RVA = "0x56DAE70", Offset = "0x56D9A70", VA = "0x1856DAE70")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00008610 File Offset: 0x00006810
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048D")]
		public int deviceId
		{
			[Token(Token = "0x6001015")]
			[Address(RVA = "0x56DAE00", Offset = "0x56D9A00", VA = "0x1856DAE00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001016")]
			[Address(RVA = "0x56DB1B0", Offset = "0x56D9DB0", VA = "0x1856DB1B0")]
			set
			{
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00008628 File Offset: 0x00006828
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048E")]
		public double time
		{
			[Token(Token = "0x6001017")]
			[Address(RVA = "0x56DB140", Offset = "0x56D9D40", VA = "0x1856DB140")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001018")]
			[Address(RVA = "0x56DB3A0", Offset = "0x56D9FA0", VA = "0x1856DB3A0")]
			set
			{
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x00008640 File Offset: 0x00006840
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048F")]
		internal double internalTime
		{
			[Token(Token = "0x6001019")]
			[Address(RVA = "0x56DAE50", Offset = "0x56D9A50", VA = "0x1856DAE50")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600101A")]
			[Address(RVA = "0x56DB330", Offset = "0x56D9F30", VA = "0x1856DB330")]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000490")]
		public unsafe InputEvent* data
		{
			[Token(Token = "0x600101B")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00008658 File Offset: 0x00006858
		[Token(Token = "0x17000491")]
		internal FourCC stateFormat
		{
			[Token(Token = "0x600101C")]
			[Address(RVA = "0x56DAE80", Offset = "0x56D9A80", VA = "0x1856DAE80")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x17000492")]
		internal uint stateSizeInBytes
		{
			[Token(Token = "0x600101D")]
			[Address(RVA = "0x56DB030", Offset = "0x56D9C30", VA = "0x1856DB030")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x17000493")]
		internal uint stateOffset
		{
			[Token(Token = "0x600101E")]
			[Address(RVA = "0x56DAF50", Offset = "0x56D9B50", VA = "0x1856DAF50")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x600101F")]
		public bool IsA<TOtherEvent>() where TOtherEvent : struct, IInputEventTypeInfo
		{
			return default(bool);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x56DAD80", Offset = "0x56D9980", VA = "0x1856DAD80")]
		public InputEventPtr Next()
		{
			return default(InputEventPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x56DADA0", Offset = "0x56D99A0", VA = "0x1856DADA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public unsafe InputEvent* ToPointer()
		{
			return null;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x56DAD30", Offset = "0x56D9930", VA = "0x1856DAD30", Slot = "4")]
		public bool Equals(InputEventPtr other)
		{
			return default(bool);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x56DAC70", Offset = "0x56D9870", VA = "0x1856DAC70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(InputEventPtr left, InputEventPtr right)
		{
			return default(bool);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(InputEventPtr left, InputEventPtr right)
		{
			return default(bool);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6001028")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public unsafe static implicit operator InputEventPtr(InputEvent* eventPtr)
		{
			return default(InputEventPtr);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6001029")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public unsafe static InputEventPtr From(InputEvent* eventPtr)
		{
			return default(InputEventPtr);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600102A")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public unsafe static implicit operator InputEvent*(InputEventPtr eventPtr)
		{
			return null;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600102B")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public unsafe static InputEvent* FromInputEventPtr(InputEventPtr eventPtr)
		{
			return null;
		}

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x0")]
		private unsafe readonly InputEvent* m_EventPtr;
	}
}
