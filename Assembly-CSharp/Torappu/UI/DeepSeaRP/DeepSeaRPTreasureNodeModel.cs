using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005147 RID: 20807
	[Token(Token = "0x2005147")]
	public class DeepSeaRPTreasureNodeModel : DeepSeaRPNodeModel
	{
		// Token: 0x0601EC00 RID: 125952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC00")]
		[Address(RVA = "0x18756A0", Offset = "0x18742A0", VA = "0x1818756A0", Slot = "5")]
		public override void InitData(string nodeId_, Act17sideData.NodeInfoData infoData_, Act17sideData actData)
		{
		}

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x0601EC01 RID: 125953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047B0")]
		public MissionData missionData
		{
			[Token(Token = "0x601EC01")]
			[Address(RVA = "0x1875E90", Offset = "0x1874A90", VA = "0x181875E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EC02 RID: 125954 RVA: 0x000AF908 File Offset: 0x000ADB08
		[Token(Token = "0x601EC02")]
		[Address(RVA = "0x1875840", Offset = "0x1874440", VA = "0x181875840")]
		public bool IsMissionComplete()
		{
			return default(bool);
		}

		// Token: 0x0601EC03 RID: 125955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC03")]
		[Address(RVA = "0x18752C0", Offset = "0x1873EC0", VA = "0x1818752C0")]
		public MissionCalcState GetMissionProgress()
		{
			return null;
		}

		// Token: 0x0601EC04 RID: 125956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC04")]
		[Address(RVA = "0x1875C80", Offset = "0x1874880", VA = "0x181875C80")]
		private void _FetchMissionData()
		{
		}

		// Token: 0x0601EC05 RID: 125957 RVA: 0x000AF920 File Offset: 0x000ADB20
		[Token(Token = "0x601EC05")]
		[Address(RVA = "0x18757E0", Offset = "0x18743E0", VA = "0x1818757E0", Slot = "6")]
		public override bool IsGrey()
		{
			return default(bool);
		}

		// Token: 0x0601EC06 RID: 125958 RVA: 0x000AF938 File Offset: 0x000ADB38
		[Token(Token = "0x601EC06")]
		[Address(RVA = "0x1875AF0", Offset = "0x18746F0", VA = "0x181875AF0", Slot = "4")]
		public override bool ShowLockOnMap()
		{
			return default(bool);
		}

		// Token: 0x0601EC07 RID: 125959 RVA: 0x000AF950 File Offset: 0x000ADB50
		[Token(Token = "0x601EC07")]
		[Address(RVA = "0x1875540", Offset = "0x1874140", VA = "0x181875540", Slot = "7")]
		public override bool HasEntryTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EC08 RID: 125960 RVA: 0x000AF968 File Offset: 0x000ADB68
		[Token(Token = "0x601EC08")]
		[Address(RVA = "0x18755D0", Offset = "0x18741D0", VA = "0x1818755D0", Slot = "8")]
		public override bool HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EC09 RID: 125961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC09")]
		[Address(RVA = "0x1874FA0", Offset = "0x1873BA0", VA = "0x181874FA0", Slot = "9")]
		public override Act17sideData.EventData GetEndEvent()
		{
			return null;
		}

		// Token: 0x0601EC0A RID: 125962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC0A")]
		[Address(RVA = "0x1875BC0", Offset = "0x18747C0", VA = "0x181875BC0", Slot = "18")]
		public override void UpdateNodeStatus(PlayerDeepSea deepSeaData)
		{
		}

		// Token: 0x0601EC0B RID: 125963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC0B")]
		[Address(RVA = "0x1875160", Offset = "0x1873D60", VA = "0x181875160", Slot = "13")]
		public override string GetMapIconName()
		{
			return null;
		}

		// Token: 0x0601EC0C RID: 125964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC0C")]
		[Address(RVA = "0x1874E40", Offset = "0x1873A40", VA = "0x181874E40", Slot = "14")]
		public override string GetDetailIconName()
		{
			return null;
		}

		// Token: 0x0601EC0D RID: 125965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC0D")]
		[Address(RVA = "0x1875000", Offset = "0x1873C00", VA = "0x181875000", Slot = "15")]
		public override string GetImgDecoName()
		{
			return null;
		}

		// Token: 0x0601EC0E RID: 125966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC0E")]
		[Address(RVA = "0x18754D0", Offset = "0x18740D0", VA = "0x1818754D0", Slot = "10")]
		public override string GetTitleText()
		{
			return null;
		}

		// Token: 0x0601EC0F RID: 125967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC0F")]
		[Address(RVA = "0x1875460", Offset = "0x1874060", VA = "0x181875460", Slot = "11")]
		public override string GetSpecialPicId()
		{
			return null;
		}

		// Token: 0x0601EC10 RID: 125968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC10")]
		[Address(RVA = "0x18753F0", Offset = "0x1873FF0", VA = "0x1818753F0", Slot = "12")]
		public override string GetNodePicId()
		{
			return null;
		}

		// Token: 0x0601EC11 RID: 125969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC11")]
		[Address(RVA = "0x1874DD0", Offset = "0x18739D0", VA = "0x181874DD0", Slot = "16")]
		public override List<string> GetDescList()
		{
			return null;
		}

		// Token: 0x0601EC12 RID: 125970 RVA: 0x000AF980 File Offset: 0x000ADB80
		[Token(Token = "0x601EC12")]
		[Address(RVA = "0x1875A90", Offset = "0x1874690", VA = "0x181875A90", Slot = "17")]
		public override bool ShouldCustomizeLasDes()
		{
			return default(bool);
		}

		// Token: 0x0601EC13 RID: 125971 RVA: 0x000AF998 File Offset: 0x000ADB98
		[Token(Token = "0x601EC13")]
		[Address(RVA = "0x18759D0", Offset = "0x18745D0", VA = "0x1818759D0", Slot = "19")]
		public override bool IsNodeComplete()
		{
			return default(bool);
		}

		// Token: 0x0601EC14 RID: 125972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC14")]
		[Address(RVA = "0x1875DF0", Offset = "0x18749F0", VA = "0x181875DF0")]
		public DeepSeaRPTreasureNodeModel()
		{
		}

		// Token: 0x0601EC15 RID: 125973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC15")]
		[Address(RVA = "0x18667E0", Offset = "0x18653E0", VA = "0x1818667E0")]
		private void <>xLuaBaseProxy_InitData(string P0, Act17sideData.NodeInfoData P1, Act17sideData P2)
		{
		}

		// Token: 0x0601EC16 RID: 125974 RVA: 0x000AF9B0 File Offset: 0x000ADBB0
		[Token(Token = "0x601EC16")]
		[Address(RVA = "0x1867910", Offset = "0x1866510", VA = "0x181867910")]
		private bool <>xLuaBaseProxy_IsGrey()
		{
			return default(bool);
		}

		// Token: 0x0601EC17 RID: 125975 RVA: 0x000AF9C8 File Offset: 0x000ADBC8
		[Token(Token = "0x601EC17")]
		[Address(RVA = "0x1867970", Offset = "0x1866570", VA = "0x181867970")]
		private bool <>xLuaBaseProxy_ShowLockOnMap()
		{
			return default(bool);
		}

		// Token: 0x0601EC18 RID: 125976 RVA: 0x000AF9E0 File Offset: 0x000ADBE0
		[Token(Token = "0x601EC18")]
		[Address(RVA = "0x1871340", Offset = "0x186FF40", VA = "0x181871340")]
		private bool <>xLuaBaseProxy_HasEntryTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EC19 RID: 125977 RVA: 0x000AF9F8 File Offset: 0x000ADBF8
		[Token(Token = "0x601EC19")]
		[Address(RVA = "0x1866780", Offset = "0x1865380", VA = "0x181866780")]
		private bool <>xLuaBaseProxy_HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EC1A RID: 125978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC1A")]
		[Address(RVA = "0x1869780", Offset = "0x1868380", VA = "0x181869780")]
		private Act17sideData.EventData <>xLuaBaseProxy_GetEndEvent()
		{
			return null;
		}

		// Token: 0x0601EC1B RID: 125979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC1B")]
		[Address(RVA = "0x18679D0", Offset = "0x18665D0", VA = "0x1818679D0")]
		private void <>xLuaBaseProxy_UpdateNodeStatus(PlayerDeepSea P0)
		{
		}

		// Token: 0x0601EC1C RID: 125980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC1C")]
		[Address(RVA = "0x18711E0", Offset = "0x186FDE0", VA = "0x1818711E0")]
		private string <>xLuaBaseProxy_GetMapIconName()
		{
			return null;
		}

		// Token: 0x0601EC1D RID: 125981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC1D")]
		[Address(RVA = "0x1869CD0", Offset = "0x18688D0", VA = "0x181869CD0")]
		private string <>xLuaBaseProxy_GetDetailIconName()
		{
			return null;
		}

		// Token: 0x0601EC1E RID: 125982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC1E")]
		[Address(RVA = "0x1871110", Offset = "0x186FD10", VA = "0x181871110")]
		private string <>xLuaBaseProxy_GetImgDecoName()
		{
			return null;
		}

		// Token: 0x0601EC1F RID: 125983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC1F")]
		[Address(RVA = "0x1867900", Offset = "0x1866500", VA = "0x181867900")]
		private string <>xLuaBaseProxy_GetTitleText()
		{
			return null;
		}

		// Token: 0x0601EC20 RID: 125984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC20")]
		[Address(RVA = "0x18678A0", Offset = "0x18664A0", VA = "0x1818678A0")]
		private string <>xLuaBaseProxy_GetSpecialPicId()
		{
			return null;
		}

		// Token: 0x0601EC21 RID: 125985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC21")]
		[Address(RVA = "0x1867840", Offset = "0x1866440", VA = "0x181867840")]
		private string <>xLuaBaseProxy_GetNodePicId()
		{
			return null;
		}

		// Token: 0x0601EC22 RID: 125986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC22")]
		[Address(RVA = "0x18677E0", Offset = "0x18663E0", VA = "0x1818677E0")]
		private List<string> <>xLuaBaseProxy_GetDescList()
		{
			return null;
		}

		// Token: 0x0601EC23 RID: 125987 RVA: 0x000AFA10 File Offset: 0x000ADC10
		[Token(Token = "0x601EC23")]
		[Address(RVA = "0x18714D0", Offset = "0x18700D0", VA = "0x1818714D0")]
		private bool <>xLuaBaseProxy_ShouldCustomizeLasDes()
		{
			return default(bool);
		}

		// Token: 0x0601EC24 RID: 125988 RVA: 0x000AFA28 File Offset: 0x000ADC28
		[Token(Token = "0x601EC24")]
		[Address(RVA = "0x18667F0", Offset = "0x18653F0", VA = "0x1818667F0")]
		private bool <>xLuaBaseProxy_IsNodeComplete()
		{
			return default(bool);
		}

		// Token: 0x040293D6 RID: 168918
		[Token(Token = "0x40293D6")]
		[FieldOffset(Offset = "0x30")]
		public Act17sideData.TreasureNodeData treasureData;

		// Token: 0x040293D7 RID: 168919
		[Token(Token = "0x40293D7")]
		[FieldOffset(Offset = "0x38")]
		public PlayerDeepSea.TreasureStatus treasureStatus;

		// Token: 0x040293D8 RID: 168920
		[Token(Token = "0x40293D8")]
		[FieldOffset(Offset = "0x40")]
		private MissionData m_missionData;

		// Token: 0x040293D9 RID: 168921
		[Token(Token = "0x40293D9")]
		[FieldOffset(Offset = "0x48")]
		private Act17sideData.EventData m_endEventData;

		// Token: 0x040293DA RID: 168922
		[Token(Token = "0x40293DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040293DB RID: 168923
		[Token(Token = "0x40293DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_missionData;

		// Token: 0x040293DC RID: 168924
		[Token(Token = "0x40293DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsMissionComplete;

		// Token: 0x040293DD RID: 168925
		[Token(Token = "0x40293DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetMissionProgress;

		// Token: 0x040293DE RID: 168926
		[Token(Token = "0x40293DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FetchMissionData;

		// Token: 0x040293DF RID: 168927
		[Token(Token = "0x40293DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsGrey;

		// Token: 0x040293E0 RID: 168928
		[Token(Token = "0x40293E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowLockOnMap;

		// Token: 0x040293E1 RID: 168929
		[Token(Token = "0x40293E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasEntryTrackPoint;

		// Token: 0x040293E2 RID: 168930
		[Token(Token = "0x40293E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasTrackPoint;

		// Token: 0x040293E3 RID: 168931
		[Token(Token = "0x40293E3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEndEvent;

		// Token: 0x040293E4 RID: 168932
		[Token(Token = "0x40293E4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateNodeStatus;

		// Token: 0x040293E5 RID: 168933
		[Token(Token = "0x40293E5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetMapIconName;

		// Token: 0x040293E6 RID: 168934
		[Token(Token = "0x40293E6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetDetailIconName;

		// Token: 0x040293E7 RID: 168935
		[Token(Token = "0x40293E7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetImgDecoName;

		// Token: 0x040293E8 RID: 168936
		[Token(Token = "0x40293E8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTitleText;

		// Token: 0x040293E9 RID: 168937
		[Token(Token = "0x40293E9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSpecialPicId;

		// Token: 0x040293EA RID: 168938
		[Token(Token = "0x40293EA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetNodePicId;

		// Token: 0x040293EB RID: 168939
		[Token(Token = "0x40293EB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetDescList;

		// Token: 0x040293EC RID: 168940
		[Token(Token = "0x40293EC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ShouldCustomizeLasDes;

		// Token: 0x040293ED RID: 168941
		[Token(Token = "0x40293ED")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsNodeComplete;

		// Token: 0x040293EE RID: 168942
		[Token(Token = "0x40293EE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
