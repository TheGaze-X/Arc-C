using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("XRScriptingClasses.h")]
	public struct Eyes : IEquatable<Eyes>
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000009")]
		internal ulong deviceId
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x1700000A")]
		internal uint featureIndex
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5BA21D0", Offset = "0x5BA0DD0", VA = "0x185BA21D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5BA20B0", Offset = "0x5BA0CB0", VA = "0x185BA20B0", Slot = "4")]
		public bool Equals(Eyes other)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5BA2180", Offset = "0x5BA0D80", VA = "0x185BA2180", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_DeviceId;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x8")]
		private uint m_FeatureIndex;
	}
}
