using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D5 RID: 10709
	[Token(Token = "0x20029D5")]
	public class FarthestPointMovement : AdvancedMovement
	{
		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x06011C13 RID: 72723 RVA: 0x0006CBA0 File Offset: 0x0006ADA0
		[Token(Token = "0x17002725")]
		private bool NotUseStartDirection
		{
			[Token(Token = "0x6011C13")]
			[Address(RVA = "0x99A3B0", Offset = "0x998FB0", VA = "0x18099A3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06011C14 RID: 72724 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
		[Token(Token = "0x17002726")]
		private bool NotUseTargetDirection
		{
			[Token(Token = "0x6011C14")]
			[Address(RVA = "0x99A410", Offset = "0x999010", VA = "0x18099A410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06011C15 RID: 72725 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		[Token(Token = "0x17002727")]
		protected bool useConstDirection
		{
			[Token(Token = "0x6011C15")]
			[Address(RVA = "0x99A540", Offset = "0x999140", VA = "0x18099A540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06011C16 RID: 72726 RVA: 0x0006CBE8 File Offset: 0x0006ADE8
		[Token(Token = "0x17002728")]
		protected SharedConsts.Direction constDirection
		{
			[Token(Token = "0x6011C16")]
			[Address(RVA = "0x99A480", Offset = "0x999080", VA = "0x18099A480")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06011C17 RID: 72727 RVA: 0x0006CC00 File Offset: 0x0006AE00
		[Token(Token = "0x17002729")]
		protected bool withinAbilityRange
		{
			[Token(Token = "0x6011C17")]
			[Address(RVA = "0x99A5A0", Offset = "0x9991A0", VA = "0x18099A5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06011C18 RID: 72728 RVA: 0x0006CC18 File Offset: 0x0006AE18
		[Token(Token = "0x1700272A")]
		protected FarthestPointMovement.TargetHeightType targetHeightType
		{
			[Token(Token = "0x6011C18")]
			[Address(RVA = "0x99A4E0", Offset = "0x9990E0", VA = "0x18099A4E0")]
			get
			{
				return FarthestPointMovement.TargetHeightType.KEEP_ORIGIN;
			}
		}

		// Token: 0x06011C19 RID: 72729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C19")]
		[Address(RVA = "0x999AA0", Offset = "0x9986A0", VA = "0x180999AA0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C1A RID: 72730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C1A")]
		[Address(RVA = "0x999B50", Offset = "0x998750", VA = "0x180999B50")]
		private void _SetTargetPosAndDirection(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C1B RID: 72731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C1B")]
		[Address(RVA = "0x99A340", Offset = "0x998F40", VA = "0x18099A340")]
		public FarthestPointMovement()
		{
		}

		// Token: 0x06011C1C RID: 72732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C1C")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x04013EAF RID: 81583
		[Token(Token = "0x4013EAF")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private FarthestPointMovement.TargetHeightType _targetHeightType;

		// Token: 0x04013EB0 RID: 81584
		[Token(Token = "0x4013EB0")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		[Inspect("NotUseTargetDirection")]
		private bool _useStartDirection;

		// Token: 0x04013EB1 RID: 81585
		[Token(Token = "0x4013EB1")]
		[FieldOffset(Offset = "0x145")]
		[SerializeField]
		private bool _withinAbilityRange;

		// Token: 0x04013EB2 RID: 81586
		[Token(Token = "0x4013EB2")]
		[FieldOffset(Offset = "0x146")]
		[SerializeField]
		private bool _useConstDirection;

		// Token: 0x04013EB3 RID: 81587
		[Token(Token = "0x4013EB3")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Inspect("useConstDirection")]
		private SharedConsts.Direction _constDirection;

		// Token: 0x04013EB4 RID: 81588
		[Token(Token = "0x4013EB4")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private bool _useDirToTarget;

		// Token: 0x04013EB5 RID: 81589
		[Token(Token = "0x4013EB5")]
		[FieldOffset(Offset = "0x14D")]
		[SerializeField]
		private bool _removeTraceTargetAtStart;

		// Token: 0x04013EB6 RID: 81590
		[Token(Token = "0x4013EB6")]
		[FieldOffset(Offset = "0x14E")]
		[SerializeField]
		private bool _useEightWaysDirection;

		// Token: 0x04013EB7 RID: 81591
		[Token(Token = "0x4013EB7")]
		[FieldOffset(Offset = "0x14F")]
		[SerializeField]
		private bool _useTraceTargetDirection;

		// Token: 0x04013EB8 RID: 81592
		[Token(Token = "0x4013EB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_NotUseStartDirection;

		// Token: 0x04013EB9 RID: 81593
		[Token(Token = "0x4013EB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_NotUseTargetDirection;

		// Token: 0x04013EBA RID: 81594
		[Token(Token = "0x4013EBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_useConstDirection;

		// Token: 0x04013EBB RID: 81595
		[Token(Token = "0x4013EBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_constDirection;

		// Token: 0x04013EBC RID: 81596
		[Token(Token = "0x4013EBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_withinAbilityRange;

		// Token: 0x04013EBD RID: 81597
		[Token(Token = "0x4013EBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_targetHeightType;

		// Token: 0x04013EBE RID: 81598
		[Token(Token = "0x4013EBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013EBF RID: 81599
		[Token(Token = "0x4013EBF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetTargetPosAndDirection;

		// Token: 0x04013EC0 RID: 81600
		[Token(Token = "0x4013EC0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029D6 RID: 10710
		[Token(Token = "0x20029D6")]
		public enum TargetHeightType
		{
			// Token: 0x04013EC2 RID: 81602
			[Token(Token = "0x4013EC2")]
			KEEP_ORIGIN,
			// Token: 0x04013EC3 RID: 81603
			[Token(Token = "0x4013EC3")]
			SAME_AS_SOURCE,
			// Token: 0x04013EC4 RID: 81604
			[Token(Token = "0x4013EC4")]
			LOWLAND,
			// Token: 0x04013EC5 RID: 81605
			[Token(Token = "0x4013EC5")]
			HIGHLAND
		}
	}
}
