using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E45 RID: 15941
	[Token(Token = "0x2003E45")]
	public class SpecialOperatorBoardLvlupModelWithDiagram : SpecialOperatorBoardLvlupModel
	{
		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x06018C39 RID: 101433 RVA: 0x0009B9A0 File Offset: 0x00099BA0
		// (set) Token: 0x06018C3A RID: 101434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF6")]
		public float width
		{
			[Token(Token = "0x6018C39")]
			[Address(RVA = "0x116D730", Offset = "0x116C330", VA = "0x18116D730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6018C3A")]
			[Address(RVA = "0x116D870", Offset = "0x116C470", VA = "0x18116D870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x06018C3B RID: 101435 RVA: 0x0009B9B8 File Offset: 0x00099BB8
		// (set) Token: 0x06018C3C RID: 101436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF7")]
		public float height
		{
			[Token(Token = "0x6018C3B")]
			[Address(RVA = "0x116D6D0", Offset = "0x116C2D0", VA = "0x18116D6D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6018C3C")]
			[Address(RVA = "0x116D800", Offset = "0x116C400", VA = "0x18116D800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x06018C3D RID: 101437 RVA: 0x0009B9D0 File Offset: 0x00099BD0
		// (set) Token: 0x06018C3E RID: 101438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF8")]
		public bool hasTrack
		{
			[Token(Token = "0x6018C3D")]
			[Address(RVA = "0x116D670", Offset = "0x116C270", VA = "0x18116D670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018C3E")]
			[Address(RVA = "0x116D790", Offset = "0x116C390", VA = "0x18116D790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x06018C3F RID: 101439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AF9")]
		public ListDict<string, SpecialOperatorDiagramPointModel> diagramPointMap
		{
			[Token(Token = "0x6018C3F")]
			[Address(RVA = "0x116D610", Offset = "0x116C210", VA = "0x18116D610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018C40 RID: 101440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C40")]
		[Address(RVA = "0x116B7B0", Offset = "0x116A3B0", VA = "0x18116B7B0", Slot = "5")]
		public override void InitData(string charId, SpecialOperatorDetailTabData tabData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C41 RID: 101441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C41")]
		[Address(RVA = "0x116B870", Offset = "0x116A470", VA = "0x18116B870", Slot = "6")]
		public override void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018C42 RID: 101442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C42")]
		[Address(RVA = "0x116D0B0", Offset = "0x116BCB0", VA = "0x18116D0B0")]
		private void _ProcessNodeCanUnlockStatus()
		{
		}

		// Token: 0x06018C43 RID: 101443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C43")]
		[Address(RVA = "0x116D300", Offset = "0x116BF00", VA = "0x18116D300")]
		private void _ProcessTrackStatus()
		{
		}

		// Token: 0x06018C44 RID: 101444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C44")]
		[Address(RVA = "0x116B230", Offset = "0x1169E30", VA = "0x18116B230")]
		public void GenerateAllLinePointList(List<Vector2> pointList)
		{
		}

		// Token: 0x06018C45 RID: 101445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C45")]
		[Address(RVA = "0x116B5A0", Offset = "0x116A1A0", VA = "0x18116B5A0")]
		public void GenerateLinePointList(List<Vector2> pointList, bool targetUnlockStatus)
		{
		}

		// Token: 0x06018C46 RID: 101446 RVA: 0x0009B9E8 File Offset: 0x00099BE8
		[Token(Token = "0x6018C46")]
		[Address(RVA = "0x116C1C0", Offset = "0x116ADC0", VA = "0x18116C1C0")]
		private bool _CalcRoadUnlockStatus(SpecialOperatorDiagramLineModel lineModel)
		{
			return default(bool);
		}

		// Token: 0x06018C47 RID: 101447 RVA: 0x0009BA00 File Offset: 0x00099C00
		[Token(Token = "0x6018C47")]
		[Address(RVA = "0x116C0C0", Offset = "0x116ACC0", VA = "0x18116C0C0")]
		private bool _CalcPointUnlockStatus(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x06018C48 RID: 101448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C48")]
		[Address(RVA = "0x116C490", Offset = "0x116B090", VA = "0x18116C490")]
		private void _InitDiagramLineData(SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C49 RID: 101449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C49")]
		[Address(RVA = "0x116C780", Offset = "0x116B380", VA = "0x18116C780")]
		private void _InitDiagramPointData(SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C4A RID: 101450 RVA: 0x0009BA18 File Offset: 0x00099C18
		[Token(Token = "0x6018C4A")]
		[Address(RVA = "0x116BE00", Offset = "0x116AA00", VA = "0x18116BE00", Slot = "7")]
		public override bool TryGetNodeModel(string nodeId, out SpecialOperatorBoardNodeBase nodeModel)
		{
			return default(bool);
		}

		// Token: 0x06018C4B RID: 101451 RVA: 0x0009BA30 File Offset: 0x00099C30
		[Token(Token = "0x6018C4B")]
		[Address(RVA = "0x116BAE0", Offset = "0x116A6E0", VA = "0x18116BAE0", Slot = "8")]
		public override bool TryFindFocusPos(out float targetPos)
		{
			return default(bool);
		}

		// Token: 0x06018C4C RID: 101452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C4C")]
		[Address(RVA = "0x116D4C0", Offset = "0x116C0C0", VA = "0x18116D4C0")]
		public SpecialOperatorBoardLvlupModelWithDiagram()
		{
		}

		// Token: 0x06018C4D RID: 101453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C4D")]
		[Address(RVA = "0x116BFE0", Offset = "0x116ABE0", VA = "0x18116BFE0")]
		private void <>xLuaBaseProxy_InitData(string P0, SpecialOperatorDetailTabData P1, SpecialOperatorDetailData P2)
		{
		}

		// Token: 0x06018C4E RID: 101454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C4E")]
		[Address(RVA = "0x116BFF0", Offset = "0x116ABF0", VA = "0x18116BFF0")]
		private void <>xLuaBaseProxy_RefreshData(PlayerCharacter P0)
		{
		}

		// Token: 0x06018C4F RID: 101455 RVA: 0x0009BA48 File Offset: 0x00099C48
		[Token(Token = "0x6018C4F")]
		[Address(RVA = "0x116C050", Offset = "0x116AC50", VA = "0x18116C050")]
		private bool <>xLuaBaseProxy_TryFindFocusPos(out float P0)
		{
			return default(bool);
		}

		// Token: 0x0401E706 RID: 124678
		[Token(Token = "0x401E706")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, SpecialOperatorDiagramPointModel> m_diagramPointMap;

		// Token: 0x0401E707 RID: 124679
		[Token(Token = "0x401E707")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, SpecialOperatorDiagramLineModel> m_diagramLineMap;

		// Token: 0x0401E70B RID: 124683
		[Token(Token = "0x401E70B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_width;

		// Token: 0x0401E70C RID: 124684
		[Token(Token = "0x401E70C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_width;

		// Token: 0x0401E70D RID: 124685
		[Token(Token = "0x401E70D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_height;

		// Token: 0x0401E70E RID: 124686
		[Token(Token = "0x401E70E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_height;

		// Token: 0x0401E70F RID: 124687
		[Token(Token = "0x401E70F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasTrack;

		// Token: 0x0401E710 RID: 124688
		[Token(Token = "0x401E710")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_hasTrack;

		// Token: 0x0401E711 RID: 124689
		[Token(Token = "0x401E711")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_diagramPointMap;

		// Token: 0x0401E712 RID: 124690
		[Token(Token = "0x401E712")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401E713 RID: 124691
		[Token(Token = "0x401E713")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E714 RID: 124692
		[Token(Token = "0x401E714")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcessNodeCanUnlockStatus;

		// Token: 0x0401E715 RID: 124693
		[Token(Token = "0x401E715")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessTrackStatus;

		// Token: 0x0401E716 RID: 124694
		[Token(Token = "0x401E716")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenerateAllLinePointList;

		// Token: 0x0401E717 RID: 124695
		[Token(Token = "0x401E717")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GenerateLinePointList;

		// Token: 0x0401E718 RID: 124696
		[Token(Token = "0x401E718")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalcRoadUnlockStatus;

		// Token: 0x0401E719 RID: 124697
		[Token(Token = "0x401E719")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CalcPointUnlockStatus;

		// Token: 0x0401E71A RID: 124698
		[Token(Token = "0x401E71A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitDiagramLineData;

		// Token: 0x0401E71B RID: 124699
		[Token(Token = "0x401E71B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitDiagramPointData;

		// Token: 0x0401E71C RID: 124700
		[Token(Token = "0x401E71C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TryGetNodeModel;

		// Token: 0x0401E71D RID: 124701
		[Token(Token = "0x401E71D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TryFindFocusPos;

		// Token: 0x0401E71E RID: 124702
		[Token(Token = "0x401E71E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
