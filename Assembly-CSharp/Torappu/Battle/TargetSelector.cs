using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002542 RID: 9538
	[Token(Token = "0x2002542")]
	public abstract class TargetSelector : MonoBehaviour, IDrawableRange, IHotfixable
	{
		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600F606 RID: 62982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F607 RID: 62983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002036")]
		public Entity owner
		{
			[Token(Token = "0x600F606")]
			[Address(RVA = "0x6E0910", Offset = "0x6DF510", VA = "0x1806E0910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F607")]
			[Address(RVA = "0x6E0A50", Offset = "0x6DF650", VA = "0x1806E0A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600F608 RID: 62984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F609 RID: 62985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002037")]
		public Ability ability
		{
			[Token(Token = "0x600F608")]
			[Address(RVA = "0x6E0790", Offset = "0x6DF390", VA = "0x1806E0790", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F609")]
			[Address(RVA = "0x6E09D0", Offset = "0x6DF5D0", VA = "0x1806E09D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600F60A RID: 62986 RVA: 0x0005B8D8 File Offset: 0x00059AD8
		[Token(Token = "0x17002038")]
		protected virtual bool ignoreMapLayer
		{
			[Token(Token = "0x600F60A")]
			[Address(RVA = "0x6E08B0", Offset = "0x6DF4B0", VA = "0x1806E08B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600F60B RID: 62987 RVA: 0x0005B8F0 File Offset: 0x00059AF0
		[Token(Token = "0x17002039")]
		protected virtual bool ignoreHitRange
		{
			[Token(Token = "0x600F60B")]
			[Address(RVA = "0x6E0850", Offset = "0x6DF450", VA = "0x1806E0850", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600F60C RID: 62988 RVA: 0x0005B908 File Offset: 0x00059B08
		[Token(Token = "0x1700203A")]
		protected virtual bool forceIgnoreCamouflage
		{
			[Token(Token = "0x600F60C")]
			[Address(RVA = "0x6E07F0", Offset = "0x6DF3F0", VA = "0x1806E07F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600F60D RID: 62989 RVA: 0x0005B920 File Offset: 0x00059B20
		[Token(Token = "0x1700203B")]
		protected virtual ActionPurposeMask sourcePurposeMask
		{
			[Token(Token = "0x600F60D")]
			[Address(RVA = "0x6D92B0", Offset = "0x6D7EB0", VA = "0x1806D92B0", Slot = "11")]
			get
			{
				return ActionPurposeMask.NONE;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600F60E RID: 62990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700203C")]
		protected Func<Entity, bool> validator
		{
			[Token(Token = "0x600F60E")]
			[Address(RVA = "0x6E0970", Offset = "0x6DF570", VA = "0x1806E0970")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F60F RID: 62991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F60F")]
		[Address(RVA = "0x6DFF90", Offset = "0x6DEB90", VA = "0x1806DFF90", Slot = "12")]
		public virtual void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F610 RID: 62992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F610")]
		[Address(RVA = "0x6DFDD0", Offset = "0x6DE9D0", VA = "0x1806DFDD0")]
		public ReusableList<Entity> FindTargets_DISPOSE(ILocatable locate)
		{
			return null;
		}

		// Token: 0x0600F611 RID: 62993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F611")]
		[Address(RVA = "0x6DFD30", Offset = "0x6DE930", VA = "0x1806DFD30")]
		public ReusableList<Entity> FindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F612 RID: 62994
		[Token(Token = "0x600F612")]
		protected abstract ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos);

		// Token: 0x0600F613 RID: 62995
		[Token(Token = "0x600F613")]
		public abstract bool CheckTargetIn(ILocatable target);

		// Token: 0x0600F614 RID: 62996 RVA: 0x0005B938 File Offset: 0x00059B38
		[Token(Token = "0x600F614")]
		[Address(RVA = "0x6D91B0", Offset = "0x6D7DB0", VA = "0x1806D91B0", Slot = "15")]
		public virtual bool CheckTargetInOriginRange(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F615 RID: 62997 RVA: 0x0005B950 File Offset: 0x00059B50
		[Token(Token = "0x600F615")]
		[Address(RVA = "0x6E0160", Offset = "0x6DED60", VA = "0x1806E0160", Slot = "16")]
		protected virtual bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F616 RID: 62998 RVA: 0x0005B968 File Offset: 0x00059B68
		[Token(Token = "0x600F616")]
		[Address(RVA = "0x6E0530", Offset = "0x6DF130", VA = "0x1806E0530", Slot = "17")]
		public virtual bool ValidateTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F617 RID: 62999 RVA: 0x0005B980 File Offset: 0x00059B80
		[Token(Token = "0x600F617")]
		[Address(RVA = "0x6E0640", Offset = "0x6DF240", VA = "0x1806E0640", Slot = "18")]
		public virtual bool VerifyTarget(List<Entity> candidates)
		{
			return default(bool);
		}

		// Token: 0x0600F618 RID: 63000 RVA: 0x0005B998 File Offset: 0x00059B98
		[Token(Token = "0x600F618")]
		[Address(RVA = "0x6E05A0", Offset = "0x6DF1A0", VA = "0x1806E05A0", Slot = "19")]
		public virtual bool VerifyTarget(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x0600F619 RID: 63001
		[Token(Token = "0x600F619")]
		public abstract List<Tile> FindTiles(Vector2 pos);

		// Token: 0x0600F61A RID: 63002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F61A")]
		[Address(RVA = "0x6DFCC0", Offset = "0x6DE8C0", VA = "0x1806DFCC0", Slot = "21")]
		public virtual List<Projectile> FindProjectiles_CLEAR(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F61B RID: 63003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F61B")]
		[Address(RVA = "0x6E0090", Offset = "0x6DEC90", VA = "0x1806E0090", Slot = "22")]
		public virtual void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F61C")]
		[Address(RVA = "0x6DFF30", Offset = "0x6DEB30", VA = "0x1806DFF30", Slot = "23")]
		public virtual void OnCastedOnTarget(Entity target)
		{
		}

		// Token: 0x0600F61D RID: 63005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F61D")]
		[Address(RVA = "0x6D9240", Offset = "0x6D7E40", VA = "0x1806D9240", Slot = "24")]
		public virtual void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600F61E RID: 63006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F61E")]
		[Address(RVA = "0x6E0730", Offset = "0x6DF330", VA = "0x1806E0730")]
		protected TargetSelector()
		{
		}

		// Token: 0x040110DB RID: 69851
		[Token(Token = "0x40110DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Func<Entity, bool> m_validator;

		// Token: 0x040110DE RID: 69854
		[Token(Token = "0x40110DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x040110DF RID: 69855
		[Token(Token = "0x40110DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_owner;

		// Token: 0x040110E0 RID: 69856
		[Token(Token = "0x40110E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x040110E1 RID: 69857
		[Token(Token = "0x40110E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ability;

		// Token: 0x040110E2 RID: 69858
		[Token(Token = "0x40110E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreMapLayer;

		// Token: 0x040110E3 RID: 69859
		[Token(Token = "0x40110E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ignoreHitRange;

		// Token: 0x040110E4 RID: 69860
		[Token(Token = "0x40110E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_forceIgnoreCamouflage;

		// Token: 0x040110E5 RID: 69861
		[Token(Token = "0x40110E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_sourcePurposeMask;

		// Token: 0x040110E6 RID: 69862
		[Token(Token = "0x40110E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_validator;

		// Token: 0x040110E7 RID: 69863
		[Token(Token = "0x40110E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040110E8 RID: 69864
		[Token(Token = "0x40110E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FindTargets_DISPOSE;

		// Token: 0x040110E9 RID: 69865
		[Token(Token = "0x40110E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_FindTargets_DISPOSE;

		// Token: 0x040110EA RID: 69866
		[Token(Token = "0x40110EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckTargetInOriginRange;

		// Token: 0x040110EB RID: 69867
		[Token(Token = "0x40110EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x040110EC RID: 69868
		[Token(Token = "0x40110EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ValidateTile;

		// Token: 0x040110ED RID: 69869
		[Token(Token = "0x40110ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x040110EE RID: 69870
		[Token(Token = "0x40110EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_VerifyTarget;

		// Token: 0x040110EF RID: 69871
		[Token(Token = "0x40110EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FindProjectiles_CLEAR;

		// Token: 0x040110F0 RID: 69872
		[Token(Token = "0x40110F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040110F1 RID: 69873
		[Token(Token = "0x40110F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnCastedOnTarget;

		// Token: 0x040110F2 RID: 69874
		[Token(Token = "0x40110F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x040110F3 RID: 69875
		[Token(Token = "0x40110F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
