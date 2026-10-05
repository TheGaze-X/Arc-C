using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200213B RID: 8507
	[Token(Token = "0x200213B")]
	public class SpineAnimatorRenderHelper : SingletonWithMonoHost<SpineAnimatorRenderHelper, BattleController>, IDisposable
	{
		// Token: 0x0600D12B RID: 53547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D12B")]
		[Address(RVA = "0x3539400", Offset = "0x3538000", VA = "0x183539400")]
		private SpineAnimatorRenderHelper()
		{
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D12C")]
		[Address(RVA = "0x3538A70", Offset = "0x3537670", VA = "0x183538A70")]
		private void _ApplyEffect(SpineAnimator animator, SpineAnimatorEffect.Param param)
		{
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D12D")]
		[Address(RVA = "0x35390C0", Offset = "0x3537CC0", VA = "0x1835390C0")]
		private SpineAnimatorEffect _GetEffect(SpineAnimatorEffectType effectType)
		{
			return null;
		}

		// Token: 0x0600D12E RID: 53550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D12E")]
		[Address(RVA = "0x3538DE0", Offset = "0x35379E0", VA = "0x183538DE0")]
		private static SpineAnimatorEffect _CreateEffect(SpineAnimatorEffectType effectType)
		{
			return null;
		}

		// Token: 0x0600D12F RID: 53551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D12F")]
		[Address(RVA = "0x3538840", Offset = "0x3537440", VA = "0x183538840", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600D130 RID: 53552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D130")]
		[Address(RVA = "0x35391C0", Offset = "0x3537DC0", VA = "0x1835391C0")]
		private SpineAnimatorRenderHelper.FacePropertyBlockHolder _GetOrCreateFaceBlockHolder(IFaceConfiguration face)
		{
			return null;
		}

		// Token: 0x0600D131 RID: 53553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D131")]
		[Address(RVA = "0x35388E0", Offset = "0x35374E0", VA = "0x1835388E0")]
		public static MaterialPropertyBlock GetCommonPropertyBlock(IFaceConfiguration face)
		{
			return null;
		}

		// Token: 0x0600D132 RID: 53554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D132")]
		[Address(RVA = "0x3538970", Offset = "0x3537570", VA = "0x183538970")]
		public static void SetFloatToPropertyBlock(IFaceConfiguration face, int propertyId, float value, int materialIndex = -1)
		{
		}

		// Token: 0x0600D133 RID: 53555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D133")]
		[Address(RVA = "0x35381F0", Offset = "0x3536DF0", VA = "0x1835381F0")]
		public static void ApplyPropertyBlock(IFaceConfiguration face, int materialIndex = -1)
		{
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D134")]
		[Address(RVA = "0x35385C0", Offset = "0x35371C0", VA = "0x1835385C0")]
		public static void ClearAndApplyFacePropertyBlocks(IFaceConfiguration face)
		{
		}

		// Token: 0x0600D135 RID: 53557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D135")]
		[Address(RVA = "0x3537F80", Offset = "0x3536B80", VA = "0x183537F80")]
		public static void ApplyDitherEffect(SpineAnimator animator, bool enabled, float intensity, [Optional] string faceKey, int materialIndex = -1)
		{
		}

		// Token: 0x0600D136 RID: 53558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D136")]
		[Address(RVA = "0x3537D50", Offset = "0x3536950", VA = "0x183537D50")]
		public static void ApplyBaselineEffect(SpineAnimator animator, float baselineHeight, [Optional] string faceKey, int materialIndex = -1)
		{
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D137")]
		[Address(RVA = "0x3538360", Offset = "0x3536F60", VA = "0x183538360")]
		public static void ApplySleepTileEffect(SpineAnimator animator, float fadeHeight, float onSleepTile, [Optional] string faceKey, int materialIndex = -1)
		{
		}

		// Token: 0x0400DFA2 RID: 57250
		[Token(Token = "0x400DFA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<SpineAnimatorEffectType, SpineAnimatorEffect> s_effectCache;

		// Token: 0x0400DFA3 RID: 57251
		[Token(Token = "0x400DFA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<IFaceConfiguration, SpineAnimatorRenderHelper.FacePropertyBlockHolder> s_faceBlockCache;

		// Token: 0x0400DFA4 RID: 57252
		[Token(Token = "0x400DFA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400DFA5 RID: 57253
		[Token(Token = "0x400DFA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyEffect;

		// Token: 0x0400DFA6 RID: 57254
		[Token(Token = "0x400DFA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetEffect;

		// Token: 0x0400DFA7 RID: 57255
		[Token(Token = "0x400DFA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateEffect;

		// Token: 0x0400DFA8 RID: 57256
		[Token(Token = "0x400DFA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400DFA9 RID: 57257
		[Token(Token = "0x400DFA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetOrCreateFaceBlockHolder;

		// Token: 0x0400DFAA RID: 57258
		[Token(Token = "0x400DFAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCommonPropertyBlock;

		// Token: 0x0400DFAB RID: 57259
		[Token(Token = "0x400DFAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetFloatToPropertyBlock;

		// Token: 0x0400DFAC RID: 57260
		[Token(Token = "0x400DFAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyPropertyBlock;

		// Token: 0x0400DFAD RID: 57261
		[Token(Token = "0x400DFAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearAndApplyFacePropertyBlocks;

		// Token: 0x0400DFAE RID: 57262
		[Token(Token = "0x400DFAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyDitherEffect;

		// Token: 0x0400DFAF RID: 57263
		[Token(Token = "0x400DFAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ApplyBaselineEffect;

		// Token: 0x0400DFB0 RID: 57264
		[Token(Token = "0x400DFB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ApplySleepTileEffect;

		// Token: 0x0200213C RID: 8508
		[Token(Token = "0x200213C")]
		private class FacePropertyBlockHolder
		{
			// Token: 0x0600D138 RID: 53560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D138")]
			[Address(RVA = "0x35364E0", Offset = "0x35350E0", VA = "0x1835364E0")]
			public MaterialPropertyBlock GetMaterialPropertyBlock(int materialIndex)
			{
				return null;
			}

			// Token: 0x0600D139 RID: 53561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D139")]
			[Address(RVA = "0x35365B0", Offset = "0x35351B0", VA = "0x1835365B0")]
			public void SetFloat(int propertyId, float value, int materialIndex = -1)
			{
			}

			// Token: 0x0600D13A RID: 53562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D13A")]
			[Address(RVA = "0x35363B0", Offset = "0x3534FB0", VA = "0x1835363B0")]
			public void Clear()
			{
			}

			// Token: 0x0600D13B RID: 53563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D13B")]
			[Address(RVA = "0x3536610", Offset = "0x3535210", VA = "0x183536610")]
			public FacePropertyBlockHolder()
			{
			}

			// Token: 0x0400DFB1 RID: 57265
			[Token(Token = "0x400DFB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MaterialPropertyBlock commonBlock;

			// Token: 0x0400DFB2 RID: 57266
			[Token(Token = "0x400DFB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<int, MaterialPropertyBlock> materialBlocks;
		}
	}
}
