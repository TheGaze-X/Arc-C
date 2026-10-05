using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200337F RID: 13183
	[Token(Token = "0x200337F")]
	public class UIFollowHunterBulletSlider : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x06015072 RID: 86130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015072")]
		[Address(RVA = "0xD71320", Offset = "0xD6FF20", VA = "0x180D71320")]
		public void Init()
		{
		}

		// Token: 0x06015073 RID: 86131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015073")]
		[Address(RVA = "0xD713C0", Offset = "0xD6FFC0", VA = "0x180D713C0", Slot = "7")]
		public override void OnAllocate()
		{
		}

		// Token: 0x06015074 RID: 86132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015074")]
		[Address(RVA = "0xD710B0", Offset = "0xD6FCB0", VA = "0x180D710B0", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x06015075 RID: 86133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015075")]
		[Address(RVA = "0xD712B0", Offset = "0xD6FEB0", VA = "0x180D712B0", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06015076 RID: 86134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015076")]
		[Address(RVA = "0xD714E0", Offset = "0xD700E0", VA = "0x180D714E0")]
		public void UpdateCharacter()
		{
		}

		// Token: 0x06015077 RID: 86135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015077")]
		[Address(RVA = "0xD71A50", Offset = "0xD70650", VA = "0x180D71A50")]
		private void _FinishCountTweenIfNot()
		{
		}

		// Token: 0x06015078 RID: 86136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015078")]
		[Address(RVA = "0xD71440", Offset = "0xD70040", VA = "0x180D71440")]
		private void OnDestroy()
		{
		}

		// Token: 0x06015079 RID: 86137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015079")]
		[Address(RVA = "0xD719F0", Offset = "0xD705F0", VA = "0x180D719F0")]
		private void Update()
		{
		}

		// Token: 0x0601507A RID: 86138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601507A")]
		[Address(RVA = "0xD71B00", Offset = "0xD70700", VA = "0x180D71B00")]
		public UIFollowHunterBulletSlider()
		{
		}

		// Token: 0x0601507B RID: 86139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601507B")]
		[Address(RVA = "0xD714D0", Offset = "0xD700D0", VA = "0x180D714D0")]
		private void <>xLuaBaseProxy_OnAllocate()
		{
		}

		// Token: 0x0601507C RID: 86140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601507C")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x0601507D RID: 86141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601507D")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401905E RID: 102494
		[Token(Token = "0x401905E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBulletBar _bulletBar;

		// Token: 0x0401905F RID: 102495
		[Token(Token = "0x401905F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04019060 RID: 102496
		[Token(Token = "0x4019060")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04019061 RID: 102497
		[Token(Token = "0x4019061")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _effectRoot;

		// Token: 0x04019062 RID: 102498
		[Token(Token = "0x4019062")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x04019063 RID: 102499
		[Token(Token = "0x4019063")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _fadeOutTime;

		// Token: 0x04019064 RID: 102500
		[Token(Token = "0x4019064")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _targetAddTime;

		// Token: 0x04019065 RID: 102501
		[Token(Token = "0x4019065")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04019066 RID: 102502
		[Token(Token = "0x4019066")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasDisplayed;

		// Token: 0x04019067 RID: 102503
		[Token(Token = "0x4019067")]
		[FieldOffset(Offset = "0x6C")]
		private int m_lastCnt;

		// Token: 0x04019068 RID: 102504
		[Token(Token = "0x4019068")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_addCountTween;

		// Token: 0x04019069 RID: 102505
		[Token(Token = "0x4019069")]
		[FieldOffset(Offset = "0x78")]
		private HunterBulletBarPluginTalent m_bulletTalent;

		// Token: 0x0401906A RID: 102506
		[Token(Token = "0x401906A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401906B RID: 102507
		[Token(Token = "0x401906B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0401906C RID: 102508
		[Token(Token = "0x401906C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401906D RID: 102509
		[Token(Token = "0x401906D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401906E RID: 102510
		[Token(Token = "0x401906E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateCharacter;

		// Token: 0x0401906F RID: 102511
		[Token(Token = "0x401906F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FinishCountTweenIfNot;

		// Token: 0x04019070 RID: 102512
		[Token(Token = "0x4019070")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019071 RID: 102513
		[Token(Token = "0x4019071")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019072 RID: 102514
		[Token(Token = "0x4019072")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
