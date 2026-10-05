using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E88 RID: 7816
	[Token(Token = "0x2001E88")]
	public class AVGCameraEffect : ExecutorComponent, IFadeTimeRatio
	{
		// Token: 0x0600C196 RID: 49558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C196")]
		[Address(RVA = "0x33D5E80", Offset = "0x33D4A80", VA = "0x1833D5E80")]
		private AVGCameraEffect.CameraEffectRecord _EnsureCameraEffectRecord(string effect)
		{
			return null;
		}

		// Token: 0x0600C197 RID: 49559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C197")]
		[Address(RVA = "0x33D51F0", Offset = "0x33D3DF0", VA = "0x1833D51F0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C198")]
		[Address(RVA = "0x33D5500", Offset = "0x33D4100", VA = "0x1833D5500", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C199")]
		[Address(RVA = "0x33D56C0", Offset = "0x33D42C0", VA = "0x1833D56C0")]
		private void _ClearEffects()
		{
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C19A")]
		[Address(RVA = "0x33D55A0", Offset = "0x33D41A0", VA = "0x1833D55A0")]
		private void _ClearEffect(string effect)
		{
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x00047160 File Offset: 0x00045360
		[Token(Token = "0x600C19B")]
		[Address(RVA = "0x33D6020", Offset = "0x33D4C20", VA = "0x1833D6020")]
		private bool _ExecuteCameraEffect(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x00047178 File Offset: 0x00045378
		[Token(Token = "0x600C19C")]
		[Address(RVA = "0x33D6B60", Offset = "0x33D5760", VA = "0x1833D6B60")]
		private bool _ExecuteFocusParam(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x00047190 File Offset: 0x00045390
		[Token(Token = "0x600C19D")]
		[Address(RVA = "0x33D6DD0", Offset = "0x33D59D0", VA = "0x1833D6DD0")]
		private bool _ExecuteFocusout(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x000471A8 File Offset: 0x000453A8
		[Token(Token = "0x600C19E")]
		[Address(RVA = "0x33D72C0", Offset = "0x33D5EC0", VA = "0x1833D72C0")]
		private AVGSceneEffectManager.EffectConfig _GenCfgByType(string type, string id)
		{
			return default(AVGSceneEffectManager.EffectConfig);
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C19F")]
		[Address(RVA = "0x33D74B0", Offset = "0x33D60B0", VA = "0x1833D74B0")]
		private void _ResetCameraLocation()
		{
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x000471C0 File Offset: 0x000453C0
		[Token(Token = "0x600C1A0")]
		[Address(RVA = "0x33D6650", Offset = "0x33D5250", VA = "0x1833D6650")]
		private bool _ExecuteCameraShake(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A1")]
		[Address(RVA = "0x33D5170", Offset = "0x33D3D70", VA = "0x1833D5170", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C1A2 RID: 49570 RVA: 0x000471D8 File Offset: 0x000453D8
		[Token(Token = "0x600C1A2")]
		[Address(RVA = "0x33D50C0", Offset = "0x33D3CC0", VA = "0x1833D50C0", Slot = "13")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x000471F0 File Offset: 0x000453F0
		[Token(Token = "0x600C1A3")]
		[Address(RVA = "0x33D5450", Offset = "0x33D4050", VA = "0x1833D5450", Slot = "14")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1A4")]
		[Address(RVA = "0x33D75E0", Offset = "0x33D61E0", VA = "0x1833D75E0")]
		private Tweener _TweenGrayscaleAmount(string effect, float initAmount, float amount, float fadetime)
		{
			return null;
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A5")]
		[Address(RVA = "0x33D5C40", Offset = "0x33D4840", VA = "0x1833D5C40")]
		private void _EnableColorInverse(bool enable)
		{
		}

		// Token: 0x0600C1A6 RID: 49574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A6")]
		[Address(RVA = "0x33D58F0", Offset = "0x33D44F0", VA = "0x1833D58F0")]
		private void _EnableChaos(bool enable, string fromSetting, string toSetting, float duration)
		{
		}

		// Token: 0x0600C1A7 RID: 49575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A7")]
		[Address(RVA = "0x33D8010", Offset = "0x33D6C10", VA = "0x1833D8010")]
		public AVGCameraEffect()
		{
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A9")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C318 RID: 49944
		[Token(Token = "0x400C318")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Camera _sceneCamera;

		// Token: 0x0400C319 RID: 49945
		[Token(Token = "0x400C319")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _sceneRoot;

		// Token: 0x0400C31A RID: 49946
		[Token(Token = "0x400C31A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _defaultFadetime;

		// Token: 0x0400C31B RID: 49947
		[Token(Token = "0x400C31B")]
		private const string FOCUSOUT_KEY_CGITEM = "cgitem";

		// Token: 0x0400C31C RID: 49948
		[Token(Token = "0x400C31C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, string[]> FOCUSOUT_CHANNELS;

		// Token: 0x0400C31D RID: 49949
		[Token(Token = "0x400C31D")]
		private const string FX_KEY_GRAYSCALE = "Grayscale";

		// Token: 0x0400C31E RID: 49950
		[Token(Token = "0x400C31E")]
		private const string FX_KEY_COLORINVERSE = "Colorinverse";

		// Token: 0x0400C31F RID: 49951
		[Token(Token = "0x400C31F")]
		private const string FX_KEY_CHAOS = "Chaos";

		// Token: 0x0400C320 RID: 49952
		[Token(Token = "0x400C320")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, AVGCameraEffect.CameraEffectRecord> m_usedEffects;

		// Token: 0x0400C321 RID: 49953
		[Token(Token = "0x400C321")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureCameraEffectRecord;

		// Token: 0x0400C322 RID: 49954
		[Token(Token = "0x400C322")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C323 RID: 49955
		[Token(Token = "0x400C323")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C324 RID: 49956
		[Token(Token = "0x400C324")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x0400C325 RID: 49957
		[Token(Token = "0x400C325")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearEffect;

		// Token: 0x0400C326 RID: 49958
		[Token(Token = "0x400C326")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteCameraEffect;

		// Token: 0x0400C327 RID: 49959
		[Token(Token = "0x400C327")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteFocusParam;

		// Token: 0x0400C328 RID: 49960
		[Token(Token = "0x400C328")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteFocusout;

		// Token: 0x0400C329 RID: 49961
		[Token(Token = "0x400C329")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenCfgByType;

		// Token: 0x0400C32A RID: 49962
		[Token(Token = "0x400C32A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetCameraLocation;

		// Token: 0x0400C32B RID: 49963
		[Token(Token = "0x400C32B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteCameraShake;

		// Token: 0x0400C32C RID: 49964
		[Token(Token = "0x400C32C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C32D RID: 49965
		[Token(Token = "0x400C32D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C32E RID: 49966
		[Token(Token = "0x400C32E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C32F RID: 49967
		[Token(Token = "0x400C32F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TweenGrayscaleAmount;

		// Token: 0x0400C330 RID: 49968
		[Token(Token = "0x400C330")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EnableColorInverse;

		// Token: 0x0400C331 RID: 49969
		[Token(Token = "0x400C331")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EnableChaos;

		// Token: 0x0400C332 RID: 49970
		[Token(Token = "0x400C332")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E89 RID: 7817
		[Token(Token = "0x2001E89")]
		private class CameraEffectRecord
		{
			// Token: 0x0600C1AA RID: 49578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1AA")]
			[Address(RVA = "0x3403FF0", Offset = "0x3402BF0", VA = "0x183403FF0")]
			public void Load(AVGSceneEffectManager.EffectConfig config)
			{
			}

			// Token: 0x0600C1AB RID: 49579 RVA: 0x00047208 File Offset: 0x00045408
			[Token(Token = "0x600C1AB")]
			[Address(RVA = "0x3403F00", Offset = "0x3402B00", VA = "0x183403F00")]
			public AVGSceneEffectManager.EffectConfig CreateClearConfig()
			{
				return default(AVGSceneEffectManager.EffectConfig);
			}

			// Token: 0x0600C1AC RID: 49580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1AC")]
			[Address(RVA = "0x3404030", Offset = "0x3402C30", VA = "0x183404030")]
			public CameraEffectRecord()
			{
			}

			// Token: 0x0400C333 RID: 49971
			[Token(Token = "0x400C333")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400C334 RID: 49972
			[Token(Token = "0x400C334")]
			[FieldOffset(Offset = "0x18")]
			public List<string> channels;
		}
	}
}
