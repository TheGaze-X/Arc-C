using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C1B RID: 11291
	[Token(Token = "0x2002C1B")]
	public class LuaAbilityBehaviourStub : AbilityStandard.Behaviour, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0601310C RID: 78092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029F6")]
		public string luaBehaviourName
		{
			[Token(Token = "0x601310C")]
			[Address(RVA = "0xB1D1D0", Offset = "0xB1BDD0", VA = "0x180B1D1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0601310D RID: 78093 RVA: 0x00074808 File Offset: 0x00072A08
		[Token(Token = "0x170029F7")]
		protected bool isLuaReady
		{
			[Token(Token = "0x601310D")]
			[Address(RVA = "0xB1D170", Offset = "0xB1BD70", VA = "0x180B1D170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601310E RID: 78094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601310E")]
		[Address(RVA = "0xB1C6E0", Offset = "0xB1B2E0", VA = "0x180B1C6E0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0601310F RID: 78095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601310F")]
		[Address(RVA = "0xB1CDE0", Offset = "0xB1B9E0", VA = "0x180B1CDE0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013110 RID: 78096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013110")]
		[Address(RVA = "0xB1CA20", Offset = "0xB1B620", VA = "0x180B1CA20", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013111 RID: 78097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013111")]
		[Address(RVA = "0xB1C7A0", Offset = "0xB1B3A0", VA = "0x180B1C7A0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013112 RID: 78098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013112")]
		[Address(RVA = "0xB1CB70", Offset = "0xB1B770", VA = "0x180B1CB70", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013113 RID: 78099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013113")]
		[Address(RVA = "0xB1C890", Offset = "0xB1B490", VA = "0x180B1C890", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013114 RID: 78100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013114")]
		[Address(RVA = "0xB1CD00", Offset = "0xB1B900", VA = "0x180B1CD00", Slot = "12")]
		public override void OnStopAffect()
		{
		}

		// Token: 0x06013115 RID: 78101 RVA: 0x00074820 File Offset: 0x00072A20
		[Token(Token = "0x6013115")]
		[Address(RVA = "0xB1CF60", Offset = "0xB1BB60", VA = "0x180B1CF60", Slot = "14")]
		public override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}

		// Token: 0x06013116 RID: 78102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013116")]
		[Address(RVA = "0xB1CB00", Offset = "0xB1B700", VA = "0x180B1CB00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013117 RID: 78103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013117")]
		[Address(RVA = "0xB1D110", Offset = "0xB1BD10", VA = "0x180B1D110")]
		public LuaAbilityBehaviourStub()
		{
		}

		// Token: 0x06013118 RID: 78104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013118")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013119 RID: 78105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013119")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601311A RID: 78106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601311A")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601311B RID: 78107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601311B")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601311C RID: 78108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601311C")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0601311D RID: 78109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601311D")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x0601311E RID: 78110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601311E")]
		[Address(RVA = "0xADB9E0", Offset = "0xADA5E0", VA = "0x180ADB9E0")]
		private void <>xLuaBaseProxy_OnStopAffect()
		{
		}

		// Token: 0x0601311F RID: 78111 RVA: 0x00074838 File Offset: 0x00072A38
		[Token(Token = "0x601311F")]
		[Address(RVA = "0xAC3FF0", Offset = "0xAC2BF0", VA = "0x180AC3FF0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x04015877 RID: 88183
		[Token(Token = "0x4015877")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _luaBehaviourName;

		// Token: 0x04015878 RID: 88184
		[Token(Token = "0x4015878")]
		[FieldOffset(Offset = "0x28")]
		private LuaAbilityBehaviourStub.LuaBinding m_luaBinding;

		// Token: 0x04015879 RID: 88185
		[Token(Token = "0x4015879")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_luaBehaviourName;

		// Token: 0x0401587A RID: 88186
		[Token(Token = "0x401587A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isLuaReady;

		// Token: 0x0401587B RID: 88187
		[Token(Token = "0x401587B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401587C RID: 88188
		[Token(Token = "0x401587C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401587D RID: 88189
		[Token(Token = "0x401587D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401587E RID: 88190
		[Token(Token = "0x401587E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401587F RID: 88191
		[Token(Token = "0x401587F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015880 RID: 88192
		[Token(Token = "0x4015880")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015881 RID: 88193
		[Token(Token = "0x4015881")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStopAffect;

		// Token: 0x04015882 RID: 88194
		[Token(Token = "0x4015882")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04015883 RID: 88195
		[Token(Token = "0x4015883")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04015884 RID: 88196
		[Token(Token = "0x4015884")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C1C RID: 11292
		[Token(Token = "0x2002C1C")]
		[CSharpCallLua]
		public interface LuaBinding
		{
			// Token: 0x06013120 RID: 78112
			[Token(Token = "0x6013120")]
			void ExportSetData(Blackboard blackboard);

			// Token: 0x06013121 RID: 78113
			[Token(Token = "0x6013121")]
			void ExportOnCastStart();

			// Token: 0x06013122 RID: 78114
			[Token(Token = "0x6013122")]
			void ExportOnCastFinish();

			// Token: 0x06013123 RID: 78115
			[Token(Token = "0x6013123")]
			void ExportOnEvent(AbilityStandard.Event ev);

			// Token: 0x06013124 RID: 78116
			[Token(Token = "0x6013124")]
			void ExportOnCastOnTarget(Entity target);

			// Token: 0x06013125 RID: 78117
			[Token(Token = "0x6013125")]
			void ExportOnStopAffect();

			// Token: 0x06013126 RID: 78118
			[Token(Token = "0x6013126")]
			bool ExportUpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed);
		}
	}
}
