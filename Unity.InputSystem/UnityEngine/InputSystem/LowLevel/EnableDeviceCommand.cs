using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[StructLayout(2)]
	public struct EnableDeviceCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x17000412")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x56D2C20", Offset = "0x56D1820", VA = "0x1856D2C20")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x17000413")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x56D2C60", Offset = "0x56D1860", VA = "0x1856D2C60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x56D2BD0", Offset = "0x56D17D0", VA = "0x1856D2BD0")]
		public static EnableDeviceCommand Create()
		{
			return default(EnableDeviceCommand);
		}

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		internal const int kSize = 8;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;
	}
}
