using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E83 RID: 7811
	[Token(Token = "0x2001E83")]
	public class AVGBlockerPanel : ExecutorComponent, IFadeTimeRatio
	{
		// Token: 0x0600C177 RID: 49527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C177")]
		[Address(RVA = "0x33D3390", Offset = "0x33D1F90", VA = "0x1833D3390", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C178 RID: 49528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C178")]
		[Address(RVA = "0x33D35E0", Offset = "0x33D21E0", VA = "0x1833D35E0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C179 RID: 49529 RVA: 0x000470B8 File Offset: 0x000452B8
		[Token(Token = "0x600C179")]
		[Address(RVA = "0x33D3A90", Offset = "0x33D2690", VA = "0x1833D3A90")]
		private bool _ExecuteBlocker(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C17A RID: 49530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C17A")]
		[Address(RVA = "0x33D43A0", Offset = "0x33D2FA0", VA = "0x1833D43A0")]
		private Tween _GenTweenerWithParam(Color targetColor, float fadetime, int blockerStyle)
		{
			return null;
		}

		// Token: 0x0600C17B RID: 49531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17B")]
		[Address(RVA = "0x33D3930", Offset = "0x33D2530", VA = "0x1833D3930")]
		private void _CleanMaterial()
		{
		}

		// Token: 0x0600C17C RID: 49532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17C")]
		[Address(RVA = "0x33D4690", Offset = "0x33D3290", VA = "0x1833D4690")]
		private void _SetMaterial(string resPath)
		{
		}

		// Token: 0x0600C17D RID: 49533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17D")]
		[Address(RVA = "0x33D37D0", Offset = "0x33D23D0", VA = "0x1833D37D0")]
		private void _ChangeBlockerImg(string imgName, int blockerStyle)
		{
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x000470D0 File Offset: 0x000452D0
		[Token(Token = "0x600C17E")]
		[Address(RVA = "0x33D39C0", Offset = "0x33D25C0", VA = "0x1833D39C0")]
		private static int _ConvertBlockerStyle(string style)
		{
			return 0;
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17F")]
		[Address(RVA = "0x33D4620", Offset = "0x33D3220", VA = "0x1833D4620")]
		private void _ResetBlockerImg()
		{
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C180")]
		[Address(RVA = "0x33D3330", Offset = "0x33D1F30", VA = "0x1833D3330", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C181")]
		[Address(RVA = "0x33D3550", Offset = "0x33D2150", VA = "0x1833D3550", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C182 RID: 49538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C182")]
		[Address(RVA = "0x33D4290", Offset = "0x33D2E90", VA = "0x1833D4290")]
		private void _FinishCommand()
		{
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x000470E8 File Offset: 0x000452E8
		[Token(Token = "0x600C183")]
		[Address(RVA = "0x33D3290", Offset = "0x33D1E90", VA = "0x1833D3290", Slot = "13")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C184 RID: 49540 RVA: 0x00047100 File Offset: 0x00045300
		[Token(Token = "0x600C184")]
		[Address(RVA = "0x33D34B0", Offset = "0x33D20B0", VA = "0x1833D34B0", Slot = "14")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C185")]
		[Address(RVA = "0x33D4830", Offset = "0x33D3430", VA = "0x1833D4830")]
		public AVGBlockerPanel()
		{
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C186")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C187")]
		[Address(RVA = "0x33D3770", Offset = "0x33D2370", VA = "0x1833D3770")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C2EC RID: 49900
		[Token(Token = "0x400C2EC")]
		private const int BLOCKER_STYLE_DEFAULT = 0;

		// Token: 0x0400C2ED RID: 49901
		[Token(Token = "0x400C2ED")]
		private const int BLOCKER_STYLE_SLIDER = 1;

		// Token: 0x0400C2EE RID: 49902
		[Token(Token = "0x400C2EE")]
		private const int BLOCKER_STYLE_SLIDER_VERTICAL = 2;

		// Token: 0x0400C2EF RID: 49903
		[Token(Token = "0x400C2EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _blocker;

		// Token: 0x0400C2F0 RID: 49904
		[Token(Token = "0x400C2F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _defaultFadetime;

		// Token: 0x0400C2F1 RID: 49905
		[Token(Token = "0x400C2F1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite _defaultBlocker;

		// Token: 0x0400C2F2 RID: 49906
		[Token(Token = "0x400C2F2")]
		private const string STYLE_DEFAULT = "defualt";

		// Token: 0x0400C2F3 RID: 49907
		[Token(Token = "0x400C2F3")]
		private const string STYLE_SLIDER = "slider";

		// Token: 0x0400C2F4 RID: 49908
		[Token(Token = "0x400C2F4")]
		private const string STYLE_SLIDER_VERTICAL = "verticalslider";

		// Token: 0x0400C2F5 RID: 49909
		[Token(Token = "0x400C2F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C2F6 RID: 49910
		[Token(Token = "0x400C2F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C2F7 RID: 49911
		[Token(Token = "0x400C2F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteBlocker;

		// Token: 0x0400C2F8 RID: 49912
		[Token(Token = "0x400C2F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenTweenerWithParam;

		// Token: 0x0400C2F9 RID: 49913
		[Token(Token = "0x400C2F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CleanMaterial;

		// Token: 0x0400C2FA RID: 49914
		[Token(Token = "0x400C2FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetMaterial;

		// Token: 0x0400C2FB RID: 49915
		[Token(Token = "0x400C2FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ChangeBlockerImg;

		// Token: 0x0400C2FC RID: 49916
		[Token(Token = "0x400C2FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConvertBlockerStyle;

		// Token: 0x0400C2FD RID: 49917
		[Token(Token = "0x400C2FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ResetBlockerImg;

		// Token: 0x0400C2FE RID: 49918
		[Token(Token = "0x400C2FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C2FF RID: 49919
		[Token(Token = "0x400C2FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C300 RID: 49920
		[Token(Token = "0x400C300")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FinishCommand;

		// Token: 0x0400C301 RID: 49921
		[Token(Token = "0x400C301")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C302 RID: 49922
		[Token(Token = "0x400C302")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C303 RID: 49923
		[Token(Token = "0x400C303")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E84 RID: 7812
		[Token(Token = "0x2001E84")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C188 RID: 49544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C188")]
			[Address(RVA = "0x33EA200", Offset = "0x33E8E00", VA = "0x1833EA200", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C189 RID: 49545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C189")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InternalResRefCollector()
			{
			}
		}
	}
}
