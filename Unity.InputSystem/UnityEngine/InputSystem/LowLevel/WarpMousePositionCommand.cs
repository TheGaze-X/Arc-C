using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	[StructLayout(2)]
	internal struct WarpMousePositionCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x1700043A")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x56E4330", Offset = "0x56E2F30", VA = "0x1856E4330")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x1700043B")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x56E4370", Offset = "0x56E2F70", VA = "0x1856E4370", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x56E42C0", Offset = "0x56E2EC0", VA = "0x1856E42C0")]
		public static WarpMousePositionCommand Create(Vector2 position)
		{
			return default(WarpMousePositionCommand);
		}

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		internal const int kSize = 16;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 warpPositionInPlayerDisplaySpace;
	}
}
