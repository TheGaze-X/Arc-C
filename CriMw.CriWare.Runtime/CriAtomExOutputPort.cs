using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class CriAtomExOutputPort : CriDisposable
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x17000051")]
		public bool isAvailable
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x36E2E30", Offset = "0x36E1A30", VA = "0x1836E2E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x36E26D0", Offset = "0x36E12D0", VA = "0x1836E26D0")]
		public int CalculateWorkSize(CriAtomExOutputPort.Config config)
		{
			return 0;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x36E2C20", Offset = "0x36E1820", VA = "0x1836E2C20")]
		public CriAtomExOutputPort(CriAtomExOutputPort.Config config)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x36E2DB0", Offset = "0x36E19B0", VA = "0x1836E2DB0")]
		internal CriAtomExOutputPort(IntPtr existingNativeHandle)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x36E2960", Offset = "0x36E1560", VA = "0x1836E2960", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x36E27A0", Offset = "0x36E13A0", VA = "0x1836E27A0", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x36E2A60", Offset = "0x36E1660", VA = "0x1836E2A60")]
		public void SetAsrRackId(int rackId)
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x36E2B80", Offset = "0x36E1780", VA = "0x1836E2B80")]
		public void SetVibrationChannelLevel(int channel, float level)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x36E2AF0", Offset = "0x36E16F0", VA = "0x1836E2AF0")]
		public void SetMonauralMix(bool monauralMix)
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x36E29E0", Offset = "0x36E15E0", VA = "0x1836E29E0")]
		public bool IsDestroyable()
		{
			return default(bool);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000338C File Offset: 0x0000158C
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000052")]
		internal IntPtr NativeHandle
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		public const uint MaxNameLength = 64U;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool hasExistingNativeHandle;

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		public enum Type
		{
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			Audio,
			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			Vibration
		}

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		public struct Config
		{
			// Token: 0x06000453 RID: 1107 RVA: 0x000033A4 File Offset: 0x000015A4
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x36DED00", Offset = "0x36DD900", VA = "0x1836DED00")]
			public static CriAtomExOutputPort.Config Default()
			{
				return default(CriAtomExOutputPort.Config);
			}

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomExOutputPort.Type type;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint maxIgnoredCategories;
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		private class NativeMethods
		{
			// Token: 0x06000454 RID: 1108
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x3707C10", Offset = "0x3706810", VA = "0x183707C10")]
			[PreserveSig]
			internal static extern int criAtomExOutputPort_CalculateWorkSize([In] CriAtomExOutputPort.Config config);

			// Token: 0x06000455 RID: 1109
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x3707CD0", Offset = "0x37068D0", VA = "0x183707CD0")]
			[PreserveSig]
			internal static extern IntPtr criAtomExOutputPort_Create(ref CriAtomExOutputPort.Config config, IntPtr work, int workSize);

			// Token: 0x06000456 RID: 1110
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x3707DE0", Offset = "0x37069E0", VA = "0x183707DE0")]
			[PreserveSig]
			internal static extern void criAtomExOutputPort_Destroy(IntPtr outputPort);

			// Token: 0x06000457 RID: 1111
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x3707EE0", Offset = "0x3706AE0", VA = "0x183707EE0")]
			[PreserveSig]
			internal static extern void criAtomExOutputPort_SetAsrRackId(IntPtr outputPort, int rackId);

			// Token: 0x06000458 RID: 1112
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x3708000", Offset = "0x3706C00", VA = "0x183708000")]
			[PreserveSig]
			internal static extern void criAtomExOutputPort_SetVibrationChannelLevel(IntPtr outputPort, int channel, float level);

			// Token: 0x06000459 RID: 1113
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x3707F70", Offset = "0x3706B70", VA = "0x183707F70")]
			[PreserveSig]
			internal static extern void criAtomExOutputPort_SetMonauralMix(IntPtr outputPort, bool monauralMix);

			// Token: 0x0600045A RID: 1114
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x3707E60", Offset = "0x3706A60", VA = "0x183707E60")]
			[PreserveSig]
			internal static extern bool criAtomExOutputPort_IsDestroyable(IntPtr outputPort);

			// Token: 0x0600045B RID: 1115 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NativeMethods()
			{
			}
		}
	}
}
