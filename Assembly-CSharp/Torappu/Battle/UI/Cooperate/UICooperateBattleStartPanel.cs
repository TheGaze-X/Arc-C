using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033D3 RID: 13267
	[Token(Token = "0x20033D3")]
	public class UICooperateBattleStartPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060152CF RID: 86735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CF")]
		[Address(RVA = "0xDA1820", Offset = "0xDA0420", VA = "0x180DA1820")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x060152D0 RID: 86736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D0")]
		[Address(RVA = "0xDA1770", Offset = "0xDA0370", VA = "0x180DA1770")]
		public void Init()
		{
		}

		// Token: 0x060152D1 RID: 86737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D1")]
		[Address(RVA = "0xDA1BB0", Offset = "0xDA07B0", VA = "0x180DA1BB0")]
		public void ShowStart(Action finishCb)
		{
		}

		// Token: 0x060152D2 RID: 86738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D2")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0700", VA = "0x180DA1B00")]
		public void ShowLoop()
		{
		}

		// Token: 0x060152D3 RID: 86739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D3")]
		[Address(RVA = "0xDA19B0", Offset = "0xDA05B0", VA = "0x180DA19B0")]
		public void ShowEnd(Action finishCb)
		{
		}

		// Token: 0x060152D4 RID: 86740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D4")]
		[Address(RVA = "0xDA1700", Offset = "0xDA0300", VA = "0x180DA1700")]
		private void Awake()
		{
		}

		// Token: 0x060152D5 RID: 86741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D5")]
		[Address(RVA = "0xDA1C70", Offset = "0xDA0870", VA = "0x180DA1C70")]
		private void Start()
		{
		}

		// Token: 0x060152D6 RID: 86742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D6")]
		[Address(RVA = "0xDA1E20", Offset = "0xDA0A20", VA = "0x180DA1E20")]
		private void Update()
		{
		}

		// Token: 0x060152D7 RID: 86743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D7")]
		[Address(RVA = "0xDA1EE0", Offset = "0xDA0AE0", VA = "0x180DA1EE0")]
		public UICooperateBattleStartPanel()
		{
		}

		// Token: 0x0401945A RID: 103514
		[Token(Token = "0x401945A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIStageInfo _stageInfo;

		// Token: 0x0401945B RID: 103515
		[Token(Token = "0x401945B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x0401945C RID: 103516
		[Token(Token = "0x401945C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _startClip;

		// Token: 0x0401945D RID: 103517
		[Token(Token = "0x401945D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationClip _loopClip;

		// Token: 0x0401945E RID: 103518
		[Token(Token = "0x401945E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationClip _endClip;

		// Token: 0x0401945F RID: 103519
		[Token(Token = "0x401945F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_startToPlay;

		// Token: 0x04019460 RID: 103520
		[Token(Token = "0x4019460")]
		[FieldOffset(Offset = "0x48")]
		private Action m_finishCb;

		// Token: 0x04019461 RID: 103521
		[Token(Token = "0x4019461")]
		[FieldOffset(Offset = "0x50")]
		private FP m_progress;

		// Token: 0x04019462 RID: 103522
		[Token(Token = "0x4019462")]
		[FieldOffset(Offset = "0x58")]
		private AnimationState m_animationState;

		// Token: 0x04019463 RID: 103523
		[Token(Token = "0x4019463")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04019464 RID: 103524
		[Token(Token = "0x4019464")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019465 RID: 103525
		[Token(Token = "0x4019465")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowStart;

		// Token: 0x04019466 RID: 103526
		[Token(Token = "0x4019466")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowLoop;

		// Token: 0x04019467 RID: 103527
		[Token(Token = "0x4019467")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowEnd;

		// Token: 0x04019468 RID: 103528
		[Token(Token = "0x4019468")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019469 RID: 103529
		[Token(Token = "0x4019469")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401946A RID: 103530
		[Token(Token = "0x401946A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401946B RID: 103531
		[Token(Token = "0x401946B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
