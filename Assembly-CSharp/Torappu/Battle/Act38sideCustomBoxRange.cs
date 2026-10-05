using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C0 RID: 9408
	[Token(Token = "0x20024C0")]
	public class Act38sideCustomBoxRange : AutoLoadBoxRange
	{
		// Token: 0x0600F20D RID: 61965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F20D")]
		[Address(RVA = "0x681860", Offset = "0x680460", VA = "0x180681860", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F20E RID: 61966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F20E")]
		[Address(RVA = "0x6817C0", Offset = "0x6803C0", VA = "0x1806817C0", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F20F RID: 61967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F20F")]
		[Address(RVA = "0x681320", Offset = "0x67FF20", VA = "0x180681320", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F210 RID: 61968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F210")]
		[Address(RVA = "0x681AA0", Offset = "0x6806A0", VA = "0x180681AA0")]
		public Act38sideCustomBoxRange()
		{
		}

		// Token: 0x0600F211 RID: 61969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F211")]
		[Address(RVA = "0x681A60", Offset = "0x680660", VA = "0x180681A60")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F212 RID: 61970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F212")]
		[Address(RVA = "0x681A20", Offset = "0x680620", VA = "0x180681A20")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F213")]
		[Address(RVA = "0x6819E0", Offset = "0x6805E0", VA = "0x1806819E0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x04010BFA RID: 68602
		[Token(Token = "0x4010BFA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x04010BFB RID: 68603
		[Token(Token = "0x4010BFB")]
		[FieldOffset(Offset = "0x60")]
		private string m_rangeId;

		// Token: 0x04010BFC RID: 68604
		[Token(Token = "0x4010BFC")]
		[FieldOffset(Offset = "0x68")]
		[Inspect]
		[ReadOnly]
		private RangeData m_rangeData;

		// Token: 0x04010BFD RID: 68605
		[Token(Token = "0x4010BFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010BFE RID: 68606
		[Token(Token = "0x4010BFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010BFF RID: 68607
		[Token(Token = "0x4010BFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C00 RID: 68608
		[Token(Token = "0x4010C00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
