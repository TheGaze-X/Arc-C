using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B4 RID: 18612
	[Token(Token = "0x20048B4")]
	public class SoCharMissionSimpleView : MissionSinglePage
	{
		// Token: 0x0601C13D RID: 115005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C13D")]
		[Address(RVA = "0x1572AE0", Offset = "0x15716E0", VA = "0x181572AE0", Slot = "5")]
		protected override void RefreshView()
		{
		}

		// Token: 0x0601C13E RID: 115006 RVA: 0x000A7250 File Offset: 0x000A5450
		[Token(Token = "0x601C13E")]
		[Address(RVA = "0x15727F0", Offset = "0x15713F0", VA = "0x1815727F0", Slot = "4")]
		public override bool IsToBeShown(MissionModel stateBean)
		{
			return default(bool);
		}

		// Token: 0x0601C13F RID: 115007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C13F")]
		[Address(RVA = "0x1572890", Offset = "0x1571490", VA = "0x181572890")]
		public void ReceiveAll()
		{
		}

		// Token: 0x0601C140 RID: 115008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C140")]
		[Address(RVA = "0x1572FD0", Offset = "0x1571BD0", VA = "0x181572FD0")]
		public SoCharMissionSimpleView()
		{
		}

		// Token: 0x0601C141 RID: 115009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C141")]
		[Address(RVA = "0x1564280", Offset = "0x1562E80", VA = "0x181564280")]
		private void <>xLuaBaseProxy_RefreshView()
		{
		}

		// Token: 0x0601C142 RID: 115010 RVA: 0x000A7268 File Offset: 0x000A5468
		[Token(Token = "0x601C142")]
		[Address(RVA = "0x1564210", Offset = "0x1562E10", VA = "0x181564210")]
		private bool <>xLuaBaseProxy_IsToBeShown(MissionModel P0)
		{
			return default(bool);
		}

		// Token: 0x04024AF4 RID: 150260
		[Token(Token = "0x4024AF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SoCharMissionCharInfoView _charInfoView;

		// Token: 0x04024AF5 RID: 150261
		[Token(Token = "0x4024AF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SoCharMissionRightPart _rightPart;

		// Token: 0x04024AF6 RID: 150262
		[Token(Token = "0x4024AF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SOCharMissionRouteView _routePart;

		// Token: 0x04024AF7 RID: 150263
		[Token(Token = "0x4024AF7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _receiveAllBtn;

		// Token: 0x04024AF8 RID: 150264
		[Token(Token = "0x4024AF8")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024AF9 RID: 150265
		[Token(Token = "0x4024AF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04024AFA RID: 150266
		[Token(Token = "0x4024AFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsToBeShown;

		// Token: 0x04024AFB RID: 150267
		[Token(Token = "0x4024AFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReceiveAll;

		// Token: 0x04024AFC RID: 150268
		[Token(Token = "0x4024AFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
