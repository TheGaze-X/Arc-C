using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002141 RID: 8513
	[Token(Token = "0x2002141")]
	public class ThreeFaceAnimator : CharacterAnimator
	{
		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600D146 RID: 53574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001905")]
		public CharacterAnimator.FaceConfiguration down
		{
			[Token(Token = "0x600D146")]
			[Address(RVA = "0x353B210", Offset = "0x3539E10", VA = "0x18353B210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600D147 RID: 53575 RVA: 0x0004B6A8 File Offset: 0x000498A8
		// (set) Token: 0x0600D148 RID: 53576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001906")]
		public override Color color
		{
			[Token(Token = "0x600D147")]
			[Address(RVA = "0x353B190", Offset = "0x3539D90", VA = "0x18353B190", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600D148")]
			[Address(RVA = "0x353B2E0", Offset = "0x3539EE0", VA = "0x18353B2E0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x0600D149 RID: 53577 RVA: 0x0004B6C0 File Offset: 0x000498C0
		[Token(Token = "0x17001907")]
		public override bool faceToDown
		{
			[Token(Token = "0x600D149")]
			[Address(RVA = "0x353B270", Offset = "0x3539E70", VA = "0x18353B270", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D14A")]
		[Address(RVA = "0x353A220", Offset = "0x3538E20", VA = "0x18353A220", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D14B")]
		[Address(RVA = "0x353A180", Offset = "0x3538D80", VA = "0x18353A180", Slot = "53")]
		public override string GetFaceKey(IFaceConfiguration faceConfig)
		{
			return null;
		}

		// Token: 0x0600D14C RID: 53580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D14C")]
		[Address(RVA = "0x353A0D0", Offset = "0x3538CD0", VA = "0x18353A0D0", Slot = "54")]
		public override IFaceConfiguration GetFaceConfiguration(string faceKey)
		{
			return null;
		}

		// Token: 0x0600D14D RID: 53581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D14D")]
		[Address(RVA = "0x353A3C0", Offset = "0x3538FC0", VA = "0x18353A3C0", Slot = "26")]
		public override void OnReset(UnitAnimator old)
		{
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D14E")]
		[Address(RVA = "0x353AFB0", Offset = "0x3539BB0", VA = "0x18353AFB0", Slot = "69")]
		protected override void _SetFourDirection(SharedConsts.Direction lOrR, SharedConsts.Direction uOrD)
		{
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D14F")]
		[Address(RVA = "0x3539EF0", Offset = "0x3538AF0", VA = "0x183539EF0", Slot = "45")]
		protected override void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D150")]
		[Address(RVA = "0x353A030", Offset = "0x3538C30", VA = "0x18353A030", Slot = "66")]
		protected override void ForEachSkeleton(Action<SkeletonAnimation> func)
		{
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D151")]
		[Address(RVA = "0x3539F90", Offset = "0x3538B90", VA = "0x183539F90", Slot = "67")]
		public override void ForEachFaceConfiguration(Action<IFaceConfiguration> func)
		{
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x0004B6D8 File Offset: 0x000498D8
		[Token(Token = "0x600D152")]
		[Address(RVA = "0x353A8E0", Offset = "0x35394E0", VA = "0x18353A8E0", Slot = "68")]
		protected override bool TryGetSpinePrefix(out string prefix)
		{
			return default(bool);
		}

		// Token: 0x0600D153 RID: 53587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D153")]
		[Address(RVA = "0x353A4C0", Offset = "0x35390C0", VA = "0x18353A4C0", Slot = "62")]
		public override void ReplaceShader()
		{
		}

		// Token: 0x0600D154 RID: 53588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D154")]
		[Address(RVA = "0x353A640", Offset = "0x3539240", VA = "0x18353A640", Slot = "56")]
		protected override void SetSpineSkinInternal(SpineAnimator.SpineSkinData data)
		{
		}

		// Token: 0x0600D155 RID: 53589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D155")]
		[Address(RVA = "0x353AC40", Offset = "0x3539840", VA = "0x18353AC40", Slot = "60")]
		protected override void UpdateSpineSkinData()
		{
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D156")]
		[Address(RVA = "0x353B130", Offset = "0x3539D30", VA = "0x18353B130")]
		public ThreeFaceAnimator()
		{
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x0004B6F0 File Offset: 0x000498F0
		[Token(Token = "0x600D157")]
		[Address(RVA = "0x353AB90", Offset = "0x3539790", VA = "0x18353AB90")]
		private Color <>xLuaBaseProxy_get_color()
		{
			return default(Color);
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D158")]
		[Address(RVA = "0x353AC20", Offset = "0x3539820", VA = "0x18353AC20")]
		private void <>xLuaBaseProxy_set_color(Color P0)
		{
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x0004B708 File Offset: 0x00049908
		[Token(Token = "0x600D159")]
		[Address(RVA = "0x353ABC0", Offset = "0x35397C0", VA = "0x18353ABC0")]
		private bool <>xLuaBaseProxy_get_faceToDown()
		{
			return default(bool);
		}

		// Token: 0x0600D15A RID: 53594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D15A")]
		[Address(RVA = "0x353AB20", Offset = "0x3539720", VA = "0x18353AB20")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D15B RID: 53595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D15B")]
		[Address(RVA = "0x353AB10", Offset = "0x3539710", VA = "0x18353AB10")]
		private string <>xLuaBaseProxy_GetFaceKey(IFaceConfiguration P0)
		{
			return null;
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D15C")]
		[Address(RVA = "0x353AB00", Offset = "0x3539700", VA = "0x18353AB00")]
		private IFaceConfiguration <>xLuaBaseProxy_GetFaceConfiguration(string P0)
		{
			return null;
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D15D")]
		[Address(RVA = "0x353AB30", Offset = "0x3539730", VA = "0x18353AB30")]
		private void <>xLuaBaseProxy_OnReset(UnitAnimator P0)
		{
		}

		// Token: 0x0600D15E RID: 53598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D15E")]
		[Address(RVA = "0x353AB80", Offset = "0x3539780", VA = "0x18353AB80")]
		private void <>xLuaBaseProxy__SetFourDirection(SharedConsts.Direction P0, SharedConsts.Direction P1)
		{
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D15F")]
		[Address(RVA = "0x353AAD0", Offset = "0x35396D0", VA = "0x18353AAD0")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0600D160 RID: 53600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D160")]
		[Address(RVA = "0x353AAF0", Offset = "0x35396F0", VA = "0x18353AAF0")]
		private void <>xLuaBaseProxy_ForEachSkeleton(Action<SkeletonAnimation> P0)
		{
		}

		// Token: 0x0600D161 RID: 53601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D161")]
		[Address(RVA = "0x353AAE0", Offset = "0x35396E0", VA = "0x18353AAE0")]
		private void <>xLuaBaseProxy_ForEachFaceConfiguration(Action<IFaceConfiguration> P0)
		{
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x0004B720 File Offset: 0x00049920
		[Token(Token = "0x600D162")]
		[Address(RVA = "0x353AB60", Offset = "0x3539760", VA = "0x18353AB60")]
		private bool <>xLuaBaseProxy_TryGetSpinePrefix(out string P0)
		{
			return default(bool);
		}

		// Token: 0x0600D163 RID: 53603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D163")]
		[Address(RVA = "0x353AB40", Offset = "0x3539740", VA = "0x18353AB40")]
		private void <>xLuaBaseProxy_ReplaceShader()
		{
		}

		// Token: 0x0600D164 RID: 53604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D164")]
		[Address(RVA = "0x353AB50", Offset = "0x3539750", VA = "0x18353AB50")]
		private void <>xLuaBaseProxy_SetSpineSkinInternal(SpineAnimator.SpineSkinData P0)
		{
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D165")]
		[Address(RVA = "0x353AB70", Offset = "0x3539770", VA = "0x18353AB70")]
		private void <>xLuaBaseProxy_UpdateSpineSkinData()
		{
		}

		// Token: 0x0400DFC1 RID: 57281
		[Token(Token = "0x400DFC1")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CharacterAnimator.FaceConfiguration _down;

		// Token: 0x0400DFC2 RID: 57282
		[Token(Token = "0x400DFC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_down;

		// Token: 0x0400DFC3 RID: 57283
		[Token(Token = "0x400DFC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DFC4 RID: 57284
		[Token(Token = "0x400DFC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DFC5 RID: 57285
		[Token(Token = "0x400DFC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_faceToDown;

		// Token: 0x0400DFC6 RID: 57286
		[Token(Token = "0x400DFC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DFC7 RID: 57287
		[Token(Token = "0x400DFC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFaceKey;

		// Token: 0x0400DFC8 RID: 57288
		[Token(Token = "0x400DFC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetFaceConfiguration;

		// Token: 0x0400DFC9 RID: 57289
		[Token(Token = "0x400DFC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400DFCA RID: 57290
		[Token(Token = "0x400DFCA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetFourDirection;

		// Token: 0x0400DFCB RID: 57291
		[Token(Token = "0x400DFCB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DFCC RID: 57292
		[Token(Token = "0x400DFCC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ForEachSkeleton;

		// Token: 0x0400DFCD RID: 57293
		[Token(Token = "0x400DFCD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ForEachFaceConfiguration;

		// Token: 0x0400DFCE RID: 57294
		[Token(Token = "0x400DFCE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetSpinePrefix;

		// Token: 0x0400DFCF RID: 57295
		[Token(Token = "0x400DFCF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReplaceShader;

		// Token: 0x0400DFD0 RID: 57296
		[Token(Token = "0x400DFD0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetSpineSkinInternal;

		// Token: 0x0400DFD1 RID: 57297
		[Token(Token = "0x400DFD1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateSpineSkinData;

		// Token: 0x0400DFD2 RID: 57298
		[Token(Token = "0x400DFD2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
