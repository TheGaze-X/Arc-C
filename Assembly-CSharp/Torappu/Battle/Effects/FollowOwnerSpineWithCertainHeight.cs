using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003232 RID: 12850
	[Token(Token = "0x2003232")]
	public class FollowOwnerSpineWithCertainHeight : Effect.Behaviour
	{
		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0601460A RID: 83466 RVA: 0x000869E8 File Offset: 0x00084BE8
		[Token(Token = "0x1700303A")]
		public bool useOffset
		{
			[Token(Token = "0x601460A")]
			[Address(RVA = "0xC9ED70", Offset = "0xC9D970", VA = "0x180C9ED70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601460B RID: 83467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601460B")]
		[Address(RVA = "0xC9E960", Offset = "0xC9D560", VA = "0x180C9E960")]
		private void Start()
		{
		}

		// Token: 0x0601460C RID: 83468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601460C")]
		[Address(RVA = "0xC9EA50", Offset = "0xC9D650", VA = "0x180C9EA50")]
		private void Update()
		{
		}

		// Token: 0x0601460D RID: 83469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601460D")]
		[Address(RVA = "0xC9EAE0", Offset = "0xC9D6E0", VA = "0x180C9EAE0")]
		private void _FollowUnitSpine()
		{
		}

		// Token: 0x0601460E RID: 83470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601460E")]
		[Address(RVA = "0xC9ED10", Offset = "0xC9D910", VA = "0x180C9ED10")]
		public FollowOwnerSpineWithCertainHeight()
		{
		}

		// Token: 0x040180BE RID: 98494
		[Token(Token = "0x40180BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useOffset;

		// Token: 0x040180BF RID: 98495
		[Token(Token = "0x40180BF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("useOffset")]
		private float _offset;

		// Token: 0x040180C0 RID: 98496
		[Token(Token = "0x40180C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useYOffsetWithSpineTiltRate;

		// Token: 0x040180C1 RID: 98497
		[Token(Token = "0x40180C1")]
		private const float SQRT_3 = 1.732051f;

		// Token: 0x040180C2 RID: 98498
		[Token(Token = "0x40180C2")]
		[FieldOffset(Offset = "0x2C")]
		private float m_initUnitTransformZ;

		// Token: 0x040180C3 RID: 98499
		[Token(Token = "0x40180C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useOffset;

		// Token: 0x040180C4 RID: 98500
		[Token(Token = "0x40180C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040180C5 RID: 98501
		[Token(Token = "0x40180C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180C6 RID: 98502
		[Token(Token = "0x40180C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FollowUnitSpine;

		// Token: 0x040180C7 RID: 98503
		[Token(Token = "0x40180C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
