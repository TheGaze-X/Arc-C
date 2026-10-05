using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C79 RID: 19577
	[Token(Token = "0x2004C79")]
	public class OpenServerMainView : OpenServerMainAbstractView
	{
		// Token: 0x0601D5BB RID: 120251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5BB")]
		[Address(RVA = "0x16EB810", Offset = "0x16EA410", VA = "0x1816EB810", Slot = "4")]
		public override void Render()
		{
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5BC")]
		[Address(RVA = "0x16EBC40", Offset = "0x16EA840", VA = "0x1816EBC40", Slot = "5")]
		public override void UpdateWithType(OpenServerFuncType funcType)
		{
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5BD")]
		[Address(RVA = "0x16EBD10", Offset = "0x16EA910", VA = "0x1816EBD10")]
		private void _UpdateTrackPoint()
		{
		}

		// Token: 0x0601D5BE RID: 120254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5BE")]
		[Address(RVA = "0x16EB360", Offset = "0x16E9F60", VA = "0x1816EB360")]
		public void OnChainLoginClick()
		{
		}

		// Token: 0x0601D5BF RID: 120255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5BF")]
		[Address(RVA = "0x16EB4F0", Offset = "0x16EA0F0", VA = "0x1816EB4F0")]
		public void OnMissionClick()
		{
		}

		// Token: 0x0601D5C0 RID: 120256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C0")]
		[Address(RVA = "0x16EB680", Offset = "0x16EA280", VA = "0x1816EB680")]
		public void OnTotalCheckClick()
		{
		}

		// Token: 0x0601D5C1 RID: 120257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C1")]
		[Address(RVA = "0x16EB2C0", Offset = "0x16E9EC0", VA = "0x1816EB2C0")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x0601D5C2 RID: 120258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C2")]
		[Address(RVA = "0x16EBA40", Offset = "0x16EA640", VA = "0x1816EBA40")]
		public void SendGetChain(int rewardIndex)
		{
		}

		// Token: 0x0601D5C3 RID: 120259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C3")]
		[Address(RVA = "0x16EBB40", Offset = "0x16EA740", VA = "0x1816EBB40")]
		public void SendGetCheckIn(int rewardIndex)
		{
		}

		// Token: 0x0601D5C4 RID: 120260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C4")]
		[Address(RVA = "0x16EB940", Offset = "0x16EA540", VA = "0x1816EB940")]
		public void SendConfirmMissionRequest(string missionId)
		{
		}

		// Token: 0x0601D5C5 RID: 120261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C5")]
		[Address(RVA = "0x16EBE40", Offset = "0x16EAA40", VA = "0x1816EBE40")]
		public OpenServerMainView()
		{
		}

		// Token: 0x04026A0D RID: 158221
		[Token(Token = "0x4026A0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OpenServerChainLoginView _chainLoginView;

		// Token: 0x04026A0E RID: 158222
		[Token(Token = "0x4026A0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private OpenServerTotalCheckInView _totalCheckInView;

		// Token: 0x04026A0F RID: 158223
		[Token(Token = "0x4026A0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OpenServerMissionView _missionView;

		// Token: 0x04026A10 RID: 158224
		[Token(Token = "0x4026A10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _missionTab;

		// Token: 0x04026A11 RID: 158225
		[Token(Token = "0x4026A11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _totalCheckInTab;

		// Token: 0x04026A12 RID: 158226
		[Token(Token = "0x4026A12")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _chainLoginTab;

		// Token: 0x04026A13 RID: 158227
		[Token(Token = "0x4026A13")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _missionTrack;

		// Token: 0x04026A14 RID: 158228
		[Token(Token = "0x4026A14")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _chainLoginTrack;

		// Token: 0x04026A15 RID: 158229
		[Token(Token = "0x4026A15")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _totalCheckInTrack;

		// Token: 0x04026A16 RID: 158230
		[Token(Token = "0x4026A16")]
		[FieldOffset(Offset = "0x60")]
		private TrackPointViewProperty m_chainLogin;

		// Token: 0x04026A17 RID: 158231
		[Token(Token = "0x4026A17")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_totalCheckIn;

		// Token: 0x04026A18 RID: 158232
		[Token(Token = "0x4026A18")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_mission;

		// Token: 0x04026A19 RID: 158233
		[Token(Token = "0x4026A19")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026A1A RID: 158234
		[Token(Token = "0x4026A1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026A1B RID: 158235
		[Token(Token = "0x4026A1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateWithType;

		// Token: 0x04026A1C RID: 158236
		[Token(Token = "0x4026A1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x04026A1D RID: 158237
		[Token(Token = "0x4026A1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnChainLoginClick;

		// Token: 0x04026A1E RID: 158238
		[Token(Token = "0x4026A1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMissionClick;

		// Token: 0x04026A1F RID: 158239
		[Token(Token = "0x4026A1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTotalCheckClick;

		// Token: 0x04026A20 RID: 158240
		[Token(Token = "0x4026A20")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x04026A21 RID: 158241
		[Token(Token = "0x4026A21")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SendGetChain;

		// Token: 0x04026A22 RID: 158242
		[Token(Token = "0x4026A22")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendGetCheckIn;

		// Token: 0x04026A23 RID: 158243
		[Token(Token = "0x4026A23")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SendConfirmMissionRequest;

		// Token: 0x04026A24 RID: 158244
		[Token(Token = "0x4026A24")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
