using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029DF RID: 10719
	[Token(Token = "0x20029DF")]
	public abstract class MovementSwitchController : Projectile.FriendComponent
	{
		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x06011C58 RID: 72792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002733")]
		protected Projectile projectile
		{
			[Token(Token = "0x6011C58")]
			[Address(RVA = "0x9A2000", Offset = "0x9A0C00", VA = "0x1809A2000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x06011C59 RID: 72793 RVA: 0x0006CD20 File Offset: 0x0006AF20
		[Token(Token = "0x17002734")]
		public bool reselectTargetWhenSwitchingMovement
		{
			[Token(Token = "0x6011C59")]
			[Address(RVA = "0x9A2060", Offset = "0x9A0C60", VA = "0x1809A2060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x06011C5A RID: 72794 RVA: 0x0006CD38 File Offset: 0x0006AF38
		[Token(Token = "0x17002735")]
		public int curMovementIndex
		{
			[Token(Token = "0x6011C5A")]
			[Address(RVA = "0x9A1FA0", Offset = "0x9A0BA0", VA = "0x1809A1FA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011C5B RID: 72795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C5B")]
		[Address(RVA = "0x9A17C0", Offset = "0x9A03C0", VA = "0x1809A17C0", Slot = "4")]
		public virtual void Init(ILocatable start, ILocatable target, Projectile projectile, GroupedMovement groupedMovement)
		{
		}

		// Token: 0x06011C5C RID: 72796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C5C")]
		[Address(RVA = "0x9A1950", Offset = "0x9A0550", VA = "0x1809A1950", Slot = "5")]
		public virtual void OnStop()
		{
		}

		// Token: 0x06011C5D RID: 72797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C5D")]
		[Address(RVA = "0x99E3E0", Offset = "0x99CFE0", VA = "0x18099E3E0", Slot = "6")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011C5E RID: 72798 RVA: 0x0006CD50 File Offset: 0x0006AF50
		[Token(Token = "0x6011C5E")]
		[Address(RVA = "0x9A1B30", Offset = "0x9A0730", VA = "0x1809A1B30", Slot = "7")]
		public virtual bool UpdateTarget()
		{
			return default(bool);
		}

		// Token: 0x06011C5F RID: 72799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C5F")]
		[Address(RVA = "0x9A19D0", Offset = "0x9A05D0", VA = "0x1809A19D0")]
		protected void SwitchMovementIndex(int targetIndex, bool inheritDirection = false)
		{
		}

		// Token: 0x06011C60 RID: 72800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C60")]
		[Address(RVA = "0x9A1EF0", Offset = "0x9A0AF0", VA = "0x1809A1EF0")]
		protected MovementSwitchController()
		{
		}

		// Token: 0x04013F18 RID: 81688
		[Token(Token = "0x4013F18")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected List<string> _abilityNames;

		// Token: 0x04013F19 RID: 81689
		[Token(Token = "0x4013F19")]
		[FieldOffset(Offset = "0x20")]
		protected Projectile m_projectile;

		// Token: 0x04013F1A RID: 81690
		[Token(Token = "0x4013F1A")]
		[FieldOffset(Offset = "0x28")]
		protected GroupedMovement m_groupedMovement;

		// Token: 0x04013F1B RID: 81691
		[Token(Token = "0x4013F1B")]
		[FieldOffset(Offset = "0x30")]
		protected int m_curMovementIndex;

		// Token: 0x04013F1C RID: 81692
		[Token(Token = "0x4013F1C")]
		[FieldOffset(Offset = "0x34")]
		protected Vector3 m_cacheDirection;

		// Token: 0x04013F1D RID: 81693
		[Token(Token = "0x4013F1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectile;

		// Token: 0x04013F1E RID: 81694
		[Token(Token = "0x4013F1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_reselectTargetWhenSwitchingMovement;

		// Token: 0x04013F1F RID: 81695
		[Token(Token = "0x4013F1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curMovementIndex;

		// Token: 0x04013F20 RID: 81696
		[Token(Token = "0x4013F20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F21 RID: 81697
		[Token(Token = "0x4013F21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04013F22 RID: 81698
		[Token(Token = "0x4013F22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F23 RID: 81699
		[Token(Token = "0x4013F23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateTarget;

		// Token: 0x04013F24 RID: 81700
		[Token(Token = "0x4013F24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SwitchMovementIndex;

		// Token: 0x04013F25 RID: 81701
		[Token(Token = "0x4013F25")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
