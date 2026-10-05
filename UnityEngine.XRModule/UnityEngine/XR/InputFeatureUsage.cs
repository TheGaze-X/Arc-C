using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeConditional("ENABLE_VR")]
	public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000004")]
		public string name
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000005")]
		internal InputFeatureType internalType
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return InputFeatureType.Custom;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BA2670", Offset = "0x5BA1270", VA = "0x185BA2670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BA2730", Offset = "0x5BA1330", VA = "0x185BA2730", Slot = "4")]
		public bool Equals(InputFeatureUsage other)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5BA2780", Offset = "0x5BA1380", VA = "0x185BA2780", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		internal string m_Name;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("m_FeatureType")]
		internal InputFeatureType m_InternalType;
	}
}
