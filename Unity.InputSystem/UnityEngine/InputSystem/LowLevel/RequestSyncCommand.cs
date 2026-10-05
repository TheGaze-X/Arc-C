using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	[StructLayout(2)]
	public struct RequestSyncCommand : IInputDeviceCommandInfo
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x17000431")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x56DFBF0", Offset = "0x56DE7F0", VA = "0x1856DFBF0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x17000432")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0x56DFC30", Offset = "0x56DE830", VA = "0x1856DFC30", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x56DFBA0", Offset = "0x56DE7A0", VA = "0x1856DFBA0")]
		public static RequestSyncCommand Create()
		{
			return default(RequestSyncCommand);
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		internal const int kSize = 8;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;
	}
}
