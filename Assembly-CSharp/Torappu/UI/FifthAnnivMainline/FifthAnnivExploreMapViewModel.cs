using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF3 RID: 20211
	[Token(Token = "0x2004EF3")]
	public class FifthAnnivExploreMapViewModel : IHotfixable
	{
		// Token: 0x0601E23F RID: 123455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E23F")]
		[Address(RVA = "0x17D0880", Offset = "0x17CF480", VA = "0x1817D0880")]
		public void LoadData(FifthAnnivExploreMapViewModel.MapParam param)
		{
		}

		// Token: 0x0601E240 RID: 123456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E240")]
		[Address(RVA = "0x17D0BE0", Offset = "0x17CF7E0", VA = "0x1817D0BE0")]
		public void UpdateData(PlayerMainlineExplore playerExplore)
		{
		}

		// Token: 0x0601E241 RID: 123457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E241")]
		[Address(RVA = "0x17D0730", Offset = "0x17CF330", VA = "0x1817D0730")]
		public void ClearMapData()
		{
		}

		// Token: 0x0601E242 RID: 123458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E242")]
		[Address(RVA = "0x17D2DC0", Offset = "0x17D19C0", VA = "0x1817D2DC0")]
		private void _LoadHistoryRoutes(FifthAnnivExploreData exploreData, PlayerMainlineExplore playerExplore)
		{
		}

		// Token: 0x0601E243 RID: 123459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E243")]
		[Address(RVA = "0x17D2C90", Offset = "0x17D1890", VA = "0x1817D2C90")]
		private void _LoadCurrentRoute(FifthAnnivExploreData exploreData, PlayerMainlineExplore playerExplore)
		{
		}

		// Token: 0x0601E244 RID: 123460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E244")]
		[Address(RVA = "0x17D1A30", Offset = "0x17D0630", VA = "0x1817D1A30")]
		private void _GeneHistoryShowNodesAndLines()
		{
		}

		// Token: 0x0601E245 RID: 123461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E245")]
		[Address(RVA = "0x17D2440", Offset = "0x17D1040", VA = "0x1817D2440")]
		private void _GeneSingleShowLineByLines(Vector2 startPos, Vector2 endPos, List<FifthAnnivExploreMapLineViewModel> lineViewModels)
		{
		}

		// Token: 0x0601E246 RID: 123462 RVA: 0x000ADA30 File Offset: 0x000ABC30
		[Token(Token = "0x601E246")]
		[Address(RVA = "0x17D3000", Offset = "0x17D1C00", VA = "0x1817D3000")]
		private Vector2 _PerpendicularClockwise(Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x0601E247 RID: 123463 RVA: 0x000ADA48 File Offset: 0x000ABC48
		[Token(Token = "0x601E247")]
		[Address(RVA = "0x17D0F90", Offset = "0x17CFB90", VA = "0x1817D0F90")]
		private Vector2 _ConvertPointLocalToWorld(Vector2 point, Vector2 startPoint, Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x0601E248 RID: 123464 RVA: 0x000ADA60 File Offset: 0x000ABC60
		[Token(Token = "0x601E248")]
		[Address(RVA = "0x17D10B0", Offset = "0x17CFCB0", VA = "0x1817D10B0")]
		private Vector2 _CovertPointWorldToLocal(Vector2 pointWorld, Vector2 targetStartPoint, Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x0601E249 RID: 123465 RVA: 0x000ADA78 File Offset: 0x000ABC78
		[Token(Token = "0x601E249")]
		[Address(RVA = "0x17D0CB0", Offset = "0x17CF8B0", VA = "0x1817D0CB0")]
		private Vector2 _ConvertCoordinates(Vector2 point, Vector2 oriLineStartPoint, Vector2 oriLineVector, Vector2 targetLineStartPoint, Vector2 targetLineVector)
		{
			return default(Vector2);
		}

		// Token: 0x0601E24A RID: 123466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E24A")]
		[Address(RVA = "0x17D3540", Offset = "0x17D2140", VA = "0x1817D3540")]
		private void _UpdateShowNodesAndLines()
		{
		}

		// Token: 0x0601E24B RID: 123467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E24B")]
		[Address(RVA = "0x17D3260", Offset = "0x17D1E60", VA = "0x1817D3260")]
		private void _UpdateShowNodesAndLinesWithCurrent()
		{
		}

		// Token: 0x0601E24C RID: 123468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E24C")]
		[Address(RVA = "0x17D11D0", Offset = "0x17CFDD0", VA = "0x1817D11D0")]
		private FifthAnnivExploreMapRouteViewModel _CreateRouteWithSeedAndCheckpoint(FifthAnnivExploreData exploreData, PlayerMainlineExplore.PlayerExploreGameContextMapDisplay playerPath, FifthAnnivRouteType routeType)
		{
			return null;
		}

		// Token: 0x0601E24D RID: 123469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E24D")]
		[Address(RVA = "0x17D2930", Offset = "0x17D1530", VA = "0x1817D2930")]
		private List<Vector2> _GenerateEventPoints(Vector2 startPos, Vector2 endPos, int count, System.Random nodeRandom)
		{
			return null;
		}

		// Token: 0x0601E24E RID: 123470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E24E")]
		[Address(RVA = "0x17D1E70", Offset = "0x17D0A70", VA = "0x1817D1E70")]
		private List<Vector2> _GeneLineCornerPosList(Vector2 startPos, Vector2 endPos, System.Random lineRandom)
		{
			return null;
		}

		// Token: 0x0601E24F RID: 123471 RVA: 0x000ADA90 File Offset: 0x000ABC90
		[Token(Token = "0x601E24F")]
		[Address(RVA = "0x17D3090", Offset = "0x17D1C90", VA = "0x1817D3090")]
		private static Vector2 _TransformLogicPosToMapPos(FifthAnnivExploreMapController.RouteCornerPos cornerPos, Vector2 logicPos)
		{
			return default(Vector2);
		}

		// Token: 0x0601E250 RID: 123472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E250")]
		[Address(RVA = "0x17D3900", Offset = "0x17D2500", VA = "0x1817D3900")]
		public FifthAnnivExploreMapViewModel()
		{
		}

		// Token: 0x040281E8 RID: 164328
		[Token(Token = "0x40281E8")]
		private const int MAP_LOGIC_SIDE_LENGTH = 400;

		// Token: 0x040281E9 RID: 164329
		[Token(Token = "0x40281E9")]
		[FieldOffset(Offset = "0x10")]
		public List<FifthAnnivExploreMapRouteViewModel> historyRouteList;

		// Token: 0x040281EA RID: 164330
		[Token(Token = "0x40281EA")]
		[FieldOffset(Offset = "0x18")]
		public FifthAnnivExploreMapRouteViewModel currentRoute;

		// Token: 0x040281EB RID: 164331
		[Token(Token = "0x40281EB")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, FifthAnnivExploreMapNodeViewModel> totalShowNodes;

		// Token: 0x040281EC RID: 164332
		[Token(Token = "0x40281EC")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, FifthAnnivExploreMapLineViewModel> totalShowLines;

		// Token: 0x040281ED RID: 164333
		[Token(Token = "0x40281ED")]
		[FieldOffset(Offset = "0x30")]
		public int currentIndexInRoute;

		// Token: 0x040281EE RID: 164334
		[Token(Token = "0x40281EE")]
		[FieldOffset(Offset = "0x38")]
		public string currentNodeKey;

		// Token: 0x040281EF RID: 164335
		[Token(Token = "0x40281EF")]
		[FieldOffset(Offset = "0x40")]
		private FifthAnnivExploreMapController.RouteCornerPos m_cornerPos;

		// Token: 0x040281F0 RID: 164336
		[Token(Token = "0x40281F0")]
		[FieldOffset(Offset = "0x60")]
		private float m_lineCornerCountFactor;

		// Token: 0x040281F1 RID: 164337
		[Token(Token = "0x40281F1")]
		[FieldOffset(Offset = "0x64")]
		private float m_lineMaxAmplitudeFactor;

		// Token: 0x040281F2 RID: 164338
		[Token(Token = "0x40281F2")]
		[FieldOffset(Offset = "0x68")]
		private FifthAnnivExploreData m_exploreData;

		// Token: 0x040281F3 RID: 164339
		[Token(Token = "0x40281F3")]
		[FieldOffset(Offset = "0x70")]
		private long m_cachedStartTs;

		// Token: 0x040281F4 RID: 164340
		[Token(Token = "0x40281F4")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isCurrentInited;

		// Token: 0x040281F5 RID: 164341
		[Token(Token = "0x40281F5")]
		[FieldOffset(Offset = "0x80")]
		private string m_currentStageId;

		// Token: 0x040281F6 RID: 164342
		[Token(Token = "0x40281F6")]
		[FieldOffset(Offset = "0x88")]
		private int m_currentIndexInStage;

		// Token: 0x040281F7 RID: 164343
		[Token(Token = "0x40281F7")]
		[FieldOffset(Offset = "0x90")]
		private List<FifthAnnivExploreMapNodeViewModel> m_historyShowNodes;

		// Token: 0x040281F8 RID: 164344
		[Token(Token = "0x40281F8")]
		[FieldOffset(Offset = "0x98")]
		private List<FifthAnnivExploreMapLineViewModel> m_historyShowLines;

		// Token: 0x040281F9 RID: 164345
		[Token(Token = "0x40281F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040281FA RID: 164346
		[Token(Token = "0x40281FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040281FB RID: 164347
		[Token(Token = "0x40281FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearMapData;

		// Token: 0x040281FC RID: 164348
		[Token(Token = "0x40281FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadHistoryRoutes;

		// Token: 0x040281FD RID: 164349
		[Token(Token = "0x40281FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadCurrentRoute;

		// Token: 0x040281FE RID: 164350
		[Token(Token = "0x40281FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GeneHistoryShowNodesAndLines;

		// Token: 0x040281FF RID: 164351
		[Token(Token = "0x40281FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneSingleShowLineByLines;

		// Token: 0x04028200 RID: 164352
		[Token(Token = "0x4028200")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PerpendicularClockwise;

		// Token: 0x04028201 RID: 164353
		[Token(Token = "0x4028201")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ConvertPointLocalToWorld;

		// Token: 0x04028202 RID: 164354
		[Token(Token = "0x4028202")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CovertPointWorldToLocal;

		// Token: 0x04028203 RID: 164355
		[Token(Token = "0x4028203")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConvertCoordinates;

		// Token: 0x04028204 RID: 164356
		[Token(Token = "0x4028204")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateShowNodesAndLines;

		// Token: 0x04028205 RID: 164357
		[Token(Token = "0x4028205")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateShowNodesAndLinesWithCurrent;

		// Token: 0x04028206 RID: 164358
		[Token(Token = "0x4028206")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateRouteWithSeedAndCheckpoint;

		// Token: 0x04028207 RID: 164359
		[Token(Token = "0x4028207")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateEventPoints;

		// Token: 0x04028208 RID: 164360
		[Token(Token = "0x4028208")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GeneLineCornerPosList;

		// Token: 0x04028209 RID: 164361
		[Token(Token = "0x4028209")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TransformLogicPosToMapPos;

		// Token: 0x0402820A RID: 164362
		[Token(Token = "0x402820A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EF4 RID: 20212
		[Token(Token = "0x2004EF4")]
		public struct MapParam
		{
			// Token: 0x0402820B RID: 164363
			[Token(Token = "0x402820B")]
			[FieldOffset(Offset = "0x0")]
			public FifthAnnivExploreMapController.RouteCornerPos cornerPos;

			// Token: 0x0402820C RID: 164364
			[Token(Token = "0x402820C")]
			[FieldOffset(Offset = "0x20")]
			public float lineCornerCountFactor;

			// Token: 0x0402820D RID: 164365
			[Token(Token = "0x402820D")]
			[FieldOffset(Offset = "0x24")]
			public float lineMaxAmplitudeFactor;

			// Token: 0x0402820E RID: 164366
			[Token(Token = "0x402820E")]
			[FieldOffset(Offset = "0x28")]
			public FifthAnnivExploreData exploreData;

			// Token: 0x0402820F RID: 164367
			[Token(Token = "0x402820F")]
			[FieldOffset(Offset = "0x30")]
			public PlayerMainlineExplore playerExplore;

			// Token: 0x04028210 RID: 164368
			[Token(Token = "0x4028210")]
			[FieldOffset(Offset = "0x38")]
			public bool isNewGame;
		}
	}
}
