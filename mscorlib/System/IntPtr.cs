using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public readonly struct IntPtr : System.Runtime.Serialization.ISerializable, System.IEquatable<System.IntPtr>
	{
		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x925690", Offset = "0x924290", VA = "0x180925690")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public IntPtr(int value)
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public IntPtr(long value)
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[System.CLSCompliant(false)]
		public unsafe IntPtr(void* value)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x4D36550", Offset = "0x4D35150", VA = "0x184D36550")]
		private IntPtr(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x1700016E")]
		public static int Size
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x4D36440", Offset = "0x4D35040", VA = "0x184D36440", Slot = "4")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0000D260 File Offset: 0x0000B460
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x4D363B0", Offset = "0x4D34FB0", VA = "0x184D363B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public int ToInt32()
		{
			return 0;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public long ToInt64()
		{
			return 0L;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[System.CLSCompliant(false)]
		public unsafe void* ToPointer()
		{
			return null;
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x4D36520", Offset = "0x4D35120", VA = "0x184D36520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x4D364F0", Offset = "0x4D350F0", VA = "0x184D364F0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static bool operator ==(System.IntPtr value1, System.IntPtr value2)
		{
			return default(bool);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static bool operator !=(System.IntPtr value1, System.IntPtr value2)
		{
			return default(bool);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x4CB1000", Offset = "0x4CAFC00", VA = "0x184CB1000")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static explicit operator System.IntPtr(int value)
		{
			return 0;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static explicit operator System.IntPtr(long value)
		{
			return 0;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[System.CLSCompliant(false)]
		public unsafe static explicit operator System.IntPtr(void* value)
		{
			return 0;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static explicit operator int(System.IntPtr value)
		{
			return 0;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0")]
		public static explicit operator long(System.IntPtr value)
		{
			return 0L;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		[System.CLSCompliant(false)]
		public unsafe static explicit operator void*(System.IntPtr value)
		{
			return null;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x3D281E0", Offset = "0x3D26DE0", VA = "0x183D281E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static System.IntPtr Add(System.IntPtr pointer, int offset)
		{
			return 0;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x3D281E0", Offset = "0x3D26DE0", VA = "0x183D281E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static System.IntPtr operator +(System.IntPtr pointer, int offset)
		{
			return 0;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x4D365C0", Offset = "0x4D351C0", VA = "0x184D365C0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static System.IntPtr operator -(System.IntPtr pointer, int offset)
		{
			return 0;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal bool IsNull()
		{
			return default(bool);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "5")]
		private bool Equals(System.IntPtr other)
		{
			return default(bool);
		}

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe readonly void* m_value;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.IntPtr Zero;
	}
}
