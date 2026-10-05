using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064A2 RID: 25762
	[Token(Token = "0x20064A2")]
	public class AutoChessBattleUIRoundResultDialog : UICompDialog<AutoChessBattleUIRoundResultDialog.Input>
	{
		// Token: 0x060250A9 RID: 151721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250A9")]
		[Address(RVA = "0x1FECE70", Offset = "0x1FEBA70", VA = "0x181FECE70", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIRoundResultDialog.Input input)
		{
		}

		// Token: 0x060250AA RID: 151722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250AA")]
		[Address(RVA = "0x1FED210", Offset = "0x1FEBE10", VA = "0x181FED210")]
		public AutoChessBattleUIRoundResultDialog()
		{
		}

		// Token: 0x04033DB9 RID: 212409
		[Token(Token = "0x4033DB9")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float MAX_SHOW_TIME;

		// Token: 0x04033DBA RID: 212410
		[Token(Token = "0x4033DBA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelPerfect;

		// Token: 0x04033DBB RID: 212411
		[Token(Token = "0x4033DBB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelMiss;

		// Token: 0x04033DBC RID: 212412
		[Token(Token = "0x4033DBC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtLostHp;

		// Token: 0x04033DBD RID: 212413
		[Token(Token = "0x4033DBD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _perfectAnimLocation;

		// Token: 0x04033DBE RID: 212414
		[Token(Token = "0x4033DBE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _missAnimLocation;

		// Token: 0x04033DBF RID: 212415
		[Token(Token = "0x4033DBF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _allPrefectAnimLocation;

		// Token: 0x04033DC0 RID: 212416
		[Token(Token = "0x4033DC0")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_tween;

		// Token: 0x04033DC1 RID: 212417
		[Token(Token = "0x4033DC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DC2 RID: 212418
		[Token(Token = "0x4033DC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064A3 RID: 25763
		[Token(Token = "0x20064A3")]
		public class Input
		{
			// Token: 0x060250AD RID: 151725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250AD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033DC3 RID: 212419
			[Token(Token = "0x4033DC3")]
			[FieldOffset(Offset = "0x10")]
			public int lostHp;

			// Token: 0x04033DC4 RID: 212420
			[Token(Token = "0x4033DC4")]
			[FieldOffset(Offset = "0x14")]
			public bool isAllPrefect;
		}
	}
}
