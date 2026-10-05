using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002687 RID: 9863
	[Token(Token = "0x2002687")]
	public class UIBattleVecBreakBossShieldPlugin : UnitHudPluginManager.HudPlugin
	{
		// Token: 0x060101B8 RID: 65976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B8")]
		[Address(RVA = "0x7D4C10", Offset = "0x7D3810", VA = "0x1807D4C10")]
		private void Start()
		{
		}

		// Token: 0x060101B9 RID: 65977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101B9")]
		[Address(RVA = "0x7D4C80", Offset = "0x7D3880", VA = "0x1807D4C80")]
		private void Update()
		{
		}

		// Token: 0x060101BA RID: 65978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101BA")]
		[Address(RVA = "0x7D5290", Offset = "0x7D3E90", VA = "0x1807D5290")]
		private void _OnShieldShown()
		{
		}

		// Token: 0x060101BB RID: 65979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101BB")]
		[Address(RVA = "0x7D5100", Offset = "0x7D3D00", VA = "0x1807D5100")]
		private void _OnShieldBreak()
		{
		}

		// Token: 0x060101BC RID: 65980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101BC")]
		[Address(RVA = "0x7D5350", Offset = "0x7D3F50", VA = "0x1807D5350")]
		public UIBattleVecBreakBossShieldPlugin()
		{
		}

		// Token: 0x04011F05 RID: 73477
		[Token(Token = "0x4011F05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("UI Option")]
		private GameObject _progressPanel;

		// Token: 0x04011F06 RID: 73478
		[Token(Token = "0x4011F06")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("UI Option")]
		private Image _progress;

		// Token: 0x04011F07 RID: 73479
		[Token(Token = "0x4011F07")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("UI Option")]
		private UIAnimationLocation _animation;

		// Token: 0x04011F08 RID: 73480
		[Token(Token = "0x4011F08")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Buff Option")]
		private string _buffKey;

		// Token: 0x04011F09 RID: 73481
		[Token(Token = "0x4011F09")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Buff Option")]
		private string _maxValuekey;

		// Token: 0x04011F0A RID: 73482
		[Token(Token = "0x4011F0A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Buff Option")]
		private string _valuekey;

		// Token: 0x04011F0B RID: 73483
		[Token(Token = "0x4011F0B")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x04011F0C RID: 73484
		[Token(Token = "0x4011F0C")]
		[FieldOffset(Offset = "0x70")]
		private float m_maxTimes;

		// Token: 0x04011F0D RID: 73485
		[Token(Token = "0x4011F0D")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isShow;

		// Token: 0x04011F0E RID: 73486
		[Token(Token = "0x4011F0E")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tween;

		// Token: 0x04011F0F RID: 73487
		[Token(Token = "0x4011F0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04011F10 RID: 73488
		[Token(Token = "0x4011F10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04011F11 RID: 73489
		[Token(Token = "0x4011F11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnShieldShown;

		// Token: 0x04011F12 RID: 73490
		[Token(Token = "0x4011F12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnShieldBreak;

		// Token: 0x04011F13 RID: 73491
		[Token(Token = "0x4011F13")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
