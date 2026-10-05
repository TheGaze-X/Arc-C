using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E5 RID: 31205
	[Token(Token = "0x20079E5")]
	public class Act13sideEntryButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602BBF2 RID: 179186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF2")]
		[Address(RVA = "0x279C020", Offset = "0x279AC20", VA = "0x18279C020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BBF3 RID: 179187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF3")]
		[Address(RVA = "0x279BF20", Offset = "0x279AB20", VA = "0x18279BF20")]
		public void OpenMission()
		{
		}

		// Token: 0x0602BBF4 RID: 179188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF4")]
		[Address(RVA = "0x279BFA0", Offset = "0x279ABA0", VA = "0x18279BFA0")]
		public void OpenPrestigeState()
		{
		}

		// Token: 0x0602BBF5 RID: 179189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF5")]
		[Address(RVA = "0x279BD40", Offset = "0x279A940", VA = "0x18279BD40")]
		public void OpenArchive()
		{
		}

		// Token: 0x0602BBF6 RID: 179190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF6")]
		[Address(RVA = "0x279B750", Offset = "0x279A350", VA = "0x18279B750", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BBF7 RID: 179191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF7")]
		[Address(RVA = "0x279C150", Offset = "0x279AD50", VA = "0x18279C150")]
		public Act13sideEntryButtonPlugin()
		{
		}

		// Token: 0x0403F49C RID: 259228
		[Token(Token = "0x403F49C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _activeMissionButton;

		// Token: 0x0403F49D RID: 259229
		[Token(Token = "0x403F49D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedMissionButton;

		// Token: 0x0403F49E RID: 259230
		[Token(Token = "0x403F49E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _activePrestigeButton;

		// Token: 0x0403F49F RID: 259231
		[Token(Token = "0x403F49F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lockedPrestigeButton;

		// Token: 0x0403F4A0 RID: 259232
		[Token(Token = "0x403F4A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lockedCond1;

		// Token: 0x0403F4A1 RID: 259233
		[Token(Token = "0x403F4A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _lockedCond2;

		// Token: 0x0403F4A2 RID: 259234
		[Token(Token = "0x403F4A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0403F4A3 RID: 259235
		[Token(Token = "0x403F4A3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _newMissionTrackPoint;

		// Token: 0x0403F4A4 RID: 259236
		[Token(Token = "0x403F4A4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act13sideEntryButtonPlugin.OrgPrestigeStatus[] _orgPrestigeList;

		// Token: 0x0403F4A5 RID: 259237
		[Token(Token = "0x403F4A5")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_property;

		// Token: 0x0403F4A6 RID: 259238
		[Token(Token = "0x403F4A6")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_newProperty;

		// Token: 0x0403F4A7 RID: 259239
		[Token(Token = "0x403F4A7")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403F4A8 RID: 259240
		[Token(Token = "0x403F4A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F4A9 RID: 259241
		[Token(Token = "0x403F4A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenMission;

		// Token: 0x0403F4AA RID: 259242
		[Token(Token = "0x403F4AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenPrestigeState;

		// Token: 0x0403F4AB RID: 259243
		[Token(Token = "0x403F4AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenArchive;

		// Token: 0x0403F4AC RID: 259244
		[Token(Token = "0x403F4AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F4AD RID: 259245
		[Token(Token = "0x403F4AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079E6 RID: 31206
		[Token(Token = "0x20079E6")]
		[Serializable]
		private class OrgPrestigeStatus
		{
			// Token: 0x0602BBF8 RID: 179192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OrgPrestigeStatus()
			{
			}

			// Token: 0x0403F4AE RID: 259246
			[Token(Token = "0x403F4AE")]
			[FieldOffset(Offset = "0x10")]
			public string orgId;

			// Token: 0x0403F4AF RID: 259247
			[Token(Token = "0x403F4AF")]
			[FieldOffset(Offset = "0x18")]
			public GameObject statusGo;

			// Token: 0x0403F4B0 RID: 259248
			[Token(Token = "0x403F4B0")]
			[FieldOffset(Offset = "0x20")]
			public Text textStatus;

			// Token: 0x0403F4B1 RID: 259249
			[Token(Token = "0x403F4B1")]
			[FieldOffset(Offset = "0x28")]
			public GameObject lockGo;
		}
	}
}
