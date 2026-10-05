using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public static class HIDSupport
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x000070B0 File Offset: 0x000052B0
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C3")]
		public static ReadOnlyArray<HIDSupport.HIDPageUsage> supportedHIDUsages
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x56D9250", Offset = "0x56D7E50", VA = "0x1856D9250")]
			get
			{
				return default(ReadOnlyArray<HIDSupport.HIDPageUsage>);
			}
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x56D92C0", Offset = "0x56D7EC0", VA = "0x1856D92C0")]
			set
			{
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x56D90C0", Offset = "0x56D7CC0", VA = "0x1856D90C0")]
		internal static void Initialize()
		{
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x0")]
		private static HIDSupport.HIDPageUsage[] s_SupportedHIDUsages;

		// Token: 0x02000145 RID: 325
		[Token(Token = "0x2000145")]
		public struct HIDPageUsage
		{
			// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public HIDPageUsage(HID.UsagePage page, int usage)
			{
			}

			// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x56D8020", Offset = "0x56D6C20", VA = "0x1856D8020")]
			public HIDPageUsage(HID.GenericDesktop usage)
			{
			}

			// Token: 0x04000817 RID: 2071
			[Token(Token = "0x4000817")]
			[FieldOffset(Offset = "0x0")]
			public HID.UsagePage page;

			// Token: 0x04000818 RID: 2072
			[Token(Token = "0x4000818")]
			[FieldOffset(Offset = "0x4")]
			public int usage;
		}
	}
}
