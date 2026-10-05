using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049D7 RID: 18903
	[Token(Token = "0x20049D7")]
	public class LoginPreAnnounceView : SingletonMonoBehaviour<LoginPreAnnounceView>, ISingletonNotAutoCreate
	{
		// Token: 0x0601C76F RID: 116591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C76F")]
		[Address(RVA = "0x15E1F90", Offset = "0x15E0B90", VA = "0x1815E1F90", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C770 RID: 116592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C770")]
		[Address(RVA = "0x15E2270", Offset = "0x15E0E70", VA = "0x1815E2270")]
		public static void TryLaunchPreAnnounce(Action finishCB, bool forceOpen)
		{
		}

		// Token: 0x0601C771 RID: 116593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C771")]
		[Address(RVA = "0x15E2220", Offset = "0x15E0E20", VA = "0x1815E2220")]
		public static void TestOnlyLaunchPreAnnounce()
		{
		}

		// Token: 0x0601C772 RID: 116594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C772")]
		[Address(RVA = "0x15E2330", Offset = "0x15E0F30", VA = "0x1815E2330")]
		private static void _LaunchPreAnnounce(Action finishCB, bool forceOpen)
		{
		}

		// Token: 0x0601C773 RID: 116595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C773")]
		[Address(RVA = "0x15E1CA0", Offset = "0x15E08A0", VA = "0x1815E1CA0")]
		public void ClosePanel()
		{
		}

		// Token: 0x0601C774 RID: 116596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C774")]
		[Address(RVA = "0x15E2590", Offset = "0x15E1190", VA = "0x1815E2590")]
		private void _RenderAnnounce(PreAnnounceConfigData data, Action finishCB)
		{
		}

		// Token: 0x0601C775 RID: 116597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C775")]
		[Address(RVA = "0x15E2810", Offset = "0x15E1410", VA = "0x1815E2810")]
		public LoginPreAnnounceView()
		{
		}

		// Token: 0x040254C0 RID: 152768
		[Token(Token = "0x40254C0")]
		private const float FINISH_CB_DELAY = 0.2f;

		// Token: 0x040254C1 RID: 152769
		[Token(Token = "0x40254C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _renderObj;

		// Token: 0x040254C2 RID: 152770
		[Token(Token = "0x40254C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x040254C3 RID: 152771
		[Token(Token = "0x40254C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _confirmButtonText;

		// Token: 0x040254C4 RID: 152772
		[Token(Token = "0x40254C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x040254C5 RID: 152773
		[Token(Token = "0x40254C5")]
		[FieldOffset(Offset = "0x38")]
		private Action m_finishCb;

		// Token: 0x040254C6 RID: 152774
		[Token(Token = "0x40254C6")]
		[FieldOffset(Offset = "0x40")]
		private LoginPreAnnounceView.Adatper m_adapter;

		// Token: 0x040254C7 RID: 152775
		[Token(Token = "0x40254C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040254C8 RID: 152776
		[Token(Token = "0x40254C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryLaunchPreAnnounce;

		// Token: 0x040254C9 RID: 152777
		[Token(Token = "0x40254C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TestOnlyLaunchPreAnnounce;

		// Token: 0x040254CA RID: 152778
		[Token(Token = "0x40254CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LaunchPreAnnounce;

		// Token: 0x040254CB RID: 152779
		[Token(Token = "0x40254CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClosePanel;

		// Token: 0x040254CC RID: 152780
		[Token(Token = "0x40254CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderAnnounce;

		// Token: 0x040254CD RID: 152781
		[Token(Token = "0x40254CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049D8 RID: 18904
		[Token(Token = "0x20049D8")]
		private class Adatper : SimpleLayoutAdapter
		{
			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0601C777 RID: 116599 RVA: 0x000A8798 File Offset: 0x000A6998
			[Token(Token = "0x17004360")]
			public override int count
			{
				[Token(Token = "0x601C777")]
				[Address(RVA = "0x15DCC20", Offset = "0x15DB820", VA = "0x1815DCC20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C778 RID: 116600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C778")]
			[Address(RVA = "0x15DCA00", Offset = "0x15DB600", VA = "0x1815DCA00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C779 RID: 116601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C779")]
			[Address(RVA = "0x15DCBC0", Offset = "0x15DB7C0", VA = "0x1815DCBC0")]
			public Adatper()
			{
			}

			// Token: 0x040254CE RID: 152782
			[Token(Token = "0x40254CE")]
			[FieldOffset(Offset = "0x20")]
			public List<string> stringList;

			// Token: 0x040254CF RID: 152783
			[Token(Token = "0x40254CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040254D0 RID: 152784
			[Token(Token = "0x40254D0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040254D1 RID: 152785
			[Token(Token = "0x40254D1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
