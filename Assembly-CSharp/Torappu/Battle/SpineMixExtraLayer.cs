using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002111 RID: 8465
	[Token(Token = "0x2002111")]
	public sealed class SpineMixExtraLayer : UnitAnimator.Behaviour
	{
		// Token: 0x0600CF4D RID: 53069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4D")]
		[Address(RVA = "0x3522010", Offset = "0x3520C10", VA = "0x183522010", Slot = "4")]
		public override void Init(UnitAnimator unitAnimator)
		{
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4E")]
		[Address(RVA = "0x3522220", Offset = "0x3520E20", VA = "0x183522220", Slot = "7")]
		public override void OnEvent(UnitAnimator.Behaviour.Event ev, ValueBundle arg)
		{
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4F")]
		[Address(RVA = "0x3522550", Offset = "0x3521150", VA = "0x183522550", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF50")]
		[Address(RVA = "0x35228D0", Offset = "0x35214D0", VA = "0x1835228D0")]
		private void _SetAnimWithAlpha(string animKey, float alpha, bool isLoop)
		{
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF51")]
		[Address(RVA = "0x3522650", Offset = "0x3521250", VA = "0x183522650")]
		private void _DoResetSkeleton(SkeletonAnimation skeleton)
		{
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF52")]
		[Address(RVA = "0x35227E0", Offset = "0x35213E0", VA = "0x1835227E0")]
		private SpineMixExtraLayer.CustomAnimLayerMixSettingGroup _GetAnimSetting(string animKey)
		{
			return null;
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF53")]
		[Address(RVA = "0x3522AC0", Offset = "0x35216C0", VA = "0x183522AC0")]
		public SpineMixExtraLayer()
		{
		}

		// Token: 0x0600CF54 RID: 53076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF54")]
		[Address(RVA = "0x3509390", Offset = "0x3507F90", VA = "0x183509390")]
		private void <>xLuaBaseProxy_Init(UnitAnimator P0)
		{
		}

		// Token: 0x0600CF55 RID: 53077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF55")]
		[Address(RVA = "0x350D850", Offset = "0x350C450", VA = "0x18350D850")]
		private void <>xLuaBaseProxy_OnEvent(UnitAnimator.Behaviour.Event P0, ValueBundle P1)
		{
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF56")]
		[Address(RVA = "0x3522640", Offset = "0x3521240", VA = "0x183522640")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400DD56 RID: 56662
		[Token(Token = "0x400DD56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpineMixExtraLayer.CustomAnimLayerMixSetting _layerMixSetting;

		// Token: 0x0400DD57 RID: 56663
		[Token(Token = "0x400DD57")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpineMixExtraLayer.LayerAnimPlayer _layerAnimPlayer;

		// Token: 0x0400DD58 RID: 56664
		[Token(Token = "0x400DD58")]
		[FieldOffset(Offset = "0x30")]
		private SingleSpineAnimator m_animator;

		// Token: 0x0400DD59 RID: 56665
		[Token(Token = "0x400DD59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DD5A RID: 56666
		[Token(Token = "0x400DD5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DD5B RID: 56667
		[Token(Token = "0x400DD5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DD5C RID: 56668
		[Token(Token = "0x400DD5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetAnimWithAlpha;

		// Token: 0x0400DD5D RID: 56669
		[Token(Token = "0x400DD5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoResetSkeleton;

		// Token: 0x0400DD5E RID: 56670
		[Token(Token = "0x400DD5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetAnimSetting;

		// Token: 0x0400DD5F RID: 56671
		[Token(Token = "0x400DD5F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002112 RID: 8466
		[Token(Token = "0x2002112")]
		[Serializable]
		public class CustomAnimLayerMixSetting
		{
			// Token: 0x0600CF57 RID: 53079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF57")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CustomAnimLayerMixSetting()
			{
			}

			// Token: 0x0400DD60 RID: 56672
			[Token(Token = "0x400DD60")]
			[FieldOffset(Offset = "0x10")]
			public SpineMixExtraLayer.CustomAnimLayerMixSettingGroup[] mixSetting;

			// Token: 0x0400DD61 RID: 56673
			[Token(Token = "0x400DD61")]
			[FieldOffset(Offset = "0x18")]
			public string defaultAnimName;
		}

		// Token: 0x02002113 RID: 8467
		[Token(Token = "0x2002113")]
		[Serializable]
		public class CustomAnimLayerMixSettingGroup
		{
			// Token: 0x0600CF58 RID: 53080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF58")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CustomAnimLayerMixSettingGroup()
			{
			}

			// Token: 0x0400DD62 RID: 56674
			[Token(Token = "0x400DD62")]
			[FieldOffset(Offset = "0x10")]
			public string animKey;

			// Token: 0x0400DD63 RID: 56675
			[Token(Token = "0x400DD63")]
			[FieldOffset(Offset = "0x18")]
			public int layerNum;

			// Token: 0x0400DD64 RID: 56676
			[Token(Token = "0x400DD64")]
			[FieldOffset(Offset = "0x20")]
			public string mixedAnimName;
		}

		// Token: 0x02002114 RID: 8468
		[Token(Token = "0x2002114")]
		public class LayerAnimPlayer : MonoBehaviour, IHotfixable
		{
			// Token: 0x1700189C RID: 6300
			// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x0004AD60 File Offset: 0x00048F60
			[Token(Token = "0x1700189C")]
			protected ObjectPtr<Unit> owner
			{
				[Token(Token = "0x600CF59")]
				[Address(RVA = "0x3512710", Offset = "0x3511310", VA = "0x183512710")]
				get
				{
					return default(ObjectPtr<Unit>);
				}
			}

			// Token: 0x1700189D RID: 6301
			// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x0004AD78 File Offset: 0x00048F78
			[Token(Token = "0x1700189D")]
			private bool isMixValid
			{
				[Token(Token = "0x600CF5A")]
				[Address(RVA = "0x3512650", Offset = "0x3511250", VA = "0x183512650")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600CF5B RID: 53083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF5B")]
			[Address(RVA = "0x3512560", Offset = "0x3511160", VA = "0x183512560", Slot = "4")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600CF5C RID: 53084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF5C")]
			[Address(RVA = "0x3512480", Offset = "0x3511080", VA = "0x183512480")]
			public void OnAnimStopped()
			{
			}

			// Token: 0x0600CF5D RID: 53085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF5D")]
			[Address(RVA = "0x3512410", Offset = "0x3511010", VA = "0x183512410")]
			public void OnAnimPlayed()
			{
			}

			// Token: 0x0600CF5E RID: 53086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF5E")]
			[Address(RVA = "0x35122A0", Offset = "0x3510EA0", VA = "0x1835122A0", Slot = "5")]
			public virtual void Init(SpineMixExtraLayer layer, ObjectPtr<Unit> owner)
			{
			}

			// Token: 0x0600CF5F RID: 53087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF5F")]
			[Address(RVA = "0x3512100", Offset = "0x3510D00", VA = "0x183512100")]
			protected void ChangeAnim(string animKey, float alpha, bool isLoop)
			{
			}

			// Token: 0x0600CF60 RID: 53088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF60")]
			[Address(RVA = "0x35124E0", Offset = "0x35110E0", VA = "0x1835124E0")]
			private void OnDestroy()
			{
			}

			// Token: 0x0600CF61 RID: 53089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF61")]
			[Address(RVA = "0x35125F0", Offset = "0x35111F0", VA = "0x1835125F0")]
			public LayerAnimPlayer()
			{
			}

			// Token: 0x0400DD65 RID: 56677
			[Token(Token = "0x400DD65")]
			[FieldOffset(Offset = "0x18")]
			private Action<string, float, bool> m_onAnimChange;

			// Token: 0x0400DD66 RID: 56678
			[Token(Token = "0x400DD66")]
			[FieldOffset(Offset = "0x20")]
			private ObjectPtr<Unit> m_owner;

			// Token: 0x0400DD67 RID: 56679
			[Token(Token = "0x400DD67")]
			[FieldOffset(Offset = "0x30")]
			private SpineMixExtraLayer m_layer;

			// Token: 0x0400DD68 RID: 56680
			[Token(Token = "0x400DD68")]
			[FieldOffset(Offset = "0x38")]
			private ValueTuple<string, float, bool> m_nullableAnimCache;

			// Token: 0x0400DD69 RID: 56681
			[Token(Token = "0x400DD69")]
			[FieldOffset(Offset = "0x48")]
			private bool m_applyMixNextFrame;

			// Token: 0x0400DD6A RID: 56682
			[Token(Token = "0x400DD6A")]
			[FieldOffset(Offset = "0x49")]
			private bool m_isAnimStopped;

			// Token: 0x0400DD6B RID: 56683
			[Token(Token = "0x400DD6B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400DD6C RID: 56684
			[Token(Token = "0x400DD6C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isMixValid;

			// Token: 0x0400DD6D RID: 56685
			[Token(Token = "0x400DD6D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400DD6E RID: 56686
			[Token(Token = "0x400DD6E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnAnimStopped;

			// Token: 0x0400DD6F RID: 56687
			[Token(Token = "0x400DD6F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnAnimPlayed;

			// Token: 0x0400DD70 RID: 56688
			[Token(Token = "0x400DD70")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400DD71 RID: 56689
			[Token(Token = "0x400DD71")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ChangeAnim;

			// Token: 0x0400DD72 RID: 56690
			[Token(Token = "0x400DD72")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x0400DD73 RID: 56691
			[Token(Token = "0x400DD73")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
