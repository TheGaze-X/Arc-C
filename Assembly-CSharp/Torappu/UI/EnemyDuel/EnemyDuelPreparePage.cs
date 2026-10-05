using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005023 RID: 20515
	[Token(Token = "0x2005023")]
	public class EnemyDuelPreparePage : StateEnginePage
	{
		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x0601E6DE RID: 124638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700470B")]
		public string actId
		{
			[Token(Token = "0x601E6DE")]
			[Address(RVA = "0x1827E60", Offset = "0x1826A60", VA = "0x181827E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x0601E6DF RID: 124639 RVA: 0x000AE6C0 File Offset: 0x000AC8C0
		[Token(Token = "0x1700470C")]
		public bool isRoom
		{
			[Token(Token = "0x601E6DF")]
			[Address(RVA = "0x1828120", Offset = "0x1826D20", VA = "0x181828120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x0601E6E0 RID: 124640 RVA: 0x000AE6D8 File Offset: 0x000AC8D8
		[Token(Token = "0x1700470D")]
		public bool hadJoinRoom
		{
			[Token(Token = "0x601E6E0")]
			[Address(RVA = "0x1827FD0", Offset = "0x1826BD0", VA = "0x181827FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x0601E6E1 RID: 124641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700470E")]
		public string initModeId
		{
			[Token(Token = "0x601E6E1")]
			[Address(RVA = "0x1828090", Offset = "0x1826C90", VA = "0x181828090")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x0601E6E2 RID: 124642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700470F")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601E6E2")]
			[Address(RVA = "0x1827F70", Offset = "0x1826B70", VA = "0x181827F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E6E3 RID: 124643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6E3")]
		[Address(RVA = "0x1827B70", Offset = "0x1826770", VA = "0x181827B70", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601E6E4 RID: 124644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6E4")]
		[Address(RVA = "0x1827C60", Offset = "0x1826860", VA = "0x181827C60", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601E6E5 RID: 124645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6E5")]
		[Address(RVA = "0x1827AC0", Offset = "0x18266C0", VA = "0x181827AC0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601E6E6 RID: 124646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6E6")]
		[Address(RVA = "0x1827D50", Offset = "0x1826950", VA = "0x181827D50")]
		private IEnumerator _RouteToRoomState()
		{
			return null;
		}

		// Token: 0x0601E6E7 RID: 124647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6E7")]
		[Address(RVA = "0x1827E00", Offset = "0x1826A00", VA = "0x181827E00")]
		public EnemyDuelPreparePage()
		{
		}

		// Token: 0x0601E6E9 RID: 124649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6E9")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601E6EA RID: 124650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6EA")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0601E6EB RID: 124651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6EB")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04028BA6 RID: 166822
		[Token(Token = "0x4028BA6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04028BA7 RID: 166823
		[Token(Token = "0x4028BA7")]
		[FieldOffset(Offset = "0xF8")]
		private DataBundle m_savedInst;

		// Token: 0x04028BA8 RID: 166824
		[Token(Token = "0x4028BA8")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_diaglogMgr;

		// Token: 0x04028BA9 RID: 166825
		[Token(Token = "0x4028BA9")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isListeningTeamServer;

		// Token: 0x04028BAA RID: 166826
		[Token(Token = "0x4028BAA")]
		[FieldOffset(Offset = "0x109")]
		private bool m_hasAlertedTeamDIsconnect;

		// Token: 0x04028BAB RID: 166827
		[Token(Token = "0x4028BAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04028BAC RID: 166828
		[Token(Token = "0x4028BAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRoom;

		// Token: 0x04028BAD RID: 166829
		[Token(Token = "0x4028BAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hadJoinRoom;

		// Token: 0x04028BAE RID: 166830
		[Token(Token = "0x4028BAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_initModeId;

		// Token: 0x04028BAF RID: 166831
		[Token(Token = "0x4028BAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04028BB0 RID: 166832
		[Token(Token = "0x4028BB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04028BB1 RID: 166833
		[Token(Token = "0x4028BB1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04028BB2 RID: 166834
		[Token(Token = "0x4028BB2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04028BB3 RID: 166835
		[Token(Token = "0x4028BB3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RouteToRoomState;

		// Token: 0x04028BB4 RID: 166836
		[Token(Token = "0x4028BB4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005024 RID: 20516
		[Token(Token = "0x2005024")]
		public class Param
		{
			// Token: 0x0601E6EC RID: 124652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E6EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04028BB5 RID: 166837
			[Token(Token = "0x4028BB5")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04028BB6 RID: 166838
			[Token(Token = "0x4028BB6")]
			[FieldOffset(Offset = "0x18")]
			public bool isRoom;

			// Token: 0x04028BB7 RID: 166839
			[Token(Token = "0x4028BB7")]
			[FieldOffset(Offset = "0x19")]
			public bool hadJoinRoom;
		}
	}
}
