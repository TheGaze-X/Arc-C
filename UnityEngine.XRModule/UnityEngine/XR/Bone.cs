using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[RequiredByNativeCode]
	public struct Bone : IEquatable<Bone>
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x1700000B")]
		internal ulong deviceId
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x1700000C")]
		internal uint featureIndex
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5BA20D0", Offset = "0x5BA0CD0", VA = "0x185BA20D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5BA20B0", Offset = "0x5BA0CB0", VA = "0x185BA20B0", Slot = "4")]
		public bool Equals(Bone other)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5BA2180", Offset = "0x5BA0D80", VA = "0x185BA2180", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_DeviceId;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x8")]
		private uint m_FeatureIndex;
	}
}
