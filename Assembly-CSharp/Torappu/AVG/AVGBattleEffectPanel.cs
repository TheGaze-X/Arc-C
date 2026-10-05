using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E7D RID: 7805
	[Token(Token = "0x2001E7D")]
	public class AVGBattleEffectPanel : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600C15D RID: 49501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C15D")]
		[Address(RVA = "0x33D04F0", Offset = "0x33CF0F0", VA = "0x1833D04F0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C15E RID: 49502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15E")]
		[Address(RVA = "0x33D06E0", Offset = "0x33CF2E0", VA = "0x1833D06E0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15F")]
		[Address(RVA = "0x33D0A90", Offset = "0x33CF690", VA = "0x1833D0A90")]
		private void _ClearAllSeq()
		{
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C160")]
		[Address(RVA = "0x33D0830", Offset = "0x33CF430", VA = "0x1833D0830")]
		private void _ClearAllBgEffect()
		{
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C161")]
		[Address(RVA = "0x33D2F80", Offset = "0x33D1B80", VA = "0x1833D2F80")]
		private void _TryRemoveBgEffectWithLayer(int layer, float fadeTime = 0f)
		{
		}

		// Token: 0x0600C162 RID: 49506 RVA: 0x00047058 File Offset: 0x00045258
		[Token(Token = "0x600C162")]
		[Address(RVA = "0x33D1A00", Offset = "0x33D0600", VA = "0x1833D1A00")]
		protected bool _ExecuteEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x00047070 File Offset: 0x00045270
		[Token(Token = "0x600C163")]
		[Address(RVA = "0x33D0B70", Offset = "0x33CF770", VA = "0x1833D0B70")]
		private bool _EffectMove(Vector2 posTo)
		{
			return default(bool);
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C164")]
		[Address(RVA = "0x33D2AE0", Offset = "0x33D16E0", VA = "0x1833D2AE0")]
		private ParticleEffect _TryGenEffect(ParticleEffect effect, Vector2 posVal, Vector3 rotatVal, float duration, int layer)
		{
			return null;
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C165")]
		[Address(RVA = "0x33D2E20", Offset = "0x33D1A20", VA = "0x1833D2E20")]
		private void _TryParseRotation(AVGBattleEffectPanel.EEffectFlip flip, ref Vector3 rotation)
		{
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x00047088 File Offset: 0x00045288
		[Token(Token = "0x600C166")]
		[Address(RVA = "0x33D0C40", Offset = "0x33CF840", VA = "0x1833D0C40")]
		protected bool _ExcuteBgEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C167")]
		[Address(RVA = "0x33D22D0", Offset = "0x33D0ED0", VA = "0x1833D22D0")]
		private ParticleEffect _GenEffect(ParticleEffect prefab, Vector2 pos, Vector3 rotate, int layer)
		{
			return null;
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x000470A0 File Offset: 0x000452A0
		[Token(Token = "0x600C168")]
		[Address(RVA = "0x33D1530", Offset = "0x33D0130", VA = "0x1833D1530")]
		protected bool _ExcuteImageEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C169")]
		[Address(RVA = "0x33D25F0", Offset = "0x33D11F0", VA = "0x1833D25F0")]
		private ParticleEffect _GenImgEffect(ParticleEffect prefab, string imageName, Vector2 pos, int layer)
		{
			return null;
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16A")]
		[Address(RVA = "0x33D2A10", Offset = "0x33D1610", VA = "0x1833D2A10", Slot = "14")]
		protected virtual void _OnClicked(object arg)
		{
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16B")]
		[Address(RVA = "0x33D0490", Offset = "0x33CF090", VA = "0x1833D0490", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C16C RID: 49516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C16C")]
		[Address(RVA = "0x33D0400", Offset = "0x33CF000", VA = "0x1833D0400", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16D")]
		[Address(RVA = "0x33D3180", Offset = "0x33D1D80", VA = "0x1833D3180")]
		public AVGBattleEffectPanel()
		{
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16E")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C2BB RID: 49851
		[Token(Token = "0x400C2BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _effectContainer;

		// Token: 0x0400C2BC RID: 49852
		[Token(Token = "0x400C2BC")]
		private const int MAX_EFFECT_LAYER = 4;

		// Token: 0x0400C2BD RID: 49853
		[Token(Token = "0x400C2BD")]
		[FieldOffset(Offset = "0x58")]
		private List<Sequence> m_sequences;

		// Token: 0x0400C2BE RID: 49854
		[Token(Token = "0x400C2BE")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<int, ParticleEffect> m_bgEffects;

		// Token: 0x0400C2BF RID: 49855
		[Token(Token = "0x400C2BF")]
		[FieldOffset(Offset = "0x68")]
		private ParticleEffect m_cachedImgEffect;

		// Token: 0x0400C2C0 RID: 49856
		[Token(Token = "0x400C2C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C2C1 RID: 49857
		[Token(Token = "0x400C2C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C2C2 RID: 49858
		[Token(Token = "0x400C2C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearAllSeq;

		// Token: 0x0400C2C3 RID: 49859
		[Token(Token = "0x400C2C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearAllBgEffect;

		// Token: 0x0400C2C4 RID: 49860
		[Token(Token = "0x400C2C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryRemoveBgEffectWithLayer;

		// Token: 0x0400C2C5 RID: 49861
		[Token(Token = "0x400C2C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteEffect;

		// Token: 0x0400C2C6 RID: 49862
		[Token(Token = "0x400C2C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EffectMove;

		// Token: 0x0400C2C7 RID: 49863
		[Token(Token = "0x400C2C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGenEffect;

		// Token: 0x0400C2C8 RID: 49864
		[Token(Token = "0x400C2C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryParseRotation;

		// Token: 0x0400C2C9 RID: 49865
		[Token(Token = "0x400C2C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExcuteBgEffect;

		// Token: 0x0400C2CA RID: 49866
		[Token(Token = "0x400C2CA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenEffect;

		// Token: 0x0400C2CB RID: 49867
		[Token(Token = "0x400C2CB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExcuteImageEffect;

		// Token: 0x0400C2CC RID: 49868
		[Token(Token = "0x400C2CC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenImgEffect;

		// Token: 0x0400C2CD RID: 49869
		[Token(Token = "0x400C2CD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x0400C2CE RID: 49870
		[Token(Token = "0x400C2CE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C2CF RID: 49871
		[Token(Token = "0x400C2CF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C2D0 RID: 49872
		[Token(Token = "0x400C2D0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E7E RID: 7806
		[Token(Token = "0x2001E7E")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C16F RID: 49519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C16F")]
			[Address(RVA = "0x33E9EE0", Offset = "0x33E8AE0", VA = "0x1833E9EE0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C170 RID: 49520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C170")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InternalResRefCollector()
			{
			}
		}

		// Token: 0x02001E7F RID: 7807
		[Token(Token = "0x2001E7F")]
		private enum EEffectFlip
		{
			// Token: 0x0400C2D2 RID: 49874
			[Token(Token = "0x400C2D2")]
			NONE,
			// Token: 0x0400C2D3 RID: 49875
			[Token(Token = "0x400C2D3")]
			HORIZENTAL,
			// Token: 0x0400C2D4 RID: 49876
			[Token(Token = "0x400C2D4")]
			VERTICAL
		}
	}
}
