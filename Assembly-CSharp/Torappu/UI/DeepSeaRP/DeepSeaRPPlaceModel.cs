using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005141 RID: 20801
	[Token(Token = "0x2005141")]
	public class DeepSeaRPPlaceModel : IHotfixable
	{
		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x0601EBB3 RID: 125875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A2")]
		public Act17sideData.EventData lockEventData
		{
			[Token(Token = "0x601EBB3")]
			[Address(RVA = "0x1872020", Offset = "0x1870C20", VA = "0x181872020")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x0601EBB4 RID: 125876 RVA: 0x000AF6C8 File Offset: 0x000AD8C8
		[Token(Token = "0x170047A3")]
		public PlayerDeepSea.PlaceStatus status
		{
			[Token(Token = "0x601EBB4")]
			[Address(RVA = "0x1872140", Offset = "0x1870D40", VA = "0x181872140")]
			get
			{
				return PlayerDeepSea.PlaceStatus.INVISIBLE;
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x0601EBB5 RID: 125877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A4")]
		public Act17sideData.PlaceData placeData
		{
			[Token(Token = "0x601EBB5")]
			[Address(RVA = "0x18720E0", Offset = "0x1870CE0", VA = "0x1818720E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x0601EBB6 RID: 125878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A5")]
		public List<DeepSeaRPNodeModel> nodeList
		{
			[Token(Token = "0x601EBB6")]
			[Address(RVA = "0x1872080", Offset = "0x1870C80", VA = "0x181872080")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EBB7 RID: 125879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EBB7")]
		[Address(RVA = "0x1871AA0", Offset = "0x18706A0", VA = "0x181871AA0")]
		public DeepSeaRPNodeModel FetchActiveNodeModel()
		{
			return null;
		}

		// Token: 0x0601EBB8 RID: 125880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBB8")]
		[Address(RVA = "0x1871C80", Offset = "0x1870880", VA = "0x181871C80")]
		public void InitData(string placeId, Act17sideData.PlaceData placeData, Act17sideData actData)
		{
		}

		// Token: 0x0601EBB9 RID: 125881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBB9")]
		[Address(RVA = "0x1871EA0", Offset = "0x1870AA0", VA = "0x181871EA0")]
		public void UpdatePlaceStatus([Optional] PlayerDeepSea playerDeepSea)
		{
		}

		// Token: 0x0601EBBA RID: 125882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBBA")]
		[Address(RVA = "0x1871A10", Offset = "0x1870610", VA = "0x181871A10")]
		public void AddNode(DeepSeaRPNodeModel nodeModel)
		{
		}

		// Token: 0x0601EBBB RID: 125883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBBB")]
		[Address(RVA = "0x1871FC0", Offset = "0x1870BC0", VA = "0x181871FC0")]
		public DeepSeaRPPlaceModel()
		{
		}

		// Token: 0x0402938A RID: 168842
		[Token(Token = "0x402938A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_placeId;

		// Token: 0x0402938B RID: 168843
		[Token(Token = "0x402938B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Act17sideData.PlaceData m_placeData;

		// Token: 0x0402938C RID: 168844
		[Token(Token = "0x402938C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<DeepSeaRPNodeModel> m_nodeList;

		// Token: 0x0402938D RID: 168845
		[Token(Token = "0x402938D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerDeepSea.PlaceStatus m_status;

		// Token: 0x0402938E RID: 168846
		[Token(Token = "0x402938E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Act17sideData.EventData m_lockEventData;

		// Token: 0x0402938F RID: 168847
		[Token(Token = "0x402938F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lockEventData;

		// Token: 0x04029390 RID: 168848
		[Token(Token = "0x4029390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04029391 RID: 168849
		[Token(Token = "0x4029391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_placeData;

		// Token: 0x04029392 RID: 168850
		[Token(Token = "0x4029392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodeList;

		// Token: 0x04029393 RID: 168851
		[Token(Token = "0x4029393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FetchActiveNodeModel;

		// Token: 0x04029394 RID: 168852
		[Token(Token = "0x4029394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04029395 RID: 168853
		[Token(Token = "0x4029395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdatePlaceStatus;

		// Token: 0x04029396 RID: 168854
		[Token(Token = "0x4029396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AddNode;

		// Token: 0x04029397 RID: 168855
		[Token(Token = "0x4029397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
