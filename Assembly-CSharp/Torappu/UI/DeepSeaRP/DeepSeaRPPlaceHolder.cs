using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200512C RID: 20780
	[Token(Token = "0x200512C")]
	public class DeepSeaRPPlaceHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x0601EB0F RID: 125711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004784")]
		public string placeId
		{
			[Token(Token = "0x601EB0F")]
			[Address(RVA = "0x18551D0", Offset = "0x1853DD0", VA = "0x1818551D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x0601EB10 RID: 125712 RVA: 0x000AF3E0 File Offset: 0x000AD5E0
		[Token(Token = "0x17004785")]
		public bool isActive
		{
			[Token(Token = "0x601EB10")]
			[Address(RVA = "0x1855160", Offset = "0x1853D60", VA = "0x181855160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x0601EB11 RID: 125713 RVA: 0x000AF3F8 File Offset: 0x000AD5F8
		[Token(Token = "0x17004786")]
		public PlayerDeepSea.PlaceStatus placeStatus
		{
			[Token(Token = "0x601EB11")]
			[Address(RVA = "0x1855230", Offset = "0x1853E30", VA = "0x181855230")]
			get
			{
				return PlayerDeepSea.PlaceStatus.INVISIBLE;
			}
		}

		// Token: 0x0601EB12 RID: 125714 RVA: 0x000AF410 File Offset: 0x000AD610
		[Token(Token = "0x601EB12")]
		[Address(RVA = "0x1854F20", Offset = "0x1853B20", VA = "0x181854F20")]
		public bool IsGrey()
		{
			return default(bool);
		}

		// Token: 0x0601EB13 RID: 125715 RVA: 0x000AF428 File Offset: 0x000AD628
		[Token(Token = "0x601EB13")]
		[Address(RVA = "0x1854E00", Offset = "0x1853A00", VA = "0x181854E00")]
		public bool HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EB14 RID: 125716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB14")]
		[Address(RVA = "0x1854FA0", Offset = "0x1853BA0", VA = "0x181854FA0")]
		public void Render(DeepSeaRPPlaceModel placeModel, DeepSeaRPZoneMapView mapView, DeepSeaRPPlaceView placeViewTemplate)
		{
		}

		// Token: 0x0601EB15 RID: 125717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB15")]
		[Address(RVA = "0x1855100", Offset = "0x1853D00", VA = "0x181855100")]
		public DeepSeaRPPlaceHolder()
		{
		}

		// Token: 0x04029262 RID: 168546
		[Token(Token = "0x4029262")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _placeParent;

		// Token: 0x04029263 RID: 168547
		[Token(Token = "0x4029263")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _placeId;

		// Token: 0x04029264 RID: 168548
		[Token(Token = "0x4029264")]
		[FieldOffset(Offset = "0x28")]
		private DeepSeaRPPlaceView m_viewInstance;

		// Token: 0x04029265 RID: 168549
		[Token(Token = "0x4029265")]
		[FieldOffset(Offset = "0x30")]
		private DeepSeaRPPlaceModel m_placeModel;

		// Token: 0x04029266 RID: 168550
		[Token(Token = "0x4029266")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_placeId;

		// Token: 0x04029267 RID: 168551
		[Token(Token = "0x4029267")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x04029268 RID: 168552
		[Token(Token = "0x4029268")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_placeStatus;

		// Token: 0x04029269 RID: 168553
		[Token(Token = "0x4029269")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsGrey;

		// Token: 0x0402926A RID: 168554
		[Token(Token = "0x402926A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HasTrackPoint;

		// Token: 0x0402926B RID: 168555
		[Token(Token = "0x402926B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402926C RID: 168556
		[Token(Token = "0x402926C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
