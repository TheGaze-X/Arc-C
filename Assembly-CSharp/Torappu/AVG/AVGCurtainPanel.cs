using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E9C RID: 7836
	[Token(Token = "0x2001E9C")]
	public class AVGCurtainPanel : ExecutorComponent, IFadeTimeRatio
	{
		// Token: 0x0600C215 RID: 49685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C215")]
		[Address(RVA = "0x33F4AB0", Offset = "0x33F36B0", VA = "0x1833F4AB0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C216")]
		[Address(RVA = "0x33F4D90", Offset = "0x33F3990", VA = "0x1833F4D90", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C217")]
		[Address(RVA = "0x33F5940", Offset = "0x33F4540", VA = "0x1833F5940")]
		private void _ResetCurtains()
		{
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C218")]
		[Address(RVA = "0x33F5730", Offset = "0x33F4330", VA = "0x1833F5730")]
		private void _HideAllCurtains(float fadetime)
		{
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C219")]
		[Address(RVA = "0x33F5860", Offset = "0x33F4460", VA = "0x1833F5860")]
		private void _RecycleCurtains()
		{
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x00047388 File Offset: 0x00045588
		[Token(Token = "0x600C21A")]
		[Address(RVA = "0x33F4E10", Offset = "0x33F3A10", VA = "0x1833F4E10")]
		private bool _ExecuteCurtain(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x000473A0 File Offset: 0x000455A0
		[Token(Token = "0x600C21B")]
		[Address(RVA = "0x33F5610", Offset = "0x33F4210", VA = "0x1833F5610")]
		private Vector2 _GenSizeDeltaWithMultiplior(Vector2 originSize, int idx, float multiplier)
		{
			return default(Vector2);
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21C")]
		[Address(RVA = "0x33F4A50", Offset = "0x33F3650", VA = "0x1833F4A50", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21D")]
		[Address(RVA = "0x33F4C70", Offset = "0x33F3870", VA = "0x1833F4C70", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x000473B8 File Offset: 0x000455B8
		[Token(Token = "0x600C21E")]
		[Address(RVA = "0x33F49B0", Offset = "0x33F35B0", VA = "0x1833F49B0", Slot = "13")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x000473D0 File Offset: 0x000455D0
		[Token(Token = "0x600C21F")]
		[Address(RVA = "0x33F4BD0", Offset = "0x33F37D0", VA = "0x1833F4BD0", Slot = "14")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C220")]
		[Address(RVA = "0x33F5A20", Offset = "0x33F4620", VA = "0x1833F5A20")]
		public AVGCurtainPanel()
		{
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C221")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C222")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C3CE RID: 50126
		[Token(Token = "0x400C3CE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _defaultFadetime;

		// Token: 0x0400C3CF RID: 50127
		[Token(Token = "0x400C3CF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGCurtain[] _curtainWidgets;

		// Token: 0x0400C3D0 RID: 50128
		[Token(Token = "0x400C3D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C3D1 RID: 50129
		[Token(Token = "0x400C3D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C3D2 RID: 50130
		[Token(Token = "0x400C3D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetCurtains;

		// Token: 0x0400C3D3 RID: 50131
		[Token(Token = "0x400C3D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAllCurtains;

		// Token: 0x0400C3D4 RID: 50132
		[Token(Token = "0x400C3D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RecycleCurtains;

		// Token: 0x0400C3D5 RID: 50133
		[Token(Token = "0x400C3D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteCurtain;

		// Token: 0x0400C3D6 RID: 50134
		[Token(Token = "0x400C3D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenSizeDeltaWithMultiplior;

		// Token: 0x0400C3D7 RID: 50135
		[Token(Token = "0x400C3D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C3D8 RID: 50136
		[Token(Token = "0x400C3D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C3D9 RID: 50137
		[Token(Token = "0x400C3D9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C3DA RID: 50138
		[Token(Token = "0x400C3DA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C3DB RID: 50139
		[Token(Token = "0x400C3DB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E9D RID: 7837
		[Token(Token = "0x2001E9D")]
		private enum CurtainDirection
		{
			// Token: 0x0400C3DD RID: 50141
			[Token(Token = "0x400C3DD")]
			TOP,
			// Token: 0x0400C3DE RID: 50142
			[Token(Token = "0x400C3DE")]
			TOP_RIGHT,
			// Token: 0x0400C3DF RID: 50143
			[Token(Token = "0x400C3DF")]
			RIGHT,
			// Token: 0x0400C3E0 RID: 50144
			[Token(Token = "0x400C3E0")]
			BOTTOM_RIGHT,
			// Token: 0x0400C3E1 RID: 50145
			[Token(Token = "0x400C3E1")]
			BOTTOM,
			// Token: 0x0400C3E2 RID: 50146
			[Token(Token = "0x400C3E2")]
			BOTTOM_LEFT,
			// Token: 0x0400C3E3 RID: 50147
			[Token(Token = "0x400C3E3")]
			LEFT,
			// Token: 0x0400C3E4 RID: 50148
			[Token(Token = "0x400C3E4")]
			TOP_LEFT
		}
	}
}
