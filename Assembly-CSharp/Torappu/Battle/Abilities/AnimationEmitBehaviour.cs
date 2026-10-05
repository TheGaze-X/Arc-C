using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BC4 RID: 11204
	[Token(Token = "0x2002BC4")]
	public class AnimationEmitBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x06012EC5 RID: 77509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC5")]
		[Address(RVA = "0xAC2F40", Offset = "0xAC1B40", VA = "0x180AC2F40", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012EC6 RID: 77510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC6")]
		[Address(RVA = "0xAC30F0", Offset = "0xAC1CF0", VA = "0x180AC30F0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012EC7 RID: 77511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC7")]
		[Address(RVA = "0xAC2D60", Offset = "0xAC1960", VA = "0x180AC2D60", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012EC8 RID: 77512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC8")]
		[Address(RVA = "0xAC3260", Offset = "0xAC1E60", VA = "0x180AC3260")]
		private void _DealWithDirection(AnimationEmitBehaviour.AnimationSetting setting)
		{
		}

		// Token: 0x06012EC9 RID: 77513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EC9")]
		[Address(RVA = "0xAC33C0", Offset = "0xAC1FC0", VA = "0x180AC33C0")]
		private void _DoPlayAnimation(AnimationEmitBehaviour.AnimationSetting setting)
		{
		}

		// Token: 0x06012ECA RID: 77514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012ECA")]
		[Address(RVA = "0xAC3700", Offset = "0xAC2300", VA = "0x180AC3700")]
		private string _HookAnimationIfNot(string fromAnimKey)
		{
			return null;
		}

		// Token: 0x06012ECB RID: 77515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ECB")]
		[Address(RVA = "0xAC3810", Offset = "0xAC2410", VA = "0x180AC3810")]
		public AnimationEmitBehaviour()
		{
		}

		// Token: 0x06012ECC RID: 77516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ECC")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012ECD RID: 77517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ECD")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06012ECE RID: 77518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ECE")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x04015599 RID: 87449
		[Token(Token = "0x4015599")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEmitBehaviour.AnimationSetting[] _settings;

		// Token: 0x0401559A RID: 87450
		[Token(Token = "0x401559A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationEmitBehaviour.BuffAnimationHookSetting[] _hookSettings;

		// Token: 0x0401559B RID: 87451
		[Token(Token = "0x401559B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _hookAbilityAnim;

		// Token: 0x0401559C RID: 87452
		[Token(Token = "0x401559C")]
		[FieldOffset(Offset = "0x38")]
		private AbstractAnimatedAbility m_animatedAbility;

		// Token: 0x0401559D RID: 87453
		[Token(Token = "0x401559D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401559E RID: 87454
		[Token(Token = "0x401559E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401559F RID: 87455
		[Token(Token = "0x401559F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040155A0 RID: 87456
		[Token(Token = "0x40155A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealWithDirection;

		// Token: 0x040155A1 RID: 87457
		[Token(Token = "0x40155A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoPlayAnimation;

		// Token: 0x040155A2 RID: 87458
		[Token(Token = "0x40155A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HookAnimationIfNot;

		// Token: 0x040155A3 RID: 87459
		[Token(Token = "0x40155A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BC5 RID: 11205
		[Token(Token = "0x2002BC5")]
		[Serializable]
		public class AnimationSetting
		{
			// Token: 0x06012ECF RID: 77519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012ECF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimationSetting()
			{
			}

			// Token: 0x040155A4 RID: 87460
			[Token(Token = "0x40155A4")]
			[FieldOffset(Offset = "0x10")]
			public AbilityStandard.Event ev;

			// Token: 0x040155A5 RID: 87461
			[Token(Token = "0x40155A5")]
			[FieldOffset(Offset = "0x18")]
			public string anim;

			// Token: 0x040155A6 RID: 87462
			[Token(Token = "0x40155A6")]
			[FieldOffset(Offset = "0x20")]
			public bool forceFromStart;

			// Token: 0x040155A7 RID: 87463
			[Token(Token = "0x40155A7")]
			[FieldOffset(Offset = "0x21")]
			public bool faceToIdleDirection;

			// Token: 0x040155A8 RID: 87464
			[Token(Token = "0x40155A8")]
			[FieldOffset(Offset = "0x22")]
			public bool checkCanUseAbilityFlag;

			// Token: 0x040155A9 RID: 87465
			[Token(Token = "0x40155A9")]
			[FieldOffset(Offset = "0x23")]
			public bool checkCannotUseWhenNotIdle;
		}

		// Token: 0x02002BC6 RID: 11206
		[Token(Token = "0x2002BC6")]
		[Serializable]
		public class BuffAnimationHookSetting
		{
			// Token: 0x06012ED0 RID: 77520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012ED0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuffAnimationHookSetting()
			{
			}

			// Token: 0x040155AA RID: 87466
			[Token(Token = "0x40155AA")]
			[FieldOffset(Offset = "0x10")]
			public string buffKey;

			// Token: 0x040155AB RID: 87467
			[Token(Token = "0x40155AB")]
			[FieldOffset(Offset = "0x18")]
			public string fromAnimKey;

			// Token: 0x040155AC RID: 87468
			[Token(Token = "0x40155AC")]
			[FieldOffset(Offset = "0x20")]
			public string toAnimKey;
		}
	}
}
