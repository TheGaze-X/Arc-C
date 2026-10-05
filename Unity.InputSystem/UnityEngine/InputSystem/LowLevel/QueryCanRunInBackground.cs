using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	[StructLayout(2)]
	public struct QueryCanRunInBackground : IInputDeviceCommandInfo
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x1700041D")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x56DF110", Offset = "0x56DDD10", VA = "0x1856DF110")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x1700041E")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x56DF150", Offset = "0x56DDD50", VA = "0x1856DF150", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x56DF0B0", Offset = "0x56DDCB0", VA = "0x1856DF0B0")]
		public static QueryCanRunInBackground Create()
		{
			return default(QueryCanRunInBackground);
		}

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		internal const int kSize = 9;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool canRunInBackground;
	}
}
