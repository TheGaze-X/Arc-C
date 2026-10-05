using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	[RequireComponent(typeof(Transform))]
	[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000E66 RID: 3686
		[Token(Token = "0x170002E2")]
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static extern int invalidSortingGroupID { [Token(Token = "0x6000E66")] [Address(RVA = "0x5987390", Offset = "0x5985F90", VA = "0x185987390")] [MethodImpl(4096)] get; }

		// Token: 0x06000E67 RID: 3687
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x5987320", Offset = "0x5985F20", VA = "0x185987320")]
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		public static extern void UpdateAllSortingGroups();

		// Token: 0x06000E68 RID: 3688
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x59872E0", Offset = "0x5985EE0", VA = "0x1859872E0")]
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		internal static extern SortingGroup GetSortingGroupByIndex(int index);

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000E69 RID: 3689
		// (set) Token: 0x06000E6A RID: 3690
		[Token(Token = "0x170002E3")]
		public extern string sortingLayerName { [Token(Token = "0x6000E69")] [Address(RVA = "0x5987480", Offset = "0x5986080", VA = "0x185987480")] [MethodImpl(4096)] get; [Token(Token = "0x6000E6A")] [Address(RVA = "0x5987540", Offset = "0x5986140", VA = "0x185987540")] [MethodImpl(4096)] set; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000E6B RID: 3691
		// (set) Token: 0x06000E6C RID: 3692
		[Token(Token = "0x170002E4")]
		public extern int sortingLayerID { [Token(Token = "0x6000E6B")] [Address(RVA = "0x5987440", Offset = "0x5986040", VA = "0x185987440")] [MethodImpl(4096)] get; [Token(Token = "0x6000E6C")] [Address(RVA = "0x5987500", Offset = "0x5986100", VA = "0x185987500")] [MethodImpl(4096)] set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000E6D RID: 3693
		// (set) Token: 0x06000E6E RID: 3694
		[Token(Token = "0x170002E5")]
		public extern int sortingOrder { [Token(Token = "0x6000E6D")] [Address(RVA = "0x59874C0", Offset = "0x59860C0", VA = "0x1859874C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000E6E")] [Address(RVA = "0x5987590", Offset = "0x5986190", VA = "0x185987590")] [MethodImpl(4096)] set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000E6F RID: 3695
		[Token(Token = "0x170002E6")]
		internal extern int sortingGroupID { [Token(Token = "0x6000E6F")] [Address(RVA = "0x59873C0", Offset = "0x5985FC0", VA = "0x1859873C0")] [MethodImpl(4096)] get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E70 RID: 3696
		[Token(Token = "0x170002E7")]
		internal extern int sortingGroupOrder { [Token(Token = "0x6000E70")] [Address(RVA = "0x5987400", Offset = "0x5986000", VA = "0x185987400")] [MethodImpl(4096)] get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E71 RID: 3697
		[Token(Token = "0x170002E8")]
		internal extern int index { [Token(Token = "0x6000E71")] [Address(RVA = "0x5987350", Offset = "0x5985F50", VA = "0x185987350")] [MethodImpl(4096)] get; }

		// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public SortingGroup()
		{
		}
	}
}
