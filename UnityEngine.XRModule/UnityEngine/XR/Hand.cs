using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[NativeConditional("ENABLE_VR")]
	[RequiredByNativeCode]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	public struct Hand : IEquatable<Hand>
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000007")]
		internal ulong deviceId
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000008")]
		internal uint featureIndex
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5BA2280", Offset = "0x5BA0E80", VA = "0x185BA2280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5BA20B0", Offset = "0x5BA0CB0", VA = "0x185BA20B0", Slot = "4")]
		public bool Equals(Hand other)
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5BA2180", Offset = "0x5BA0D80", VA = "0x185BA2180", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_DeviceId;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x8")]
		private uint m_FeatureIndex;
	}
}
