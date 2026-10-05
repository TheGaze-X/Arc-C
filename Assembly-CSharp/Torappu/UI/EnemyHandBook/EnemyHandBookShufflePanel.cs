using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F46 RID: 20294
	[Token(Token = "0x2004F46")]
	public class EnemyHandBookShufflePanel : DataBinder<EnemyHandBookShowProperty>
	{
		// Token: 0x0601E37B RID: 123771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E37B")]
		[Address(RVA = "0x17EC140", Offset = "0x17EAD40", VA = "0x1817EC140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E37C RID: 123772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E37C")]
		[Address(RVA = "0x17EBCB0", Offset = "0x17EA8B0", VA = "0x1817EBCB0")]
		public void OnCleanShuffle()
		{
		}

		// Token: 0x0601E37D RID: 123773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E37D")]
		[Address(RVA = "0x17EBDA0", Offset = "0x17EA9A0", VA = "0x1817EBDA0")]
		public void OnShow()
		{
		}

		// Token: 0x0601E37E RID: 123774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E37E")]
		[Address(RVA = "0x17EBD20", Offset = "0x17EA920", VA = "0x1817EBD20")]
		public void OnHide()
		{
		}

		// Token: 0x0601E37F RID: 123775 RVA: 0x000ADF10 File Offset: 0x000AC110
		[Token(Token = "0x601E37F")]
		[Address(RVA = "0x17EBC40", Offset = "0x17EA840", VA = "0x1817EBC40")]
		public bool IsShow()
		{
			return default(bool);
		}

		// Token: 0x0601E380 RID: 123776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E380")]
		[Address(RVA = "0x17EBE20", Offset = "0x17EAA20", VA = "0x1817EBE20", Slot = "7")]
		public override void OnValueChanged(EnemyHandBookShowProperty property)
		{
		}

		// Token: 0x0601E381 RID: 123777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E381")]
		[Address(RVA = "0x17EC580", Offset = "0x17EB180", VA = "0x1817EC580")]
		public EnemyHandBookShufflePanel()
		{
		}

		// Token: 0x04028476 RID: 164982
		[Token(Token = "0x4028476")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyHandbookBossShuffleObject _bossShuffle;

		// Token: 0x04028477 RID: 164983
		[Token(Token = "0x4028477")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyHandbookBossShuffleObject _bossShuffle2;

		// Token: 0x04028478 RID: 164984
		[Token(Token = "0x4028478")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _raceShuffleContent;

		// Token: 0x04028479 RID: 164985
		[Token(Token = "0x4028479")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _attackTypeShuffleContent;

		// Token: 0x0402847A RID: 164986
		[Token(Token = "0x402847A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _damageTypeShuffleContent;

		// Token: 0x0402847B RID: 164987
		[Token(Token = "0x402847B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _motionTypeShuffleContent;

		// Token: 0x0402847C RID: 164988
		[Token(Token = "0x402847C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _ascendingButton;

		// Token: 0x0402847D RID: 164989
		[Token(Token = "0x402847D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _haveShuffleState;

		// Token: 0x0402847E RID: 164990
		[Token(Token = "0x402847E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent _onCleanShuffle;

		// Token: 0x0402847F RID: 164991
		[Token(Token = "0x402847F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIIntEvent _damageTypeEvent;

		// Token: 0x04028480 RID: 164992
		[Token(Token = "0x4028480")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIIntEvent _attackTypeEvent;

		// Token: 0x04028481 RID: 164993
		[Token(Token = "0x4028481")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIIntEvent _motionTypeEvent;

		// Token: 0x04028482 RID: 164994
		[Token(Token = "0x4028482")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIIntEvent _raceTypeEvent;

		// Token: 0x04028483 RID: 164995
		[Token(Token = "0x4028483")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028484 RID: 164996
		[Token(Token = "0x4028484")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x04028485 RID: 164997
		[Token(Token = "0x4028485")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UnityEnemyLevelEvent _enemyLevelEvent;

		// Token: 0x04028486 RID: 164998
		[Token(Token = "0x4028486")]
		[FieldOffset(Offset = "0xA8")]
		private RaceAdatper m_raceAdapter;

		// Token: 0x04028487 RID: 164999
		[Token(Token = "0x4028487")]
		[FieldOffset(Offset = "0xB0")]
		private AttackTypeAdatper m_atAdapter;

		// Token: 0x04028488 RID: 165000
		[Token(Token = "0x4028488")]
		[FieldOffset(Offset = "0xB8")]
		private DamageTypeAdatper m_dtAdapter;

		// Token: 0x04028489 RID: 165001
		[Token(Token = "0x4028489")]
		[FieldOffset(Offset = "0xC0")]
		private MotionTypeAdatper m_mtAdapter;

		// Token: 0x0402848A RID: 165002
		[Token(Token = "0x402848A")]
		[FieldOffset(Offset = "0xC8")]
		private AnimationSwitchTween m_fadeSwitchTween;

		// Token: 0x0402848B RID: 165003
		[Token(Token = "0x402848B")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x0402848C RID: 165004
		[Token(Token = "0x402848C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402848D RID: 165005
		[Token(Token = "0x402848D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCleanShuffle;

		// Token: 0x0402848E RID: 165006
		[Token(Token = "0x402848E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0402848F RID: 165007
		[Token(Token = "0x402848F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x04028490 RID: 165008
		[Token(Token = "0x4028490")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x04028491 RID: 165009
		[Token(Token = "0x4028491")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028492 RID: 165010
		[Token(Token = "0x4028492")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
