using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C3 RID: 9411
	[Token(Token = "0x20024C3")]
	public class AutoLoadBoxRangeWithExtraRange : AutoLoadBoxRange
	{
		// Token: 0x0600F228 RID: 61992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F228")]
		[Address(RVA = "0x683C40", Offset = "0x682840", VA = "0x180683C40", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F229")]
		[Address(RVA = "0x6838C0", Offset = "0x6824C0", VA = "0x1806838C0")]
		private Collider2D[] FetchCollidersByRangeIds(string[] rangeIds, Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F22A")]
		[Address(RVA = "0x683E80", Offset = "0x682A80", VA = "0x180683E80")]
		public AutoLoadBoxRangeWithExtraRange()
		{
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F22B")]
		[Address(RVA = "0x6819E0", Offset = "0x6805E0", VA = "0x1806819E0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x04010C12 RID: 68626
		[Token(Token = "0x4010C12")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _extraRangeId;

		// Token: 0x04010C13 RID: 68627
		[Token(Token = "0x4010C13")]
		[FieldOffset(Offset = "0x60")]
		private string[] m_rangeIds;

		// Token: 0x04010C14 RID: 68628
		[Token(Token = "0x4010C14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C15 RID: 68629
		[Token(Token = "0x4010C15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FetchCollidersByRangeIds;

		// Token: 0x04010C16 RID: 68630
		[Token(Token = "0x4010C16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
