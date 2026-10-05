using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	[StructLayout(2)]
	public struct QueryDimensionsCommand : IInputDeviceCommandInfo
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x1700041F")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x56DF1F0", Offset = "0x56DDDF0", VA = "0x1856DF1F0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x17000420")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x56DF230", Offset = "0x56DDE30", VA = "0x1856DF230", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x56DF190", Offset = "0x56DDD90", VA = "0x1856DF190")]
		public static QueryDimensionsCommand Create()
		{
			return default(QueryDimensionsCommand);
		}

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		internal const int kSize = 16;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 outDimensions;
	}
}
