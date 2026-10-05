using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	[StructLayout(2)]
	public struct EnableIMECompositionCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x17000414")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x56D2D10", Offset = "0x56D1910", VA = "0x1856D2D10")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x17000415")]
		public bool imeEnabled
		{
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x56D2D50", Offset = "0x56D1950", VA = "0x1856D2D50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x17000416")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x56D2D60", Offset = "0x56D1960", VA = "0x1856D2D60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x56D2CA0", Offset = "0x56D18A0", VA = "0x1856D2CA0")]
		public static EnableIMECompositionCommand Create(bool enabled)
		{
			return default(EnableIMECompositionCommand);
		}

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		internal const int kSize = 12;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte m_ImeEnabled;
	}
}
