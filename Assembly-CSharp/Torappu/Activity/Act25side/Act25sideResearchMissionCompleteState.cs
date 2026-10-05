using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074FA RID: 29946
	[Token(Token = "0x20074FA")]
	public class Act25sideResearchMissionCompleteState : PopupFloatState, IHotfixable
	{
		// Token: 0x0602A34B RID: 172875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A34B")]
		[Address(RVA = "0x25E3A70", Offset = "0x25E2670", VA = "0x1825E3A70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A34C RID: 172876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A34C")]
		[Address(RVA = "0x25E3BE0", Offset = "0x25E27E0", VA = "0x1825E3BE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A34D RID: 172877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A34D")]
		[Address(RVA = "0x25E3D60", Offset = "0x25E2960", VA = "0x1825E3D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A34E RID: 172878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A34E")]
		[Address(RVA = "0x25E3F80", Offset = "0x25E2B80", VA = "0x1825E3F80")]
		private void _PlayAnim()
		{
		}

		// Token: 0x0602A34F RID: 172879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A34F")]
		[Address(RVA = "0x25E4170", Offset = "0x25E2D70", VA = "0x1825E4170")]
		private void _Render()
		{
		}

		// Token: 0x0602A350 RID: 172880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A350")]
		[Address(RVA = "0x25E3E80", Offset = "0x25E2A80", VA = "0x1825E3E80")]
		private Sprite _LoadIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0602A351 RID: 172881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A351")]
		[Address(RVA = "0x25E3AD0", Offset = "0x25E26D0", VA = "0x1825E3AD0")]
		public void OnDismiss()
		{
		}

		// Token: 0x0602A352 RID: 172882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A352")]
		[Address(RVA = "0x25E44F0", Offset = "0x25E30F0", VA = "0x1825E44F0")]
		public Act25sideResearchMissionCompleteState()
		{
		}

		// Token: 0x0602A353 RID: 172883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A353")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CA61 RID: 248417
		[Token(Token = "0x403CA61")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403CA62 RID: 248418
		[Token(Token = "0x403CA62")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _areaName;

		// Token: 0x0403CA63 RID: 248419
		[Token(Token = "0x403CA63")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _progress;

		// Token: 0x0403CA64 RID: 248420
		[Token(Token = "0x403CA64")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _max;

		// Token: 0x0403CA65 RID: 248421
		[Token(Token = "0x403CA65")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CA66 RID: 248422
		[Token(Token = "0x403CA66")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403CA67 RID: 248423
		[Token(Token = "0x403CA67")]
		[FieldOffset(Offset = "0xA8")]
		private Act25sideResearchMissionCompleteStateBean m_stateBean;

		// Token: 0x0403CA68 RID: 248424
		[Token(Token = "0x403CA68")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedAudSig;

		// Token: 0x0403CA69 RID: 248425
		[Token(Token = "0x403CA69")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_cachedTween;

		// Token: 0x0403CA6A RID: 248426
		[Token(Token = "0x403CA6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA6B RID: 248427
		[Token(Token = "0x403CA6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA6C RID: 248428
		[Token(Token = "0x403CA6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA6D RID: 248429
		[Token(Token = "0x403CA6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403CA6E RID: 248430
		[Token(Token = "0x403CA6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403CA6F RID: 248431
		[Token(Token = "0x403CA6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x0403CA70 RID: 248432
		[Token(Token = "0x403CA70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDismiss;

		// Token: 0x0403CA71 RID: 248433
		[Token(Token = "0x403CA71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
