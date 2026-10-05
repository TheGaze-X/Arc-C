using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005142 RID: 20802
	[Token(Token = "0x2005142")]
	public abstract class DeepSeaRPNodeModel : IHotfixable
	{
		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x0601EBBC RID: 125884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A6")]
		public string nodeId
		{
			[Token(Token = "0x601EBBC")]
			[Address(RVA = "0x1871770", Offset = "0x1870370", VA = "0x181871770")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x0601EBBD RID: 125885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A7")]
		public string placeId
		{
			[Token(Token = "0x601EBBD")]
			[Address(RVA = "0x18718A0", Offset = "0x18704A0", VA = "0x1818718A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x0601EBBE RID: 125886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A8")]
		public Act17sideData.NodeInfoData infoData
		{
			[Token(Token = "0x601EBBE")]
			[Address(RVA = "0x1871640", Offset = "0x1870240", VA = "0x181871640")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x0601EBBF RID: 125887 RVA: 0x000AF6E0 File Offset: 0x000AD8E0
		[Token(Token = "0x170047A9")]
		public int sortId
		{
			[Token(Token = "0x601EBBF")]
			[Address(RVA = "0x1871930", Offset = "0x1870530", VA = "0x181871930")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x0601EBC0 RID: 125888 RVA: 0x000AF6F8 File Offset: 0x000AD8F8
		[Token(Token = "0x170047AA")]
		public Act17sideData.TrackPointType trackPointType
		{
			[Token(Token = "0x601EBC0")]
			[Address(RVA = "0x18719A0", Offset = "0x18705A0", VA = "0x1818719A0")]
			get
			{
				return Act17sideData.TrackPointType.NONE;
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x0601EBC1 RID: 125889 RVA: 0x000AF710 File Offset: 0x000AD910
		[Token(Token = "0x170047AB")]
		public Act17sideData.NodeType nodeType
		{
			[Token(Token = "0x601EBC1")]
			[Address(RVA = "0x1871830", Offset = "0x1870430", VA = "0x181871830")]
			get
			{
				return Act17sideData.NodeType.LANDMARK;
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x0601EBC2 RID: 125890 RVA: 0x000AF728 File Offset: 0x000AD928
		[Token(Token = "0x170047AC")]
		public PlayerDeepSea.NodeStatus nodeStatus
		{
			[Token(Token = "0x601EBC2")]
			[Address(RVA = "0x18717D0", Offset = "0x18703D0", VA = "0x1818717D0")]
			get
			{
				return PlayerDeepSea.NodeStatus.LOCKED;
			}
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x0601EBC3 RID: 125891 RVA: 0x000AF740 File Offset: 0x000AD940
		[Token(Token = "0x170047AD")]
		public bool isLock
		{
			[Token(Token = "0x601EBC3")]
			[Address(RVA = "0x18716A0", Offset = "0x18702A0", VA = "0x1818716A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601EBC4 RID: 125892 RVA: 0x000AF758 File Offset: 0x000AD958
		[Token(Token = "0x601EBC4")]
		[Address(RVA = "0x1867970", Offset = "0x1866570", VA = "0x181867970", Slot = "4")]
		public virtual bool ShowLockOnMap()
		{
			return default(bool);
		}

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x0601EBC5 RID: 125893 RVA: 0x000AF770 File Offset: 0x000AD970
		[Token(Token = "0x170047AE")]
		public bool isPointNode
		{
			[Token(Token = "0x601EBC5")]
			[Address(RVA = "0x1871700", Offset = "0x1870300", VA = "0x181871700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601EBC6 RID: 125894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBC6")]
		[Address(RVA = "0x18713A0", Offset = "0x186FFA0", VA = "0x1818713A0", Slot = "5")]
		public virtual void InitData(string nodeId_, Act17sideData.NodeInfoData infoData_, Act17sideData actData)
		{
		}

		// Token: 0x0601EBC7 RID: 125895 RVA: 0x000AF788 File Offset: 0x000AD988
		[Token(Token = "0x601EBC7")]
		[Address(RVA = "0x1867910", Offset = "0x1866510", VA = "0x181867910", Slot = "6")]
		public virtual bool IsGrey()
		{
			return default(bool);
		}

		// Token: 0x0601EBC8 RID: 125896 RVA: 0x000AF7A0 File Offset: 0x000AD9A0
		[Token(Token = "0x601EBC8")]
		[Address(RVA = "0x1871340", Offset = "0x186FF40", VA = "0x181871340", Slot = "7")]
		public virtual bool HasEntryTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EBC9 RID: 125897 RVA: 0x000AF7B8 File Offset: 0x000AD9B8
		[Token(Token = "0x601EBC9")]
		[Address(RVA = "0x1866780", Offset = "0x1865380", VA = "0x181866780", Slot = "8")]
		public virtual bool HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EBCA RID: 125898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCA")]
		[Address(RVA = "0x1869780", Offset = "0x1868380", VA = "0x181869780", Slot = "9")]
		public virtual Act17sideData.EventData GetEndEvent()
		{
			return null;
		}

		// Token: 0x0601EBCB RID: 125899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCB")]
		[Address(RVA = "0x18712B0", Offset = "0x186FEB0", VA = "0x1818712B0", Slot = "10")]
		public virtual string GetTitleText()
		{
			return null;
		}

		// Token: 0x0601EBCC RID: 125900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCC")]
		[Address(RVA = "0x18678A0", Offset = "0x18664A0", VA = "0x1818678A0", Slot = "11")]
		public virtual string GetSpecialPicId()
		{
			return null;
		}

		// Token: 0x0601EBCD RID: 125901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCD")]
		[Address(RVA = "0x1867840", Offset = "0x1866440", VA = "0x181867840", Slot = "12")]
		public virtual string GetNodePicId()
		{
			return null;
		}

		// Token: 0x0601EBCE RID: 125902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCE")]
		[Address(RVA = "0x18711E0", Offset = "0x186FDE0", VA = "0x1818711E0", Slot = "13")]
		public virtual string GetMapIconName()
		{
			return null;
		}

		// Token: 0x0601EBCF RID: 125903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBCF")]
		[Address(RVA = "0x1871040", Offset = "0x186FC40", VA = "0x181871040", Slot = "14")]
		public virtual string GetDetailIconName()
		{
			return null;
		}

		// Token: 0x0601EBD0 RID: 125904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBD0")]
		[Address(RVA = "0x1871110", Offset = "0x186FD10", VA = "0x181871110", Slot = "15")]
		public virtual string GetImgDecoName()
		{
			return null;
		}

		// Token: 0x0601EBD1 RID: 125905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBD1")]
		[Address(RVA = "0x18677E0", Offset = "0x18663E0", VA = "0x1818677E0", Slot = "16")]
		public virtual List<string> GetDescList()
		{
			return null;
		}

		// Token: 0x0601EBD2 RID: 125906 RVA: 0x000AF7D0 File Offset: 0x000AD9D0
		[Token(Token = "0x601EBD2")]
		[Address(RVA = "0x18714D0", Offset = "0x18700D0", VA = "0x1818714D0", Slot = "17")]
		public virtual bool ShouldCustomizeLasDes()
		{
			return default(bool);
		}

		// Token: 0x0601EBD3 RID: 125907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBD3")]
		[Address(RVA = "0x1871530", Offset = "0x1870130", VA = "0x181871530", Slot = "18")]
		public virtual void UpdateNodeStatus(PlayerDeepSea deepSeaData)
		{
		}

		// Token: 0x0601EBD4 RID: 125908 RVA: 0x000AF7E8 File Offset: 0x000AD9E8
		[Token(Token = "0x601EBD4")]
		[Address(RVA = "0x18667F0", Offset = "0x18653F0", VA = "0x1818667F0", Slot = "19")]
		public virtual bool IsNodeComplete()
		{
			return default(bool);
		}

		// Token: 0x0601EBD5 RID: 125909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBD5")]
		[Address(RVA = "0x1870940", Offset = "0x186F540", VA = "0x181870940")]
		public static DeepSeaRPNodeModel Create(string nodeId, Act17sideData.NodeInfoData infoData, Act17sideData actData)
		{
			return null;
		}

		// Token: 0x0601EBD6 RID: 125910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBD6")]
		[Address(RVA = "0x18715E0", Offset = "0x18701E0", VA = "0x1818715E0")]
		protected DeepSeaRPNodeModel()
		{
		}

		// Token: 0x04029398 RID: 168856
		[Token(Token = "0x4029398")]
		[FieldOffset(Offset = "0x10")]
		protected string m_nodeId;

		// Token: 0x04029399 RID: 168857
		[Token(Token = "0x4029399")]
		[FieldOffset(Offset = "0x18")]
		protected Act17sideData.NodeInfoData m_infoData;

		// Token: 0x0402939A RID: 168858
		[Token(Token = "0x402939A")]
		[FieldOffset(Offset = "0x20")]
		protected Act17sideData.PlaceData m_placeData;

		// Token: 0x0402939B RID: 168859
		[Token(Token = "0x402939B")]
		[FieldOffset(Offset = "0x28")]
		protected PlayerDeepSea.NodeStatus m_nodeStatus;

		// Token: 0x0402939C RID: 168860
		[Token(Token = "0x402939C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x0402939D RID: 168861
		[Token(Token = "0x402939D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_placeId;

		// Token: 0x0402939E RID: 168862
		[Token(Token = "0x402939E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_infoData;

		// Token: 0x0402939F RID: 168863
		[Token(Token = "0x402939F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x040293A0 RID: 168864
		[Token(Token = "0x40293A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_trackPointType;

		// Token: 0x040293A1 RID: 168865
		[Token(Token = "0x40293A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x040293A2 RID: 168866
		[Token(Token = "0x40293A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_nodeStatus;

		// Token: 0x040293A3 RID: 168867
		[Token(Token = "0x40293A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isLock;

		// Token: 0x040293A4 RID: 168868
		[Token(Token = "0x40293A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowLockOnMap;

		// Token: 0x040293A5 RID: 168869
		[Token(Token = "0x40293A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isPointNode;

		// Token: 0x040293A6 RID: 168870
		[Token(Token = "0x40293A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040293A7 RID: 168871
		[Token(Token = "0x40293A7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsGrey;

		// Token: 0x040293A8 RID: 168872
		[Token(Token = "0x40293A8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HasEntryTrackPoint;

		// Token: 0x040293A9 RID: 168873
		[Token(Token = "0x40293A9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HasTrackPoint;

		// Token: 0x040293AA RID: 168874
		[Token(Token = "0x40293AA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetEndEvent;

		// Token: 0x040293AB RID: 168875
		[Token(Token = "0x40293AB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetTitleText;

		// Token: 0x040293AC RID: 168876
		[Token(Token = "0x40293AC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetSpecialPicId;

		// Token: 0x040293AD RID: 168877
		[Token(Token = "0x40293AD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetNodePicId;

		// Token: 0x040293AE RID: 168878
		[Token(Token = "0x40293AE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetMapIconName;

		// Token: 0x040293AF RID: 168879
		[Token(Token = "0x40293AF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetDetailIconName;

		// Token: 0x040293B0 RID: 168880
		[Token(Token = "0x40293B0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetImgDecoName;

		// Token: 0x040293B1 RID: 168881
		[Token(Token = "0x40293B1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetDescList;

		// Token: 0x040293B2 RID: 168882
		[Token(Token = "0x40293B2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShouldCustomizeLasDes;

		// Token: 0x040293B3 RID: 168883
		[Token(Token = "0x40293B3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UpdateNodeStatus;

		// Token: 0x040293B4 RID: 168884
		[Token(Token = "0x40293B4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsNodeComplete;

		// Token: 0x040293B5 RID: 168885
		[Token(Token = "0x40293B5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x040293B6 RID: 168886
		[Token(Token = "0x40293B6")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
