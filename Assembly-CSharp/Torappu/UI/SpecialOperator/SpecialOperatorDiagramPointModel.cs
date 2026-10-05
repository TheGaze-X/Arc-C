using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E49 RID: 15945
	[Token(Token = "0x2003E49")]
	public abstract class SpecialOperatorDiagramPointModel : IHotfixable
	{
		// Token: 0x06018C60 RID: 101472
		[Token(Token = "0x6018C60")]
		protected abstract void OnLoadData(SpecialOperatorDiagramData diagramData, SpecialOperatorDetailData detailData);

		// Token: 0x06018C61 RID: 101473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C61")]
		[Address(RVA = "0x117A120", Offset = "0x1178D20", VA = "0x18117A120", Slot = "5")]
		protected virtual void OnRefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x06018C62 RID: 101474 RVA: 0x0009BAA8 File Offset: 0x00099CA8
		// (set) Token: 0x06018C63 RID: 101475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFE")]
		public Vector2 pos
		{
			[Token(Token = "0x6018C62")]
			[Address(RVA = "0x117A370", Offset = "0x1178F70", VA = "0x18117A370")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6018C63")]
			[Address(RVA = "0x117A590", Offset = "0x1179190", VA = "0x18117A590")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x06018C64 RID: 101476 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C65 RID: 101477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AFF")]
		public string pointId
		{
			[Token(Token = "0x6018C64")]
			[Address(RVA = "0x117A310", Offset = "0x1178F10", VA = "0x18117A310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C65")]
			[Address(RVA = "0x117A510", Offset = "0x1179110", VA = "0x18117A510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x06018C66 RID: 101478
		[Token(Token = "0x17003B00")]
		public abstract SpecialOperatorPointViewType pointViewType { [Token(Token = "0x6018C66")] get; }

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x06018C67 RID: 101479 RVA: 0x0009BAC0 File Offset: 0x00099CC0
		[Token(Token = "0x17003B01")]
		public virtual SpecialOperatorSelectAnchorType selectAnchorType
		{
			[Token(Token = "0x6018C67")]
			[Address(RVA = "0x117A4B0", Offset = "0x11790B0", VA = "0x18117A4B0", Slot = "7")]
			get
			{
				return SpecialOperatorSelectAnchorType.OFFSET;
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x06018C68 RID: 101480 RVA: 0x0009BAD8 File Offset: 0x00099CD8
		[Token(Token = "0x17003B02")]
		public virtual Vector2 selectAnchorPos
		{
			[Token(Token = "0x6018C68")]
			[Address(RVA = "0x117A3E0", Offset = "0x1178FE0", VA = "0x18117A3E0", Slot = "8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06018C69 RID: 101481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C69")]
		[Address(RVA = "0x1179F40", Offset = "0x1178B40", VA = "0x181179F40")]
		public void LoadData(string pointId, SpecialOperatorDiagramData diagramData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C6A RID: 101482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C6A")]
		[Address(RVA = "0x117A180", Offset = "0x1178D80", VA = "0x18117A180")]
		public void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018C6B RID: 101483 RVA: 0x0009BAF0 File Offset: 0x00099CF0
		[Token(Token = "0x6018C6B")]
		[Address(RVA = "0x117A210", Offset = "0x1178E10", VA = "0x18117A210", Slot = "9")]
		public virtual bool TryGetNodeModel(string nodeId, out SpecialOperatorBoardNodeBase nodeModel)
		{
			return default(bool);
		}

		// Token: 0x06018C6C RID: 101484 RVA: 0x0009BB08 File Offset: 0x00099D08
		[Token(Token = "0x6018C6C")]
		[Address(RVA = "0x1179ED0", Offset = "0x1178AD0", VA = "0x181179ED0", Slot = "10")]
		public virtual bool CalcUnlockStatus(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018C6D RID: 101485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C6D")]
		[Address(RVA = "0x117A2B0", Offset = "0x1178EB0", VA = "0x18117A2B0")]
		protected SpecialOperatorDiagramPointModel()
		{
		}

		// Token: 0x0401E733 RID: 124723
		[Token(Token = "0x401E733")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x0401E734 RID: 124724
		[Token(Token = "0x401E734")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pos;

		// Token: 0x0401E735 RID: 124725
		[Token(Token = "0x401E735")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_pos;

		// Token: 0x0401E736 RID: 124726
		[Token(Token = "0x401E736")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_pointId;

		// Token: 0x0401E737 RID: 124727
		[Token(Token = "0x401E737")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_pointId;

		// Token: 0x0401E738 RID: 124728
		[Token(Token = "0x401E738")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectAnchorType;

		// Token: 0x0401E739 RID: 124729
		[Token(Token = "0x401E739")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectAnchorPos;

		// Token: 0x0401E73A RID: 124730
		[Token(Token = "0x401E73A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401E73B RID: 124731
		[Token(Token = "0x401E73B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E73C RID: 124732
		[Token(Token = "0x401E73C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetNodeModel;

		// Token: 0x0401E73D RID: 124733
		[Token(Token = "0x401E73D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CalcUnlockStatus;

		// Token: 0x0401E73E RID: 124734
		[Token(Token = "0x401E73E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
