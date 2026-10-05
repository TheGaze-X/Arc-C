using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200510E RID: 20750
	[Token(Token = "0x200510E")]
	public class DeepSeaRPBattlePreviewConfigController : DataBinder<DeepSeaRPBattleNodeConfigProperty>
	{
		// Token: 0x0601EA44 RID: 125508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA44")]
		[Address(RVA = "0x184FE10", Offset = "0x184EA10", VA = "0x18184FE10")]
		public void OnAutoBattleLocked()
		{
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x0601EA45 RID: 125509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004770")]
		protected UIPage page
		{
			[Token(Token = "0x601EA45")]
			[Address(RVA = "0x18503F0", Offset = "0x184EFF0", VA = "0x1818503F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EA46 RID: 125510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA46")]
		[Address(RVA = "0x18501D0", Offset = "0x184EDD0", VA = "0x1818501D0")]
		public void Setup(UIPage page)
		{
		}

		// Token: 0x0601EA47 RID: 125511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA47")]
		[Address(RVA = "0x184FEA0", Offset = "0x184EAA0", VA = "0x18184FEA0", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPBattleNodeConfigProperty property)
		{
		}

		// Token: 0x0601EA48 RID: 125512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA48")]
		[Address(RVA = "0x1850250", Offset = "0x184EE50", VA = "0x181850250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EA49 RID: 125513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA49")]
		[Address(RVA = "0x1850380", Offset = "0x184EF80", VA = "0x181850380")]
		public DeepSeaRPBattlePreviewConfigController()
		{
		}

		// Token: 0x04029169 RID: 168297
		[Token(Token = "0x4029169")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _btnHard;

		// Token: 0x0402916A RID: 168298
		[Token(Token = "0x402916A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnHardLocked;

		// Token: 0x0402916B RID: 168299
		[Token(Token = "0x402916B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _btnPractice;

		// Token: 0x0402916C RID: 168300
		[Token(Token = "0x402916C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _btnAutoBattle;

		// Token: 0x0402916D RID: 168301
		[Token(Token = "0x402916D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnAutoBattleLocked;

		// Token: 0x0402916E RID: 168302
		[Token(Token = "0x402916E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnReplayStory;

		// Token: 0x0402916F RID: 168303
		[Token(Token = "0x402916F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StagePreviewApStatusBinder _apStatusView;

		// Token: 0x04029170 RID: 168304
		[Token(Token = "0x4029170")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04029171 RID: 168305
		[Token(Token = "0x4029171")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isAutoBattleUnlocked;

		// Token: 0x04029172 RID: 168306
		[Token(Token = "0x4029172")]
		[FieldOffset(Offset = "0x60")]
		private UIPage m_page;

		// Token: 0x04029173 RID: 168307
		[Token(Token = "0x4029173")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAutoBattleLocked;

		// Token: 0x04029174 RID: 168308
		[Token(Token = "0x4029174")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04029175 RID: 168309
		[Token(Token = "0x4029175")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04029176 RID: 168310
		[Token(Token = "0x4029176")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029177 RID: 168311
		[Token(Token = "0x4029177")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029178 RID: 168312
		[Token(Token = "0x4029178")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
