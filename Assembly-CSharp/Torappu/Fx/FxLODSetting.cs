using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x02002036 RID: 8246
	[Token(Token = "0x2002036")]
	public class FxLODSetting : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x0600CB31 RID: 52017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700180D")]
		public List<GameObject> disableObjects
		{
			[Token(Token = "0x600CB31")]
			[Address(RVA = "0x34C3630", Offset = "0x34C2230", VA = "0x1834C3630")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700180E")]
		public List<FxLODSetting.ParticleDetailsHooker> particleDetailsHookers
		{
			[Token(Token = "0x600CB32")]
			[Address(RVA = "0x34C3690", Offset = "0x34C2290", VA = "0x1834C3690")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB33")]
		[Address(RVA = "0x34C30C0", Offset = "0x34C1CC0", VA = "0x1834C30C0")]
		[Inspect]
		[Descriptor(Name = "重播特效(运行时生效)")]
		public void ReplayEffect()
		{
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB34")]
		[Address(RVA = "0x34C3060", Offset = "0x34C1C60", VA = "0x1834C3060")]
		[Inspect]
		[Descriptor(Name = "预览低配特效(运行时生效)")]
		public void ApplyLowDetail()
		{
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB35")]
		[Address(RVA = "0x34C2C10", Offset = "0x34C1810", VA = "0x1834C2C10")]
		public void ApplyLowDetail(bool force)
		{
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB36")]
		[Address(RVA = "0x34C3160", Offset = "0x34C1D60", VA = "0x1834C3160")]
		[Inspect]
		[Descriptor(Name = "预览原特效(运行时生效)")]
		public void RevertToHighDetail()
		{
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB37")]
		[Address(RVA = "0x34C3530", Offset = "0x34C2130", VA = "0x1834C3530")]
		public FxLODSetting()
		{
		}

		// Token: 0x0400D52B RID: 54571
		[Token(Token = "0x400D52B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Descriptor(Name = "隐藏子物体")]
		private List<GameObject> _disableObjects;

		// Token: 0x0400D52C RID: 54572
		[Token(Token = "0x400D52C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Descriptor(Name = "修改粒子参数")]
		private List<FxLODSetting.ParticleDetailsHooker> _particleDetailsHookers;

		// Token: 0x0400D52D RID: 54573
		[Token(Token = "0x400D52D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableObjects;

		// Token: 0x0400D52E RID: 54574
		[Token(Token = "0x400D52E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_particleDetailsHookers;

		// Token: 0x0400D52F RID: 54575
		[Token(Token = "0x400D52F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReplayEffect;

		// Token: 0x0400D530 RID: 54576
		[Token(Token = "0x400D530")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyLowDetail;

		// Token: 0x0400D531 RID: 54577
		[Token(Token = "0x400D531")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_ApplyLowDetail;

		// Token: 0x0400D532 RID: 54578
		[Token(Token = "0x400D532")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RevertToHighDetail;

		// Token: 0x0400D533 RID: 54579
		[Token(Token = "0x400D533")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002037 RID: 8247
		[Token(Token = "0x2002037")]
		[Serializable]
		public class ParticleDetailsHooker
		{
			// Token: 0x0600CB38 RID: 52024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB38")]
			[Address(RVA = "0x34C7260", Offset = "0x34C5E60", VA = "0x1834C7260")]
			public void ApplyLowDetailPS()
			{
			}

			// Token: 0x0600CB39 RID: 52025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB39")]
			[Address(RVA = "0x34C78B0", Offset = "0x34C64B0", VA = "0x1834C78B0")]
			private void _RefreshCurveViaPercentage(ref ParticleSystem.MinMaxCurve curve, float detailPercentage)
			{
			}

			// Token: 0x0600CB3A RID: 52026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB3A")]
			[Address(RVA = "0x34C7580", Offset = "0x34C6180", VA = "0x1834C7580")]
			public void RevertToHighDetailPS()
			{
			}

			// Token: 0x0600CB3B RID: 52027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB3B")]
			[Address(RVA = "0x34C76E0", Offset = "0x34C62E0", VA = "0x1834C76E0")]
			public void SaveOrigin()
			{
			}

			// Token: 0x0600CB3C RID: 52028 RVA: 0x00049800 File Offset: 0x00047A00
			[Token(Token = "0x600CB3C")]
			[Address(RVA = "0x34C7520", Offset = "0x34C6120", VA = "0x1834C7520")]
			public bool CheckValid()
			{
				return default(bool);
			}

			// Token: 0x0600CB3D RID: 52029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB3D")]
			[Address(RVA = "0x34C7980", Offset = "0x34C6580", VA = "0x1834C7980")]
			public ParticleDetailsHooker()
			{
			}

			// Token: 0x0400D534 RID: 54580
			[Token(Token = "0x400D534")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Descriptor(Name = "粒子")]
			private ParticleSystem _particle;

			// Token: 0x0400D535 RID: 54581
			[Token(Token = "0x400D535")]
			[FieldOffset(Offset = "0x18")]
			[Descriptor(Name = "数量百分比")]
			[Tooltip("影响rate和burst的粒子数量")]
			[SerializeField]
			private float _detailPercentage;

			// Token: 0x0400D536 RID: 54582
			[Token(Token = "0x400D536")]
			[FieldOffset(Offset = "0x20")]
			private ParticleSystem.MinMaxCurve m_RateOverTime;

			// Token: 0x0400D537 RID: 54583
			[Token(Token = "0x400D537")]
			[FieldOffset(Offset = "0x40")]
			private List<ParticleSystem.Burst> m_originBursts;

			// Token: 0x0400D538 RID: 54584
			[Token(Token = "0x400D538")]
			[FieldOffset(Offset = "0x48")]
			private bool m_HasSavedOrigin;
		}
	}
}
