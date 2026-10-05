using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200321B RID: 12827
	[Token(Token = "0x200321B")]
	public class SetAnimatorTriggerByCondition : Effect.Behaviour
	{
		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0601459F RID: 83359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003034")]
		private Animator animator
		{
			[Token(Token = "0x601459F")]
			[Address(RVA = "0xCADAA0", Offset = "0xCAC6A0", VA = "0x180CADAA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x060145A0 RID: 83360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003035")]
		private AnimatorTriggerSource source
		{
			[Token(Token = "0x60145A0")]
			[Address(RVA = "0xCADB70", Offset = "0xCAC770", VA = "0x180CADB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060145A1 RID: 83361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A1")]
		[Address(RVA = "0xCAD680", Offset = "0xCAC280", VA = "0x180CAD680", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145A2 RID: 83362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A2")]
		[Address(RVA = "0xCAD770", Offset = "0xCAC370", VA = "0x180CAD770")]
		private void Update()
		{
		}

		// Token: 0x060145A3 RID: 83363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A3")]
		[Address(RVA = "0xCAD910", Offset = "0xCAC510", VA = "0x180CAD910")]
		private void _UpdateAnimator()
		{
		}

		// Token: 0x060145A4 RID: 83364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A4")]
		[Address(RVA = "0xCAD620", Offset = "0xCAC220", VA = "0x180CAD620", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060145A5 RID: 83365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A5")]
		[Address(RVA = "0xCADA30", Offset = "0xCAC630", VA = "0x180CADA30")]
		public SetAnimatorTriggerByCondition()
		{
		}

		// Token: 0x060145A6 RID: 83366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A6")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145A7 RID: 83367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A7")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018005 RID: 98309
		[Token(Token = "0x4018005")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimatorTriggerSource _source;

		// Token: 0x04018006 RID: 98310
		[Token(Token = "0x4018006")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoFindSource;

		// Token: 0x04018007 RID: 98311
		[Token(Token = "0x4018007")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _checkInterval;

		// Token: 0x04018008 RID: 98312
		[Token(Token = "0x4018008")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isally;

		// Token: 0x04018009 RID: 98313
		[Token(Token = "0x4018009")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		// Token: 0x0401800A RID: 98314
		[Token(Token = "0x401800A")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedValue;

		// Token: 0x0401800B RID: 98315
		[Token(Token = "0x401800B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasPlayed;

		// Token: 0x0401800C RID: 98316
		[Token(Token = "0x401800C")]
		[FieldOffset(Offset = "0x49")]
		private bool m_cacheBool;

		// Token: 0x0401800D RID: 98317
		[Token(Token = "0x401800D")]
		[FieldOffset(Offset = "0x4C")]
		private float m_timeAcc;

		// Token: 0x0401800E RID: 98318
		[Token(Token = "0x401800E")]
		[FieldOffset(Offset = "0x50")]
		private AnimatorTriggerSource m_source;

		// Token: 0x0401800F RID: 98319
		[Token(Token = "0x401800F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04018010 RID: 98320
		[Token(Token = "0x4018010")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_source;

		// Token: 0x04018011 RID: 98321
		[Token(Token = "0x4018011")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018012 RID: 98322
		[Token(Token = "0x4018012")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018013 RID: 98323
		[Token(Token = "0x4018013")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateAnimator;

		// Token: 0x04018014 RID: 98324
		[Token(Token = "0x4018014")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018015 RID: 98325
		[Token(Token = "0x4018015")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
