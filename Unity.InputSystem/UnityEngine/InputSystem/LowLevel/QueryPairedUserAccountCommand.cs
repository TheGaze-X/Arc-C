using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	[StructLayout(2)]
	public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x17000427")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0x56DF5F0", Offset = "0x56DE1F0", VA = "0x1856DF5F0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000428")]
		public string id
		{
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x56DF630", Offset = "0x56DE230", VA = "0x1856DF630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x56DF6B0", Offset = "0x56DE2B0", VA = "0x1856DF6B0")]
			set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		public string name
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x56DF650", Offset = "0x56DE250", VA = "0x1856DF650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x56DF7E0", Offset = "0x56DE3E0", VA = "0x1856DF7E0")]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x1700042A")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x56DF670", Offset = "0x56DE270", VA = "0x1856DF670", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x56DF590", Offset = "0x56DE190", VA = "0x1856DF590")]
		public static QueryPairedUserAccountCommand Create()
		{
			return default(QueryPairedUserAccountCommand);
		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		internal const int kMaxNameLength = 256;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		internal const int kMaxIdLength = 256;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		internal const int kSize = 1040;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong handle;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FixedBuffer(typeof(byte), 512)]
		internal QueryPairedUserAccountCommand.<nameBuffer>e__FixedBuffer nameBuffer;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[FixedBuffer(typeof(byte), 512)]
		internal QueryPairedUserAccountCommand.<idBuffer>e__FixedBuffer idBuffer;

		// Token: 0x0200017B RID: 379
		[Token(Token = "0x200017B")]
		[Flags]
		public enum Result : long
		{
			// Token: 0x04000909 RID: 2313
			[Token(Token = "0x4000909")]
			DevicePairedToUserAccount = 2L,
			// Token: 0x0400090A RID: 2314
			[Token(Token = "0x400090A")]
			UserAccountSelectionInProgress = 4L,
			// Token: 0x0400090B RID: 2315
			[Token(Token = "0x400090B")]
			UserAccountSelectionComplete = 8L,
			// Token: 0x0400090C RID: 2316
			[Token(Token = "0x400090C")]
			UserAccountSelectionCanceled = 16L
		}

		// Token: 0x0200017C RID: 380
		[Token(Token = "0x200017C")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <nameBuffer>e__FixedBuffer
		{
			// Token: 0x0400090D RID: 2317
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}

		// Token: 0x0200017D RID: 381
		[Token(Token = "0x200017D")]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct <idBuffer>e__FixedBuffer
		{
			// Token: 0x0400090E RID: 2318
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
