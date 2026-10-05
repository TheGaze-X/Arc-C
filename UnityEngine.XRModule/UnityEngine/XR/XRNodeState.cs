using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[UsedByNativeCode]
	public struct XRNodeState
	{
		// Token: 0x17000001 RID: 1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public ulong uniqueID
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x35378E0", Offset = "0x35364E0", VA = "0x1835378E0")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public XRNode nodeType
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public bool tracked
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5BA3580", Offset = "0x5BA2180", VA = "0x185BA3580")]
			set
			{
			}
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		private XRNode m_Type;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x4")]
		private AvailableTrackingData m_AvailableFields;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		private Vector3 m_Position;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x14")]
		private Quaternion m_Rotation;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 m_Velocity;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_AngularVelocity;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Acceleration;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 m_AngularAcceleration;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x54")]
		private int m_Tracked;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x58")]
		private ulong m_UniqueID;
	}
}
