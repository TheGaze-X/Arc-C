using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200513B RID: 20795
	[Token(Token = "0x200513B")]
	public class DeepSeaRPModel : IHotfixable
	{
		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x0601EB98 RID: 125848 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EB99 RID: 125849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700479B")]
		public string selectedZoneId
		{
			[Token(Token = "0x601EB98")]
			[Address(RVA = "0x186B680", Offset = "0x186A280", VA = "0x18186B680")]
			get
			{
				return null;
			}
			[Token(Token = "0x601EB99")]
			[Address(RVA = "0x186B6E0", Offset = "0x186A2E0", VA = "0x18186B6E0")]
			set
			{
			}
		}

		// Token: 0x0601EB9A RID: 125850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB9A")]
		[Address(RVA = "0x186A260", Offset = "0x1868E60", VA = "0x18186A260")]
		public void InitData(bool isRetro_, string groupId_, string zoneId_)
		{
		}

		// Token: 0x0601EB9B RID: 125851 RVA: 0x000AF5F0 File Offset: 0x000AD7F0
		[Token(Token = "0x601EB9B")]
		[Address(RVA = "0x186A540", Offset = "0x1869140", VA = "0x18186A540")]
		public bool TrySelectPlaceByStageId(string stageId_)
		{
			return default(bool);
		}

		// Token: 0x0601EB9C RID: 125852 RVA: 0x000AF608 File Offset: 0x000AD808
		[Token(Token = "0x601EB9C")]
		[Address(RVA = "0x186A3E0", Offset = "0x1868FE0", VA = "0x18186A3E0")]
		public bool IsBattleSelected()
		{
			return default(bool);
		}

		// Token: 0x0601EB9D RID: 125853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EB9D")]
		[Address(RVA = "0x1869F70", Offset = "0x1868B70", VA = "0x181869F70")]
		public DeepSeaRPPlaceModel GetSelectedPlaceModel()
		{
			return null;
		}

		// Token: 0x0601EB9E RID: 125854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EB9E")]
		[Address(RVA = "0x1869E70", Offset = "0x1868A70", VA = "0x181869E70")]
		public DeepSeaRPNodeModel GetSelectedNodeModel()
		{
			return null;
		}

		// Token: 0x0601EB9F RID: 125855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EB9F")]
		[Address(RVA = "0x1869D80", Offset = "0x1868980", VA = "0x181869D80")]
		public Act17sideData.EventData GetLockEventData()
		{
			return null;
		}

		// Token: 0x0601EBA0 RID: 125856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBA0")]
		[Address(RVA = "0x186A680", Offset = "0x1869280", VA = "0x18186A680")]
		private void _InitData(bool isRetro, Act17sideData actData)
		{
		}

		// Token: 0x0601EBA1 RID: 125857 RVA: 0x000AF620 File Offset: 0x000AD820
		[Token(Token = "0x601EBA1")]
		[Address(RVA = "0x186A020", Offset = "0x1868C20", VA = "0x18186A020")]
		public static DeepSeaRPModel.ZoneInfo GetZoneInfoById(string zoneId, bool isRetro)
		{
			return default(DeepSeaRPModel.ZoneInfo);
		}

		// Token: 0x0601EBA2 RID: 125858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBA2")]
		[Address(RVA = "0x186B620", Offset = "0x186A220", VA = "0x18186B620")]
		public DeepSeaRPModel()
		{
		}

		// Token: 0x04029358 RID: 168792
		[Token(Token = "0x4029358")]
		[FieldOffset(Offset = "0x10")]
		public List<DeepSeaRPZoneMapModel> zoneMapModelList;

		// Token: 0x04029359 RID: 168793
		[Token(Token = "0x4029359")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, DeepSeaRPPlaceModel> placeDict;

		// Token: 0x0402935A RID: 168794
		[Token(Token = "0x402935A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, DeepSeaRPNodeModel> nodeDict;

		// Token: 0x0402935B RID: 168795
		[Token(Token = "0x402935B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<Act17sideData.MainlineData>> mainlineDict;

		// Token: 0x0402935C RID: 168796
		[Token(Token = "0x402935C")]
		[FieldOffset(Offset = "0x30")]
		public DeepSeaRPTechModel techModel;

		// Token: 0x0402935D RID: 168797
		[Token(Token = "0x402935D")]
		[FieldOffset(Offset = "0x38")]
		public string selectedPlaceId;

		// Token: 0x0402935E RID: 168798
		[Token(Token = "0x402935E")]
		[FieldOffset(Offset = "0x40")]
		public string groupId;

		// Token: 0x0402935F RID: 168799
		[Token(Token = "0x402935F")]
		[FieldOffset(Offset = "0x48")]
		public bool isRetro;

		// Token: 0x04029360 RID: 168800
		[Token(Token = "0x4029360")]
		[FieldOffset(Offset = "0x4C")]
		public int showToastSequence;

		// Token: 0x04029361 RID: 168801
		[Token(Token = "0x4029361")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> m_stageToPlaceDict;

		// Token: 0x04029362 RID: 168802
		[Token(Token = "0x4029362")]
		[FieldOffset(Offset = "0x58")]
		private string m_selectedZoneId;

		// Token: 0x04029363 RID: 168803
		[Token(Token = "0x4029363")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x04029364 RID: 168804
		[Token(Token = "0x4029364")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedZoneId;

		// Token: 0x04029365 RID: 168805
		[Token(Token = "0x4029365")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04029366 RID: 168806
		[Token(Token = "0x4029366")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TrySelectPlaceByStageId;

		// Token: 0x04029367 RID: 168807
		[Token(Token = "0x4029367")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsBattleSelected;

		// Token: 0x04029368 RID: 168808
		[Token(Token = "0x4029368")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSelectedPlaceModel;

		// Token: 0x04029369 RID: 168809
		[Token(Token = "0x4029369")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSelectedNodeModel;

		// Token: 0x0402936A RID: 168810
		[Token(Token = "0x402936A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLockEventData;

		// Token: 0x0402936B RID: 168811
		[Token(Token = "0x402936B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0402936C RID: 168812
		[Token(Token = "0x402936C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetZoneInfoById;

		// Token: 0x0402936D RID: 168813
		[Token(Token = "0x402936D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200513C RID: 20796
		[Token(Token = "0x200513C")]
		public struct ZoneInfo
		{
			// Token: 0x0601EBA3 RID: 125859 RVA: 0x000AF638 File Offset: 0x000AD838
			[Token(Token = "0x601EBA3")]
			[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402936E RID: 168814
			[Token(Token = "0x402936E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeepSeaRPModel.ZoneInfo EMPTY;

			// Token: 0x0402936F RID: 168815
			[Token(Token = "0x402936F")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x04029370 RID: 168816
			[Token(Token = "0x4029370")]
			[FieldOffset(Offset = "0x8")]
			public string zoneId;

			// Token: 0x04029371 RID: 168817
			[Token(Token = "0x4029371")]
			[FieldOffset(Offset = "0x10")]
			public bool isRetro;
		}
	}
}
