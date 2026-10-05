using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("ContactFilter", "struct ContactFilter;")]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	[Serializable]
	public struct ContactFilter2D
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59C3270", Offset = "0x59C1E70", VA = "0x1859C3270")]
		public ContactFilter2D NoFilter()
		{
			return default(ContactFilter2D);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59C3110", Offset = "0x59C1D10", VA = "0x1859C3110")]
		private void CheckConsistency()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59C3150", Offset = "0x59C1D50", VA = "0x1859C3150")]
		public void ClearLayerMask()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x59C3340", Offset = "0x59C1F40", VA = "0x1859C3340")]
		public void SetLayerMask(LayerMask layerMask)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59C32F0", Offset = "0x59C1EF0", VA = "0x1859C32F0")]
		public void SetDepth(float minDepth, float maxDepth)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59C3160", Offset = "0x59C1D60", VA = "0x1859C3160")]
		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
		{
			return default(ContactFilter2D);
		}

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59C3110", Offset = "0x59C1D10", VA = "0x1859C3110")]
		[MethodImpl(4096)]
		private static extern void CheckConsistency_Injected(ref ContactFilter2D _unity_self);

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("m_UseTriggers")]
		public bool useTriggers;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x1")]
		[NativeName("m_UseLayerMask")]
		public bool useLayerMask;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x2")]
		[NativeName("m_UseDepth")]
		public bool useDepth;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x3")]
		[NativeName("m_UseOutsideDepth")]
		public bool useOutsideDepth;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x4")]
		[NativeName("m_UseNormalAngle")]
		public bool useNormalAngle;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x5")]
		[NativeName("m_UseOutsideNormalAngle")]
		public bool useOutsideNormalAngle;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("m_LayerMask")]
		public LayerMask layerMask;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("m_MinDepth")]
		public float minDepth;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("m_MaxDepth")]
		public float maxDepth;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x14")]
		[NativeName("m_MinNormalAngle")]
		public float minNormalAngle;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("m_MaxNormalAngle")]
		public float maxNormalAngle;
	}
}
