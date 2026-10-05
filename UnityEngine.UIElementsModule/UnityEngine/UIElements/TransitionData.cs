using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData>
	{
		// Token: 0x060010B3 RID: 4275 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x5B2A6D0", Offset = "0x5B292D0", VA = "0x185B2A6D0", Slot = "4")]
		public TransitionData Copy()
		{
			return default(TransitionData);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x5B2A570", Offset = "0x5B29170", VA = "0x185B2A570", Slot = "5")]
		public void CopyFrom(ref TransitionData other)
		{
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x5B2AB20", Offset = "0x5B29720", VA = "0x185B2AB20")]
		public static bool operator ==(TransitionData lhs, TransitionData rhs)
		{
			return default(bool);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x5B2A890", Offset = "0x5B29490", VA = "0x185B2A890", Slot = "6")]
		public bool Equals(TransitionData other)
		{
			return default(bool);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x5B2A900", Offset = "0x5B29500", VA = "0x185B2A900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x5B2AA00", Offset = "0x5B29600", VA = "0x185B2AA00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x0")]
		public List<TimeValue> transitionDelay;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x8")]
		public List<TimeValue> transitionDuration;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x10")]
		public List<StylePropertyName> transitionProperty;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x18")]
		public List<EasingFunction> transitionTimingFunction;
	}
}
