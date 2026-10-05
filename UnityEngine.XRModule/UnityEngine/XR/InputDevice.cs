using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[NativeConditional("ENABLE_VR")]
	[UsedByNativeCode]
	public struct InputDevice : IEquatable<InputDevice>
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5BA2590", Offset = "0x5BA1190", VA = "0x185BA2590")]
		internal InputDevice(ulong deviceId)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000006")]
		private ulong deviceId
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x5BA25A0", Offset = "0x5BA11A0", VA = "0x185BA25A0")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5BA2480", Offset = "0x5BA1080", VA = "0x185BA2480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5BA2530", Offset = "0x5BA1130", VA = "0x185BA2530", Slot = "4")]
		public bool Equals(InputDevice other)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5BA2560", Offset = "0x5BA1160", VA = "0x185BA2560", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_DeviceId;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x8")]
		private bool m_Initialized;
	}
}
