using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C1E RID: 11294
	[Token(Token = "0x2002C1E")]
	public class PireneHPBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0601312F RID: 78127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029F8")]
		private Buff hpStoreBuff
		{
			[Token(Token = "0x601312F")]
			[Address(RVA = "0xB20010", Offset = "0xB1EC10", VA = "0x180B20010")]
			get
			{
				return null;
			}
		}

		// Token: 0x06013130 RID: 78128 RVA: 0x00074850 File Offset: 0x00072A50
		[Token(Token = "0x6013130")]
		[Address(RVA = "0xB1D790", Offset = "0xB1C390", VA = "0x180B1D790")]
		public bool CheckWaterEffectAffecting(PireneHPBehaviour source)
		{
			return default(bool);
		}

		// Token: 0x06013131 RID: 78129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013131")]
		[Address(RVA = "0xB1F480", Offset = "0xB1E080", VA = "0x180B1F480", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013132 RID: 78130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013132")]
		[Address(RVA = "0xB1D8F0", Offset = "0xB1C4F0", VA = "0x180B1D8F0", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06013133 RID: 78131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013133")]
		[Address(RVA = "0xB1F740", Offset = "0xB1E340", VA = "0x180B1F740")]
		private void _CollectNeighbors()
		{
		}

		// Token: 0x06013134 RID: 78132 RVA: 0x00074868 File Offset: 0x00072A68
		[Token(Token = "0x6013134")]
		[Address(RVA = "0xB1FCD0", Offset = "0xB1E8D0", VA = "0x180B1FCD0")]
		private int _SortNeighbors(PireneHPBehaviour left, PireneHPBehaviour right)
		{
			return 0;
		}

		// Token: 0x06013135 RID: 78133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013135")]
		[Address(RVA = "0xB1FE80", Offset = "0xB1EA80", VA = "0x180B1FE80")]
		public PireneHPBehaviour()
		{
		}

		// Token: 0x06013138 RID: 78136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013138")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013139 RID: 78137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013139")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401588F RID: 88207
		[Token(Token = "0x401588F")]
		private const float NO_LOSS_HP_VALUE = 1f;

		// Token: 0x04015890 RID: 88208
		[Token(Token = "0x4015890")]
		private const float TWEEN_WAIT_TIME = 1f;

		// Token: 0x04015891 RID: 88209
		[Token(Token = "0x4015891")]
		private const float TWEEN_SCALE_TIME = 0.5f;

		// Token: 0x04015892 RID: 88210
		[Token(Token = "0x4015892")]
		private const float TWEEN_SCALE_END_VALUE = 1f;

		// Token: 0x04015893 RID: 88211
		[Token(Token = "0x4015893")]
		private const string TWEEN_START_AUDIO_SIGNAL = "pirene_flower_appear";

		// Token: 0x04015894 RID: 88212
		[Token(Token = "0x4015894")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffStoreKey;

		// Token: 0x04015895 RID: 88213
		[Token(Token = "0x4015895")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _buffStoreBB;

		// Token: 0x04015896 RID: 88214
		[Token(Token = "0x4015896")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _effectWaterKey;

		// Token: 0x04015897 RID: 88215
		[Token(Token = "0x4015897")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _waterTweenStartSize;

		// Token: 0x04015898 RID: 88216
		[Token(Token = "0x4015898")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _waterStartPos;

		// Token: 0x04015899 RID: 88217
		[Token(Token = "0x4015899")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _showWaterEffectValue;

		// Token: 0x0401589A RID: 88218
		[Token(Token = "0x401589A")]
		[FieldOffset(Offset = "0x44")]
		private bool m_collected;

		// Token: 0x0401589B RID: 88219
		[Token(Token = "0x401589B")]
		[FieldOffset(Offset = "0x48")]
		private FP m_hpRatio;

		// Token: 0x0401589C RID: 88220
		[Token(Token = "0x401589C")]
		[FieldOffset(Offset = "0x50")]
		private FP m_hpLossPerSec;

		// Token: 0x0401589D RID: 88221
		[Token(Token = "0x401589D")]
		[FieldOffset(Offset = "0x58")]
		private List<PireneHPBehaviour> m_neighbors;

		// Token: 0x0401589E RID: 88222
		[Token(Token = "0x401589E")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<Buff> m_hpStoreBuff;

		// Token: 0x0401589F RID: 88223
		[Token(Token = "0x401589F")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_water;

		// Token: 0x040158A0 RID: 88224
		[Token(Token = "0x40158A0")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_flower;

		// Token: 0x040158A1 RID: 88225
		[Token(Token = "0x40158A1")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_flowerTween;

		// Token: 0x040158A2 RID: 88226
		[Token(Token = "0x40158A2")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cachedFull;

		// Token: 0x040158A3 RID: 88227
		[Token(Token = "0x40158A3")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<PireneHPBehaviour, PireneHPBehaviour.WaterEffectData> m_waterEffects;

		// Token: 0x040158A4 RID: 88228
		[Token(Token = "0x40158A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hpStoreBuff;

		// Token: 0x040158A5 RID: 88229
		[Token(Token = "0x40158A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckWaterEffectAffecting;

		// Token: 0x040158A6 RID: 88230
		[Token(Token = "0x40158A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158A7 RID: 88231
		[Token(Token = "0x40158A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040158A8 RID: 88232
		[Token(Token = "0x40158A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CollectNeighbors;

		// Token: 0x040158A9 RID: 88233
		[Token(Token = "0x40158A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SortNeighbors;

		// Token: 0x040158AA RID: 88234
		[Token(Token = "0x40158AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C1F RID: 11295
		[Token(Token = "0x2002C1F")]
		public class WaterEffectData
		{
			// Token: 0x0601313A RID: 78138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601313A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WaterEffectData()
			{
			}

			// Token: 0x040158AB RID: 88235
			[Token(Token = "0x40158AB")]
			[FieldOffset(Offset = "0x10")]
			public ObjectPtr<Effect> effect;

			// Token: 0x040158AC RID: 88236
			[Token(Token = "0x40158AC")]
			[FieldOffset(Offset = "0x20")]
			public float startTime;
		}
	}
}
